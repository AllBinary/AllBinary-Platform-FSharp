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
type VectorExplosionAnimationFactory =
    [<DefaultValue(false)>] val mutable vectorExplosionGenerator : VectorExplosionGenerator
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorExplosionAnimationFactory.jclinitDone then
            VectorExplosionAnimationFactory.jclinitDone <- true
            VectorExplosionAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_VectorExplosionAnimationFactory() : unit =
        this.vectorExplosionGenerator <- VectorExplosionGenerator.getInstance_jstatic()
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        ()
    
    new (basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_VectorExplosionAnimationFactory()
            this.jctor1(basicColor, animationBehaviorFactory)
    member this.jctor1(basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.animationBehaviorFactory <- animationBehaviorFactory
        this.setBasicColorP(basicColor)
        ()
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        let mutable vectorRotationAnimationInterface : VectorAnimationInterface = (box (animationInterface) :?> VectorAnimationInterface)
        let mutable frame : int = vectorRotationAnimationInterface.getFrame()
        let mutable framePoints : int[][] = vectorRotationAnimationInterface.getPoints(frame)
        let mutable points : int[][][] = this.vectorExplosionGenerator.getInstance(framePoints, 6, this.vectorExplosionGenerator.ROTATION)
        (new VectorRotationAnimation(points, this.getBasicColorP(), this.animationBehaviorFactory.getOrCreateInstance()))
    
    member this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    member this.getBasicColorP() : BasicColor =
        this.basicColor
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


