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
type TerrainEventCircularStaticPool =
    [<DefaultValue(false)>] val mutable EVENT_POOL : AllBinaryEventCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : TerrainEventCircularStaticPool
    static member instance with get() : TerrainEventCircularStaticPool = (TerrainEventCircularStaticPool.jclinit(); TerrainEventCircularStaticPool.jcell_instance) and set (jvalue: TerrainEventCircularStaticPool) = (TerrainEventCircularStaticPool.jclinit(); TerrainEventCircularStaticPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TerrainEventCircularStaticPool.jclinitDone then
            TerrainEventCircularStaticPool.jclinitDone <- true
            TerrainEventCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        TerrainEventCircularStaticPool.jcell_instance <- (new TerrainEventCircularStaticPool())
        ()
    new () as this =
        {  }
        then
            this.jfields_TerrainEventCircularStaticPool()
    member this.jfields_TerrainEventCircularStaticPool() : unit =
        this.EVENT_POOL <- (new AllBinaryEventCircularPool(20))
        ()
    
    static member getInstance() : TerrainEventCircularStaticPool =
        TerrainEventCircularStaticPool.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.EVENT_POOL.initAllBinaryEventCircularPool((new TerrainEventFactory()))
    
    abstract getNext : basicTerrainInfo: BasicTerrainInfo -> TerrainEvent
    default this.getNext(basicTerrainInfo: BasicTerrainInfo) : TerrainEvent =
        let mutable trackingEvent : TerrainEvent = (box (this.EVENT_POOL.getNextInstance()) :?> TerrainEvent)
        trackingEvent.setBasicTerrainInfoForCircularStaticPool(basicTerrainInfo)
        trackingEvent


