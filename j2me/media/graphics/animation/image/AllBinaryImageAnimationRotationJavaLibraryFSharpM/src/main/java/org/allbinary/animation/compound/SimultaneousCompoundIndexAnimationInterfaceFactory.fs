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
type SimultaneousCompoundIndexAnimationInterfaceFactory =
    [<DefaultValue(false)>] val mutable basicAnimationInterfaceFactoryInterfaceArray : AnimationInterfaceFactoryInterface[]
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimultaneousCompoundIndexAnimationInterfaceFactory.jclinitDone then
            SimultaneousCompoundIndexAnimationInterfaceFactory.jclinitDone <- true
            SimultaneousCompoundIndexAnimationInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicAnimationInterfaceFactoryInterfaceArray: AnimationInterfaceFactoryInterface[], animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jctor1(basicAnimationInterfaceFactoryInterfaceArray, animationBehaviorFactory)
    member this.jctor1(basicAnimationInterfaceFactoryInterfaceArray: AnimationInterfaceFactoryInterface[], animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.basicAnimationInterfaceFactoryInterfaceArray <- basicAnimationInterfaceFactoryInterfaceArray
        this.animationBehaviorFactory <- animationBehaviorFactory
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        let mutable size : int = this.basicAnimationInterfaceFactoryInterfaceArray.Length
        let mutable animationInterfaceArray : IndexedAnimation[] = (Array.zeroCreate<IndexedAnimation> (size))
        let mutable index : int = 0
        while index < size do
            animationInterfaceArray.[index] <- (box (this.basicAnimationInterfaceFactoryInterfaceArray.[index].getInstance(instanceId)) :?> IndexedAnimation)
            index <- index + 1
        this.getOrCreate(animationInterfaceArray)
    
    abstract getOrCreate : animationInterfaceArray: IndexedAnimation[] -> Animation
    default this.getOrCreate(animationInterfaceArray: IndexedAnimation[]) : Animation =
        (new SimultaneousCompoundIndexAnimation(animationInterfaceArray, this.animationBehaviorFactory.getOrCreateInstance()))
    
    abstract getBasicAnimationInterfaceFactoryInterfaceArray : unit -> AnimationInterfaceFactoryInterface[]
    default this.getBasicAnimationInterfaceFactoryInterfaceArray() : AnimationInterfaceFactoryInterface[] =
        this.basicAnimationInterfaceFactoryInterfaceArray
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


