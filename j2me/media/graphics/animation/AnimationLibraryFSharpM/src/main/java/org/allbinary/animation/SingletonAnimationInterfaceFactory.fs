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
type SingletonAnimationInterfaceFactory =
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SingletonAnimationInterfaceFactory.jclinitDone then
            SingletonAnimationInterfaceFactory.jclinitDone <- true
            SingletonAnimationInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterface: Animation) as this =
        {  }
        then
            this.jctor1(animationInterface)
    member this.jctor1(animationInterface: Animation) : unit =
        this.animationInterface <- animationInterface
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        this.animationInterface
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        this.animationInterface
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


