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
type ClientInformation =
    [<DefaultValue(false)>] val mutable operatingSystemInterface : GenericOperatingSystem
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable shortName : string
    [<DefaultValue(false)>] val mutable version : string
    [<DefaultValue(false)>] val mutable specialName : string
    [<DefaultValue(false)>] val mutable hardSale : bool
    [<DefaultValue(false)>] val mutable licenseId : string
    [<DefaultValue(false)>] val mutable licenseServers : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ClientInformation.jclinitDone then
            ClientInformation.jclinitDone <- true
            ClientInformation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ClientInformation() : unit =
        this.operatingSystemInterface <- NoOperatingSystem.NO_OPERATING_SYSTEM
        this.tsUtil <- TsUtil.getInstance()
        this.hardSale <- true
        this.licenseId <- StringUtil.getInstance().EMPTY_STRING
        this.licenseServers <- BasicArrayListUtil.getInstance().getImmutableInstance()
        ()
    
    new (name: string, version: string, specialName: string, shortName: string) as this =
        {  }
        then
            this.jfields_ClientInformation()
            this.jctor1(name, version, specialName, shortName)
    member this.jctor1(name: string, version: string, specialName: string, shortName: string) : unit =
        this.name <- name
        this.version <- version
        this.specialName <- specialName
        this.shortName <- (new StringMaker()).append(shortName).append(CommonSeps.getInstance().UNDERSCORE).append(version).ToString()
        this.init()
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract getOperatingSystemInterface : unit -> GenericOperatingSystem
    default this.getOperatingSystemInterface() : GenericOperatingSystem =
        this.operatingSystemInterface
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getSpecialName : unit -> string
    default this.getSpecialName() : string =
        this.specialName
    
    abstract getVersion : unit -> string
    default this.getVersion() : string =
        this.version
    
    abstract getLicenseId : unit -> string
    default this.getLicenseId() : string =
        this.licenseId
    
    abstract getLicenseServers : unit -> BasicArrayList
    default this.getLicenseServers() : BasicArrayList =
        this.licenseServers
    
    abstract getLicenseServer : index: int -> string
    default this.getLicenseServer(index: int) : string =
        (box (this.licenseServers.objectArray.[index]) :?> string)
    
    abstract getNumberOfLicenseServers : unit -> int
    default this.getNumberOfLicenseServers() : int =
        this.licenseServers.size()
    
    abstract toHashtable : unit -> ABHashtable
    default this.toHashtable() : ABHashtable =
        let mutable abeClientInformationData : AbeClientInformationData = AbeClientInformationData.getInstance()
        let mutable genericOperatingSystem : GenericOperatingSystem = this.getOperatingSystemInterface()
        let mutable clientInfoHashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        ignore (clientInfoHashtable.put(abeClientInformationData.NAME, this.name))
        ignore (clientInfoHashtable.put(abeClientInformationData.VERSION, this.version))
        ignore (clientInfoHashtable.put(abeClientInformationData.SPECIALNAME, this.specialName))
        ignore (clientInfoHashtable.put(abeClientInformationData.LICENSEID, this.getLicenseId()))
        ignore (clientInfoHashtable.put(abeClientInformationData.OSNAME, genericOperatingSystem.getName()))
        ignore (clientInfoHashtable.put(abeClientInformationData.OSARCH, genericOperatingSystem.getArch()))
        ignore (clientInfoHashtable.put(abeClientInformationData.OSVERSION, genericOperatingSystem.getVersion()))
        ignore (clientInfoHashtable.put(abeClientInformationData.OS, genericOperatingSystem.ToString()))
        let mutable hardwareInterface : HardwareInterface = SystemHardwareFactory.getInstance_jstatic().getInstance(genericOperatingSystem)
        let mutable hardwareString : string = hardwareInterface.ToString()
        ignore (clientInfoHashtable.put(abeClientInformationData.HARDWARE, hardwareString))
        clientInfoHashtable
    
    abstract isSameId : alicenseId: string -> bool
    default this.isSameId(alicenseId: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.tsUtil.compareTo(this.getLicenseId(), alicenseId) = 0 then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract isLargerOrDifferentServerList : list_: BasicArrayList -> bool
    default this.isLargerOrDifferentServerList(list_: BasicArrayList) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable size : int = list_.size() - 1
        let mutable currentSize : int = this.licenseServers.size() - 1
        if size > currentSize then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            let mutable index : int = size
            while jflow = 0 && (index >= 0) do
                let mutable newServerName : string = (box (list_.objectArray.[index]) :?> string)
                let mutable index2 : int = currentSize
                while jflow = 0 && (index2 >= 0) do
                    let mutable nextOldServerName : string = (box (this.licenseServers.objectArray.[index]) :?> string)
                    if this.tsUtil.compareTo(newServerName, nextOldServerName) <> 0 then
                        jret <- true
                        jflow <- 1
                    if jflow = 200002 then jflow <- 0
                    if jflow = 0 then index2 <- index2 - 1
                if jflow = 100002 then jflow <- 0
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                jret <- false
                jflow <- 1
        jret
    
    abstract setHardSale : hardSale: bool -> unit
    default this.setHardSale(hardSale: bool) : unit =
        this.hardSale <- hardSale
    
    abstract isHardSale : unit -> bool
    default this.isHardSale() : bool =
        this.hardSale
    
    abstract setOperatingSystemInterface : operatingSystemInterface: GenericOperatingSystem -> unit
    default this.setOperatingSystemInterface(operatingSystemInterface: GenericOperatingSystem) : unit =
        this.operatingSystemInterface <- operatingSystemInterface
    
    abstract setLicenseId : licenseId: string -> unit
    default this.setLicenseId(licenseId: string) : unit =
        this.licenseId <- licenseId
    
    abstract setLicenseServers : licenseServers: BasicArrayList -> unit
    default this.setLicenseServers(licenseServers: BasicArrayList) : unit =
        this.licenseServers <- licenseServers
    
    abstract toShortString : unit -> string
    default this.toShortString() : string =
        this.shortName
    interface AbeClientInformationInterface with
        member this.init() : unit = this.init()
        member this.getOperatingSystemInterface() : GenericOperatingSystem = this.getOperatingSystemInterface()
        member this.getName() : string = this.getName()
        member this.getSpecialName() : string = this.getSpecialName()
        member this.getVersion() : string = this.getVersion()
        member this.getLicenseId() : string = this.getLicenseId()
        member this.getLicenseServers() : BasicArrayList = this.getLicenseServers()
        member this.getLicenseServer(jp0: int) : string = this.getLicenseServer(jp0)
        member this.getNumberOfLicenseServers() : int = this.getNumberOfLicenseServers()
        member this.toHashtable() : ABHashtable = this.toHashtable()
        member this.isSameId(jp0: string) : bool = this.isSameId(jp0)
        member this.isLargerOrDifferentServerList(jp0: BasicArrayList) : bool = this.isLargerOrDifferentServerList(jp0)
        member this.isHardSale() : bool = this.isHardSale()
        member this.toShortString() : string = this.toShortString()


