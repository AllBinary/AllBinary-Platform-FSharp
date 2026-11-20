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
type DistanceUtil =
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : DistanceUtil
    static member instance with get() : DistanceUtil = (DistanceUtil.jclinit(); DistanceUtil.jcell_instance) and set (jvalue: DistanceUtil) = (DistanceUtil.jclinit(); DistanceUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DistanceUtil.jclinitDone then
            DistanceUtil.jclinitDone <- true
            DistanceUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DistanceUtil.jcell_instance <- (new DistanceUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_DistanceUtil()
    member this.jfields_DistanceUtil() : unit =
        this.mathUtil <- MathUtil.getInstance()
        ()
    
    static member getInstance() : DistanceUtil =
        DistanceUtil.instance
    
    abstract getDistance : x1: int * y1: int * x2: int * y2: int -> int
    default this.getDistance(x1: int, y1: int, x2: int, y2: int) : int =
        let mutable dx : int = x1 - x2
        let mutable dy : int = y1 - y2
        this.mathUtil.sqrt(((dx * dx) + (dy * dy)))


