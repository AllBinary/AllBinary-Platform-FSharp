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
    [<DefaultValue(false)>] val mutable INITFILENAME : string
    [<DefaultValue(false)>] val mutable ABOUT : string
    [<DefaultValue(false)>] val mutable PRIVACY_POLICY : string
    [<DefaultValue(false)>] val mutable OFFICIAL_ALLBINARY_SERVICES_SERVER : string
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
    member this.jfields_LicenseInitInfoUtil() : unit =
        this.INITFILENAME <- "licenseinitdata.dat"
        this.ABOUT <- "about"
        this.PRIVACY_POLICY <- "privacy_policy"
        this.OFFICIAL_ALLBINARY_SERVICES_SERVER <- "https://services.allbinary.com/LicServ/serverssl.php"
        ()
    
    static member getInstance() : LicenseInitInfoUtil =
        LicenseInitInfoUtil.instance
    
    abstract setFilePath : filePath: string -> unit
    default this.setFilePath(filePath: string) : unit =
        ()
    
    new () as this =
        {  }
        then
            this.jfields_LicenseInitInfoUtil()
    
    abstract write : initData: LicenseInitInfo -> unit
    default this.write(initData: LicenseInitInfo) : unit =
        ()
    
    abstract read : unit -> LicenseInitInfo
    default this.read() : LicenseInitInfo =
        this.readAgain(0)
    
    abstract readAgain : initializeCounter: int -> LicenseInitInfo
    default this.readAgain(initializeCounter: int) : LicenseInitInfo =
        let mutable licenseInitInfo : LicenseInitInfo = (new LicenseInitInfo())
        licenseInitInfo.clearServers()
        licenseInitInfo.addServer(this.OFFICIAL_ALLBINARY_SERVICES_SERVER)
        licenseInitInfo


