namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CompleteMotionGestureInputEventListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompleteMotionGestureInputEventListener.jclinitDone then
            CompleteMotionGestureInputEventListener.jclinitDone <- true
            CompleteMotionGestureInputEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ()
    
    abstract onCompleteMotionGestureInputEvent : completeMotionGestureInputEvent: CompleteMotionGestureInputEvent -> unit
    default this.onCompleteMotionGestureInputEvent(completeMotionGestureInputEvent: CompleteMotionGestureInputEvent) : unit =
        ()
    interface CompleteMotionGestureInputEventListenerInterface with
        member this.onCompleteMotionGestureInputEvent(jp0: CompleteMotionGestureInputEvent) : unit = this.onCompleteMotionGestureInputEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


