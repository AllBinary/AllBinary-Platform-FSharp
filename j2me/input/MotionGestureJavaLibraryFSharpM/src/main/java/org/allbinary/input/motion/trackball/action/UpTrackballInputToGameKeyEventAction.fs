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
type UpTrackballInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (UpTrackballInputToGameKeyEventAction.jclinit(); UpTrackballInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (UpTrackballInputToGameKeyEventAction.jclinit(); UpTrackballInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpTrackballInputToGameKeyEventAction.jclinitDone then
            UpTrackballInputToGameKeyEventAction.jclinitDone <- true
            UpTrackballInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        UpTrackballInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(UpTrackballInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            UpTrackballInputToGameKeyEventAction.instance <- (new UpTrackballInputToGameKeyEventAction())
        (box (UpTrackballInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Up Action", TrackballMotionGestureFactory.getInstance().UP, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


