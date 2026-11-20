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
type SpriteIndexedAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable animationFactorySpriteScaleUtil : AnimationFactorySpriteScaleUtil
    [<DefaultValue(false)>] val mutable basicColorArray : BasicColor[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpriteIndexedAnimationFactory.jclinitDone then
            SpriteIndexedAnimationFactory.jclinitDone <- true
            SpriteIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_SpriteIndexedAnimationFactory() : unit =
        this.animationFactorySpriteScaleUtil <- AnimationFactorySpriteScaleUtil.getInstance()
        this.basicColorArray <- BasicColorUtil.getInstance().ZERO_ARRAY
        ()
    
    static member createCWHDXY(image: Image, basicColorArray: BasicColor[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : SpriteIndexedAnimationFactory =
        (new SpriteIndexedAnimationFactory(image, basicColorArray, PrimitiveIntUtil.getArrayInstance(), width, height, dx, dy, animationBehaviorFactory))
    
    static member createCWH(image: Image, basicColorArray: BasicColor[], width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) : SpriteIndexedAnimationFactory =
        let mutable spriteIndexedAnimationFactory : SpriteIndexedAnimationFactory = (new SpriteIndexedAnimationFactory(image, basicColorArray, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory))
        spriteIndexedAnimationFactory.initHWH()
        spriteIndexedAnimationFactory
    
    static member createWH(image: Image, width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) : SpriteIndexedAnimationFactory =
        (new SpriteIndexedAnimationFactory(image, BasicColorUtil.getInstance().ZERO_ARRAY, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory))
    
    new (image: Image, basicColorArray: BasicColor[], sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, sequenceArray, width, height, dx, dy, animationBehaviorFactory) }
        then
            this.jfields_SpriteIndexedAnimationFactory()
            this.jctor1(image, basicColorArray, sequenceArray, width, height, dx, dy, animationBehaviorFactory)
    member this.jctor1(image: Image, basicColorArray: BasicColor[], sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        this.basicColorArray <- basicColorArray
        ()
    
    member this.initHWH() : unit =
        this.animationFactoryInitializationVisitor.dx <- -((this.animationFactoryInitializationVisitor.width >>> 2))
        this.animationFactoryInitializationVisitor.dy <- -((this.animationFactoryInitializationVisitor.height >>> 2))
        if AndroidUtil.isAndroid() then
            this.animationFactoryInitializationVisitor.dx <- this.animationFactoryInitializationVisitor.dx + 3
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable sprite : Sprite = this.animationFactorySpriteScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            jret <- (new AdjustedSpriteIndexedAnimation(sprite, this.getImage(), this.basicColorArray, this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new SpriteIndexedAnimation(sprite, this.getImage(), this.basicColorArray, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        this.getInstance(0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


