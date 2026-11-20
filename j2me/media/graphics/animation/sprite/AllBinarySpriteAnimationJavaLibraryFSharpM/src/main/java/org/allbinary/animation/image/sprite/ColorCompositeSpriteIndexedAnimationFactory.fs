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
type ColorCompositeSpriteIndexedAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable animationFactorySpriteScaleUtil : AnimationFactorySpriteScaleUtil
    [<DefaultValue(false)>] val mutable basicColorArray : BasicColor[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorCompositeSpriteIndexedAnimationFactory.jclinitDone then
            ColorCompositeSpriteIndexedAnimationFactory.jclinitDone <- true
            ColorCompositeSpriteIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ColorCompositeSpriteIndexedAnimationFactory() : unit =
        this.animationFactorySpriteScaleUtil <- AnimationFactorySpriteScaleUtil.getInstance()
        ()
    
    new (image: Image, basicColorArray: BasicColor[], width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory) }
        then
            this.jfields_ColorCompositeSpriteIndexedAnimationFactory()
            this.jctor1(image, basicColorArray, width, height, animationBehaviorFactory)
    member this.jctor1(image: Image, basicColorArray: BasicColor[], width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        this.basicColorArray <- basicColorArray
        ()
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable sprite : Sprite = this.animationFactorySpriteScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        (new SpriteIndexedAnimation(sprite, this.getImage(), this.basicColorArray, this.animationBehaviorFactory.getOrCreateInstance()))
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        this.getInstance(0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


