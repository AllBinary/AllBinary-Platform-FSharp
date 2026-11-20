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
type CaptionAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable overlayAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable captionDx : int
    [<DefaultValue(false)>] val mutable captionDy : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CaptionAnimation.jclinitDone then
            CaptionAnimation.jclinitDone <- true
            CaptionAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterface: Animation, overlayAnimationInterface: Animation, captionDx: int, captionDy: int, dx: int, dy: int) as this =
        { inherit Animation() }
        then
            this.jctor1(animationInterface, overlayAnimationInterface, captionDx, captionDy, dx, dy)
    member this.jctor1(animationInterface: Animation, overlayAnimationInterface: Animation, captionDx: int, captionDy: int, dx: int, dy: int) : unit =
        this.animationInterface <- animationInterface
        this.overlayAnimationInterface <- overlayAnimationInterface
        this.captionDx <- captionDx
        this.captionDy <- captionDy
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.nextFrame() : unit =
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.animationInterface.paintXY(graphics, (x + this.captionDx), (y + this.captionDy))
        this.overlayAnimationInterface.paintXY(graphics, ((x + this.captionDx) + this.dx), ((y + this.captionDy) + this.dy))
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        this.animationInterface.paintThreedXYZ(graphics, (x + this.captionDx), (y + this.captionDy), z)
        this.overlayAnimationInterface.paintThreedXYZ(graphics, ((x + this.captionDx) + this.dx), ((y + this.captionDy) + this.dy), z)


