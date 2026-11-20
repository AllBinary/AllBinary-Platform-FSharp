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
type DropLayerProcessor =
    inherit BasicLayerProcessor
    [<DefaultValue(false)>] static val mutable private jcell_LAYER_PROCESSOR : BasicLayerProcessor
    static member LAYER_PROCESSOR with get() : BasicLayerProcessor = (DropLayerProcessor.jclinit(); DropLayerProcessor.jcell_LAYER_PROCESSOR) and set (jvalue: BasicLayerProcessor) = (DropLayerProcessor.jclinit(); DropLayerProcessor.jcell_LAYER_PROCESSOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DropLayerProcessor.jclinitDone then
            DropLayerProcessor.jclinitDone <- true
            DropLayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        DropLayerProcessor.jcell_LAYER_PROCESSOR <- (new DropLayerProcessor())
        ()
    
    new () =
        { inherit BasicLayerProcessor() }
    
    static member getInstance() : BasicLayerProcessor =
        DropLayerProcessor.LAYER_PROCESSOR
    
    override this.process_(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable list_ : BasicArrayList = this.getList()
        let mutable size : int = list_.size()
        let mutable layerInterface : AllBinaryLayer = null
        let mutable dropLayerInterface : DropLayerInterface = null
        let mutable index : int = 0
        while index < size do
            layerInterface <- (box (list_.objectArray.[index]) :?> AllBinaryLayer)
            dropLayerInterface <- (box (layerInterface) :?> DropLayerInterface)
            layerInterface <- (box (dropLayerInterface.getDroppedLayer()) :?> AllBinaryLayer)
            allBinaryLayerManager.append(layerInterface)
            index <- index + 1
        list_.clear()


