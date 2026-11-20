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
type AdjustedImageBaseRotationAnimation =
    inherit ImageBaseRotationAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustedImageBaseRotationAnimation.jclinitDone then
            AdjustedImageBaseRotationAnimation.jclinitDone <- true
            AdjustedImageBaseRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, angleInfo: AngleInfo, totalAngle: int16, dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit ImageBaseRotationAnimation(image, angleInfo, totalAngle, animationBehavior) }
        then
            this.jctor1(image, angleInfo, totalAngle, dx, dy, animationBehavior)
    member this.jctor1(image: Image, angleInfo: AngleInfo, totalAngle: int16, dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.init(dx, dy)
        ()
    
    abstract init : dx: int * dy: int -> unit
    default this.init(dx: int, dy: int) : unit =
        this.dx <- dx
        this.dy <- dy
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        base.paintXY(graphics, (x + this.dx), (y + this.dy))


