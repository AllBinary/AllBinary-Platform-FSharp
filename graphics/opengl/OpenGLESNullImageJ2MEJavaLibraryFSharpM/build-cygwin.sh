#!/usr/bin/env bash

# Compiles the F# files the F# converter generated with the .NET SDK F# compiler (dotnet fsc.dll) to a library.
# Every converted file is namespace rec AllBinary, so the files of the project are joined into one file with one
# namespace rec line (one recursive group: the classes can use each other in any order, like Java). The hand written
# runtime is joined and compiled the same way to AllBinaryJava.dll (cached by its content). The project library
# references the runtime and the libraries of the dependencies (META-INF/fsharp/lib of their jars).
# This project's sources are written to <output>/src and its library to <output>/lib/<artifactId>.dll.
# An error line of the joined file is shown with the converted file and line it came from.
# Arguments: source_dir output_dir object_dir dependency_dir runtime_dir compiler "flags" artifactId fail_on_error

set -uo pipefail

export PATH="/usr/local/bin:/usr/bin:/bin:$PATH"
export DOTNET_CLI_TELEMETRY_OPTOUT=1
export DOTNET_NOLOGO=1
export DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1

source_dir="$(cygpath -u "$1")"
output_dir="$(cygpath -u "$2")"
object_dir="$(cygpath -u "$3")"
dependency_dir="$(cygpath -u "$4")"
runtime_dir="$(cygpath -u "$5")"
compiler="$(cygpath -u "$6")"
read -r -a compiler_flags <<< "$7"
artifact="$8"
fail_on_error="${9:-true}"

if [ ! -d "$source_dir" ]; then
    echo "No F# sources: $source_dir"
    exit 0
fi

rm -rf "$output_dir" "$object_dir"
mkdir -p "$output_dir/src" "$output_dir/lib" "$object_dir"
cp -R "$source_dir/." "$output_dir/src/"

# The F# compiler of the .NET SDK next to dotnet.exe (8.0 first) and the reference assemblies of its runtime
dotnet_root="$(dirname "$compiler")"
fsc=""
for sdk in "$dotnet_root"/sdk/8.0.* "$dotnet_root"/sdk/9.0.*; do
    if [ -f "$sdk/FSharp/fsc.dll" ] && [ -z "$fsc" ]; then fsc="$sdk/FSharp/fsc.dll"; fi
done
if [ -z "$fsc" ]; then
    echo "No F# compiler (sdk/*/FSharp/fsc.dll) under $dotnet_root" >&2
    exit 1
fi
reference_dir="$(ls -d "$dotnet_root"/packs/Microsoft.NETCore.App.Ref/8.0.*/ref/net8.0 2>/dev/null | tail -1)"
fsharp_core="$(dirname "$fsc")/FSharp.Core.dll"

