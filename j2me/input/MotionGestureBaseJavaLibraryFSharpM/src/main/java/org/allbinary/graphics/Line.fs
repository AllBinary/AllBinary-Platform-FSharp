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
type Line =
    [<DefaultValue(false)>] val mutable p1 : GPoint
    [<DefaultValue(false)>] val mutable p2 : GPoint
    [<DefaultValue(false)>] val mutable deltaX : float
    [<DefaultValue(false)>] val mutable deltaY : float
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Line.jclinitDone then
            Line.jclinitDone <- true
            Line.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (p1: GPoint, p2: GPoint) as this =
        {  }
        then
            this.jctor1(p1, p2)
    member this.jctor1(p1: GPoint, p2: GPoint) : unit =
        this.p1 <- PointFactory.getInstance().ZERO_ZERO
        this.p2 <- this.p1
        this.setP1(p1)
        this.setP2(p2)
        ()
    
    abstract getGradient : unit -> float
    default this.getGradient() : float =
        this.getDeltaY() / this.getDeltaX()
    
    member this.update() : unit =
        this.deltaX <- float (this.getP1().getX()) - float (this.getP2().getX())
        this.deltaY <- float (this.getP1().getY()) - float (this.getP2().getY())
    
    abstract getDeltaX : unit -> float
    default this.getDeltaX() : float =
        this.deltaX
    
    abstract getDeltaY : unit -> float
    default this.getDeltaY() : float =
        this.deltaY
    
    abstract getP1 : unit -> GPoint
    default this.getP1() : GPoint =
        this.p1
    
    abstract getP2 : unit -> GPoint
    default this.getP2() : GPoint =
        this.p2
    
    abstract setP1 : p1: GPoint -> unit
    default this.setP1(p1: GPoint) : unit =
        this.p1 <- p1
        this.update()
    
    abstract setP2 : p2: GPoint -> unit
    default this.setP2(p2: GPoint) : unit =
        this.p2 <- p2
        this.update()


