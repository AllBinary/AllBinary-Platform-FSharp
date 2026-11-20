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
type PopupMenuInputProcessor =
    inherit BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable rectangleCollisionUtil : RectangleCollisionUtil
    [<DefaultValue(false)>] val mutable CLICK_DELAY : int
    [<DefaultValue(false)>] val mutable clickTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable rectangle : Rectangle
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PopupMenuInputProcessor.jclinitDone then
            PopupMenuInputProcessor.jclinitDone <- true
            PopupMenuInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PopupMenuInputProcessor() : unit =
        this.rectangleCollisionUtil <- RectangleCollisionUtil.getInstance()
        this.CLICK_DELAY <- 120
        this.clickTimeHelper <- (new TimeDelayHelper(this.CLICK_DELAY))
        ()
    
    new (gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: MyCanvas, rectangle: Rectangle) as this =
        { inherit BasicMenuInputProcessor(gameKeyEventList, playerInputId, gameCanvas) }
        then
            this.jfields_PopupMenuInputProcessor()
            this.jctor1(gameKeyEventList, playerInputId, gameCanvas, rectangle)
    member this.jctor1(gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: MyCanvas, rectangle: Rectangle) : unit =
        ()
        this.rectangle <- rectangle
        ()
    
    abstract init : rectangle: Rectangle -> unit
    default this.init(rectangle: Rectangle) : unit =
        this.rectangle <- rectangle
    
    abstract processInput : key: int -> int
    default this.processInput(key: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if key = Canvas.KEY_STAR then
            let mutable gameCanvas : AllBinaryGameCanvas = (box (this.getCanvas()) :?> AllBinaryGameCanvas)
            gameCanvas.toggleMenu()
            jret <- 1
            jflow <- 1
        if jflow = 0 then
            jret <- 0
            jflow <- 1
        jret
    
    override this.processInputList() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        try
            let mutable motionInputsIndex : int = this.processMotionInputs()
            let mutable list_ : BasicArrayList = this.getGameKeyEventList()
            let mutable size : int = list_.size()
            let mutable key : int = 0
            let mutable gameKeyEvent : GameKeyEvent = null
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                gameKeyEvent <- (box (list_.objectArray.[index]) :?> GameKeyEvent)
                if not (JR.same(gameKeyEvent, null)) then
                    key <- gameKeyEvent.getKey()
                    if this.processInput(key) = 1 then
                        jflow <- 100001
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                this.clear()
                if (size > 0) || (motionInputsIndex >= 0) then
                    jret <- 1
                    jflow <- 1
                else
                    jret <- -1
                    jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, GameInputStrings.getInstance().PROCESS_INPUT, e)
                jret <- -1
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract processMotionInputs : unit -> int
    default this.processMotionInputs() : int =
        let mutable lastIndex : int = this.motionGestureEventList.size() - 1
        if lastIndex >= 0 then
            let mutable motionGestureEvent : MotionGestureEvent = (box (this.motionGestureEventList.objectArray.[lastIndex]) :?> MotionGestureEvent)
            this.processMotionInput(motionGestureEvent)
        this.motionGestureEventList.clear()
        lastIndex
    
    abstract processMotionInput : motionGestureEvent: MotionGestureEvent -> unit
    default this.processMotionInput(motionGestureEvent: MotionGestureEvent) : unit =
        let mutable jflow = 0
        if (JR.same(motionGestureEvent, null)) then
            this.logUtil.putF("Exception: Bug", this, this.gameInputStrings.PROCESS_MOTION_INPUT)
            jflow <- 1
        if jflow = 0 then
            let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
            let mutable motionGestureInput : MotionGestureInput = motionGestureEvent.getMotionGesture()
            if (JR.same(motionGestureInput, touchMotionGestureFactory.RELEASED)) then
                let mutable point : GPoint = motionGestureEvent.getCurrentPoint()
                let mutable rectPoint : GPoint = this.rectangle.getPoint()
                if this.rectangleCollisionUtil.isInside(rectPoint.getX(), rectPoint.getY(), (this.rectangle.getMaxX() + 20), this.rectangle.getMaxY(), point.getX(), point.getY()) then
                    if this.clickTimeHelper.isTimeTNT() then
                        let mutable gameCanvas : AllBinaryGameCanvas = (box (this.getCanvas()) :?> AllBinaryGameCanvas)
                        gameCanvas.toggleMenu()


