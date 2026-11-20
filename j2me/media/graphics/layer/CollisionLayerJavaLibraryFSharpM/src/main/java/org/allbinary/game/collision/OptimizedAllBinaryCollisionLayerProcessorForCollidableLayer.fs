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
type OptimizedAllBinaryCollisionLayerProcessorForCollidableLayer =
    inherit LayerProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OptimizedAllBinaryCollisionLayerProcessorForCollidableLayer.jclinitDone then
            OptimizedAllBinaryCollisionLayerProcessorForCollidableLayer.jclinitDone <- true
            OptimizedAllBinaryCollisionLayerProcessorForCollidableLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit LayerProcessor((new OptimizedAllBinaryCollisionLayerManager())) }
    
    override this.processAt(allBinaryLayerManager: AllBinaryLayerManager, layerInterface: AllBinaryLayer, startIndex: int) : unit =
        let mutable collidableInterfaceCompositeInterface : CollidableCompositeLayer = (box (layerInterface) :?> CollidableCompositeLayer)
        let mutable collidableBase : CollidableBaseBehavior = collidableInterfaceCompositeInterface.getCollidableInferface()
        if collidableBase.isCollidable(collidableInterfaceCompositeInterface) then
            let mutable layerManager : LayerManager = this.getLayerManager()
            let mutable size : int = layerManager.getSize()
            let mutable collidableInterfaceCompositeInterface2 : CollidableCompositeLayer = null
            let mutable collidableBase2 : CollidableBaseBehavior = null
            let mutable index : int = startIndex + 1
            while index < size do
                collidableInterfaceCompositeInterface2 <- (box (layerManager.getLayerAt(index)) :?> CollidableCompositeLayer)
                collidableBase2 <- collidableInterfaceCompositeInterface2.getCollidableInferface()
                if collidableBase2.isCollidable(collidableInterfaceCompositeInterface) && collidableBase.isCollision(collidableInterfaceCompositeInterface, collidableInterfaceCompositeInterface2) then
                    collidableBase.collide(collidableInterfaceCompositeInterface, collidableInterfaceCompositeInterface2)
                    collidableBase2.collide(collidableInterfaceCompositeInterface2, collidableInterfaceCompositeInterface)
                index <- index + 1
    
    override this.isProcessorLayer(layerInterface: AllBinaryLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if layerInterface.implmentsCollidableInterface() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