short_tree="$(mktemp -d /tmp/fscheckXXXXXX)"
trap 'rm -rf "$short_tree"' EXIT
{
    echo "--noframework"
    echo "--targetprofile:netcore"
    echo "--nologo"
    echo "--target:library"
    echo "--optimize+"
    # 20 an ignored value, 64 a less generic type, 1182 an unused variable, 3370 the old array index syntax,
    # 864 a member that hides a base member, 3536 a recursive object reference
    echo "--nowarn:20,64,1182,3370,864,3536,1183,3388,3389,3390,0026,0049,0346,0040,0193,3391"
    for reference in "$reference_dir"/*.dll; do echo "-r:$(cygpath -m "$reference")"; done
    echo "-r:$(cygpath -m "$fsharp_core")"
} > "$short_tree/references.rsp"

# Joins the F# files of a folder into one file: one namespace rec AllBinary line, each file without its own
join_files() {
    local folder="$1"
    local joined="$2"
    local map="$3"
    perl -e '
        my ($joined, $map, @files) = @ARGV;
        open(my $out, ">", $joined) or die;
        open(my $lines, ">", $map) or die;
        print $out "namespace rec AllBinary\n";
        my $line = 1;
        for my $file (@files) {
            open(my $in, "<", $file) or next;
            my $number = 0;
            while (my $text = <$in>) {
                $number++;
                $text =~ s/\r?\n$//;
                if ($number == 1 && $text =~ /^\s*namespace\s+rec\s+AllBinary\s*$/) { next; }
                print $out "$text\n";
                $line++;
                print $lines "$line\t$file\t$number\n";
            }
            close($in);
        }
        close($out);
        close($lines);
    ' "$joined" "$map" $(find "$folder" -type f -name '*.fs' | sort)
}

compile() {
    local output="$1"
    shift
    "$compiler" "$(cygpath -m "$fsc")" @"$(cygpath -m "$short_tree/references.rsp")" "${compiler_flags[@]}" -o:"$(cygpath -m "$output")" "$@" 2>&1 | tr -d '\r'
    return "${PIPESTATUS[0]}"
}

# Shows the error lines of the compiler with the converted file and line of a joined file
show_errors() {
    local errors="$1"
    local joined="$2"
    local map="$3"
    echo "$errors" | grep -E ': error ' | head -${FSHARP_ERROR_LINES:-60} | perl -e '
        my ($joined, $map) = @ARGV;
        my %where;
        open(my $in, "<", $map) or die;
        while (my $line = <$in>) { chomp $line; my ($joinedLine, $file, $number) = split(/\t/, $line); $where{$joinedLine} = "$file:$number"; }
        my $name = $joined; $name =~ s{.*/}{};
        while (my $line = <STDIN>) {
            if ($line =~ /\Q$name\E\((\d+),(\d+)\)/) { my $at = $where{$1}; $line = "[$at] $line" if $at; }
            print $line;
        }
    ' "$joined" "$map"
}

# The runtime library, compiled once for each runtime content
runtime_joined="$short_tree/AllBinaryJava.fs"
join_files "$runtime_dir" "$runtime_joined" "$short_tree/runtime.map"
runtime_hash="$(md5sum "$runtime_joined" | cut -d' ' -f1)"
runtime_cache="/tmp/fsharp_runtime_cache/$runtime_hash"
runtime_dll="$runtime_cache/AllBinaryJava.dll"
if [ ! -f "$runtime_dll" ]; then
    mkdir -p "$runtime_cache"
    runtime_output="$(compile "$short_tree/AllBinaryJava.dll" "$(cygpath -m "$runtime_joined")")"
    if [ ! -f "$short_tree/AllBinaryJava.dll" ]; then
        show_errors "$runtime_output" "$runtime_joined" "$short_tree/runtime.map"
        echo "F# runtime build failed: $runtime_dir" >&2
        exit 1
    fi
    cp "$short_tree/AllBinaryJava.dll" "$runtime_dll"
fi
cp "$runtime_dll" "$output_dir/lib/"

