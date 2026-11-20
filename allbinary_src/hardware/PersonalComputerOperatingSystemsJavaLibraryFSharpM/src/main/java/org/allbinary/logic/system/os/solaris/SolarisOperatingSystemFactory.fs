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
type SolarisOperatingSystemFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : SolarisOperatingSystemFactory
    static member instance with get() : SolarisOperatingSystemFactory = (SolarisOperatingSystemFactory.jclinit(); SolarisOperatingSystemFactory.jcell_instance) and set (jvalue: SolarisOperatingSystemFactory) = (SolarisOperatingSystemFactory.jclinit(); SolarisOperatingSystemFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SolarisOperatingSystemFactory.jclinitDone then
            SolarisOperatingSystemFactory.jclinitDone <- true
            SolarisOperatingSystemFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SolarisOperatingSystemFactory.jcell_instance <- (new SolarisOperatingSystemFactory())
        ()
    member this.jfields_SolarisOperatingSystemFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : SolarisOperatingSystemFactory =
        SolarisOperatingSystemFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_SolarisOperatingSystemFactory()
    
    abstract getOperatingSystemInstance : unit -> GenericOperatingSystem
    default this.getOperatingSystemInstance() : GenericOperatingSystem =
        let mutable jflow = 0
        let mutable jret : GenericOperatingSystem = Unchecked.defaultof<GenericOperatingSystem>
        try
            let mutable operatingSystems : OperatingSystems = OperatingSystems.getInstance()
            let mutable osName : string = SystemProperties.getInstance().getName()
            let mutable operatingSystemInterface : GenericOperatingSystem = null
            if JString.compareTo(osName, operatingSystems.SOLARIS) = 0 then
                operatingSystemInterface <- (new SolarisOS())
            else
                if operatingSystems.isUnknownSpecificOSAllowed() then
                    operatingSystemInterface <- (new SolarisOS())
                else
                    raise ((new JException((JR.nn("Specific Solaris OS Not Supported: ") + JR.nn(osName)))))
            jret <- operatingSystemInterface
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                if LogConfigTypes.LOGGING.contains(LogConfigTypeFactory.getInstance().FACTORYERROR) then
                    let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                    this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
                jret <- NoOperatingSystem.NO_OPERATING_SYSTEM
                jflow <- 1
            | _ -> reraise ()
        jret


