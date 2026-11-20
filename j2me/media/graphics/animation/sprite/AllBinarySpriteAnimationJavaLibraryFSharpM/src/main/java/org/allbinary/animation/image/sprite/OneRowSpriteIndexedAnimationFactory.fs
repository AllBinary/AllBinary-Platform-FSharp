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
type OneRowSpriteIndexedAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable animationFactorySpriteScaleUtil : AnimationFactorySpriteScaleUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OneRowSpriteIndexedAnimationFactory.jclinitDone then
            OneRowSpriteIndexedAnimationFactory.jclinitDone <- true
            OneRowSpriteIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OneRowSpriteIndexedAnimationFactory() : unit =
        this.animationFactorySpriteScaleUtil <- AnimationFactorySpriteScaleUtil.getInstance()
        ()
    
    static member createFactoryDX(image: Image, dx: int, animationBehaviorFactory: AnimationBehaviorFactory) : OneRowSpriteIndexedAnimationFactory =
        let mutable oneRowSpriteIndexedAnimationFactory : OneRowSpriteIndexedAnimationFactory = (new OneRowSpriteIndexedAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getHeight(), image.getHeight(), 0, 0, animationBehaviorFactory))
        oneRowSpriteIndexedAnimationFactory.initW(dx)
        oneRowSpriteIndexedAnimationFactory
    
    static member createFactoryDXY(image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : OneRowSpriteIndexedAnimationFactory =
        let mutable oneRowSpriteIndexedAnimationFactory : OneRowSpriteIndexedAnimationFactory = (new OneRowSpriteIndexedAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getHeight(), image.getHeight(), 0, 0, animationBehaviorFactory))
        oneRowSpriteIndexedAnimationFactory.init(dx, dy)
        oneRowSpriteIndexedAnimationFactory
    
    static member createFactoryWH(image: Image, width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) : OneRowSpriteIndexedAnimationFactory =
        (new OneRowSpriteIndexedAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory))
    
    static member createFactory(image: Image, animationBehaviorFactory: AnimationBehaviorFactory) : OneRowSpriteIndexedAnimationFactory =
        (new OneRowSpriteIndexedAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getHeight(), image.getHeight(), 0, 0, animationBehaviorFactory))
    
    new (image: Image, sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, sequenceArray, width, height, dx, dy, animationBehaviorFactory) }
        then
            this.jfields_OneRowSpriteIndexedAnimationFactory()
    
    abstract init : dx: int * dy: int -> unit
    default this.init(dx: int, dy: int) : unit =
        this.animationFactoryInitializationVisitor.dx <- dx
        this.animationFactoryInitializationVisitor.dy <- dy
    
    abstract initW : dx: int -> unit
    default this.initW(dx: int) : unit =
        this.init(dx, 0)
        this.animationFactoryInitializationVisitor.dx <- this.animationFactoryInitializationVisitor.dx + (-((this.animationFactoryInitializationVisitor.width >>> 2)))
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable sprite : Sprite = this.animationFactorySpriteScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            jret <- (new AdjustedSpriteIndexedAnimation(sprite, this.getImage(), BasicColorUtil.getInstance().ZERO_ARRAY, this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new SpriteIndexedAnimation(sprite, this.getImage(), BasicColorUtil.getInstance().ZERO_ARRAY, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret


