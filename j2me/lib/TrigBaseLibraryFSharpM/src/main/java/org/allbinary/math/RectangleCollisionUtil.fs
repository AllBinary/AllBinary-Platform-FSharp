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
type RectangleCollisionUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : RectangleCollisionUtil
    static member instance with get() : RectangleCollisionUtil = (RectangleCollisionUtil.jclinit(); RectangleCollisionUtil.jcell_instance) and set (jvalue: RectangleCollisionUtil) = (RectangleCollisionUtil.jclinit(); RectangleCollisionUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RectangleCollisionUtil.jclinitDone then
            RectangleCollisionUtil.jclinitDone <- true
            RectangleCollisionUtil.jclinitBody()
    static member private jclinitBody() : unit =
        RectangleCollisionUtil.jcell_instance <- (new RectangleCollisionUtil())
        ()
    
    static member getInstance() : RectangleCollisionUtil =
        RectangleCollisionUtil.instance
    
    new () =
        {  }
    
    abstract isCollision : rectX1: int * rectY1: int * rectX2: int * rectY2: int * rect2X1: int * rect2Y1: int * rect2X2: int * rect2Y2: int -> bool
    default this.isCollision(rectX1: int, rectY1: int, rectX2: int, rectY2: int, rect2X1: int, rect2Y1: int, rect2X2: int, rect2Y2: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((rect2X1 >= rectX2) || (rect2Y1 >= rectY2)) || (rect2X2 <= rectX1)) || (rect2Y2 <= rectY1) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    abstract isInside : rectX1: int * rectY1: int * rectX2: int * rectY2: int * x: int * y: int -> bool
    default this.isInside(rectX1: int, rectY1: int, rectX2: int, rectY2: int, x: int, y: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((x >= rectX2) || (y >= rectY2)) || (x <= rectX1)) || (y <= rectY1) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret


