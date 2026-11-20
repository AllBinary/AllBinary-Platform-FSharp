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
type ImageRotationAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable angleIncrement : int16
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageRotationAnimationFactory.jclinitDone then
            ImageRotationAnimationFactory.jclinitDone <- true
            ImageRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, width: int, height: int, dx: int, dy: int, angleIncrement: int16, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory) }
        then
            this.jctor1(image, width, height, dx, dy, angleIncrement, animationBehaviorFactory)
    member this.jctor1(image: Image, width: int, height: int, dx: int, dy: int, angleIncrement: int16, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        this.angleIncrement <- angleIncrement
        this.animationFactoryInitializationVisitor.dx <- dx
        this.animationFactoryInitializationVisitor.dy <- dy
        ()
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            this.animationFactoryImageScaleUtil.processAdjust(this)
            jret <- (new AdjustedImageBaseRotationAnimation(this.getImage(), AngleInfo.getInstance(this.angleIncrement), AngleFactory.getInstance().TOTAL_ANGLE, this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new ImageBaseRotationAnimation(this.getImage(), AngleInfo.getInstance(this.angleIncrement), AngleFactory.getInstance().TOTAL_ANGLE, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret
    
    abstract getAngleIncrementP : unit -> int16
    default this.getAngleIncrementP() : int16 =
        this.angleIncrement


