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
type CompoundRotationAnimationInterfaceFactory =
    inherit CompoundAnimationInterfaceFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompoundRotationAnimationInterfaceFactory.jclinitDone then
            CompoundRotationAnimationInterfaceFactory.jclinitDone <- true
            CompoundRotationAnimationInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicAnimationInterfaceFactoryInterfaceArray: AnimationInterfaceFactoryInterface[], animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit CompoundAnimationInterfaceFactory(basicAnimationInterfaceFactoryInterfaceArray, animationBehaviorFactory) }
        then
            this.jctor1(basicAnimationInterfaceFactoryInterfaceArray, animationBehaviorFactory)
    member this.jctor1(basicAnimationInterfaceFactoryInterfaceArray: AnimationInterfaceFactoryInterface[], animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        if (JR.same(animationBehaviorFactory, AnimationBehaviorFactory.getInstance())) then
            ForcedLogUtil.log("Using default AnimationBehaviorFactory with IndexedAnimationFactory", this)
        ()
    
    override this.createArray(size: int) : Animation[] =
        (box ((Array.zeroCreate<RotationAnimation> (size))) :?> Animation[])
    
    override this.createAnimation(animationInterfaceArray: Animation[]) : Animation =
        (new CompoundRotationAnimation((box (animationInterfaceArray) :?> RotationAnimation[]), this.animationBehaviorFactory.getOrCreateInstance()))


