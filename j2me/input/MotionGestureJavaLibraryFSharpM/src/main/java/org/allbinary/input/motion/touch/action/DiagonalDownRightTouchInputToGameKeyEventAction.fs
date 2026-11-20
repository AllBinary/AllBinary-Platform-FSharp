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
type DiagonalDownRightTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DiagonalDownRightTouchInputToGameKeyEventAction.jclinit(); DiagonalDownRightTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DiagonalDownRightTouchInputToGameKeyEventAction.jclinit(); DiagonalDownRightTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DiagonalDownRightTouchInputToGameKeyEventAction.jclinitDone then
            DiagonalDownRightTouchInputToGameKeyEventAction.jclinitDone <- true
            DiagonalDownRightTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DiagonalDownRightTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DiagonalDownRightTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DiagonalDownRightTouchInputToGameKeyEventAction.instance <- (new DiagonalDownRightTouchInputToGameKeyEventAction())
        (box (DiagonalDownRightTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Diagonal Down Right Action", TouchMotionGestureFactory.getInstance().DIAGONAL_DOWN_RIGHT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


