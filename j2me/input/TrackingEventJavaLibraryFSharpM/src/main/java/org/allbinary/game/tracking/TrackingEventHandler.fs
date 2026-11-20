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
type TrackingEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_instance : TrackingEventHandler
    static member instance with get() : TrackingEventHandler = (TrackingEventHandler.jclinit(); TrackingEventHandler.jcell_instance) and set (jvalue: TrackingEventHandler) = (TrackingEventHandler.jclinit(); TrackingEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrackingEventHandler.jclinitDone then
            TrackingEventHandler.jclinitDone <- true
            TrackingEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        TrackingEventHandler.jcell_instance <- (new TrackingEventHandler())
        ()
    
    static member getInstance() : TrackingEventHandler =
        TrackingEventHandler.instance
    
    new () =
        { inherit BasicEventHandler() }
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable trackingEventListenerInterface : TrackingEventListenerInterface = (box (eventListenerInterface) :?> TrackingEventListenerInterface)
        trackingEventListenerInterface.onMovement((box (eventObject) :?> TrackingEvent))


