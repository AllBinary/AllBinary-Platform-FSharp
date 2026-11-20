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
type LayerManagerEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable CREATE : string
    [<DefaultValue(false)>] val mutable DELETE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : LayerManagerEventHandler
    static member instance with get() : LayerManagerEventHandler = (LayerManagerEventHandler.jclinit(); LayerManagerEventHandler.jcell_instance) and set (jvalue: LayerManagerEventHandler) = (LayerManagerEventHandler.jclinit(); LayerManagerEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManagerEventHandler.jclinitDone then
            LayerManagerEventHandler.jclinitDone <- true
            LayerManagerEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        LayerManagerEventHandler.jcell_instance <- (new LayerManagerEventHandler())
        ()
    member this.jfields_LayerManagerEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        this.CREATE <- "Create"
        this.DELETE <- "Delete"
        ()
    
    static member getInstance() : LayerManagerEventHandler =
        LayerManagerEventHandler.instance
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_LayerManagerEventHandler()
    
    abstract addListener : layerManagerEventListener: LayerManagerEventListener -> unit
    default this.addListener(layerManagerEventListener: LayerManagerEventListener) : unit =
        if not (this.list.contains(layerManagerEventListener)) then
            ignore (this.list.add(layerManagerEventListener))
    
    override this.removeAllListeners() : unit =
        this.list.clear()
        base.removeAllListeners()
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.list.remove(eventListenerInterface))
        base.removeListener(eventListenerInterface)
    
    override this.fireEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable layerManagerEventListener : LayerManagerEventListener = (box (this.list.objectArray.[index]) :?> LayerManagerEventListener)
                layerManagerEventListener.onCreateLayerManagerEvent((box (eventObject) :?> LayerManagerEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    abstract fireDeleteEvent : eventObject: AllBinaryEventObject -> unit
    default this.fireDeleteEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable layerManagerEventListener : LayerManagerEventListener = (box (this.list.objectArray.[index]) :?> LayerManagerEventListener)
                layerManagerEventListener.onDeleteLayerManagerEvent((box (eventObject) :?> LayerManagerEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        let mutable eventListenerInterfaceList : BasicArrayList = this.eventListenerInterfaceList
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable layerManagerEventListenerInterface : LayerManagerEventListenerInterface = null
        let mutable listenerIndex : int = 0
        while listenerIndex < eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (eventListenerInterfaceList.objectArray.[listenerIndex]) :?> EventListenerInterface)
                layerManagerEventListenerInterface <- ((box (eventListenerInterface) :?> LayerManagerEventListenerInterface))
                layerManagerEventListenerInterface.onDeleteLayerManagerEvent((box (eventObject) :?> LayerManagerEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
            listenerIndex <- listenerIndex + 1
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable layerManagerEventListenerInterface : LayerManagerEventListenerInterface = ((box (eventListenerInterface) :?> LayerManagerEventListenerInterface))
        layerManagerEventListenerInterface.onCreateLayerManagerEvent((box (eventObject) :?> LayerManagerEvent))


