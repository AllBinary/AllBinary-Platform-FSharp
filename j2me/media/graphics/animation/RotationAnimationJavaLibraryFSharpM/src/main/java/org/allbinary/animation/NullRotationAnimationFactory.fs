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
type NullRotationAnimationFactory =
    [<DefaultValue(false)>] val mutable NULL_ROTATION_ANIMATION_ARRAY : RotationAnimation[]
    [<DefaultValue(false)>] val mutable NULL_ANIMATION : Animation
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ROTATION_ANIMATION_FACTORY : NullRotationAnimationFactory
    static member NULL_ROTATION_ANIMATION_FACTORY with get() : NullRotationAnimationFactory = (NullRotationAnimationFactory.jclinit(); NullRotationAnimationFactory.jcell_NULL_ROTATION_ANIMATION_FACTORY) and set (jvalue: NullRotationAnimationFactory) = (NullRotationAnimationFactory.jclinit(); NullRotationAnimationFactory.jcell_NULL_ROTATION_ANIMATION_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRotationAnimationFactory.jclinitDone then
            NullRotationAnimationFactory.jclinitDone <- true
            NullRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullRotationAnimationFactory.jcell_NULL_ROTATION_ANIMATION_FACTORY <- (new NullRotationAnimationFactory())
        ()
    member this.jfields_NullRotationAnimationFactory() : unit =
        this.NULL_ROTATION_ANIMATION_ARRAY <- (Array.zeroCreate<RotationAnimation> (0))
        this.NULL_ANIMATION <- (new NullRotationAnimation2())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_NullRotationAnimationFactory()
    
    static member getFactoryInstance() : NullRotationAnimationFactory =
        NullRotationAnimationFactory.NULL_ROTATION_ANIMATION_FACTORY
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        this.NULL_ANIMATION
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        this.NULL_ANIMATION
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


