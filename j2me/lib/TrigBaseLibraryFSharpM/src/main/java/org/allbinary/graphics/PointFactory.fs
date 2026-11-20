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
type PointFactory =
    [<DefaultValue(false)>] val mutable ZERO_ZERO : GPoint
    [<DefaultValue(false)>] static val mutable private jcell_instance : PointFactory
    static member instance with get() : PointFactory = (PointFactory.jclinit(); PointFactory.jcell_instance) and set (jvalue: PointFactory) = (PointFactory.jclinit(); PointFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PointFactory.jclinitDone then
            PointFactory.jclinitDone <- true
            PointFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PointFactory.jcell_instance <- (new PointFactory())
        ()
    member this.jfields_PointFactory() : unit =
        this.ZERO_ZERO <- this.createXYZ(0, 0, 0)
        ()
    
    static member getInstance() : PointFactory =
        PointFactory.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    new () as this =
        {  }
        then
            this.jfields_PointFactory()
    
    abstract createXY : x: int * y: int -> GPoint
    default this.createXY(x: int, y: int) : GPoint =
        (new GPoint(x, y, 0))
    
    abstract createXYZ : x: int * y: int * z: int -> GPoint
    default this.createXYZ(x: int, y: int, z: int) : GPoint =
        (new GPoint(x, y, z))


