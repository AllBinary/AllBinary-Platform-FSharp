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
type GameKeyFromMotionGestureEventListener =
    inherit CompleteMotionGestureInputEventListener
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable previousGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyFromMotionGestureEventListener.jclinitDone then
            GameKeyFromMotionGestureEventListener.jclinitDone <- true
            GameKeyFromMotionGestureEventListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit CompleteMotionGestureInputEventListener() }
        then
            this.jfields_GameKeyFromMotionGestureEventListener()
    member this.jfields_GameKeyFromMotionGestureEventListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.previousGameKeyEvent <- GameKeyEvent.NONE
        ()
    
    override this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    override this.onCompleteMotionGestureInputEvent(completeMotionGestureInputEvent: CompleteMotionGestureInputEvent) : unit =
        try
            let mutable gameKeyCompleteMotionGestureInputEvent : GameKeyCompleteMotionGestureInputEvent = (box (completeMotionGestureInputEvent) :?> GameKeyCompleteMotionGestureInputEvent)
            let mutable gameKeyEvent : GameKeyEvent = gameKeyCompleteMotionGestureInputEvent.getGameKeyEvent()
            if not (JR.same(gameKeyEvent, this.previousGameKeyEvent)) then
                if not (JR.same(this.previousGameKeyEvent, GameKeyEvent.NONE)) then
                    UpGameKeyEventHandler.getInstance().fireEvent(this.previousGameKeyEvent)
                this.previousGameKeyEvent <- gameKeyEvent
                if (not (JR.same(gameKeyEvent, null))) && (not (JR.same(gameKeyEvent, GameKeyEvent.NONE))) then
                    DownGameKeyEventHandler.getInstance().fireEvent(gameKeyEvent)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "onCompleteMotionGestureInputEvent", e)
            | _ -> reraise ()


