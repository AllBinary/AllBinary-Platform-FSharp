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
type LeftTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (LeftTouchInputToGameKeyEventAction.jclinit(); LeftTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (LeftTouchInputToGameKeyEventAction.jclinit(); LeftTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LeftTouchInputToGameKeyEventAction.jclinitDone then
            LeftTouchInputToGameKeyEventAction.jclinitDone <- true
            LeftTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        LeftTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(LeftTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            LeftTouchInputToGameKeyEventAction.instance <- (new LeftTouchInputToGameKeyEventAction())
        (box (LeftTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Left Action", TouchMotionGestureFactory.getInstance().LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


