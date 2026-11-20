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
type BasicDecimal =
    [<DefaultValue(false)>] val mutable units : int64
    [<DefaultValue(false)>] val mutable scaled : int
    [<DefaultValue(false)>] val mutable factor : int
    [<DefaultValue(false)>] val mutable factorValue : int
    [<DefaultValue(false)>] static val mutable private jcell_ZERO_BIGDECIMAL : BasicDecimal
    static member ZERO_BIGDECIMAL with get() : BasicDecimal = (BasicDecimal.jclinit(); BasicDecimal.jcell_ZERO_BIGDECIMAL) and set (jvalue: BasicDecimal) = (BasicDecimal.jclinit(); BasicDecimal.jcell_ZERO_BIGDECIMAL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicDecimal.jclinitDone then
            BasicDecimal.jclinitDone <- true
            BasicDecimal.jclinitBody()
    static member private jclinitBody() : unit =
        BasicDecimal.jcell_ZERO_BIGDECIMAL <- (new BasicDecimal(0L))
        ()
    member this.jfields_BasicDecimal() : unit =
        this.factor <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_FACTOR
        this.factorValue <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_VALUE
        ()
    
    static member createBigDecimal(bigDecimal: BasicDecimal) : BasicDecimal =
        (new BasicDecimal(bigDecimal.getUnscaled()))
    
    new (units: int64) as this =
        {  }
        then
            this.jfields_BasicDecimal()
            this.jctor1(units)
    member this.jctor1(units: int64) : unit =
        this.units <- units
        this.updateScaled()
        ()
    
    abstract setint : value: int -> unit
    default this.setint(value: int) : unit =
        this.units <- int64 (value)
        this.updateScaled()
    
    abstract setlong : value: int64 -> unit
    default this.setlong(value: int64) : unit =
        this.units <- value
        this.updateScaled()
    
    abstract set : bigDecimal: BasicDecimal -> unit
    default this.set(bigDecimal: BasicDecimal) : unit =
        this.units <- bigDecimal.getUnscaled()
        this.updateScaled()
    
    abstract addint : value: int -> unit
    default this.addint(value: int) : unit =
        this.units <- this.units + int64 (value)
        this.updateScaled()
    
    abstract addlong : value: int64 -> unit
    default this.addlong(value: int64) : unit =
        this.units <- this.units + value
        this.updateScaled()
    
    abstract add : bigDecimal: BasicDecimal -> unit
    default this.add(bigDecimal: BasicDecimal) : unit =
        this.units <- this.units + bigDecimal.getUnscaled()
        this.updateScaled()
    
    abstract subtractint : value: int -> unit
    default this.subtractint(value: int) : unit =
        this.units <- this.units - int64 (value)
        this.updateScaled()
    
    abstract subtractlong : value: int64 -> unit
    default this.subtractlong(value: int64) : unit =
        this.units <- this.units - value
        this.updateScaled()
    
    abstract subtract : bigDecimal: BasicDecimal -> unit
    default this.subtract(bigDecimal: BasicDecimal) : unit =
        this.units <- this.units - bigDecimal.getUnscaled()
        this.updateScaled()
    
    abstract multiplyint : value: int -> unit
    default this.multiplyint(value: int) : unit =
        this.units <- this.units * int64 (value)
        this.updateScaled()
    
    abstract multiplylong : value: int64 -> unit
    default this.multiplylong(value: int64) : unit =
        this.units <- this.units * value
        this.updateScaled()
    
    abstract multiply : bigDecimal: BasicDecimal -> unit
    default this.multiply(bigDecimal: BasicDecimal) : unit =
        this.units <- this.units * bigDecimal.getUnscaled()
        this.updateScaled()
    
    abstract divideint : value: int -> unit
    default this.divideint(value: int) : unit =
        this.units <- this.units / int64 (value)
        this.updateScaled()
    
    abstract dividelong : value: int64 -> unit
    default this.dividelong(value: int64) : unit =
        this.units <- this.units / value
        this.updateScaled()
    
    abstract divide : bigDecimal: BasicDecimal -> unit
    default this.divide(bigDecimal: BasicDecimal) : unit =
        this.units <- this.units / bigDecimal.getUnscaled()
        this.updateScaled()
    
    abstract getUnscaled : unit -> int64
    default this.getUnscaled() : int64 =
        this.units
    
    member this.updateScaled() : unit =
        this.scaled <- int ((this.units / int64 (this.factorValue)))
    
    abstract getScaled : unit -> int
    default this.getScaled() : int =
        this.scaled
    
    override this.ToString() : string =
        Long.toString(this.units)
    
    abstract getScaledFactor : unit -> int
    default this.getScaledFactor() : int =
        this.factor
    
    abstract getScaledFactorValue : unit -> int
    default this.getScaledFactorValue() : int =
        this.factorValue


