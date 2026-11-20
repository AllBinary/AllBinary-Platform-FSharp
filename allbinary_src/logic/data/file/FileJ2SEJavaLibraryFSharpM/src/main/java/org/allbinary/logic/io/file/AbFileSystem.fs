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
        let mutable file : File = (new File(path))
        file.isDirectory() || file.isFile()
    
    abstract isDirectory : path: string -> bool
    default this.isDirectory(path: string) : bool =
        (new File(path)).isDirectory()
    
    abstract getFilesAsStringArrayForPath : currentDirPath: string -> string[]
    default this.getFilesAsStringArrayForPath(currentDirPath: string) : string[] =
        let mutable jflow = 0
        let mutable jret : string[] = Unchecked.defaultof<string[]>
        let mutable file : File = (new File(currentDirPath))
        if file.exists() then
            jret <- file.list()
            jflow <- 1
        else
            jret <- StringUtil.getInstance().getArrayInstance()
            jflow <- 1
        jret
    
    abstract readAsString : fileName: string -> string
    default this.readAsString(fileName: string) : string =
        let mutable bytes : sbyte[] = (Array.zeroCreate<sbyte> (1000000))
        this.readAsString(fileName, bytes)
    
    abstract readAsString : fileName: string * bytes: sbyte[] -> string
    default this.readAsString(fileName: string, bytes: sbyte[]) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable closeable : obj = NullUtil.getInstance().NULL_OBJECT
        try
            try
                let mutable idFile : InputStream = (new FileInputStream(fileName))
                closeable <- idFile
                let mutable size : int = idFile.read(bytes)
                if size > 0 then
                    jret <- JString.newString(bytes, 0, size)
                    jflow <- 1
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, "readAsString", e)
                | _ -> reraise ()
        finally
            ignore (this.close(closeable))
        if jflow = 0 then
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        jret
    
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


