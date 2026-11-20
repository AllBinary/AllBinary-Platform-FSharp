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
type TerrainEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_hashtable : ABHashtable
    static member hashtable with get() : ABHashtable = (TerrainEventHandler.jclinit(); TerrainEventHandler.jcell_hashtable) and set (jvalue: ABHashtable) = (TerrainEventHandler.jclinit(); TerrainEventHandler.jcell_hashtable <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TerrainEventHandler.jclinitDone then
            TerrainEventHandler.jclinitDone <- true
            TerrainEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        TerrainEventHandler.jcell_hashtable <- StdUtil.getInstance().NULL_TABLE
        ()
    member this.jfields_TerrainEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member init() : unit =
        TerrainEventHandler.hashtable <- StdUtil.getInstance().createHashtable()
    
    static member getInstance(anyType: obj) : TerrainEventHandler =
        let mutable eventHandlerCanBeNull : obj = TerrainEventHandler.hashtable.get(anyType)
        if (JR.same(eventHandlerCanBeNull, null)) then
            eventHandlerCanBeNull <- (new TerrainEventHandler())
            ignore (TerrainEventHandler.hashtable.put(anyType, eventHandlerCanBeNull))
        (box (eventHandlerCanBeNull) :?> TerrainEventHandler)
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_TerrainEventHandler()
    
    abstract addListener : terrainEventListener: TerrainEventListener -> unit
    default this.addListener(terrainEventListener: TerrainEventListener) : unit =
        if not (this.list.contains(terrainEventListener)) then
            ignore (this.list.add(terrainEventListener))
    
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
                let mutable terrainEventListener : TerrainEventListener = (box (this.list.get(index)) :?> TerrainEventListener)
                terrainEventListener.onTerrainEvent((box (eventObject) :?> TerrainEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable terrainEventListenerInterface : TerrainEventListenerInterface = (box (eventListenerInterface) :?> TerrainEventListenerInterface)
        terrainEventListenerInterface.onTerrainEvent((box (eventObject) :?> TerrainEvent))


