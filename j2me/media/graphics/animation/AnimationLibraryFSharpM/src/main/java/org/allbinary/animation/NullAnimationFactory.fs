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
type NullAnimationFactory =
    [<DefaultValue(false)>] val mutable NULL_ANIMATION : Animation
    [<DefaultValue(false)>] val mutable EMPTY_ARRAY : Animation[]
    [<DefaultValue(false)>] static val mutable private jcell_NULL_NOT_FOR_USE_ANIMATION_FACTORY : NullAnimationFactory
    static member NULL_NOT_FOR_USE_ANIMATION_FACTORY with get() : NullAnimationFactory = (NullAnimationFactory.jclinit(); NullAnimationFactory.jcell_NULL_NOT_FOR_USE_ANIMATION_FACTORY) and set (jvalue: NullAnimationFactory) = (NullAnimationFactory.jclinit(); NullAnimationFactory.jcell_NULL_NOT_FOR_USE_ANIMATION_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ANIMATION_FACTORY : NullAnimationFactory
    static member NULL_ANIMATION_FACTORY with get() : NullAnimationFactory = (NullAnimationFactory.jclinit(); NullAnimationFactory.jcell_NULL_ANIMATION_FACTORY) and set (jvalue: NullAnimationFactory) = (NullAnimationFactory.jclinit(); NullAnimationFactory.jcell_NULL_ANIMATION_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullAnimationFactory.jclinitDone then
            NullAnimationFactory.jclinitDone <- true
            NullAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullAnimationFactory.jcell_NULL_NOT_FOR_USE_ANIMATION_FACTORY <- (new NullAnimationFactory())
        NullAnimationFactory.jcell_NULL_ANIMATION_FACTORY <- (new NullAnimationFactory())
        ()
    member this.jfields_NullAnimationFactory() : unit =
        this.NULL_ANIMATION <- (new NullAnimationFactory_jAnon1(this))
        this.EMPTY_ARRAY <- (Array.zeroCreate<Animation> (0))
        ()
    
    new () as this =
        {  }
        then
            this.jfields_NullAnimationFactory()
    
    static member getFactoryInstance() : NullAnimationFactory =
        NullAnimationFactory.NULL_ANIMATION_FACTORY
    
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


[<AllowNullLiteral>]
type NullAnimationFactory_jAnon1 =
    inherit Animation
    [<DefaultValue(false)>] val mutable jouter : NullAnimationFactory
    new (jouter: NullAnimationFactory) as this =
        { inherit Animation() }
        then
            this.jouter <- jouter
            ()
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()


