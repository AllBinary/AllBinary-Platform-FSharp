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
type AbFileInterface =
    abstract canRead : unit -> bool
    abstract canWrite : unit -> bool
    abstract createNewFile : unit -> bool
    abstract delete : unit -> bool
    abstract deleteOnExit : unit -> unit
    abstract exists : unit -> bool
    abstract getAbsolutePath : unit -> string
    abstract getCanonicalPath : unit -> string
    abstract getParent : unit -> string
    abstract getPath : unit -> string
    abstract isAbsolute : unit -> bool
    abstract isDirectory : unit -> bool
    abstract isFile : unit -> bool
    abstract isHidden : unit -> bool
    abstract lastModified : unit -> int64
    abstract length : unit -> int64
    abstract list : unit -> string[]
    abstract listWithFilter : filter: FilenameFilter -> string[]
    abstract mkdir : unit -> bool
    abstract mkdirs : unit -> bool
    abstract setLastModified : time: int64 -> bool
    abstract setReadOnly : unit -> bool
    abstract toURI : unit -> URI


