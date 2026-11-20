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
type MotionInputMappingEventListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionInputMappingEventListener.jclinitDone then
            MotionInputMappingEventListener.jclinitDone <- true
            MotionInputMappingEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onInputMappingEvent : inputMappingEvent: InputMappingEvent -> unit
    default this.onInputMappingEvent(inputMappingEvent: InputMappingEvent) : unit =
        GameKeyCompleteMotionGestureInputEventFactory.getInstance().updateAll()
        BasicTouchInputFactory.getInstance().updateAll(inputMappingEvent.getInputToGameKeyMapping())
    interface InputMappingEventListenerInterface with
        member this.onInputMappingEvent(jp0: InputMappingEvent) : unit = this.onInputMappingEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


