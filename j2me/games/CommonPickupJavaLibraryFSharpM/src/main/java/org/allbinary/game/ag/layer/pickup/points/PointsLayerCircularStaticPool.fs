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
type PointsLayerCircularStaticPool =
    inherit AllBinaryLayerCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PointsLayerCircularStaticPool.jclinitDone then
            PointsLayerCircularStaticPool.jclinitDone <- true
            PointsLayerCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (allbinaryLayerFactoryInterface: AllBinaryLayerFactoryInterface, total: int) as this =
        { inherit AllBinaryLayerCircularPool() }
        then
            this.jctor1(allbinaryLayerFactoryInterface, total)
    member this.jctor1(allbinaryLayerFactoryInterface: AllBinaryLayerFactoryInterface, total: int) : unit =
        base.initAllBinaryLayerCircularPool(allbinaryLayerFactoryInterface, total)
        ()
    
    abstract visit : sourceLayerInterface: AllBinaryLayer -> unit
    default this.visit(sourceLayerInterface: AllBinaryLayer) : unit =
        let mutable pointsLayer : PointsLayer = (box (this.getNextInstance()) :?> PointsLayer)
        let mutable scoreableInterface : ScoreableInterface = (box (sourceLayerInterface) :?> ScoreableInterface)
        pointsLayer.visit(scoreableInterface)


