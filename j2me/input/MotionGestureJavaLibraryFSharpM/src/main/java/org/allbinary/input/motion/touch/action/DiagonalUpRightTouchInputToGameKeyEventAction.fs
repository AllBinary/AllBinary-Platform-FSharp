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
type DiagonalUpRightTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DiagonalUpRightTouchInputToGameKeyEventAction.jclinit(); DiagonalUpRightTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DiagonalUpRightTouchInputToGameKeyEventAction.jclinit(); DiagonalUpRightTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DiagonalUpRightTouchInputToGameKeyEventAction.jclinitDone then
            DiagonalUpRightTouchInputToGameKeyEventAction.jclinitDone <- true
            DiagonalUpRightTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DiagonalUpRightTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DiagonalUpRightTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DiagonalUpRightTouchInputToGameKeyEventAction.instance <- (new DiagonalUpRightTouchInputToGameKeyEventAction())
        (box (DiagonalUpRightTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Diagonal Up Right Action", TouchMotionGestureFactory.getInstance().DIAGONAL_UP_RIGHT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


