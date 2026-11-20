namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type AbFileSystem =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbFileSystem
    static member instance with get() : AbFileSystem = (AbFileSystem.jclinit(); AbFileSystem.jcell_instance) and set (jvalue: AbFileSystem) = (AbFileSystem.jclinit(); AbFileSystem.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbFileSystem.jclinitDone then
            AbFileSystem.jclinitDone <- true
            AbFileSystem.jclinitBody()
    static member private jclinitBody() : unit =
        AbFileSystem.jcell_instance <- (new AbFileSystem())
        ()
    new () as this =
        {  }
        then
            this.jfields_AbFileSystem()
    member this.jfields_AbFileSystem() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    static member getInstance() : AbFileSystem =
        AbFileSystem.instance
    
    abstract isDirectoryOrFile : path: string -> bool
    default this.isDirectoryOrFile(path: string) : bool =
        false
    
    abstract isDirectory : path: string -> bool
    default this.isDirectory(path: string) : bool =
        false
    
    abstract getFilesAsStringArrayForPath : currentDirPath: string -> string[]
    default this.getFilesAsStringArrayForPath(currentDirPath: string) : string[] =
        StringUtil.getInstance().getArrayInstance()
    
    abstract readAsString : fileName: string -> string
    default this.readAsString(fileName: string) : string =
        let mutable bytes : sbyte[] = (Array.zeroCreate<sbyte> (1000000))
        this.readAsString(fileName, bytes)
    
    abstract readAsString : fileName: string * bytes: sbyte[] -> string
    default this.readAsString(fileName: string, bytes: sbyte[]) : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract close : closeable: obj -> bool
    default this.close(closeable: obj) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        try
            if not (JR.same(closeable, null)) then
                let mutable inputStream : InputStream = ((box (closeable) :?> InputStream))
                ignore (inputStream.close())
            jret <- true
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.CLOSE, e)
                jret <- false
                jflow <- 1
            | _ -> reraise ()
        jret


