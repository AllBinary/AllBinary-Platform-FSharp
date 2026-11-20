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
type BasicMotionGesturesHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : BasicMotionGesturesHandler
    static member SINGLETON with get() : BasicMotionGesturesHandler = (BasicMotionGesturesHandler.jclinit(); BasicMotionGesturesHandler.jcell_SINGLETON) and set (jvalue: BasicMotionGesturesHandler) = (BasicMotionGesturesHandler.jclinit(); BasicMotionGesturesHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicMotionGesturesHandler.jclinitDone then
            BasicMotionGesturesHandler.jclinitDone <- true
            BasicMotionGesturesHandler.jclinitBody()
    static member private jclinitBody() : unit =
        BasicMotionGesturesHandler.jcell_SINGLETON <- (new BasicMotionGesturesHandler())
        ()
    
    static member getInstance() : BasicMotionGesturesHandler =
        BasicMotionGesturesHandler.SINGLETON
    
    new () =
        { inherit BasicEventHandler() }
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable baseMotionGestureEventListener : BaseMotionGestureEventListener = (box (eventListenerInterface) :?> BaseMotionGestureEventListener)
        baseMotionGestureEventListener.onMotionGestureEvent((box (eventObject) :?> MotionGestureEvent))


