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
type IndependentVectorExplosionRotationAnimationFactory =
    [<DefaultValue(false)>] val mutable framePoints : int[][][]
    [<DefaultValue(false)>] val mutable vectorInfo : VectorInfo
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable vectorAnimationFactoryInterface : VectorAnimationFactoryInterface
    [<DefaultValue(false)>] val mutable vectorExplosionGenerator : VectorExplosionGenerator
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IndependentVectorExplosionRotationAnimationFactory.jclinitDone then
            IndependentVectorExplosionRotationAnimationFactory.jclinitDone <- true
            IndependentVectorExplosionRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_IndependentVectorExplosionRotationAnimationFactory() : unit =
        this.framePoints <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY_ARRAY
        this.vectorExplosionGenerator <- VectorExplosionGenerator.getInstance_jstatic()
        ()
    
    new (vectorInfo: VectorInfo, basicColor: BasicColor, vectorAnimationFactoryInterface: VectorAnimationFactoryInterface) as this =
        {  }
        then
            this.jfields_IndependentVectorExplosionRotationAnimationFactory()
            this.jctor1(vectorInfo, basicColor, vectorAnimationFactoryInterface)
    member this.jctor1(vectorInfo: VectorInfo, basicColor: BasicColor, vectorAnimationFactoryInterface: VectorAnimationFactoryInterface) : unit =
        this.vectorInfo <- vectorInfo
        this.basicColor <- basicColor
        this.vectorAnimationFactoryInterface <- vectorAnimationFactoryInterface
        this.init()
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.framePoints <- VectorRotationGenerator.getInstance_jstatic().getInstance(this.vectorInfo)
    
    abstract getInstanceAnimation : animationInterface: Animation -> Animation
    default this.getInstanceAnimation(animationInterface: Animation) : Animation =
        let mutable frame : int = 0
        if not (JR.same(animationInterface, null)) then
            let mutable rotationAnimationInterface : IndexedAnimation = (box (animationInterface) :?> IndexedAnimation)
            frame <- rotationAnimationInterface.getFrame()
        let mutable points : int[][][] = this.vectorExplosionGenerator.getInstance(this.framePoints.[frame], 6, this.vectorExplosionGenerator.ROTATION)
        this.vectorAnimationFactoryInterface.getInstance(points, this.basicColor)
    interface ProceduralAnimationInterfaceFactoryInterface with
        member this.getInstanceAnimation(jp0: Animation) : Animation = this.getInstanceAnimation(jp0)
    interface BasicAnimationInterfaceFactoryInterface


