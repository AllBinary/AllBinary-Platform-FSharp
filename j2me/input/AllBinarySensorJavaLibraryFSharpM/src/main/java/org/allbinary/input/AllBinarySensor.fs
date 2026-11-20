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
type AllBinarySensor =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_SENSOR : AllBinarySensor
    static member NULL_ALLBINARY_SENSOR with get() : AllBinarySensor = (AllBinarySensor.jclinit(); AllBinarySensor.jcell_NULL_ALLBINARY_SENSOR) and set (jvalue: AllBinarySensor) = (AllBinarySensor.jclinit(); AllBinarySensor.jcell_NULL_ALLBINARY_SENSOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_max : int
    static member max with get() : int = (AllBinarySensor.jclinit(); AllBinarySensor.jcell_max) and set (jvalue: int) = (AllBinarySensor.jclinit(); AllBinarySensor.jcell_max <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinarySensor.jclinitDone then
            AllBinarySensor.jclinitDone <- true
            AllBinarySensor.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinarySensor.jcell_NULL_ALLBINARY_SENSOR <- (new AllBinarySensor())
        AllBinarySensor.jcell_max <- 100
        ()
    member this.jfields_AllBinarySensor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_AllBinarySensor()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract update : unit -> unit
    default this.update() : unit =
        ()
    
    static member setMax(max_: int) : unit =
        AllBinarySensor.max <- max_
    
    static member getMax() : int =
        AllBinarySensor.max
    
    abstract getId : unit -> int
    default this.getId() : int =
        AllBinarySensor.getMax()
    
    abstract shutdown : unit -> unit
    default this.shutdown() : unit =
        this.logUtil.putF(this.commonStrings.START, this, "shutdown")
    
    abstract onSensorChange : unit -> unit
    default this.onSensorChange() : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
    interface AllBinarySensorListener with
        member this.onSensorChange() : unit = this.onSensorChange()


