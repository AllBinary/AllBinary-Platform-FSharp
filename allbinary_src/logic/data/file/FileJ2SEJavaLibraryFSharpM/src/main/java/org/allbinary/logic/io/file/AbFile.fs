namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type AbFile =
    [<DefaultValue(false)>] val mutable file : File
    [<DefaultValue(false)>] static val mutable private jcell_NULL_FILE : AbFile
    static member NULL_FILE with get() : AbFile = (AbFile.jclinit(); AbFile.jcell_NULL_FILE) and set (jvalue: AbFile) = (AbFile.jclinit(); AbFile.jcell_NULL_FILE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbFile.jclinitDone then
            AbFile.jclinitDone <- true
            AbFile.jclinitBody()
    static member private jclinitBody() : unit =
        AbFile.jcell_NULL_FILE <- AbFile.createAbFileFromRawPath(StringUtil.getInstance().EMPTY_STRING)
        ()
    
    static member createAbFileWithChild(file: AbFile, childPathName: string) : AbFile =
        (new AbFile((new File(file.getFile(), childPathName))))
    
    static member createAbFile(filePath: string) : AbFile =
        (new AbFile((new File((new AbPath(filePath, StringUtil.getInstance().EMPTY_STRING)).toFileSystemString()))))
    
    static member createAbFilePathAndName(filePath: string, fileName: string) : AbFile =
        (new AbFile((new File((new AbPath(filePath, StringUtil.getInstance().EMPTY_STRING)).toFileSystemString(), fileName))))
    
    static member createAbFileFromAbPath(abPath: AbPath) : AbFile =
        (new AbFile((new File(abPath.toFileSystemString()))))
    
    static member createAbFileFromRawPath(filePath: string) : AbFile =
        (new AbFile((new File(filePath))))
    
    new (file: File) as this =
        {  }
        then
            this.jctor1(file)
    member this.jctor1(file: File) : unit =
        this.file <- file
        ()
    
    abstract getFile : unit -> File
    default this.getFile() : File =
        this.file
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.file.getName()
    
    abstract getParent : unit -> string
    default this.getParent() : string =
        this.file.getParent()
    
    abstract getParentFile : unit -> obj
    default this.getParentFile() : obj =
        this.file.getParentFile()
    
    abstract getPath : unit -> string
    default this.getPath() : string =
        this.file.getPath()
    
    abstract isAbsolute : unit -> bool
    default this.isAbsolute() : bool =
        this.file.isAbsolute()
    
    abstract getAbsolutePath : unit -> string
    default this.getAbsolutePath() : string =
        this.file.getAbsolutePath()
    
    abstract getAbsoluteFile : unit -> obj
    default this.getAbsoluteFile() : obj =
        this.file.getAbsoluteFile()
    
    abstract getCanonicalPath : unit -> string
    default this.getCanonicalPath() : string =
        this.file.getCanonicalPath()
    
    abstract getCanonicalFile : unit -> obj
    default this.getCanonicalFile() : obj =
        this.file.getCanonicalFile()
    
    abstract toURI : unit -> URI
    default this.toURI() : URI =
        this.file.toURI()
    
    abstract canRead : unit -> bool
    default this.canRead() : bool =
        this.file.canRead()
    
    abstract canWrite : unit -> bool
    default this.canWrite() : bool =
        this.file.canWrite()
    
    abstract exists : unit -> bool
    default this.exists() : bool =
        this.file.exists()
    
    abstract isDirectory : unit -> bool
    default this.isDirectory() : bool =
        this.file.isDirectory()
    
    abstract isFile : unit -> bool
    default this.isFile() : bool =
        this.file.isFile()
    
    abstract isHidden : unit -> bool
    default this.isHidden() : bool =
        this.file.isHidden()
    
    abstract lastModified : unit -> int64
    default this.lastModified() : int64 =
        this.file.lastModified()
    
    abstract length : unit -> int64
    default this.length() : int64 =
        int64 (this.file.length())
    
    abstract createNewFile : unit -> bool
    default this.createNewFile() : bool =
        this.file.createNewFile()
    
    abstract delete : unit -> bool
    default this.delete() : bool =
        this.file.delete()
    
    abstract deleteOnExit : unit -> unit
    default this.deleteOnExit() : unit =
        this.file.deleteOnExit()
    
    abstract list : unit -> string[]
    default this.list() : string[] =
        this.file.list()
    
    abstract listWithFilter : filter: FilenameFilter -> string[]
    default this.listWithFilter(filter: FilenameFilter) : string[] =
        this.file.list(filter)
    
    abstract listFiles : unit -> obj[]
    default this.listFiles() : obj[] =
        (box (this.file.listFiles()) :?> obj[])
    
    abstract listFilesFileNameFilter : filter: FilenameFilter -> obj[]
    default this.listFilesFileNameFilter(filter: FilenameFilter) : obj[] =
        (box (this.file.listFiles(filter)) :?> obj[])
    
    abstract listFilesFileFilter : filter: FileFilter -> obj[]
    default this.listFilesFileFilter(filter: FileFilter) : obj[] =
        (box (this.file.listFiles(filter)) :?> obj[])
    
    abstract mkdir : unit -> bool
    default this.mkdir() : bool =
        this.file.mkdir()
    
    abstract mkdirs : unit -> bool
    default this.mkdirs() : bool =
        this.file.mkdirs()
    
    abstract renameTo : dest: AbFile -> bool
    default this.renameTo(dest: AbFile) : bool =
        this.file.renameTo(dest.getFile())
    
    abstract setLastModified : time: int64 -> bool
    default this.setLastModified(time: int64) : bool =
        this.file.setLastModified(time)
    
    abstract setReadOnly : unit -> bool
    default this.setReadOnly() : bool =
        this.file.setReadOnly()
    
    abstract setWritable : writable: bool * ownerOnly: bool -> bool
    default this.setWritable(writable: bool, ownerOnly: bool) : bool =
        this.file.setExecutable(writable, ownerOnly)
    
    abstract setWritable : writable: bool -> bool
    default this.setWritable(writable: bool) : bool =
        this.file.setWritable(writable)
    
    abstract setReadable : readable: bool * ownerOnly: bool -> bool
    default this.setReadable(readable: bool, ownerOnly: bool) : bool =
        this.file.setReadable(readable, ownerOnly)
    
    abstract setReadable : readable: bool -> bool
    default this.setReadable(readable: bool) : bool =
        this.file.setReadable(readable)
    
    abstract setExecutable : executable: bool * ownerOnly: bool -> bool
    default this.setExecutable(executable: bool, ownerOnly: bool) : bool =
        this.file.setExecutable(executable, ownerOnly)
    
    abstract setExecutable : executable: bool -> bool
    default this.setExecutable(executable: bool) : bool =
        this.file.setExecutable(executable)
    
    abstract canExecute : unit -> bool
    default this.canExecute() : bool =
        this.file.canExecute()
    
    abstract getTotalSpace : unit -> int64
    default this.getTotalSpace() : int64 =
        this.file.getTotalSpace()
    
    abstract getFreeSpace : unit -> int64
    default this.getFreeSpace() : int64 =
        this.file.getFreeSpace()
    
    abstract getUsableSpace : unit -> int64
    default this.getUsableSpace() : int64 =
        this.file.getUsableSpace()
    
    abstract compareTo : pathname: File -> int
    default this.compareTo(pathname: File) : int =
        this.file.compareTo(pathname)
    
    override this.Equals(obj_: obj) : bool =
        TsUtil.getInstance().equalsNotstring(this.file, obj_)
    
    override this.GetHashCode() : int =
        JR.hashCode(this.file)
    
    override this.ToString() : string =
        this.file.ToString()
    interface AbFileInterface with
        member this.canRead() : bool = this.canRead()
        member this.canWrite() : bool = this.canWrite()
        member this.createNewFile() : bool = this.createNewFile()
        member this.delete() : bool = this.delete()
        member this.deleteOnExit() : unit = this.deleteOnExit()
        member this.exists() : bool = this.exists()
        member this.getAbsolutePath() : string = this.getAbsolutePath()
        member this.getCanonicalPath() : string = this.getCanonicalPath()
        member this.getParent() : string = this.getParent()
        member this.getPath() : string = this.getPath()
        member this.isAbsolute() : bool = this.isAbsolute()
        member this.isDirectory() : bool = this.isDirectory()
        member this.isFile() : bool = this.isFile()
        member this.isHidden() : bool = this.isHidden()
        member this.lastModified() : int64 = this.lastModified()
        member this.length() : int64 = this.length()
        member this.list() : string[] = this.list()
        member this.listWithFilter(jp0: FilenameFilter) : string[] = this.listWithFilter(jp0)
        member this.mkdir() : bool = this.mkdir()
        member this.mkdirs() : bool = this.mkdirs()
        member this.setLastModified(jp0: int64) : bool = this.setLastModified(jp0)
        member this.setReadOnly() : bool = this.setReadOnly()
        member this.toURI() : URI = this.toURI()


