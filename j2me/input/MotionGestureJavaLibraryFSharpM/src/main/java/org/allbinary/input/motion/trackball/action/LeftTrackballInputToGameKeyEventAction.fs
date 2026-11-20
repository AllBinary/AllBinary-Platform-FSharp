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
type LeftTrackballInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (LeftTrackballInputToGameKeyEventAction.jclinit(); LeftTrackballInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (LeftTrackballInputToGameKeyEventAction.jclinit(); LeftTrackballInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LeftTrackballInputToGameKeyEventAction.jclinitDone then
            LeftTrackballInputToGameKeyEventAction.jclinitDone <- true
            LeftTrackballInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        LeftTrackballInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(LeftTrackballInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            LeftTrackballInputToGameKeyEventAction.instance <- (new LeftTrackballInputToGameKeyEventAction())
        (box (LeftTrackballInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Left Action", TrackballMotionGestureFactory.getInstance().LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


