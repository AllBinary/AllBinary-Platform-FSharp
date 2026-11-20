namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullEventListener =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_EVENT_LISTENER : NullEventListener
    static member NULL_EVENT_LISTENER with get() : NullEventListener = (NullEventListener.jclinit(); NullEventListener.jcell_NULL_EVENT_LISTENER) and set (jvalue: NullEventListener) = (NullEventListener.jclinit(); NullEventListener.jcell_NULL_EVENT_LISTENER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullEventListener.jclinitDone then
            NullEventListener.jclinitDone <- true
            NullEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        NullEventListener.jcell_NULL_EVENT_LISTENER <- (new NullEventListener())
        ()
    new () =
        {  }
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ()
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


