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
type NullIndexedAnimationFactory =
    [<DefaultValue(false)>] val mutable NULL_ANIMATION : Animation
    [<DefaultValue(false)>] static val mutable private jcell_NULL_INDEXED_ANIMATION_ARRAY : IndexedAnimation[]
    static member NULL_INDEXED_ANIMATION_ARRAY with get() : IndexedAnimation[] = (NullIndexedAnimationFactory.jclinit(); NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_ARRAY) and set (jvalue: IndexedAnimation[]) = (NullIndexedAnimationFactory.jclinit(); NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_ARRAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_NULL_INDEXED_ANIMATION_FACTORY : NullIndexedAnimationFactory
    static member NULL_INDEXED_ANIMATION_FACTORY with get() : NullIndexedAnimationFactory = (NullIndexedAnimationFactory.jclinit(); NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_FACTORY) and set (jvalue: NullIndexedAnimationFactory) = (NullIndexedAnimationFactory.jclinit(); NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullIndexedAnimationFactory.jclinitDone then
            NullIndexedAnimationFactory.jclinitDone <- true
            NullIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_ARRAY <- (Array.zeroCreate<IndexedAnimation> (0))
        NullIndexedAnimationFactory.jcell_NULL_INDEXED_ANIMATION_FACTORY <- (new NullIndexedAnimationFactory())
        ()
    member this.jfields_NullIndexedAnimationFactory() : unit =
        this.NULL_ANIMATION <- (new NullIndexedAnimationInner())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_NullIndexedAnimationFactory()
    
    static member getFactoryInstance() : NullIndexedAnimationFactory =
        NullIndexedAnimationFactory.NULL_INDEXED_ANIMATION_FACTORY
    
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


