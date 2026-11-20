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
type NullSpecialAnimationFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_SPECIAL_ANIMATION_FACTORY : NullSpecialAnimationFactory
    static member NULL_SPECIAL_ANIMATION_FACTORY with get() : NullSpecialAnimationFactory = (NullSpecialAnimationFactory.jclinit(); NullSpecialAnimationFactory.jcell_NULL_SPECIAL_ANIMATION_FACTORY) and set (jvalue: NullSpecialAnimationFactory) = (NullSpecialAnimationFactory.jclinit(); NullSpecialAnimationFactory.jcell_NULL_SPECIAL_ANIMATION_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullSpecialAnimationFactory.jclinitDone then
            NullSpecialAnimationFactory.jclinitDone <- true
            NullSpecialAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullSpecialAnimationFactory.jcell_NULL_SPECIAL_ANIMATION_FACTORY <- (new NullSpecialAnimationFactory())
        ()
    
    new () =
        {  }
    
    static member getFactoryInstance() : NullSpecialAnimationFactory =
        NullSpecialAnimationFactory.NULL_SPECIAL_ANIMATION_FACTORY
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        SpecialAnimation.getInstance()
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        SpecialAnimation.getInstance()
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


