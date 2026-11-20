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
type LayerProcessor =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable layerManager : LayerManager
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerProcessor.jclinitDone then
            LayerProcessor.jclinitDone <- true
            LayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LayerProcessor() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (layerManager: LayerManager) as this =
        {  }
        then
            this.jfields_LayerProcessor()
            this.jctor1(layerManager)
    member this.jctor1(layerManager: LayerManager) : unit =
        this.layerManager <- layerManager
        ()
    
    abstract processAt : allBinaryLayerManager: AllBinaryLayerManager * layerInterface: AllBinaryLayer * index: int -> unit
    default this.processAt(allBinaryLayerManager: AllBinaryLayerManager, layerInterface: AllBinaryLayer, index: int) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract isProcessorLayer : layerInterface: AllBinaryLayer -> bool
    default this.isProcessorLayer(layerInterface: AllBinaryLayer) : bool =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract getLayerManager : unit -> LayerManager
    default this.getLayerManager() : LayerManager =
        this.layerManager
    
    abstract process_ : allBinaryLayerManager: AllBinaryLayerManager -> unit
    default this.process_(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable layerManager : LayerManager = this.getLayerManager()
        let mutable size : int = layerManager.getSize()
        let mutable index : int = 0
        while index < size do
            this.processAt(allBinaryLayerManager, (box (layerManager.getLayerAt(index)) :?> AllBinaryLayer), index)
            index <- index + 1
    interface LayerProcessorInterface with
        member this.getLayerManager() : LayerManager = this.getLayerManager()
        member this.processAt(jp0: AllBinaryLayerManager, jp1: AllBinaryLayer, jp2: int) : unit = this.processAt(jp0, jp1, jp2)
        member this.isProcessorLayer(jp0: AllBinaryLayer) : bool = this.isProcessorLayer(jp0)
    interface BasicLayerProcessorInterface with
        member this.process_(jp0: AllBinaryLayerManager) : unit = this.process_(jp0)


