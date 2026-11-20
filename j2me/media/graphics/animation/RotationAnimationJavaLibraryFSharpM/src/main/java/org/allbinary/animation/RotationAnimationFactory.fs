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
type RotationAnimationFactory =
    [<DefaultValue(false)>] val mutable totalAngle : int16
    [<DefaultValue(false)>] val mutable angleIncrement : int16
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RotationAnimationFactory.jclinitDone then
            RotationAnimationFactory.jclinitDone <- true
            RotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createFactory() : RotationAnimationFactory =
        let mutable totalAngle : int16 = AngleFactory.getInstance().TOTAL_ANGLE
        (new RotationAnimationFactory(totalAngle, int16 ((int (int (totalAngle)) / GameConfigurationCentral.getInstance().getGameControlFidelity()))))
    
    new (totalAngle: int16, angleIncrement: int16) as this =
        {  }
        then
            this.jctor1(totalAngle, angleIncrement)
    member this.jctor1(totalAngle: int16, angleIncrement: int16) : unit =
        this.totalAngle <- totalAngle
        this.angleIncrement <- angleIncrement
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        NullRotationAnimation.createTotalAngle(AngleInfo.getInstance(this.angleIncrement), this.totalAngle, AnimationBehavior.getInstance())
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        NullRotationAnimation.createTotalAngle(AngleInfo.getInstance(this.angleIncrement), this.totalAngle, AnimationBehavior.getInstance())
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


