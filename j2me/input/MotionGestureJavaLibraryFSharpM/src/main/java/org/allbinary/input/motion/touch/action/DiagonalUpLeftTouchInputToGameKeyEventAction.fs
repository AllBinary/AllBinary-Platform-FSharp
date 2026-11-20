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
type DiagonalUpLeftTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DiagonalUpLeftTouchInputToGameKeyEventAction.jclinit(); DiagonalUpLeftTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DiagonalUpLeftTouchInputToGameKeyEventAction.jclinit(); DiagonalUpLeftTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DiagonalUpLeftTouchInputToGameKeyEventAction.jclinitDone then
            DiagonalUpLeftTouchInputToGameKeyEventAction.jclinitDone <- true
            DiagonalUpLeftTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DiagonalUpLeftTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DiagonalUpLeftTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DiagonalUpLeftTouchInputToGameKeyEventAction.instance <- (new DiagonalUpLeftTouchInputToGameKeyEventAction())
        (box (DiagonalUpLeftTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Diagonal Up Left Action", TouchMotionGestureFactory.getInstance().DIAGONAL_UP_LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


