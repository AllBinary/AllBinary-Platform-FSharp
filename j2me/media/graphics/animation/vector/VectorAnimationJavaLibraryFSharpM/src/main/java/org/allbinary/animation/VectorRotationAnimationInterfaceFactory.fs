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
type VectorRotationAnimationInterfaceFactory =
    [<DefaultValue(false)>] val mutable currentPoints : int[][][]
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorRotationAnimationInterfaceFactory.jclinitDone then
            VectorRotationAnimationInterfaceFactory.jclinitDone <- true
            VectorRotationAnimationInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_VectorRotationAnimationInterfaceFactory() : unit =
        this.currentPoints <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY_ARRAY
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        ()
    
    new (currentPoints: int[][][], basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_VectorRotationAnimationInterfaceFactory()
            this.jctor1(currentPoints, basicColor, animationBehaviorFactory)
    member this.jctor1(currentPoints: int[][][], basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.currentPoints <- currentPoints
        this.setBasicColorP(basicColor)
        this.animationBehaviorFactory <- animationBehaviorFactory
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        (new VectorRotationAnimation(this.currentPoints, this.getBasicColorP(), this.animationBehaviorFactory.getOrCreateInstance()))
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


