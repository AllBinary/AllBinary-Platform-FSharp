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
type CustomGPoint =
    inherit GPoint
    [<DefaultValue(false)>] val mutable cx : int
    [<DefaultValue(false)>] val mutable cy : int
    [<DefaultValue(false)>] val mutable cz : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CUSTOM_POINT : CustomGPoint
    static member NULL_CUSTOM_POINT with get() : CustomGPoint = (CustomGPoint.jclinit(); CustomGPoint.jcell_NULL_CUSTOM_POINT) and set (jvalue: CustomGPoint) = (CustomGPoint.jclinit(); CustomGPoint.jcell_NULL_CUSTOM_POINT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomGPoint.jclinitDone then
            CustomGPoint.jclinitDone <- true
            CustomGPoint.jclinitBody()
    static member private jclinitBody() : unit =
        CustomGPoint.jcell_NULL_CUSTOM_POINT <- (new CustomGPoint(0, 0, 0))
        ()
    
    static member getInstance(point: GPoint) : CustomGPoint =
        (new CustomGPoint(point.getX(), point.getY(), point.getZ()))
    
    static member getInstance3(x: int, y: int) : CustomGPoint =
        (new CustomGPoint(x, y, 3))
    
    new (x: int, y: int, z: int) =
        { inherit GPoint(x, y, z) }
    
    abstract setX : x: int -> unit
    default this.setX(x: int) : unit =
        this.cx <- x
    
    override this.getX() : int =
        this.cx
    
    abstract setY : y: int -> unit
    default this.setY(y: int) : unit =
        this.cy <- y
    
    override this.getY() : int =
        this.cy
    
    abstract setZ : z: int -> unit
    default this.setZ(z: int) : unit =
        this.cz <- z
    
    override this.getZ() : int =
        this.cz


