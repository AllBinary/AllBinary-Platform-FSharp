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
type RightTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (RightTouchInputToGameKeyEventAction.jclinit(); RightTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (RightTouchInputToGameKeyEventAction.jclinit(); RightTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RightTouchInputToGameKeyEventAction.jclinitDone then
            RightTouchInputToGameKeyEventAction.jclinitDone <- true
            RightTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        RightTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(RightTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            RightTouchInputToGameKeyEventAction.instance <- (new RightTouchInputToGameKeyEventAction())
        (box (RightTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Right Action", TouchMotionGestureFactory.getInstance().RIGHT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


