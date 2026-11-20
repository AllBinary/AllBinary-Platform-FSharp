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
type LicenseInitInfoUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable INITFILENAME : string
    [<DefaultValue(false)>] val mutable ABOUT : string
    [<DefaultValue(false)>] val mutable PRIVACY_POLICY : string
    [<DefaultValue(false)>] val mutable filePath : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : LicenseInitInfoUtil
    static member instance with get() : LicenseInitInfoUtil = (LicenseInitInfoUtil.jclinit(); LicenseInitInfoUtil.jcell_instance) and set (jvalue: LicenseInitInfoUtil) = (LicenseInitInfoUtil.jclinit(); LicenseInitInfoUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseInitInfoUtil.jclinitDone then
            LicenseInitInfoUtil.jclinitDone <- true
            LicenseInitInfoUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseInitInfoUtil.jcell_instance <- (new LicenseInitInfoUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_LicenseInitInfoUtil()
    member this.jfields_LicenseInitInfoUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.stringUtil <- StringUtil.getInstance()
        this.INITFILENAME <- "licenseinitdata.dat"
        this.ABOUT <- "about"
        this.PRIVACY_POLICY <- "privacy_policy"
        this.filePath <- this.stringUtil.EMPTY_STRING
        ()
    
    static member getInstance() : LicenseInitInfoUtil =
        LicenseInitInfoUtil.instance
    
    abstract setFilePath : filePath: string -> unit
    default this.setFilePath(filePath: string) : unit =
        this.filePath <- filePath
    
    abstract write : initData: LicenseInitInfo -> unit
    default this.write(initData: LicenseInitInfo) : unit =
        if (JR.sameString(this.filePath, this.stringUtil.EMPTY_STRING)) then
            this.filePath <- JR.nn(URLGLOBALS.getMainPath()) + JR.nn(PATH_GLOBALS.getInstance().INIT_PATH)
        try
            let mutable tsUtil : TsUtil = TsUtil.getInstance()
            let mutable dataOutputStream : AbDataOutputStream = DataOutputStreamFactory.getInstance_jstatic().getInstance(this.filePath, this.INITFILENAME)
            let mutable licenseIdCrypted : sbyte[] = tsUtil.getByteArray((new WeakCrypt(1)).encrypt(initData.getLicenseId()))
            ignore (dataOutputStream.writeUTF(DatabaseEncoder.encode(licenseIdCrypted)))
            let mutable numberOfLicenseServers : int = initData.getNumberOfServers()
            ignore (dataOutputStream.writeInt(numberOfLicenseServers))
            let mutable licenseServerCrypted : sbyte[] = null
            let mutable index : int = 0
            while index < numberOfLicenseServers do
                licenseServerCrypted <- tsUtil.getByteArray((new WeakCrypt(3)).encrypt(initData.getServer(index)))
                ignore (dataOutputStream.writeUTF(DatabaseEncoder.encode(licenseServerCrypted)))
                index <- index + 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put((JR.nn("Command Failed: ") + JR.nn(this.INITFILENAME)), this, "write", e)
                ignore (FileStreamFactory.getInstance().delete(this.filePath, this.INITFILENAME))
                raise (e)
            | _ -> reraise ()
    
    abstract read : unit -> LicenseInitInfo
    default this.read() : LicenseInitInfo =
        this.readAgain(0)
    
    abstract readAgain : initializeCounter: int -> LicenseInitInfo
    default this.readAgain(initializeCounter: int) : LicenseInitInfo =
        let mutable jflow = 0
        let mutable jret : LicenseInitInfo = Unchecked.defaultof<LicenseInitInfo>
        let mutable METHOD_NAME : string = "readAgain"
        if (JR.sameString(this.filePath, this.stringUtil.EMPTY_STRING)) then
            this.filePath <- JR.nn(URLGLOBALS.getMainPath()) + JR.nn(PATH_GLOBALS.getInstance().INIT_PATH)
        try
            this.logUtil.putF((JR.nn("LicenseInitInfo File: ") + JR.nn(this.INITFILENAME)), this, METHOD_NAME)
            let mutable fileStreamFactory : FileStreamFactory = FileStreamFactory.getInstance()
            let mutable iFile : AbFileInputStream = fileStreamFactory.getFileInputStreamInstance(this.filePath, this.INITFILENAME)
            if not (JR.same(iFile, null)) then
                let mutable iData : AbDataInputStream = (new AbDataInputStream(iFile))
                let mutable initInfo : LicenseInitInfo = (new LicenseInitInfo())
                let mutable decodedByteArray : sbyte[] = DatabaseEncoder.decode(iData.readUTF())
                let mutable licenseIdDecoded : string = JString.newString(decodedByteArray)
                initInfo.setLicenseId((new WeakCrypt(1)).decrypt(licenseIdDecoded))
                let mutable numberOfLicenseServers : int = iData.readInt()
                let mutable NEXT_FILE : string = (new StringMaker()).append(CommonLabels.getInstance().NEXT).append(" License Server From File: ").ToString()
                let mutable licenseServerDecoded : string = null
                let mutable index : int = 0
                while index < numberOfLicenseServers do
                    decodedByteArray <- DatabaseEncoder.decode(iData.readUTF())
                    licenseServerDecoded <- JString.newString(decodedByteArray)
                    initInfo.setServer((new WeakCrypt(3)).decrypt(licenseServerDecoded), index)
                    this.logUtil.putF((JR.nn(NEXT_FILE) + JR.nn(initInfo.getServer(index))), this, METHOD_NAME)
                    index <- index + 1
                jret <- initInfo
                jflow <- 1
            else
                raise ((new JException((JR.nn("Could Not Load License InitInfo: ") + JR.nn(this.INITFILENAME)))))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                try
                    this.logUtil.put((JR.nn("Command Failed: ") + JR.nn(this.INITFILENAME)), this, METHOD_NAME, e)
                with jex ->
                    match JR.throwable(jex) with
                    | :? JException as e2 ->
                        this.logUtil.put((JR.nn("LicenseInitInfo Read Retry: ") + JR.nn(this.INITFILENAME)), this, "readAgain()", e2)
                    | _ -> reraise ()
                raise ((new JException((JR.nn("LicenseInitInfo Read Error: ") + JR.nn(this.INITFILENAME)))))
            | _ -> reraise ()
        jret
    
    abstract getFilePath : unit -> string
    default this.getFilePath() : string =
        this.filePath


