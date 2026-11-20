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
type RollLeftOrientationInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (RollLeftOrientationInputToGameKeyEventAction.jclinit(); RollLeftOrientationInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (RollLeftOrientationInputToGameKeyEventAction.jclinit(); RollLeftOrientationInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RollLeftOrientationInputToGameKeyEventAction.jclinitDone then
            RollLeftOrientationInputToGameKeyEventAction.jclinitDone <- true
            RollLeftOrientationInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        RollLeftOrientationInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(RollLeftOrientationInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            RollLeftOrientationInputToGameKeyEventAction.instance <- (new RollLeftOrientationInputToGameKeyEventAction())
        (box (RollLeftOrientationInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () =
        { inherit GameKeyCompleteMotionGestureInputEvent("Roll Left Action", OrientationMotionGestureFactory.getInstance().ROLL_LEFT, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }


