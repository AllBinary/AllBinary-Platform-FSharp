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
type FileFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : FileFactory
    static member instance with get() : FileFactory = (FileFactory.jclinit(); FileFactory.jcell_instance) and set (jvalue: FileFactory) = (FileFactory.jclinit(); FileFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FileFactory.jclinitDone then
            FileFactory.jclinitDone <- true
            FileFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FileFactory.jcell_instance <- (new FileFactory())
        ()
    new () =
        {  }
    
    static member getInstance_jstatic() : FileFactory =
        FileFactory.instance
    
    abstract getInstance : filePath: string -> AbFile
    default this.getInstance(filePath: string) : AbFile =
        AbFile.createAbFileFromRawPath(filePath)
    
    abstract getInstance : file: AbFile * childFilePath: string -> AbFile
    default this.getInstance(file: AbFile, childFilePath: string) : AbFile =
        AbFile.createAbFileWithChild(file, childFilePath)
    
    abstract isFile : path: string -> bool
    default this.isFile(path: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable file : AbFile = AbFile.createAbFile(path)
        if file.exists() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


