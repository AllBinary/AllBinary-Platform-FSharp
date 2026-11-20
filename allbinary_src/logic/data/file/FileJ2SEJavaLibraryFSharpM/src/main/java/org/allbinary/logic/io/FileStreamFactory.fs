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
type FileStreamFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : obj
    static member SINGLETON with get() : obj = (FileStreamFactory.jclinit(); FileStreamFactory.jcell_SINGLETON) and set (jvalue: obj) = (FileStreamFactory.jclinit(); FileStreamFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FileStreamFactory.jclinitDone then
            FileStreamFactory.jclinitDone <- true
            FileStreamFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FileStreamFactory.jcell_SINGLETON <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : FileStreamFactory =
        if (JR.same(FileStreamFactory.SINGLETON, NullUtil.getInstance().NULL_OBJECT)) then
            FileStreamFactory.SINGLETON <- (new FileStreamFactory())
        (box (FileStreamFactory.SINGLETON) :?> FileStreamFactory)
    
    new () =
        {  }
    
    abstract getFileInputStreamInstance : path: string * fileName: string -> AbFileInputStream
    default this.getFileInputStreamInstance(path: string, fileName: string) : AbFileInputStream =
        let mutable FILEABPATH : AbPath = (new AbPath(path, fileName))
        let mutable file : AbFile = AbFile.createAbFileFromAbPath(FILEABPATH)
        AbFileInputStream.createFromAbFile(file)
    
    abstract getFileOutputStreamInstance : path: string * fileName: string -> AbFileOutputStream
    default this.getFileOutputStreamInstance(path: string, fileName: string) : AbFileOutputStream =
        let mutable FILEABPATH : AbPath = (new AbPath(path, fileName))
        let mutable file : AbFile = AbFile.createAbFileFromAbPath(FILEABPATH)
        if file.exists() then
            ignore (file.delete())
            ignore (file.createNewFile())
        AbFileOutputStream.createFromAbFile(file)
    
    abstract delete : path: string * fileName: string -> unit
    default this.delete(path: string, fileName: string) : unit =
        let mutable FILEABPATH : AbPath = (new AbPath(path, fileName))
        let mutable file : AbFile = AbFile.createAbFileFromAbPath(FILEABPATH)
        ignore (file.delete())


