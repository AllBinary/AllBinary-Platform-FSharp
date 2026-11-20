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
type AbeClientInformation =
    inherit ClientInformation
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbeClientInformation.jclinitDone then
            AbeClientInformation.jclinitDone <- true
            AbeClientInformation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AbeClientInformation() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (name: string, version: string, specialName: string, shortName: string) as this =
        { inherit ClientInformation(name, version, specialName, shortName) }
        then
            this.jfields_AbeClientInformation()
    
    override this.init() : unit =
        try
            this.setOperatingSystemInterface(OperatingSystemFactory.getInstance().getOperatingSystemInstance())
            let mutable licenseInitInfo : LicenseInitInfo = LicenseInitInfoUtil.getInstance().read()
            this.setLicenseId(licenseInitInfo.getLicenseId())
            this.setLicenseServers(licenseInitInfo.getServerList())
            let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
            if stringValidationUtil.isEmpty(this.getLicenseId()) then
                let mutable NONE : string = "No License Id"
                this.setLicenseId(NONE)
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            PreLogUtil.put((new StringMaker()).append("Special Name: ").append(this.getSpecialName()).ToString(), this, commonStrings.CONSTRUCTOR)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()


