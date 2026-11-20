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
type ImmediateCommandFormInputProcessor =
    inherit CommandFormInputProcessor
    [<DefaultValue(false)>] val mutable timeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable gameCommandCanvas : GameCommandCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImmediateCommandFormInputProcessor.jclinitDone then
            ImmediateCommandFormInputProcessor.jclinitDone <- true
            ImmediateCommandFormInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImmediateCommandFormInputProcessor() : unit =
        this.timeHelper <- (new TimeDelayHelper(25))
        ()
    
    new (gameKeyEventList: BasicArrayList, playerInputId: int, gameCommandCanvas: GameCommandCanvas, form: ScrollSelectionForm) as this =
        { inherit CommandFormInputProcessor(gameKeyEventList, playerInputId, gameCommandCanvas, form) }
        then
            this.jfields_ImmediateCommandFormInputProcessor()
            this.jctor1(gameKeyEventList, playerInputId, gameCommandCanvas, form)
    member this.jctor1(gameKeyEventList: BasicArrayList, playerInputId: int, gameCommandCanvas: GameCommandCanvas, form: ScrollSelectionForm) : unit =
        ()
        this.gameCommandCanvas <- gameCommandCanvas
        ()
    
    override this.onPressGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        try
            base.onPressGameKeyEvent(gameKeyEvent)
            if this.timeHelper.isTimeTNT() then
                ignore (this.processInputList())
                this.gameCommandCanvas.repaintBehavior.onChangeRepaint(this.getCanvas())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.ON_PRESS_GAME_KEY, e)
            | _ -> reraise ()
    
    override this.onDownGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        try
            base.onDownGameKeyEvent(gameKeyEvent)
            if this.timeHelper.isTimeTNT() then
                ignore (this.processInputList())
                this.gameCommandCanvas.repaintBehavior.onChangeRepaint(this.getCanvas())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.ON_DOWN_GAME_KEY, e)
            | _ -> reraise ()
    
    override this.onUpGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        try
            base.onUpGameKeyEvent(gameKeyEvent)
            if this.timeHelper.isTimeTNT() then
                ignore (this.processInputList())
                this.gameCommandCanvas.repaintBehavior.onChangeRepaint(this.getCanvas())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.ON_UP_GAME_KEY, e)
            | _ -> reraise ()
    
    override this.onMotionGestureEvent(motionGestureEvent: MotionGestureEvent) : unit =
        try
            base.onMotionGestureEvent(motionGestureEvent)
            if this.timeHelper.isTimeTNT() then
                ignore (this.processInputList())
                this.gameCommandCanvas.repaintBehavior.onChangeRepaint(this.getCanvas())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "onMotionGestureEvent", e)
            | _ -> reraise ()


