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
type LeftToRightImageAnimation =
    inherit ImageSegmentAnimation
    [<DefaultValue(false)>] val mutable currentWidth : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LeftToRightImageAnimation.jclinitDone then
            LeftToRightImageAnimation.jclinitDone <- true
            LeftToRightImageAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LeftToRightImageAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, sequenceArray: int[], animationBehavior: AnimationBehavior) as this =
        { inherit ImageSegmentAnimation(image, sequenceArray, animationBehavior) }
        then
            this.jfields_LeftToRightImageAnimation()
            this.jctor1(image, sequenceArray, animationBehavior)
    member this.jctor1(image: Image, sequenceArray: int[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.currentWidth <- 0
        if this.getSequence().[0] = (-1) then
            this.setFrame((this.getSize() - 1))
        ()
    
    override this.nextFrame() : unit =
        if this.getSequence().[0] = (-1) then
            base.previousFrame()
        else
            base.nextFrame()
        this.update()
    
    override this.previousFrame() : unit =
        if this.getSequence().[0] = (-1) then
            base.nextFrame()
        else
            base.previousFrame()
        this.update()
    
    override this.setFrame(index: int) : unit =
        base.setFrame(index)
        this.update()
    
    member this.update() : unit =
        this.currentWidth <- (this.getDrawWidth() * this.getFrame()) / this.getSize()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawRegion(this.getImage(), this.getStartX(), this.getStartY(), this.currentWidth, this.getDrawHeight(), Sprite.TRANS_NONE, x, y, this.anchor)


