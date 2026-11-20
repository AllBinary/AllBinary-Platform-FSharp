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
type HackRotationSpriteIndexedAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable sprite : Sprite
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HackRotationSpriteIndexedAnimation.jclinitDone then
            HackRotationSpriteIndexedAnimation.jclinitDone <- true
            HackRotationSpriteIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sprite: Sprite, image: Image, angleInfo: AngleInfo, animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(angleInfo, CircularIndexUtil.createInstance((360 / int (int (angleInfo.getAngleIncrementInfo().getAngleIncrement())))), animationBehavior) }
        then
            this.jctor1(sprite, image, angleInfo, animationBehavior)
    member this.jctor1(sprite: Sprite, image: Image, angleInfo: AngleInfo, animationBehavior: AnimationBehavior) : unit =
        ()
        this.sprite <- sprite
        this.image <- image
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    abstract paintFrame : g: Graphics * frame: int * x: int * y: int -> unit
    default this.paintFrame(g: Graphics, frame: int, x: int, y: int) : unit =
        this.setFrame(frame)
        this.paintXY(g, x, y)
    
    override this.paintXY(g: Graphics, x: int, y: int) : unit =
        this.sprite.setPosition(x, y)
        this.paint(g)
    
    abstract paint : g: Graphics -> unit
    default this.paint(g: Graphics) : unit =
        this.sprite.paint(g)
    
    override this.nextRotation() : unit =
        this.sprite.nextFrame()
    
    override this.previousRotation() : unit =
        this.sprite.prevFrame()
    
    override this.getSize() : int =
        this.sprite.getRawFrameCount()
    
    override this.setFrame(frame: int) : unit =
        this.sprite.setFrame(frame)
    
    override this.getFrame() : int =
        this.sprite.getFrame()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()


