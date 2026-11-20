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
type AllBinarySpriteRotationAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable animationFactorySpriteScaleUtil : AnimationFactorySpriteScaleUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinarySpriteRotationAnimationFactory.jclinitDone then
            AllBinarySpriteRotationAnimationFactory.jclinitDone <- true
            AllBinarySpriteRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AllBinarySpriteRotationAnimationFactory() : unit =
        this.animationFactorySpriteScaleUtil <- AnimationFactorySpriteScaleUtil.getInstance()
        ()
    
    static member createWHDY(image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        let mutable spriteRotationAnimationFactory : AllBinarySpriteRotationAnimationFactory = (new AllBinarySpriteRotationAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), (image.getHeight() >>> 2), (image.getHeight() >>> 2), 0, 0, animationBehaviorFactory))
        spriteRotationAnimationFactory.initWH(dx, dy)
        spriteRotationAnimationFactory
    
    static member createWH(image: Image, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        AllBinarySpriteRotationAnimationFactory.createWHDY(image, 0, 0, animationBehaviorFactory)
    
    static member createDXY(image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        let mutable spriteRotationAnimationFactory : AllBinarySpriteRotationAnimationFactory = (new AllBinarySpriteRotationAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getHeight(), image.getHeight(), 0, 0, animationBehaviorFactory))
        spriteRotationAnimationFactory.init(dx, dy)
        spriteRotationAnimationFactory
    
    static member createDXYQ(image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        let mutable spriteRotationAnimationFactory : AllBinarySpriteRotationAnimationFactory = (new AllBinarySpriteRotationAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), (image.getHeight() >>> 2), (image.getHeight() >>> 2), 0, 0, animationBehaviorFactory))
        spriteRotationAnimationFactory.init(dx, dy)
        spriteRotationAnimationFactory
    
    static member createQ(image: Image, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        (new AllBinarySpriteRotationAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), (image.getHeight() >>> 2), (image.getHeight() >>> 2), 0, 0, animationBehaviorFactory))
    
    static member createWHF(image: Image, animationBehaviorFactory: AnimationBehaviorFactory) : AllBinarySpriteRotationAnimationFactory =
        (new AllBinarySpriteRotationAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getHeight(), image.getHeight(), 0, 0, animationBehaviorFactory))
    
    new (image: Image, sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, sequenceArray, width, height, dx, dy, animationBehaviorFactory) }
        then
            this.jfields_AllBinarySpriteRotationAnimationFactory()
            this.jctor1(image, sequenceArray, width, height, dx, dy, animationBehaviorFactory)
    member this.jctor1(image: Image, sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        if (JR.same(animationBehaviorFactory, AnimationBehaviorFactory.getInstance())) then
            ForcedLogUtil.log("Using default AnimationBehaviorFactory with IndexedAnimationFactory", this)
        ()
    
    abstract init : dx: int * dy: int -> unit
    default this.init(dx: int, dy: int) : unit =
        this.animationFactoryInitializationVisitor.dx <- dx
        this.animationFactoryInitializationVisitor.dy <- dy
    
    member this.initWH(dx: int, dy: int) : unit =
        this.init(dx, dy)
        this.animationFactoryInitializationVisitor.dx <- this.animationFactoryInitializationVisitor.dx + ((-(this.animationFactoryInitializationVisitor.width)) / 5)
        this.animationFactoryInitializationVisitor.dy <- this.animationFactoryInitializationVisitor.dy + ((-(this.animationFactoryInitializationVisitor.height)) / 5)
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable sprite : Sprite = this.animationFactorySpriteScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            jret <- (new AllBinaryAdjustedSpriteRotationAnimation(sprite, this.getImage(), this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new AllBinarySpriteRotationAnimation(sprite, this.getImage(), this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        this.getInstance(0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


