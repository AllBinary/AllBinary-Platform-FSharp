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
    [<DefaultValue(false)>] val mutable genericOperatingSystem : GenericOperatingSystem
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
        this.genericOperatingSystem <- NoOperatingSystem.NO_OPERATING_SYSTEM
        ()
    
    static member getInstance() : OperatingSystemFactory =
        OperatingSystemFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_OperatingSystemFactory()
    
    abstract getOperatingSystemInstance : unit -> GenericOperatingSystem
    default this.getOperatingSystemInstance() : GenericOperatingSystem =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        try
            let mutable osString : string = (new StringMaker()).append("OperatingSystem Info: ").append(this.genericOperatingSystem.ToString()).ToString()
            JSystem.out.println(osString)
            this.logUtil.putF(osString, this, commonStrings.GET_INSTANCE)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
            | _ -> reraise ()
        this.genericOperatingSystem


