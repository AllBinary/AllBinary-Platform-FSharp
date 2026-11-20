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
type DownOrientationInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (DownOrientationInputToGameKeyEventAction.jclinit(); DownOrientationInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (DownOrientationInputToGameKeyEventAction.jclinit(); DownOrientationInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DownOrientationInputToGameKeyEventAction.jclinitDone then
            DownOrientationInputToGameKeyEventAction.jclinitDone <- true
            DownOrientationInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        DownOrientationInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(DownOrientationInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            DownOrientationInputToGameKeyEventAction.instance <- (new DownOrientationInputToGameKeyEventAction())
        (box (DownOrientationInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Down Action", OrientationMotionGestureFactory.getInstance().DOWN, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


