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
type RightToLeftImageAnimation =
    inherit ImageSegmentAnimation
    [<DefaultValue(false)>] val mutable startWidth : int
    [<DefaultValue(false)>] val mutable currentWidth : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RightToLeftImageAnimation.jclinitDone then
            RightToLeftImageAnimation.jclinitDone <- true
            RightToLeftImageAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RightToLeftImageAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, animationBehavior: AnimationBehavior) as this =
        { inherit ImageSegmentAnimation(image, PrimitiveIntUtil.getArrayInstance(), animationBehavior) }
        then
            this.jfields_RightToLeftImageAnimation()
            this.jctor1(image, animationBehavior)
    member this.jctor1(image: Image, animationBehavior: AnimationBehavior) : unit =
        ()
        this.setFrame((this.getSize() - 1))
        ()
    
    override this.nextFrame() : unit =
        base.previousFrame()
        this.update()
    
    override this.previousFrame() : unit =
        base.nextFrame()
        this.update()
    
    override this.setFrame(index: int) : unit =
        base.setFrame(index)
        this.update()
    
    member this.update() : unit =
        this.startWidth <- (this.getDrawWidth() * this.getFrame()) / this.getSize()
        this.currentWidth <- this.getDrawWidth() - this.startWidth
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawRegion(this.getImage(), this.startWidth, this.getStartY(), this.currentWidth, this.getDrawHeight(), Sprite.TRANS_NONE, (x + this.startWidth), y, this.anchor)


