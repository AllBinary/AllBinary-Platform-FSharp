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
type SimultaneousCompoundIndexedAnimationInterfaceFactory =
    inherit CompoundAnimationInterfaceFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimultaneousCompoundIndexedAnimationInterfaceFactory.jclinitDone then
            SimultaneousCompoundIndexedAnimationInterfaceFactory.jclinitDone <- true
            SimultaneousCompoundIndexedAnimationInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicAnimationInterfaceFactoryInterfaceArray: AnimationInterfaceFactoryInterface[], animationBehaviorFactory: AnimationBehaviorFactory) =
        { inherit CompoundAnimationInterfaceFactory(basicAnimationInterfaceFactoryInterfaceArray, animationBehaviorFactory) }
    
    override this.createArray(size: int) : Animation[] =
        (Array.zeroCreate<Animation> (size))
    
    override this.createAnimation(animationArray: Animation[]) : Animation =
        (new SimultaneousCompoundIndexedAnimation(animationArray, this.animationBehaviorFactory.getOrCreateInstance()))


