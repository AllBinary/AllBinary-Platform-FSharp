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
type AbeClientInformationData =
    [<DefaultValue(false)>] val mutable KEY : string
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] val mutable VERSION : string
    [<DefaultValue(false)>] val mutable SPECIALNAME : string
    [<DefaultValue(false)>] val mutable LICENSEID : string
    [<DefaultValue(false)>] val mutable LICENSE_TYPE : string
    [<DefaultValue(false)>] val mutable PREVIOUSLICENSEID : string
    [<DefaultValue(false)>] val mutable OSNAME : string
    [<DefaultValue(false)>] val mutable OSARCH : string
    [<DefaultValue(false)>] val mutable OSVERSION : string
    [<DefaultValue(false)>] val mutable OS : string
    [<DefaultValue(false)>] val mutable HARDWARE : string
    [<DefaultValue(false)>] val mutable LICENSESERVERS : string
    [<DefaultValue(false)>] val mutable NEWLICENSE : string
    [<DefaultValue(false)>] val mutable ISNEW : string
    [<DefaultValue(false)>] val mutable SPECIAL : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbeClientInformationData
    static member instance with get() : AbeClientInformationData = (AbeClientInformationData.jclinit(); AbeClientInformationData.jcell_instance) and set (jvalue: AbeClientInformationData) = (AbeClientInformationData.jclinit(); AbeClientInformationData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbeClientInformationData.jclinitDone then
            AbeClientInformationData.jclinitDone <- true
            AbeClientInformationData.jclinitBody()
    static member private jclinitBody() : unit =
        AbeClientInformationData.jcell_instance <- (new AbeClientInformationData())
        ()
    member this.jfields_AbeClientInformationData() : unit =
        this.KEY <- "KEY"
        this.NAME <- "NAME"
        this.VERSION <- "VERSION"
        this.SPECIALNAME <- "SPECIALNAME"
        this.LICENSEID <- "LICENSEID"
        this.LICENSE_TYPE <- "LICENSETYPE"
        this.PREVIOUSLICENSEID <- "PREVIOUSLICENSEID"
        this.OSNAME <- "OSNAME"
        this.OSARCH <- "OSARCH"
        this.OSVERSION <- "OSVERSION"
        this.OS <- "OS"
        this.HARDWARE <- "HARDWARE"
        this.LICENSESERVERS <- "LICENSESERVERS"
        this.NEWLICENSE <- "NEWLICENSE"
        this.ISNEW <- "ISNEW"
        this.SPECIAL <- "SPECIAL"
        ()
    
    static member getInstance() : AbeClientInformationData =
        AbeClientInformationData.instance
    
    new () as this =
        {  }
        then
            this.jfields_AbeClientInformationData()


