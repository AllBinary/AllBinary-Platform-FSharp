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
type MovedMotionGesturesHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : MovedMotionGesturesHandler
    static member SINGLETON with get() : MovedMotionGesturesHandler = (MovedMotionGesturesHandler.jclinit(); MovedMotionGesturesHandler.jcell_SINGLETON) and set (jvalue: MovedMotionGesturesHandler) = (MovedMotionGesturesHandler.jclinit(); MovedMotionGesturesHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MovedMotionGesturesHandler.jclinitDone then
            MovedMotionGesturesHandler.jclinitDone <- true
            MovedMotionGesturesHandler.jclinitBody()
    static member private jclinitBody() : unit =
        MovedMotionGesturesHandler.jcell_SINGLETON <- (new MovedMotionGesturesHandler())
        ()
    
    static member getInstance() : MovedMotionGesturesHandler =
        MovedMotionGesturesHandler.SINGLETON
    
    new () =
        { inherit BasicEventHandler() }
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable baseMotionGestureEventListener : BaseMotionGestureEventListener = (box (eventListenerInterface) :?> BaseMotionGestureEventListener)
        baseMotionGestureEventListener.onMotionGestureEvent((box (eventObject) :?> MotionGestureEvent))


