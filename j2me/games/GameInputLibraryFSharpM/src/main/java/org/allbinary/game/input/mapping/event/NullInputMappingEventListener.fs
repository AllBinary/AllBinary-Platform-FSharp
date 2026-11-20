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
type NullInputMappingEventListener =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_INPUT_MAPPING_EVENT_LISTENER : NullInputMappingEventListener
    static member NULL_INPUT_MAPPING_EVENT_LISTENER with get() : NullInputMappingEventListener = (NullInputMappingEventListener.jclinit(); NullInputMappingEventListener.jcell_NULL_INPUT_MAPPING_EVENT_LISTENER) and set (jvalue: NullInputMappingEventListener) = (NullInputMappingEventListener.jclinit(); NullInputMappingEventListener.jcell_NULL_INPUT_MAPPING_EVENT_LISTENER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullInputMappingEventListener.jclinitDone then
            NullInputMappingEventListener.jclinitDone <- true
            NullInputMappingEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        NullInputMappingEventListener.jcell_NULL_INPUT_MAPPING_EVENT_LISTENER <- (new NullInputMappingEventListener())
        ()
    new () =
        {  }
    
    abstract onInputMappingEvent : inputMappingEvent: InputMappingEvent -> unit
    default this.onInputMappingEvent(inputMappingEvent: InputMappingEvent) : unit =
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ()
    interface InputMappingEventListenerInterface with
        member this.onInputMappingEvent(jp0: InputMappingEvent) : unit = this.onInputMappingEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


