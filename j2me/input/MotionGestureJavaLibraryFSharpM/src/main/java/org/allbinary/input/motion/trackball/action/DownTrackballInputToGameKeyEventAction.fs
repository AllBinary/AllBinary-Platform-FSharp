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
type DownTrackballInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DownTrackballInputToGameKeyEventAction.jclinit(); DownTrackballInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DownTrackballInputToGameKeyEventAction.jclinit(); DownTrackballInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DownTrackballInputToGameKeyEventAction.jclinitDone then
            DownTrackballInputToGameKeyEventAction.jclinitDone <- true
            DownTrackballInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DownTrackballInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DownTrackballInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DownTrackballInputToGameKeyEventAction.instance <- (new DownTrackballInputToGameKeyEventAction())
        (box (DownTrackballInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Down Action", TrackballMotionGestureFactory.getInstance().DOWN, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