# The libraries of the dependencies: lib/ has the library of each dependency jar (fresh from the reactor or the local
# repository), closure/ the libraries each one was compiled with (a dependency of an optional dependency is not unpacked
# by Maven; a copy can be older). A library of lib/ wins over a copy of closure/.
dep_libs="$short_tree/dependency_libraries"
mkdir -p "$dep_libs"
[ -d "$dependency_dir/closure" ] && cp "$dependency_dir"/closure/*.dll "$dep_libs/" 2>/dev/null
# The unpack folder keeps the files of earlier builds: a library of lib/ is used only when its jar was unpacked by this
# build (a marker of the dependency plugin for its artifactId), else a closure/ copy is used.
markers_dir="$(cd "$dependency_dir/../../.." 2>/dev/null && pwd)/dependency-maven-plugin-markers"
if [ -d "$dependency_dir/lib" ]; then
    for library in "$dependency_dir"/lib/*.dll; do
        [ -f "$library" ] || continue
        name="$(basename "$library" .dll)"
        if [ "$name" = "AllBinaryJava" ] || [ ! -d "$markers_dir" ] || ls "$markers_dir" | grep -q -- "-$name-jar-"; then
            cp "$library" "$dep_libs/"
        fi
    done
fi

own_count="$(find "$source_dir" -type f -name '*.fs' | wc -l)"
echo "F# files: $own_count"
if [ "$own_count" = "0" ]; then
    echo "F# checked: $artifact"
    exit 0
fi

# The libraries of the dependencies (not the runtime, which is this one). Two libraries can have one class (a project
# that replaces a class of a base project, such as TsUtil): F# uses the one of the library referenced last, so the
# direct dependencies of the pom come last, the first one of the pom at the end, like the Java class path.
# Platform variants are projects with the same classes for different platforms (LogJ2ME, LogJ2SE, LogNoPlatform...);
# Java uses the one on the class path. In .NET a class is its assembly name plus its name, so every project of a variant
# group is compiled to one assembly name (the group) and a project references only one library of a group: its direct
# dependency when it has one. The library file keeps the artifactId name.
variant_group() {
    case "$1" in
        LogJ2MEJavaLibraryFSharp|LogJ2SEJavaLibraryFSharp|LogNoPlatformJavaLibraryFSharp|LogAndroidJavaLibraryFSharp|LogiOSJavaLibraryFSharp|LogPlayNJavaLibraryFSharp|LogPlayN2JavaLibraryFSharp) echo "AllBinaryVariantLog" ;;
        J2MEForJ2MEJavaLibraryFSharp|J2SEForJ2MEJavaLibraryFSharp) echo "AllBinaryVariantForJ2ME" ;;
        OpenGLESBaseJ2MEJavaLibraryFSharp|OpenGLESBaseJavaLibraryFSharp|OpenGLNoneOther2JavaLibraryFSharp) echo "AllBinaryVariantOpenGLESBase" ;;
        OpenGLJ2MENoneJavaLibraryFSharp|OpenGLNoneJavaLibraryFSharp) echo "AllBinaryVariantOpenGLNone" ;;
        OpenGLESNullImageJ2MEJavaLibraryFSharp|OpenGLESNullImageJavaLibraryFSharp) echo "AllBinaryVariantOpenGLESNullImage" ;;
        NoTouchButtonJavaLibraryFSharp|TouchButtonJavaLibraryFSharp) echo "AllBinaryVariantTouchButton" ;;
        JSEGyroSensorJavaLibraryFSharp|NoSensorJavaLibraryFSharp) echo "AllBinaryVariantSensor" ;;
        BasicPlayerJavaLibraryFSharp|BasicPlayerMIDP2JavaLibraryFSharp) echo "AllBinaryVariantBasicPlayer" ;;
        GameInputPCKeyOnlyJavaLibraryFSharp|GameInputPCMotionJavaLibraryFSharp|GameInputMEKeyOnlyJavaLibraryFSharp|GameInputMEMotionJavaLibraryFSharp) echo "AllBinaryVariantGameInput" ;;
        FileLicenseInitInfoJavaLibraryFSharp|HardCodedLicenseInitInfoJavaLibraryFSharp) echo "AllBinaryVariantLicenseInitInfo" ;;
        *) echo "$1" ;;
    esac
}

references=("-r:$(cygpath -m "$runtime_dll")")
own_group="$(variant_group "$artifact")"
if [ -d "$dep_libs" ]; then
    pom="$(cd "$source_dir/../../.." 2>/dev/null && pwd)/pom.xml"
    direct=""
    if [ -f "$pom" ]; then
        direct="$(perl -0ne 's/<!--.*?-->//gs; s/<build>.*//s; while (/<dependency>.*?<artifactId>([^<]+)<\/artifactId>.*?<\/dependency>/gs) { print "$1\n"; }' "$pom" | awk '!seen[$0]++' | tac)"
    fi
    # The library chosen for each variant group: the direct dependency of the group (the first one of the pom), else
    # the first library of the group
    chosen=" "
    for name in $direct; do
        [ -f "$dep_libs/$name.dll" ] || continue
        group="$(variant_group "$name")"
        [ "$group" = "$name" ] && continue
        chosen="$(echo "$chosen" | sed "s/ $group=[^ ]* / /") $group=$name "
    done
    for library in "$dep_libs"/*.dll; do
        [ -f "$library" ] || continue
        name="$(basename "$library" .dll)"
        group="$(variant_group "$name")"
        [ "$group" = "$name" ] && continue
        echo "$chosen" | grep -q " $group=" || chosen="$chosen$group=$name "
    done
    # J2SEForJ2ME has every class of ForJ2ME a library of another project uses (TsUtil.gc of the J2SE TsUtil); the
    # libraries of the J2ME only classes (ChoiceGroupImageFactory, RatioProcessor) are not part of a public signature
    if [ -f "$dep_libs/J2SEForJ2MEJavaLibraryFSharp.dll" ]; then
        chosen="$(echo "$chosen" | sed "s/ AllBinaryVariantForJ2ME=[^ ]* / /") AllBinaryVariantForJ2ME=J2SEForJ2MEJavaLibraryFSharp "
    fi
    # A No* project (NoGyroSensor) has stub copies of classes of a full project (MotionGestureBase): it is referenced
    # first, so the full project's class is used when both are dependencies
    for library in "$dep_libs"/No*.dll $(ls "$dep_libs"/*.dll | grep -v '/No[^/]*\.dll$'); do
        [ -f "$library" ] || continue
        name="$(basename "$library" .dll)"
        [ "$name" = "AllBinaryJava" ] && continue
        [ "$name" = "$artifact" ] && continue
        group="$(variant_group "$name")"
        [ "$group" = "$own_group" ] && continue
        [ "$group" != "$name" ] && ! echo "$chosen" | grep -q " $group=$name " && continue
        echo "$direct" | grep -qx "$name" && continue
        references+=("-r:$(cygpath -m "$library")")
    done
    for name in $direct; do
        [ -f "$dep_libs/$name.dll" ] && [ "$name" != "$artifact" ] || continue
        group="$(variant_group "$name")"
        [ "$group" = "$own_group" ] && continue
        [ "$group" != "$name" ] && ! echo "$chosen" | grep -q " $group=$name " && continue
        references+=("-r:$(cygpath -m "$dep_libs/$name.dll")")
    done
fi

project_joined="$short_tree/$artifact.fs"
join_files "$source_dir" "$project_joined" "$short_tree/project.map"
output="$(compile "$short_tree/$own_group.dll" "${references[@]}" "$(cygpath -m "$project_joined")")"
cp "$project_joined" "$short_tree/project.map" "$object_dir/" 2>/dev/null
[ -f "$short_tree/$own_group.dll" ] && [ "$own_group" != "$artifact" ] && mv "$short_tree/$own_group.dll" "$short_tree/$artifact.dll"
if [ -f "$short_tree/$artifact.dll" ]; then
    # The libraries this one was compiled with go into the jar too: a project that uses this library needs the libraries
    # of the types in its signatures, also the ones of optional Maven dependencies (not transitive)
    if [ -d "$dep_libs" ]; then
        for library in "$dep_libs"/*.dll; do
            [ -f "$library" ] && mkdir -p "$output_dir/closure" && cp "$library" "$output_dir/closure/"
        done
    fi
    cp "$short_tree/$artifact.dll" "$output_dir/lib/"
    echo "F# checked: $artifact"
    exit 0
fi
show_errors "$output" "$project_joined" "$short_tree/project.map"
echo "F# errors: $(echo "$output" | grep -c ': error ')"
echo "F# build failed: $artifact" >&2
if [ "$fail_on_error" = "true" ]; then
    exit 1
fi
exit 0
