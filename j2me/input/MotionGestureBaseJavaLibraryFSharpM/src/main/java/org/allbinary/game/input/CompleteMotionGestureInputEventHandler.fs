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
type CompleteMotionGestureInputEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : CompleteMotionGestureInputEventHandler
    static member SINGLETON with get() : CompleteMotionGestureInputEventHandler = (CompleteMotionGestureInputEventHandler.jclinit(); CompleteMotionGestureInputEventHandler.jcell_SINGLETON) and set (jvalue: CompleteMotionGestureInputEventHandler) = (CompleteMotionGestureInputEventHandler.jclinit(); CompleteMotionGestureInputEventHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompleteMotionGestureInputEventHandler.jclinitDone then
            CompleteMotionGestureInputEventHandler.jclinitDone <- true
            CompleteMotionGestureInputEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        CompleteMotionGestureInputEventHandler.jcell_SINGLETON <- (new CompleteMotionGestureInputEventHandler())
        ()
    member this.jfields_CompleteMotionGestureInputEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : CompleteMotionGestureInputEventHandler =
        CompleteMotionGestureInputEventHandler.SINGLETON
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_CompleteMotionGestureInputEventHandler()
    
    abstract addListener : completeMotionGestureInputEventListener: CompleteMotionGestureInputEventListener -> unit
    default this.addListener(completeMotionGestureInputEventListener: CompleteMotionGestureInputEventListener) : unit =
        if not (this.list.contains(completeMotionGestureInputEventListener)) then
            ignore (this.list.add(completeMotionGestureInputEventListener))
    
    override this.removeAllListeners() : unit =
        this.list.clear()
        base.removeAllListeners()
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.list.remove(eventListenerInterface))
        base.removeListener(eventListenerInterface)
    
    override this.fireEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable completeMotionGestureInputEventListener : CompleteMotionGestureInputEventListener = (box (this.list.objectArray.[index]) :?> CompleteMotionGestureInputEventListener)
                completeMotionGestureInputEventListener.onCompleteMotionGestureInputEvent((box (eventObject) :?> CompleteMotionGestureInputEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable completeMotionGestureInputEventListenerInterface : CompleteMotionGestureInputEventListenerInterface = (box (eventListenerInterface) :?> CompleteMotionGestureInputEventListenerInterface)
        completeMotionGestureInputEventListenerInterface.onCompleteMotionGestureInputEvent((box (eventObject) :?> CompleteMotionGestureInputEvent))


