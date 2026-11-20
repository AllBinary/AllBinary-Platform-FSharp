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
type RightOrientationInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (RightOrientationInputToGameKeyEventAction.jclinit(); RightOrientationInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (RightOrientationInputToGameKeyEventAction.jclinit(); RightOrientationInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RightOrientationInputToGameKeyEventAction.jclinitDone then
            RightOrientationInputToGameKeyEventAction.jclinitDone <- true
            RightOrientationInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        RightOrientationInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(RightOrientationInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            RightOrientationInputToGameKeyEventAction.instance <- (new RightOrientationInputToGameKeyEventAction())
        (box (RightOrientationInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Right Action", OrientationMotionGestureFactory.getInstance().RIGHT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


