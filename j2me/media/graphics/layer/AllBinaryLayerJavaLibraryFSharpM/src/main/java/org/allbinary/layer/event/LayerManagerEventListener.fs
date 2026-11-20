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
type LayerManagerEventListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManagerEventListener.jclinitDone then
            LayerManagerEventListener.jclinitDone <- true
            LayerManagerEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ()
    
    abstract onCreateLayerManagerEvent : layerManagerEvent: LayerManagerEvent -> unit
    default this.onCreateLayerManagerEvent(layerManagerEvent: LayerManagerEvent) : unit =
        ()
    
    abstract onDeleteLayerManagerEvent : layerManagerEvent: LayerManagerEvent -> unit
    default this.onDeleteLayerManagerEvent(layerManagerEvent: LayerManagerEvent) : unit =
        ()
    interface LayerManagerEventListenerInterface with
        member this.onCreateLayerManagerEvent(jp0: LayerManagerEvent) : unit = this.onCreateLayerManagerEvent(jp0)
        member this.onDeleteLayerManagerEvent(jp0: LayerManagerEvent) : unit = this.onDeleteLayerManagerEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


