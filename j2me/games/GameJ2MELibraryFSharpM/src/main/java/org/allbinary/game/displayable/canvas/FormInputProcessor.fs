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
type FormInputProcessor =
    inherit InputProcessor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable downKeyEventHandler : DownKeyEventHandler
    [<DefaultValue(false)>] val mutable upGameKeyEventHandler : UpGameKeyEventHandler
    [<DefaultValue(false)>] val mutable inputFactory : InputFactory
    [<DefaultValue(false)>] val mutable platformKeyFactory : PlatformKeyFactory
    [<DefaultValue(false)>] val mutable allBinaryGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FormInputProcessor.jclinitDone then
            FormInputProcessor.jclinitDone <- true
            FormInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_FormInputProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.downKeyEventHandler <- DownKeyEventHandler.getInstance()
        this.upGameKeyEventHandler <- UpGameKeyEventHandler.getInstance()
        this.inputFactory <- InputFactory.getInstance()
        this.platformKeyFactory <- PlatformKeyFactory.getInstance()
        ()
    
    new (allBinaryGameCanvas: AllBinaryGameCanvas) as this =
        { inherit InputProcessor() }
        then
            this.jfields_FormInputProcessor()
            this.jctor1(allBinaryGameCanvas)
    member this.jctor1(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        this.allBinaryGameCanvas <- allBinaryGameCanvas
        ()
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        try
            PreLogUtil.put((new StringMaker()).append(this.inputFactory.KEY_CODE_LABEL).appendint(keyCode).append(CommonSeps.getInstance().SPACE).append(this.inputFactory.DEVICE_ID_LABEL).appendint(deviceId).ToString(), this, this.gameInputStrings.KEY_PRESSED)
            let mutable input : Input = this.inputFactory.getInstanceById(keyCode)
            let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this.allBinaryGameCanvas, input)
            this.downKeyEventHandler.fireEventForGameKeyEvent(gameKeyEvent)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()
    
    override this.keyReleasedByDevice(canvas: Canvas, keyCode: int, deviceId: int) : unit =
        try
            let mutable input : Input = this.inputFactory.getInstanceById(keyCode)
            if this.platformKeyFactory.isEnter(input) then
                PreLogUtil.put((new StringMaker()).append(this.inputFactory.KEY_CODE_LABEL).appendint(keyCode).append(CommonSeps.getInstance().SPACE).append(this.inputFactory.DEVICE_ID_LABEL).appendint(deviceId).ToString(), this, this.gameInputStrings.KEY_RELEASED)
                let mutable gameKey : GameKey = GameKeyFactory.getInstance().KEY_NUM0
                let mutable gameKeyEventSourceInterface : GameKeyEventSourceInterface = (box (canvas) :?> GameKeyEventSourceInterface)
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(gameKeyEventSourceInterface, gameKey)
                this.upGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.upGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()


