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
type AllBinaryLayerManager =
    inherit LayerManager
    [<DefaultValue(false)>] val mutable layerManagerEventHandler : LayerManagerEventHandler
    [<DefaultValue(false)>] val mutable createLayerManagerEvent : LayerManagerEvent
    [<DefaultValue(false)>] val mutable deleteLayerManagerEvent : LayerManagerEvent
    [<DefaultValue(false)>] val mutable basicLayerProcessorArray : LayerProcessor[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryLayerManager.jclinitDone then
            AllBinaryLayerManager.jclinitDone <- true
            AllBinaryLayerManager.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AllBinaryLayerManager() : unit =
        this.layerManagerEventHandler <- LayerManagerEventHandler.getInstance()
        this.createLayerManagerEvent <- (new LayerManagerEvent(this, this.layerManagerEventHandler.CREATE))
        this.deleteLayerManagerEvent <- (new LayerManagerEvent(this, this.layerManagerEventHandler.DELETE))
        this.basicLayerProcessorArray <- (Array.zeroCreate<LayerProcessor> (0))
        ()
    
    new () as this =
        { inherit LayerManager(LayerManagerNoDebug.getInstance()) }
        then
            this.jfields_AllBinaryLayerManager()
    
    abstract getLayerProcessorArray : unit -> LayerProcessor[]
    default this.getLayerProcessorArray() : LayerProcessor[] =
        this.basicLayerProcessorArray
    
    abstract setLayerProcessorArray : layerProcessorArray: LayerProcessor[] -> unit
    default this.setLayerProcessorArray(layerProcessorArray: LayerProcessor[]) : unit =
        this.basicLayerProcessorArray <- layerProcessorArray
    
    member this.log() : unit =
        let mutable size : int = this.basicLayerProcessorArray.Length
        let mutable index : int = 0
        while index < size do
            let mutable layerProcessorInterface : LayerProcessor = this.basicLayerProcessorArray.[index]
            ()
            index <- index + 1
    
    override this.append(layerInterface: AllBinaryLayer) : unit =
        if not (this.contains(layerInterface)) then
            this.appendProcessors(layerInterface)
            base.append(layerInterface)
    
    override this.appendAt(layerInterface: AllBinaryLayer, index: int) : unit =
        if not (this.contains(layerInterface)) then
            this.appendProcessors(layerInterface)
            base.appendAt(layerInterface, index)
    
    member this.appendProcessors(layerInterface: AllBinaryLayer) : unit =
        this.createLayerManagerEvent.setLayerInterface(layerInterface)
        this.layerManagerEventHandler.fireEvent(this.createLayerManagerEvent)
        let mutable layerProcessorInterface : LayerProcessor = null
        let mutable index : int = this.basicLayerProcessorArray.Length
        while ((index <- index - 1; index)) >= 0 do
            layerProcessorInterface <- this.basicLayerProcessorArray.[index]
            if layerProcessorInterface.isProcessorLayer(layerInterface) then
                layerProcessorInterface.getLayerManager().append(layerInterface)
    
    override this.remove(layerInterface: AllBinaryLayer) : unit =
        this.deleteLayerManagerEvent.setLayerInterface(layerInterface)
        this.layerManagerEventHandler.fireDeleteEvent(this.deleteLayerManagerEvent)
        let mutable layerProcessorInterface : LayerProcessor = null
        let mutable index : int = this.basicLayerProcessorArray.Length
        while ((index <- index - 1; index)) >= 0 do
            layerProcessorInterface <- this.basicLayerProcessorArray.[index]
            ignore (layerProcessorInterface.getLayerManager().remove(layerInterface))
        base.remove(layerInterface)
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        let mutable layerProcessorInterface : LayerProcessor = null
        let mutable size : int = this.basicLayerProcessorArray.Length
        let mutable index : int = 0
        while index < size do
            layerProcessorInterface <- this.basicLayerProcessorArray.[index]
            layerProcessorInterface.process_(this)
            index <- index + 1
    
    override this.cleanup() : unit =
        let mutable layerProcessorInterface : LayerProcessor = null
        let mutable size : int = this.basicLayerProcessorArray.Length
        let mutable index : int = 0
        while index < size do
            layerProcessorInterface <- this.basicLayerProcessorArray.[index]
            layerProcessorInterface.getLayerManager().cleanup()
            index <- index + 1
        base.cleanup()


