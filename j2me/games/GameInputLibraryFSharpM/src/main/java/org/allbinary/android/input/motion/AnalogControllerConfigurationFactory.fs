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
type AnalogControllerConfigurationFactory =
    [<DefaultValue(false)>] val mutable SCALE_FACTOR : int
    [<DefaultValue(false)>] val mutable SCALE_VALUE : int
    [<DefaultValue(false)>] val mutable available : bool
    [<DefaultValue(false)>] val mutable analogControllerConfigurationEvent : AnalogControllerConfigurationEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnalogControllerConfigurationFactory
    static member instance with get() : AnalogControllerConfigurationFactory = (AnalogControllerConfigurationFactory.jclinit(); AnalogControllerConfigurationFactory.jcell_instance) and set (jvalue: AnalogControllerConfigurationFactory) = (AnalogControllerConfigurationFactory.jclinit(); AnalogControllerConfigurationFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogControllerConfigurationFactory.jclinitDone then
            AnalogControllerConfigurationFactory.jclinitDone <- true
            AnalogControllerConfigurationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AnalogControllerConfigurationFactory.jcell_instance <- (new AnalogControllerConfigurationFactory())
        ()
    member this.jfields_AnalogControllerConfigurationFactory() : unit =
        this.SCALE_FACTOR <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_FACTOR
        this.SCALE_VALUE <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_VALUE
        this.analogControllerConfigurationEvent <- (new AnalogControllerConfigurationEvent(this))
        ()
    
    static member getInstance() : AnalogControllerConfigurationFactory =
        AnalogControllerConfigurationFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AnalogControllerConfigurationFactory()
    
    abstract isAvailable : unit -> bool
    default this.isAvailable() : bool =
        this.available
    
    abstract setAvailable : available: bool -> unit
    default this.setAvailable(available: bool) : unit =
        this.available <- available
        AnalogControllerConfigurationEventHandler.getInstance().fireEvent(this.analogControllerConfigurationEvent)


