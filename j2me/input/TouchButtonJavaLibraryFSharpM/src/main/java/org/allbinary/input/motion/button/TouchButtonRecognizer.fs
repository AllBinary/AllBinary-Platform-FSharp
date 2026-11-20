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
type TouchButtonRecognizer =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable rectangleCollisionUtil : RectangleCollisionUtil
    [<DefaultValue(false)>] val mutable upGameKeyEventHandler : UpGameKeyEventHandler
    [<DefaultValue(false)>] val mutable downGameKeyEventHandler : DownGameKeyEventHandler
    [<DefaultValue(false)>] val mutable lastPressedTouchButtonInput : TouchButtonInput
    [<DefaultValue(false)>] val mutable currentlyPressedTouchButtonSingleton : CurrentlyPressedTouchButtonSingleton
    [<DefaultValue(false)>] val mutable releaseHelper : ReleaseHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonRecognizer.jclinitDone then
            TouchButtonRecognizer.jclinitDone <- true
            TouchButtonRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButtonRecognizer() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.rectangleCollisionUtil <- RectangleCollisionUtil.getInstance()
        this.upGameKeyEventHandler <- UpGameKeyEventHandler.getInstance()
        this.downGameKeyEventHandler <- DownGameKeyEventHandler.getInstance()
        this.lastPressedTouchButtonInput <- BasicTouchInputFactory.getInstance().NONE
        this.currentlyPressedTouchButtonSingleton <- CurrentlyPressedTouchButtonSingleton.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_TouchButtonRecognizer()
            this.jctor1()
    member this.jctor1() : unit =
        if TouchScreenFactory.getInstance().isMultiTouch() then
            this.releaseHelper <- (new MultitouchReleaseHelper(this))
        else
            this.releaseHelper <- (new ReleaseHelper(this))
        ()
    
    member this.processRelease(touchButtonInput: TouchButtonInput, deviceId: int) : unit =
        this.releaseHelper.release(touchButtonInput, deviceId)
        let mutable gameKeyEvent : GameKeyEvent = touchButtonInput.getGameKeyEvent()
        this.upGameKeyEventHandler.fireEvent(gameKeyEvent)
        this.upGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
        ignore (this.currentlyPressedTouchButtonSingleton.remove(touchButtonInput))
    
    abstract releaseTouchButtonInput : x: int * y: int * deviceId: int -> bool
    default this.releaseTouchButtonInput(x: int, y: int, deviceId: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable touchButtonInput : TouchButtonInput = this.lastPressedTouchButtonInput
        if this.currentlyPressedTouchButtonSingleton.contains(touchButtonInput) then
            this.lastPressedTouchButtonInput <- BasicTouchInputFactory.getInstance().NONE
            this.processRelease(touchButtonInput, deviceId)
            jret <- true
            jflow <- 1
        else
            let mutable list_ : BasicArrayList = TouchButtonFactory.getInstance().getList()
            let mutable rectangle : Rectangle = null
            let mutable point : GPoint = null
            let mutable touchButton : TouchButton = null
            let mutable index : int = list_.size() - 1
            while jflow = 0 && (index >= 0) do
                touchButton <- (box (list_.objectArray.[index]) :?> TouchButton)
                rectangle <- touchButton.getRectangle()
                point <- rectangle.getPoint()
                if this.rectangleCollisionUtil.isInside(point.getX(), point.getY(), rectangle.getMaxX(), rectangle.getMaxY(), x, y) then
                    touchButtonInput <- touchButton.getTouchButtonInput()
                    this.processRelease(touchButtonInput, deviceId)
                    jret <- true
                    jflow <- 1
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract pressTouchButtonInput : x: int * y: int * deviceId: int -> bool
    default this.pressTouchButtonInput(x: int, y: int, deviceId: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable list_ : BasicArrayList = TouchButtonFactory.getInstance().getList()
        let mutable rectangle : Rectangle = null
        let mutable point : GPoint = null
        let mutable touchButton : TouchButton = null
        let mutable touchButtonInput : TouchButtonInput = null
        let mutable gameKeyEvent : GameKeyEvent = null
        let mutable index : int = list_.size() - 1
        while jflow = 0 && (index >= 0) do
            touchButton <- (box (list_.objectArray.[index]) :?> TouchButton)
            rectangle <- touchButton.getRectangle()
            point <- rectangle.getPoint()
            if this.rectangleCollisionUtil.isInside(point.getX(), point.getY(), rectangle.getMaxX(), rectangle.getMaxY(), x, y) then
                touchButtonInput <- touchButton.getTouchButtonInput()
                if not (this.currentlyPressedTouchButtonSingleton.contains(touchButtonInput)) then
                    this.releaseHelper.release(touchButtonInput, deviceId)
                    this.lastPressedTouchButtonInput <- touchButtonInput
                    ignore (this.currentlyPressedTouchButtonSingleton.add(touchButtonInput))
                    gameKeyEvent <- touchButtonInput.getGameKeyEvent()
                    this.downGameKeyEventHandler.fireEvent(gameKeyEvent)
                    this.downGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
                jret <- true
                jflow <- 1
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret


