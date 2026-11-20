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
type GameKeyCompleteMotionGestureInputEventFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable eventList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : GameKeyCompleteMotionGestureInputEventFactory
    static member SINGLETON with get() : GameKeyCompleteMotionGestureInputEventFactory = (GameKeyCompleteMotionGestureInputEventFactory.jclinit(); GameKeyCompleteMotionGestureInputEventFactory.jcell_SINGLETON) and set (jvalue: GameKeyCompleteMotionGestureInputEventFactory) = (GameKeyCompleteMotionGestureInputEventFactory.jclinit(); GameKeyCompleteMotionGestureInputEventFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyCompleteMotionGestureInputEventFactory.jclinitDone then
            GameKeyCompleteMotionGestureInputEventFactory.jclinitDone <- true
            GameKeyCompleteMotionGestureInputEventFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyCompleteMotionGestureInputEventFactory.jcell_SINGLETON <- (new GameKeyCompleteMotionGestureInputEventFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameKeyCompleteMotionGestureInputEventFactory()
    member this.jfields_GameKeyCompleteMotionGestureInputEventFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.eventList <- (new BasicArrayListD())
        ()
    
    static member getInstance() : GameKeyCompleteMotionGestureInputEventFactory =
        GameKeyCompleteMotionGestureInputEventFactory.SINGLETON
    
    abstract add : gameKeyCompleteMotionGestureInputEvent: GameKeyCompleteMotionGestureInputEvent -> unit
    default this.add(gameKeyCompleteMotionGestureInputEvent: GameKeyCompleteMotionGestureInputEvent) : unit =
        ignore (this.eventList.add(gameKeyCompleteMotionGestureInputEvent))
    
    abstract updateAll : unit -> unit
    default this.updateAll() : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).appendint(this.eventList.size()).ToString(), this, "updateAll")
        let mutable index : int = this.eventList.size() - 1
        while index >= 0 do
            let mutable gameKeyCompleteMotionGestureInputEvent : GameKeyCompleteMotionGestureInputEvent = (box (this.eventList.objectArray.[index]) :?> GameKeyCompleteMotionGestureInputEvent)
            gameKeyCompleteMotionGestureInputEvent.update()
            index <- index - 1


