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
type HudGraphicsPosition =
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable point : GPoint
    [<DefaultValue(false)>] static val mutable private jcell_NULL_HUD_GRAPHICS_POSITION : HudGraphicsPosition
    static member NULL_HUD_GRAPHICS_POSITION with get() : HudGraphicsPosition = (HudGraphicsPosition.jclinit(); HudGraphicsPosition.jcell_NULL_HUD_GRAPHICS_POSITION) and set (jvalue: HudGraphicsPosition) = (HudGraphicsPosition.jclinit(); HudGraphicsPosition.jcell_NULL_HUD_GRAPHICS_POSITION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HudGraphicsPosition.jclinitDone then
            HudGraphicsPosition.jclinitDone <- true
            HudGraphicsPosition.jclinitBody()
    static member private jclinitBody() : unit =
        HudGraphicsPosition.jcell_NULL_HUD_GRAPHICS_POSITION <- (new HudGraphicsPosition(PointFactory.getInstance().ZERO_ZERO, 9))
        ()
    member this.jfields_HudGraphicsPosition() : unit =
        this.point <- PointFactory.getInstance().ZERO_ZERO
        ()
    
    new (point: GPoint, anchor: int) as this =
        {  }
        then
            this.jfields_HudGraphicsPosition()
            this.jctor1(point, anchor)
    member this.jctor1(point: GPoint, anchor: int) : unit =
        this.setAnchor(anchor)
        this.setPoint(point)
        ()
    
    abstract getAnchor : unit -> int
    default this.getAnchor() : int =
        this.anchor
    
    member this.setAnchor(anchor: int) : unit =
        this.anchor <- anchor
    
    abstract getPoint : unit -> GPoint
    default this.getPoint() : GPoint =
        this.point
    
    abstract setPoint : point: GPoint -> unit
    default this.setPoint(point: GPoint) : unit =
        this.point <- point


