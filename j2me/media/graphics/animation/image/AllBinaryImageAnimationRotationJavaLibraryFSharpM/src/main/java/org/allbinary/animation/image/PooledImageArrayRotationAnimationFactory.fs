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
type PooledImageArrayRotationAnimationFactory =
    [<DefaultValue(false)>] val mutable allBinaryImageRotationAnimationInfo : obj
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PooledImageArrayRotationAnimationFactory.jclinitDone then
            PooledImageArrayRotationAnimationFactory.jclinitDone <- true
            PooledImageArrayRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PooledImageArrayRotationAnimationFactory() : unit =
        this.allBinaryImageRotationAnimationInfo <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member createFactory(image: Image, animationBehaviorFactory: AnimationBehaviorFactory) : PooledImageArrayRotationAnimationFactory =
        let mutable totalAngle : int = int (AngleFactory.getInstance().TOTAL_ANGLE)
        let mutable angleIncrement : int = (totalAngle / GameConfigurationCentral.getInstance().getGameControlFidelity())
        (new PooledImageArrayRotationAnimationFactory(image, image.getWidth(), image.getHeight(), -((image.getWidth() >>> 2)), -((image.getHeight() >>> 2)), angleIncrement, animationBehaviorFactory))
    
    static member createDXY(image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : PooledImageArrayRotationAnimationFactory =
        let mutable totalAngle : int = int (AngleFactory.getInstance().TOTAL_ANGLE)
        let mutable angleIncrement : int = (totalAngle / GameConfigurationCentral.getInstance().getGameControlFidelity())
        (new PooledImageArrayRotationAnimationFactory(image, image.getWidth(), image.getHeight(), dx, dy, angleIncrement, animationBehaviorFactory))
    
    new (image: Image, width: int, height: int, dx: int, dy: int, angleIncrement: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_PooledImageArrayRotationAnimationFactory()
            this.jctor1(image, width, height, dx, dy, angleIncrement, animationBehaviorFactory)
    member this.jctor1(image: Image, width: int, height: int, dx: int, dy: int, angleIncrement: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.animationBehaviorFactory <- animationBehaviorFactory
        let mutable totalAngle : int = int (AngleFactory.getInstance().TOTAL_ANGLE)
        let mutable imageArray : Image[] = ImageToRotationImageArrayUtil.getInstance().generate(image, angleIncrement, totalAngle)
        this.allBinaryImageRotationAnimationInfo <- (new ImageArrayRotationAnimationInfo(imageArray, angleIncrement, totalAngle, dx, dy))
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        AdjustedImageArrayRotationAnimation.createAdjustedImageArrayRotationAnimationInfo(this.allBinaryImageRotationAnimationInfo, this.animationBehaviorFactory.getOrCreateInstance())
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


