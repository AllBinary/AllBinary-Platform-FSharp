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
type UpOrientationInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (UpOrientationInputToGameKeyEventAction.jclinit(); UpOrientationInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (UpOrientationInputToGameKeyEventAction.jclinit(); UpOrientationInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpOrientationInputToGameKeyEventAction.jclinitDone then
            UpOrientationInputToGameKeyEventAction.jclinitDone <- true
            UpOrientationInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        UpOrientationInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(UpOrientationInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            UpOrientationInputToGameKeyEventAction.instance <- (new UpOrientationInputToGameKeyEventAction())
        (box (UpOrientationInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Up Action", OrientationMotionGestureFactory.getInstance().UP, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


