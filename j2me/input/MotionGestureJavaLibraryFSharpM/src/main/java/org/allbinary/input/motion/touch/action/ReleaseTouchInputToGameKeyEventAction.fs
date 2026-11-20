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
type ReleaseTouchInputToGameKeyEventAction =
    inherit GameKeyCompleteMotionGestureInputEvent
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (ReleaseTouchInputToGameKeyEventAction.jclinit(); ReleaseTouchInputToGameKeyEventAction.jcell_instance) and set (jvalue: obj) = (ReleaseTouchInputToGameKeyEventAction.jclinit(); ReleaseTouchInputToGameKeyEventAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ReleaseTouchInputToGameKeyEventAction.jclinitDone then
            ReleaseTouchInputToGameKeyEventAction.jclinitDone <- true
            ReleaseTouchInputToGameKeyEventAction.jclinitBody()
    static member private jclinitBody() : unit =
        ReleaseTouchInputToGameKeyEventAction.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_ReleaseTouchInputToGameKeyEventAction() : unit =
        this.NONE <- GameKeyFactory.getInstance().NONE
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEvent =
        if (JR.same(ReleaseTouchInputToGameKeyEventAction.instance, NullUtil.getInstance().NULL_OBJECT)) then
            ReleaseTouchInputToGameKeyEventAction.instance <- (new ReleaseTouchInputToGameKeyEventAction())
        (box (ReleaseTouchInputToGameKeyEventAction.instance) :?> GameKeyCompleteMotionGestureInputEvent)
    
    new () as this =
        { inherit GameKeyCompleteMotionGestureInputEvent("Release Action", TouchMotionGestureFactory.getInstance().RELEASED, PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()) }
        then
            this.jfields_ReleaseTouchInputToGameKeyEventAction()
            this.jctor1()
    member this.jctor1() : unit =
        ()
        try
            this.setGameKey(this.NONE)
            this.setGameKeyEvent(GameKeyEventFactory.getInstance().getInstanceForInput(this, this.NONE))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    override this.update() : unit =
        ()


