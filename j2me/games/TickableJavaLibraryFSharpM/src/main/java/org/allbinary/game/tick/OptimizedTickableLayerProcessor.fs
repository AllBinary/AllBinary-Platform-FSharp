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
type OptimizedTickableLayerProcessor =
    inherit LayerProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OptimizedTickableLayerProcessor.jclinitDone then
            OptimizedTickableLayerProcessor.jclinitDone <- true
            OptimizedTickableLayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit LayerProcessor((new OptimizedTickableLayerManager())) }
    
    override this.processAt(allBinaryLayerManager: AllBinaryLayerManager, layerInterface: AllBinaryLayer, index: int) : unit =
        let mutable tickableInterface : AllBinaryGameLayer = (box (layerInterface) :?> AllBinaryGameLayer)
        tickableInterface.processTick(allBinaryLayerManager)
    
    override this.isProcessorLayer(layerInterface: AllBinaryLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if layerInterface.implmentsTickableInterface() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


