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
type AxisMathVectorUtil =
    [<DefaultValue(false)>] val mutable noDecimalTrigTable : NoDecimalTrigTable
    [<DefaultValue(false)>] static val mutable private jcell_instance : AxisMathVectorUtil
    static member instance with get() : AxisMathVectorUtil = (AxisMathVectorUtil.jclinit(); AxisMathVectorUtil.jcell_instance) and set (jvalue: AxisMathVectorUtil) = (AxisMathVectorUtil.jclinit(); AxisMathVectorUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AxisMathVectorUtil.jclinitDone then
            AxisMathVectorUtil.jclinitDone <- true
            AxisMathVectorUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AxisMathVectorUtil.jcell_instance <- (new AxisMathVectorUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_AxisMathVectorUtil()
    member this.jfields_AxisMathVectorUtil() : unit =
        this.noDecimalTrigTable <- NoDecimalTrigTable.getInstance()
        ()
    
    static member getInstance() : AxisMathVectorUtil =
        AxisMathVectorUtil.instance
    
    abstract calculateX : magnitude: int64 * angle: int -> int64
    default this.calculateX(magnitude: int64, angle: int) : int64 =
        (magnitude * this.noDecimalTrigTable.cos(angle)) / 10L
    
    abstract calculateY : magnitude: int64 * angle: int -> int64
    default this.calculateY(magnitude: int64, angle: int) : int64 =
        (magnitude * this.noDecimalTrigTable.sin(angle)) / 10L
    
    abstract calculateZ : magnitude: int64 * otherAngle: int -> int64
    default this.calculateZ(magnitude: int64, otherAngle: int) : int64 =
        (magnitude * this.noDecimalTrigTable.sin(otherAngle)) / 10L


