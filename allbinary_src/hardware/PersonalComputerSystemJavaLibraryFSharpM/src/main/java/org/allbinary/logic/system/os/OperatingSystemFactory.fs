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
type OperatingSystemFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable genericOperatingSystem : GenericOperatingSystem
    [<DefaultValue(false)>] val mutable hasDetected : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : OperatingSystemFactory
    static member instance with get() : OperatingSystemFactory = (OperatingSystemFactory.jclinit(); OperatingSystemFactory.jcell_instance) and set (jvalue: OperatingSystemFactory) = (OperatingSystemFactory.jclinit(); OperatingSystemFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OperatingSystemFactory.jclinitDone then
            OperatingSystemFactory.jclinitDone <- true
            OperatingSystemFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OperatingSystemFactory.jcell_instance <- (new OperatingSystemFactory())
        ()
    member this.jfields_OperatingSystemFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.genericOperatingSystem <- NoOperatingSystem.NO_OPERATING_SYSTEM
        this.hasDetected <- false
        ()
    
    static member getInstance() : OperatingSystemFactory =
        OperatingSystemFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_OperatingSystemFactory()
    
    abstract getOperatingSystemInstance : unit -> GenericOperatingSystem
    default this.getOperatingSystemInstance() : GenericOperatingSystem =
        let mutable jflow = 0
        let mutable jret : GenericOperatingSystem = Unchecked.defaultof<GenericOperatingSystem>
        try
            let mutable operatingSystems : OperatingSystems = OperatingSystems.getInstance()
            let mutable systemProperties : SystemProperties = SystemProperties.getInstance()
            let mutable osName : string = systemProperties.getName()
            let mutable osArch : string = systemProperties.getArch()
            let mutable osVersion : string = systemProperties.getVersion()
            if not (this.hasDetected) then
                this.logUtil.putF((JR.nn("osName: ") + JR.nn(osName)), this, this.commonStrings.GET_INSTANCE)
                this.hasDetected <- true
                if JString.indexOf(osName, operatingSystems.LINUX) >= 0 then
                    if LogConfigTypes.LOGGING.contains(LogConfigTypeFactory.getInstance().FACTORYERROR) then
                        this.logUtil.putF("Found a Linux OS", this, this.commonStrings.GET_INSTANCE)
                    this.genericOperatingSystem <- LinuxOperatingSystemFactory.getInstance().getOperatingSystemInstance()
                elif JString.indexOf(osName, operatingSystems.WINDOWS) >= 0 then
                    if LogConfigTypes.LOGGING.contains(LogConfigTypeFactory.getInstance().FACTORYERROR) then
                        this.logUtil.putF("Found a Windows OS", this, this.commonStrings.GET_INSTANCE)
                    this.genericOperatingSystem <- WindowsOperatingSystemFactory.getInstance().getOperatingSystemInstance()
                elif JString.indexOf(osName, operatingSystems.SOLARIS) >= 0 then
                    if LogConfigTypes.LOGGING.contains(LogConfigTypeFactory.getInstance().FACTORYERROR) then
                        this.logUtil.putF("Found a Solaris OS", this, this.commonStrings.GET_INSTANCE)
                    this.genericOperatingSystem <- SolarisOperatingSystemFactory.getInstance().getOperatingSystemInstance()
                else
                    raise ((new JException((new StringMaker()).append("OS Not Supported: ").append(osName).ToString())))
                let mutable log : Log = LogFactory.getInstanceF((new StringMaker()).append("OperatingSystem Info: ").append(StringUtil.getInstance().toString(this.genericOperatingSystem)).ToString(), this, this.commonStrings.GET_INSTANCE)
                JSystem.out.println(log.ToString())
                this.logUtil.putL(log)
            jret <- this.genericOperatingSystem
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                if LogConfigTypes.LOGGING.contains(LogConfigTypeFactory.getInstance().FACTORYERROR) then
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.GET_INSTANCE, e)
                jret <- NoOperatingSystem.NO_OPERATING_SYSTEM
                jflow <- 1
            | _ -> reraise ()
        jret


