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
type OptimizedArtificialIntelligenceLayerProcessorForCollidableLayer =
    inherit LayerProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OptimizedArtificialIntelligenceLayerProcessorForCollidableLayer.jclinitDone then
            OptimizedArtificialIntelligenceLayerProcessorForCollidableLayer.jclinitDone <- true
            OptimizedArtificialIntelligenceLayerProcessorForCollidableLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit LayerProcessor((new OptimizedArtificialIntelligenceLayerManager())) }
    
    override this.processAt(allBinaryLayerManager: AllBinaryLayerManager, layerInterface: AllBinaryLayer, index: int) : unit =
        let mutable artificialIntelligenceCompositeInterface : CollidableCompositeLayer = (box (layerInterface) :?> CollidableCompositeLayer)
        artificialIntelligenceCompositeInterface.getArtificialIntelligenceInterface().processAI(allBinaryLayerManager)
    
    override this.isProcessorLayer(layerInterface: AllBinaryLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if layerInterface.implmentsArtificialIntelligenceCompositeInterface() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


