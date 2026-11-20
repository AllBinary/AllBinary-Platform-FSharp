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
type GameKeyEventFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable TOUCH_BUTTON_SOURCE_ID : int
    [<DefaultValue(false)>] val mutable MOTION_GESTURE_SOURCE_ID : int
    [<DefaultValue(false)>] val mutable MAX_SOURCES : int
    [<DefaultValue(false)>] val mutable ARRAY : GameKeyEvent[][]
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GameKeyEventFactory.jclinit(); GameKeyEventFactory.jcell_instance) and set (jvalue: obj) = (GameKeyEventFactory.jclinit(); GameKeyEventFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyEventFactory.jclinitDone then
            GameKeyEventFactory.jclinitDone <- true
            GameKeyEventFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyEventFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_GameKeyEventFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.TOUCH_BUTTON_SOURCE_ID <- 2
        this.MOTION_GESTURE_SOURCE_ID <- 3
        this.MAX_SOURCES <- 4
        this.ARRAY <- (JR.newArray2<GameKeyEvent>(this.MAX_SOURCES, InputFactory.getInstance().MAX))
        ()
    
    static member getInstance() : GameKeyEventFactory =
        if (JR.same(GameKeyEventFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GameKeyEventFactory.instance <- (new GameKeyEventFactory())
        (box (GameKeyEventFactory.instance) :?> GameKeyEventFactory)
    
    new () as this =
        {  }
        then
            this.jfields_GameKeyEventFactory()
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable nullUtil : NullUtil = NullUtil.getInstance()
        let mutable size : int = InputFactory.getInstance().MAX
        let mutable index : int = this.MAX_SOURCES
        while ((index <- index - 1; index)) >= 0 do
            let mutable index2 : int = size
            while ((index2 <- index2 - 1; index2)) >= 0 do
                this.ARRAY.[index].[index2] <- GameKeyEvent.createEvent(nullUtil.NULL_OBJECT, index, index2)
    
    abstract getInstanceForKey : anyType: GameKeyEventSourceInterface * key: int -> GameKeyEvent
    default this.getInstanceForKey(anyType: GameKeyEventSourceInterface, key: int) : GameKeyEvent =
        let mutable gameKeyEvent : GameKeyEvent = this.ARRAY.[anyType.getSourceId()].[key]
        gameKeyEvent
    
    abstract getInstanceForInput : anyType: GameKeyEventSourceInterface * input: Input -> GameKeyEvent
    default this.getInstanceForInput(anyType: GameKeyEventSourceInterface, input: Input) : GameKeyEvent =
        let mutable gameKeyEvent : GameKeyEvent = this.ARRAY.[anyType.getSourceId()].[input.getId()]
        gameKeyEvent


