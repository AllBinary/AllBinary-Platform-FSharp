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
type DiagonalDownLeftTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DiagonalDownLeftTouchInputToGameKeyEventAction.jclinit(); DiagonalDownLeftTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DiagonalDownLeftTouchInputToGameKeyEventAction.jclinit(); DiagonalDownLeftTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DiagonalDownLeftTouchInputToGameKeyEventAction.jclinitDone then
            DiagonalDownLeftTouchInputToGameKeyEventAction.jclinitDone <- true
            DiagonalDownLeftTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DiagonalDownLeftTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DiagonalDownLeftTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DiagonalDownLeftTouchInputToGameKeyEventAction.instance <- (new DiagonalDownLeftTouchInputToGameKeyEventAction())
        (box (DiagonalDownLeftTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Diagonal Down Left Action", TouchMotionGestureFactory.getInstance().DIAGONAL_DOWN_LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


