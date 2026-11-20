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
type BottomToTopImageAnimation =
    inherit ImageSegmentAnimation
    [<DefaultValue(false)>] val mutable startHeight : int
    [<DefaultValue(false)>] val mutable currentHeight : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BottomToTopImageAnimation.jclinitDone then
            BottomToTopImageAnimation.jclinitDone <- true
            BottomToTopImageAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BottomToTopImageAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, animationBehavior: AnimationBehavior) as this =
        { inherit ImageSegmentAnimation(image, PrimitiveIntUtil.getArrayInstance(), animationBehavior) }
        then
            this.jfields_BottomToTopImageAnimation()
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
        this.startHeight <- (this.getDrawHeight() * this.getFrame()) / this.getSize()
        this.currentHeight <- this.getDrawHeight() - this.startHeight
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawRegion(this.getImage(), this.getStartX(), this.startHeight, this.getDrawWidth(), this.currentHeight, Sprite.TRANS_NONE, x, (y + this.startHeight), this.anchor)


