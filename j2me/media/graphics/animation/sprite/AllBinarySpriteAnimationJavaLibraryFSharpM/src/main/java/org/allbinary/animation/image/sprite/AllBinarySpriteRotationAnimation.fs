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
type AllBinarySpriteRotationAnimation =
    inherit HackRotationSpriteIndexedAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinarySpriteRotationAnimation.jclinitDone then
            AllBinarySpriteRotationAnimation.jclinitDone <- true
            AllBinarySpriteRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sprite: Sprite, image: Image, animationBehavior: AnimationBehavior) as this =
        { inherit HackRotationSpriteIndexedAnimation(sprite, image, AngleInfo.getInstance(int16 ((int (int (AngleFactory.getInstance().TOTAL_ANGLE)) / sprite.getRawFrameCount()))), animationBehavior) }
        then
            this.jctor1(sprite, image, animationBehavior)
    member this.jctor1(sprite: Sprite, image: Image, animationBehavior: AnimationBehavior) : unit =
        ()
        this.angleInfo.adjustAngle(this.sprite.getFrame())
        ()
    
    override this.nextRotation() : unit =
        this.sprite.nextFrame()
        this.angleInfo.adjustAngle(this.sprite.getFrame())
    
    override this.previousRotation() : unit =
        this.sprite.prevFrame()
        this.angleInfo.adjustAngle(this.sprite.getFrame())
    
    override this.setFrameByDirection(direction: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getFrameAngle(direction)
        this.adjustFrameToAngle(angle)
    
    override this.setFrameToAngle(angle: Angle) : unit =
        this.adjustFrameToAngle(angle)
    
    override this.setFrame(index: int) : unit =
        this.sprite.setFrame(index)
        this.angleInfo.adjustAngle(this.getFrame())
    
    override this.adjustFrameToAngle(angle: Angle) : unit =
        this.adjustFrame(angle.getValue())
    
    override this.adjustFrame(angle: int16) : unit =
        this.setFrame(this.frameUtil.getFrameForAngle(angle, int (this.angleInfo.getAngleIncrementInfo().getAngleIncrement())))


