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
type NoCompleteMotionGestureInputEventListener =
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoCompleteMotionGestureInputEventListener
    static member instance with get() : NoCompleteMotionGestureInputEventListener = (NoCompleteMotionGestureInputEventListener.jclinit(); NoCompleteMotionGestureInputEventListener.jcell_instance) and set (jvalue: NoCompleteMotionGestureInputEventListener) = (NoCompleteMotionGestureInputEventListener.jclinit(); NoCompleteMotionGestureInputEventListener.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoCompleteMotionGestureInputEventListener.jclinitDone then
            NoCompleteMotionGestureInputEventListener.jclinitDone <- true
            NoCompleteMotionGestureInputEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        NoCompleteMotionGestureInputEventListener.jcell_instance <- (new NoCompleteMotionGestureInputEventListener())
        ()
    
    new () =
        {  }
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onCompleteMotionGestureInputEvent : completeMotionGestureInputEvent: CompleteMotionGestureInputEvent -> unit
    default this.onCompleteMotionGestureInputEvent(completeMotionGestureInputEvent: CompleteMotionGestureInputEvent) : unit =
        ()
    
    static member getInstance() : NoCompleteMotionGestureInputEventListener =
        NoCompleteMotionGestureInputEventListener.instance
    interface CompleteMotionGestureInputEventListenerInterface with
        member this.onCompleteMotionGestureInputEvent(jp0: CompleteMotionGestureInputEvent) : unit = this.onCompleteMotionGestureInputEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


