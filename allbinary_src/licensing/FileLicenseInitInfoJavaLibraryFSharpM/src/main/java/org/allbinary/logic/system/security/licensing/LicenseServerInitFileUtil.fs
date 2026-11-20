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
type LicenseServerInitFileUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable NULL_OUTPUT_STREAM : OutputStream
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseServerInitFileUtil.jclinitDone then
            LicenseServerInitFileUtil.jclinitDone <- true
            LicenseServerInitFileUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_LicenseServerInitFileUtil()
    member this.jfields_LicenseServerInitFileUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.NULL_OUTPUT_STREAM <- SimpleFileUtil.nullOutputStream()
        ()
    
    member this.init() : unit =
        try
            let mutable filePath : string = LicenseInitInfoUtil.getInstance().INITFILENAME
            LicenseInitInfoUtil.getInstance().setFilePath(StringUtil.getInstance().EMPTY_STRING)
            if FileFactory.getInstance_jstatic().isFile(filePath) then
                this.logUtil.putF("Using Existing License File", this, this.commonStrings.INIT)
            else
                this.write()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.INIT, e)
            | _ -> reraise ()
    
    member this.write() : unit =
        let mutable jflow = 0
        let mutable fileOutputStream : OutputStream = this.NULL_OUTPUT_STREAM
        try
            try
                let mutable resourceUtil : ResourceUtil = ResourceUtil.getInstance()
                let mutable filePath : string = LicenseInitInfoUtil.getInstance().INITFILENAME
                let mutable inputStream : InputStream = resourceUtil.getResourceAsStream(filePath)
                this.logUtil.putF("Writing Default License File", this, this.commonStrings.INIT)
                let mutable fileStreamFactory : FileStreamFactory = FileStreamFactory.getInstance()
                fileOutputStream <- fileStreamFactory.getFileOutputStreamInstance(StringUtil.getInstance().EMPTY_STRING, filePath)
                let mutable b : int = 0
                let mutable index : int = 0
                while jflow = 0 && (true) do
                    b <- inputStream.read()
                    if b = (-1) then
                        jflow <- 100001
                    if jflow = 0 then
                        fileOutputStream.write(b)
                        index <- index + 1
                    if jflow = 200001 then jflow <- 0
                if jflow = 100001 then jflow <- 0
                if jflow = 0 then
                    this.logUtil.putF((JR.nn("Wrote Bytes: ") + JR.str(index)), this, this.commonStrings.INIT)
                    ignore (fileOutputStream.flush())
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.INIT, e)
                | _ -> reraise ()
        finally
            ignore (StreamUtil.getInstance().close(fileOutputStream))


