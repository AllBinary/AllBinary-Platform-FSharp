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
type DestroyEventCircularStaticPool =
    [<DefaultValue(false)>] val mutable EVENT_POOL : AllBinaryEventCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : DestroyEventCircularStaticPool
    static member instance with get() : DestroyEventCircularStaticPool = (DestroyEventCircularStaticPool.jclinit(); DestroyEventCircularStaticPool.jcell_instance) and set (jvalue: DestroyEventCircularStaticPool) = (DestroyEventCircularStaticPool.jclinit(); DestroyEventCircularStaticPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyEventCircularStaticPool.jclinitDone then
            DestroyEventCircularStaticPool.jclinitDone <- true
            DestroyEventCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        DestroyEventCircularStaticPool.jcell_instance <- (new DestroyEventCircularStaticPool())
        ()
    member this.jfields_DestroyEventCircularStaticPool() : unit =
        this.EVENT_POOL <- (new AllBinaryEventCircularPool(20))
        ()
    
    static member getInstance() : DestroyEventCircularStaticPool =
        DestroyEventCircularStaticPool.instance
    
    new () as this =
        {  }
        then
            this.jfields_DestroyEventCircularStaticPool()
    
    abstract init : combatGameCanvas: AllBinaryGameCanvas -> unit
    default this.init(combatGameCanvas: AllBinaryGameCanvas) : unit =
        this.EVENT_POOL.initAllBinaryEventCircularPool((new DestroyEventFactory(combatGameCanvas)))
    
    abstract getInstanceForLayer : layerInterface: AllBinaryLayer -> DestroyedEvent
    default this.getInstanceForLayer(layerInterface: AllBinaryLayer) : DestroyedEvent =
        let mutable destroyedEvent : DestroyedEvent = (box (this.EVENT_POOL.getNextInstance()) :?> DestroyedEvent)
        destroyedEvent.setLayerInterfaceForCircularStaticPool(layerInterface)
        destroyedEvent


