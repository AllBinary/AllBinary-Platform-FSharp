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
type GameCanvasInputProcessor =
    inherit InputProcessor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable allBinaryGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable downGameKeyEventHandler : DownGameKeyEventHandler
    [<DefaultValue(false)>] val mutable upGameKeyEventHandler : UpGameKeyEventHandler
    [<DefaultValue(false)>] val mutable downKeyEventHandler : DownKeyEventHandler
    [<DefaultValue(false)>] val mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameCanvasInputProcessor.jclinitDone then
            GameCanvasInputProcessor.jclinitDone <- true
            GameCanvasInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameCanvasInputProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.downGameKeyEventHandler <- DownGameKeyEventHandler.getInstance()
        this.upGameKeyEventHandler <- UpGameKeyEventHandler.getInstance()
        this.downKeyEventHandler <- DownKeyEventHandler.getInstance()
        this.smallIntegerSingletonFactory <- SmallIntegerSingletonFactory.getInstance()
        this.inputToGameKeyMapping <- PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()
        this.NONE <- GameKeyFactory.getInstance().NONE
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        ()
    
    new (allBinaryGameCanvas: AllBinaryGameCanvas) as this =
        { inherit InputProcessor() }
        then
            this.jfields_GameCanvasInputProcessor()
            this.jctor1(allBinaryGameCanvas)
    member this.jctor1(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        this.allBinaryGameCanvas <- allBinaryGameCanvas
        this.inputToGameKeyMapping.init(this.allBinaryGameCanvas)
        ()
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this.allBinaryGameCanvas, keyCode)
            if not (JR.same(gameKey, this.NONE)) then
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this.allBinaryGameCanvas, gameKey)
                this.downGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.downGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
            else
                this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.ADD_KEY_EVENT)
            let mutable keyCodeAsInteger : Integer = this.smallIntegerSingletonFactory.getAtNoThrow(keyCode)
            this.downKeyEventHandler.fireEventI(keyCodeAsInteger)
            this.downKeyEventHandler.getInstanceForDevice(deviceId).fireEventI(keyCodeAsInteger)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()
    
    override this.keyReleasedByDevice(canvas: Canvas, keyCode: int, deviceId: int) : unit =
        this.removeGameKeyEvent(canvas, keyCode, deviceId, false)
    
    member this.removeGameKeyEvent(canvas: Canvas, keyCode: int, deviceId: int, repeated: bool) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(canvas, keyCode)
            if not (JR.same(gameKey, this.NONE)) then
                let mutable gameKeyEventSourceInterface : GameKeyEventSourceInterface = (box (canvas) :?> GameKeyEventSourceInterface)
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(gameKeyEventSourceInterface, gameKey)
                this.upGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.upGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
            else
                this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.REMOVE_KEY_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.REMOVE_KEY_EVENT, e)
            | _ -> reraise ()


