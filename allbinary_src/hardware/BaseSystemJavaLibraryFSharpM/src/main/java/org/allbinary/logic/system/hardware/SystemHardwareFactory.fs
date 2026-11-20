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
type SystemHardwareFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable hardwareInterface : HardwareInterface
    [<DefaultValue(false)>] static val mutable private jcell_instance : SystemHardwareFactory
    static member instance with get() : SystemHardwareFactory = (SystemHardwareFactory.jclinit(); SystemHardwareFactory.jcell_instance) and set (jvalue: SystemHardwareFactory) = (SystemHardwareFactory.jclinit(); SystemHardwareFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SystemHardwareFactory.jclinitDone then
            SystemHardwareFactory.jclinitDone <- true
            SystemHardwareFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SystemHardwareFactory.jcell_instance <- (new SystemHardwareFactory())
        ()
    member this.jfields_SystemHardwareFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.hardwareInterface <- NoHardware.getInstance()
        ()
    
    static member getInstance_jstatic() : SystemHardwareFactory =
        SystemHardwareFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_SystemHardwareFactory()
    
    abstract getInstance : operatingSystemInterface: GenericOperatingSystem -> HardwareInterface
    default this.getInstance(operatingSystemInterface: GenericOperatingSystem) : HardwareInterface =
        try
            if (JR.same(this.hardwareInterface, NoHardware.getInstance())) then
                this.hardwareInterface <- HardwareFactory.getInstance_jstatic().getInstance(operatingSystemInterface)
            this.logUtil.putF("Found Hardware", this, this.commonStrings.CONSTRUCTOR)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        this.hardwareInterface
    
    static member static_toString() : string =
        let mutable systemHardwareFactory : SystemHardwareFactory = SystemHardwareFactory.getInstance_jstatic()
        let mutable osBuffer : StringMaker = (new StringMaker())
        ignore (osBuffer.append("Hardware Info: \n"))
        if not (JR.same(systemHardwareFactory.hardwareInterface, null)) then
            ignore (osBuffer.append(systemHardwareFactory.hardwareInterface.ToString()))
        else
            ignore (osBuffer.append(StringUtil.getInstance().NULL_STRING))
        osBuffer.ToString()


