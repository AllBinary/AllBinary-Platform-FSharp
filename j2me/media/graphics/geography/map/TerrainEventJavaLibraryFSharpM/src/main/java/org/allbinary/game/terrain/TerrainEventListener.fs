namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type TerrainEventListener =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TerrainEventListener.jclinitDone then
            TerrainEventListener.jclinitDone <- true
            TerrainEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_TerrainEventListener()
    member this.jfields_TerrainEventListener() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onTerrainEvent : terrainEvent: TerrainEvent -> unit
    default this.onTerrainEvent(terrainEvent: TerrainEvent) : unit =
        this.list.clear()
        ignore (this.list.add(terrainEvent))
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list
    interface TerrainEventListenerInterface with
        member this.onTerrainEvent(jp0: TerrainEvent) : unit = this.onTerrainEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


