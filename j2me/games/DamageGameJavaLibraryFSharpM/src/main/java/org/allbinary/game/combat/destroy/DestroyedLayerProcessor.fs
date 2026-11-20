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
type DestroyedLayerProcessor =
    inherit BasicLayerProcessor
    [<DefaultValue(false)>] static val mutable private jcell_DESTROYED_LAYER_PROCESSOR : BasicLayerProcessor
    static member DESTROYED_LAYER_PROCESSOR with get() : BasicLayerProcessor = (DestroyedLayerProcessor.jclinit(); DestroyedLayerProcessor.jcell_DESTROYED_LAYER_PROCESSOR) and set (jvalue: BasicLayerProcessor) = (DestroyedLayerProcessor.jclinit(); DestroyedLayerProcessor.jcell_DESTROYED_LAYER_PROCESSOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyedLayerProcessor.jclinitDone then
            DestroyedLayerProcessor.jclinitDone <- true
            DestroyedLayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        DestroyedLayerProcessor.jcell_DESTROYED_LAYER_PROCESSOR <- BasicLayerProcessor.NULL_LAYER_PROCESSOR
        ()
    
    new () =
        { inherit BasicLayerProcessor() }
    
    static member init() : unit =
        DestroyedLayerProcessor.DESTROYED_LAYER_PROCESSOR <- (new DestroyedLayerProcessor())
    
    static member getInstance() : BasicLayerProcessor =
        DestroyedLayerProcessor.DESTROYED_LAYER_PROCESSOR
    
    override this.process_(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable list_ : BasicArrayList = this.getList()
        let mutable size : int = list_.size()
        let mutable destroyedEventHandler : DestroyedEventHandler = DestroyedEventHandler.getInstance()
        let mutable destroyEventCircularStaticPool : DestroyEventCircularStaticPool = DestroyEventCircularStaticPool.getInstance()
        let mutable destroyedEvent : DestroyedEvent = null
        let mutable layerInterface : AllBinaryLayer = null
        let mutable index : int = 0
        while index < size do
            let mutable layerInterfaceCanBeNull : obj = list_.objectArray.[index]
            if not (JR.same(layerInterfaceCanBeNull, null)) then
                layerInterface <- (box (layerInterfaceCanBeNull) :?> AllBinaryLayer)
                ignore (allBinaryLayerManager.remove(layerInterface))
                destroyedEvent <- destroyEventCircularStaticPool.getInstanceForLayer(layerInterface)
                destroyedEventHandler.fireEvent(destroyedEvent)
            else
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                ()
            index <- index + 1
        list_.clear()


