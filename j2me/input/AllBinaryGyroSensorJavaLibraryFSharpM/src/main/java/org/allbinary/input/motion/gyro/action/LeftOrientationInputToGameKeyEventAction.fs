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
type LeftOrientationInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (LeftOrientationInputToGameKeyEventAction.jclinit(); LeftOrientationInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (LeftOrientationInputToGameKeyEventAction.jclinit(); LeftOrientationInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LeftOrientationInputToGameKeyEventAction.jclinitDone then
            LeftOrientationInputToGameKeyEventAction.jclinitDone <- true
            LeftOrientationInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        LeftOrientationInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(LeftOrientationInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            LeftOrientationInputToGameKeyEventAction.instance <- (new LeftOrientationInputToGameKeyEventAction())
        (box (LeftOrientationInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Left Action", OrientationMotionGestureFactory.getInstance().LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


