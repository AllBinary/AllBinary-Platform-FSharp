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
type TrackingEventCircularStaticPool =
    [<DefaultValue(false)>] val mutable EVENT_POOL : AllBinaryEventCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : TrackingEventCircularStaticPool
    static member instance with get() : TrackingEventCircularStaticPool = (TrackingEventCircularStaticPool.jclinit(); TrackingEventCircularStaticPool.jcell_instance) and set (jvalue: TrackingEventCircularStaticPool) = (TrackingEventCircularStaticPool.jclinit(); TrackingEventCircularStaticPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrackingEventCircularStaticPool.jclinitDone then
            TrackingEventCircularStaticPool.jclinitDone <- true
            TrackingEventCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        TrackingEventCircularStaticPool.jcell_instance <- (new TrackingEventCircularStaticPool())
        ()
    new () as this =
        {  }
        then
            this.jfields_TrackingEventCircularStaticPool()
    member this.jfields_TrackingEventCircularStaticPool() : unit =
        this.EVENT_POOL <- (new AllBinaryEventCircularPool(20))
        ()
    
    static member getInstance() : TrackingEventCircularStaticPool =
        TrackingEventCircularStaticPool.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.EVENT_POOL.initAllBinaryEventCircularPool((new TrackingEventFactory()))
    
    abstract getNextInstance : layerInterface: AllBinaryLayer -> TrackingEvent
    default this.getNextInstance(layerInterface: AllBinaryLayer) : TrackingEvent =
        let mutable trackingEvent : TrackingEvent = (box (this.EVENT_POOL.getNextInstance()) :?> TrackingEvent)
        trackingEvent.setLayerInterfaceForCircularStaticPool(layerInterface)
        trackingEvent


