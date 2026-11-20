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
type HardwareFactory =
    [<DefaultValue(false)>] val mutable SINGLETON : HardwareInterface
    [<DefaultValue(false)>] static val mutable private jcell_instance : HardwareFactory
    static member instance with get() : HardwareFactory = (HardwareFactory.jclinit(); HardwareFactory.jcell_instance) and set (jvalue: HardwareFactory) = (HardwareFactory.jclinit(); HardwareFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HardwareFactory.jclinitDone then
            HardwareFactory.jclinitDone <- true
            HardwareFactory.jclinitBody()
    static member private jclinitBody() : unit =
        HardwareFactory.jcell_instance <- (new HardwareFactory())
        ()
    member this.jfields_HardwareFactory() : unit =
        this.SINGLETON <- NoHardware.getInstance()
        ()
    
    static member getInstance_jstatic() : HardwareFactory =
        HardwareFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_HardwareFactory()
    
    abstract getInstance : os: OperatingSystemInterface -> HardwareInterface
    default this.getInstance(os: OperatingSystemInterface) : HardwareInterface =
        let mutable jflow = 0
        let mutable jret : HardwareInterface = Unchecked.defaultof<HardwareInterface>
        try
            jret <- this.SINGLETON
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                raise (e)
            | _ -> reraise ()
        jret


