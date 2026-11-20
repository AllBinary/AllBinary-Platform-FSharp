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
type DataOutputStreamFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : DataOutputStreamFactory
    static member instance with get() : DataOutputStreamFactory = (DataOutputStreamFactory.jclinit(); DataOutputStreamFactory.jcell_instance) and set (jvalue: DataOutputStreamFactory) = (DataOutputStreamFactory.jclinit(); DataOutputStreamFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DataOutputStreamFactory.jclinitDone then
            DataOutputStreamFactory.jclinitDone <- true
            DataOutputStreamFactory.jclinitBody()
    static member private jclinitBody() : unit =
        DataOutputStreamFactory.jcell_instance <- (new DataOutputStreamFactory())
        ()
    new () =
        {  }
    
    static member getInstance_jstatic() : DataOutputStreamFactory =
        DataOutputStreamFactory.instance
    
    abstract getInstanceForAbFile : file: AbFile -> AbDataOutputStream
    default this.getInstanceForAbFile(file: AbFile) : AbDataOutputStream =
        let mutable idFileOutputStream : AbFileOutputStream = AbFileOutputStream.createFromAbFile(file)
        let mutable idOutData : AbDataOutputStream = (new AbDataOutputStream(idFileOutputStream))
        idOutData
    
    abstract getInstance : filePath: string * fileName: string -> AbDataOutputStream
    default this.getInstance(filePath: string, fileName: string) : AbDataOutputStream =
        let mutable fileStreamFactory : FileStreamFactory = FileStreamFactory.getInstance()
        let mutable fileOutputStream : AbFileOutputStream = fileStreamFactory.getFileOutputStreamInstance(filePath, fileName)
        let mutable idOutData : AbDataOutputStream = (new AbDataOutputStream(fileOutputStream))
        idOutData


