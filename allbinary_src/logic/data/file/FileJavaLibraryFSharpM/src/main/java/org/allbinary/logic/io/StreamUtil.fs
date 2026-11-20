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
type StreamUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : StreamUtil
    static member instance with get() : StreamUtil = (StreamUtil.jclinit(); StreamUtil.jcell_instance) and set (jvalue: StreamUtil) = (StreamUtil.jclinit(); StreamUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StreamUtil.jclinitDone then
            StreamUtil.jclinitDone <- true
            StreamUtil.jclinitBody()
    static member private jclinitBody() : unit =
        StreamUtil.jcell_instance <- (new StreamUtil())
        ()
    member this.jfields_StreamUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : StreamUtil =
        StreamUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_StreamUtil()
    
    abstract get : inputStream: InputStream * outputStream: OutputStream * buffer: sbyte[] -> OutputStream
    default this.get(inputStream: InputStream, outputStream: OutputStream, buffer: sbyte[]) : OutputStream =
        let mutable jflow = 0
        let mutable jret : OutputStream = Unchecked.defaultof<OutputStream>
        let mutable len : int = 0
        while jflow = 0 && (true) do
            len <- inputStream.read(buffer, 0, buffer.Length)
            if len <> (-1) then
                ()
            else
                jflow <- 100001
            if jflow = 0 then
                ignore (outputStream.write(buffer, 0, len))
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- outputStream
            jflow <- 1
        jret
    
    abstract getByteArray : inputStream: InputStream * outputStream2: ByteArrayOutputStream * byteArray: sbyte[] -> sbyte[]
    default this.getByteArray(inputStream: InputStream, outputStream2: ByteArrayOutputStream, byteArray: sbyte[]) : sbyte[] =
        let mutable jflow = 0
        let mutable jret : sbyte[] = Unchecked.defaultof<sbyte[]>
        let mutable outputStream : ByteArrayOutputStream = outputStream2
        try
            try
                ignore (this.get(inputStream, outputStream, byteArray))
                jret <- outputStream.toByteArray()
                jflow <- 1
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            ignore (this.close(outputStream))
        jret
    
    abstract close : closeable: Closeable -> bool
    default this.close(closeable: Closeable) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        try
            if not (JR.same(closeable, null)) then
                ignore (closeable.close())
            jret <- true
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CLOSE, e)
                jret <- false
                jflow <- 1
            | _ -> reraise ()
        jret


