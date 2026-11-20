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
type GameCommandCanvas =
    inherit MyCanvas
    [<DefaultValue(false)>] val mutable repaintProcessor : Processor
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] val mutable foregroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable backgroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] val mutable gameKeyFactory : GameKeyFactory
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable downGameKeyEventHandler : DownGameKeyEventHandler
    [<DefaultValue(false)>] val mutable upGameKeyEventHandler : UpGameKeyEventHandler
    [<DefaultValue(false)>] val mutable repaintBehavior : RepaintBehavior
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable foregroundColor : int
    [<DefaultValue(false)>] val mutable backgroundColor : int
    [<DefaultValue(false)>] val mutable menuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable menuPaintable : Paintable
    [<DefaultValue(false)>] val mutable menuForm : PaintableForm
    [<DefaultValue(false)>] val mutable isSingleKeyRepeatableProcessing : bool
    [<DefaultValue(false)>] val mutable fontHeight : int
    static member id : int = 0
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameCommandCanvas.jclinitDone then
            GameCommandCanvas.jclinitDone <- true
            GameCommandCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameCommandCanvas() : unit =
        this.repaintProcessor <- ScreenRepaintProcessorFactory.getInstance().create(this)
        this.gameInputStrings <- GameInputStrings.getInstance()
        this.inputToGameKeyMapping <- PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()
        this.gameKeyFactory <- GameKeyFactory.getInstance()
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.downGameKeyEventHandler <- DownGameKeyEventHandler.getInstance()
        this.upGameKeyEventHandler <- UpGameKeyEventHandler.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.menuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.menuPaintable <- NullPaintable.getInstance()
        this.menuForm <- PaintableForm.getNullPaintableForm()
        this.isSingleKeyRepeatableProcessing <- Features.getInstance().isFeature(InputFeatureFactory.getInstance().SINGLE_KEY_REPEAT_PRESS)
        this.fontHeight <- 0
        ()
    
    new (cmdListener: CommandListener, name: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit MyCanvas(name, CanvasStrings.getInstance().EMPTY_CHILD_NAME_LIST) }
        then
            this.jfields_GameCommandCanvas()
            this.jctor1(cmdListener, name, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(cmdListener: CommandListener, name: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.repaintBehavior <- RepaintBehavior.getInstance()
        this.foregroundBasicColor <- foregroundBasicColor
        this.backgroundBasicColor <- backgroundBasicColor
        this.foregroundColor <- this.foregroundBasicColor.intValue()
        this.backgroundColor <- this.backgroundBasicColor.intValue()
        this.initCommands(cmdListener)
        if not (JR.same(cmdListener, NullCommandListener.NULL_COMMAND_LISTENER)) then
            try
                this.initMenu()
                this.repaintProcessor.process_()
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise ((new JRuntimeException()))
                | _ -> reraise ()
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        try
            let mutable font : Font = graphics.getFont()
            this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(this.canvasStrings.FD_WIDTH).appendint(MyFontProcessor.defaultCharWidth(font)).append(this.canvasStrings.FD_HEIGHT).appendint(font.getHeight()).ToString(), this, this.canvasStrings.UPDATE_MEASUREMENT)
            this.fontHeight <- font.getHeight()
            let mutable rectangle : Rectangle = this.createRectangle(this.menuForm.size())
            this.menuForm.init(rectangle, FormTypeFactory.getInstance().VERTICAL_CENTER_FORM)
            this.update()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT, e)
            | _ -> reraise ()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onDisplayChangeEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(DisplayInfoSingleton.getInstance().ToString()).ToString(), this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract initCommands : cmdListener: CommandListener -> unit
    default this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommand(GameCommandsFactory.getInstance().CLOSE_AND_SHOW_GAME_CANVAS)
        this.setCommandListener(cmdListener)
    
    abstract initMenu : unit -> unit
    default this.initMenu() : unit =
        let mutable form : ScrollSelectionForm = this.createForm()
        this.menuForm <- form
        if not (JR.same(form, ScrollSelectionFormNoneFactory.getInstance())) then
            this.setMenuInputProcessor((new ImmediateCommandFormInputProcessor((new BasicArrayListD()), -1, this, form)))
            this.menuPaintable <- (new FormPaintable(form))
        this.repaintBehavior.onChangeRepaint(this)
    
    abstract createForm : unit -> ScrollSelectionForm
    default this.createForm() : ScrollSelectionForm =
        let mutable items : ABCustomItem[] = (new CommandTextItemArrayFactory((new AllCommandsVisitor()))).getInstance(this.getCommandStack(), this.backgroundBasicColor, this.foregroundBasicColor)
        let mutable rectangle : Rectangle = this.createRectangle(items.Length)
        CommandCurrentSelectionFormFactory.getInstance(StringUtil.getInstance().EMPTY_STRING, items, rectangle, FormTypeFactory.getInstance().VERTICAL_CENTER_FORM, 15, false, this.backgroundBasicColor, this.foregroundBasicColor)
    
    abstract createRectangle : size: int -> Rectangle
    default this.createRectangle(size: int) : Rectangle =
        let mutable height : int = size * this.fontHeight
        let mutable startY : int = ((this.displayInfo.getLastHeight() * 2) / 3) - height
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable rectangle : Rectangle = (new Rectangle(pointFactory.createXY(30, startY), (this.displayInfo.getLastWidth() - 30), startY))
        rectangle
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        this.logUtil.putF(this.commonStrings.START, this, "open")
        BasicMotionGesturesHandler.getInstance().addListenerInterface(this.getMenuInputProcessor())
        GameKeyEventHandler.getInstance().addListener(this.getMenuInputProcessor())
        DisplayChangeEventHandler.getInstance().addListenerInterface(this)
    
    abstract close : unit -> unit
    default this.close() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CLOSE)
        BasicMotionGesturesHandler.getInstance().removeListener(this.getMenuInputProcessor())
        GameKeyEventHandler.getInstance().removeListener(this.getMenuInputProcessor())
        DisplayChangeEventHandler.getInstance().removeListener(this)
    
    abstract update : unit -> unit
    default this.update() : unit =
        this.repaintProcessor.process_()
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        GameCommandCanvas.id
    
    override this.keyPressed(keyCode: int) : unit =
        this.keyPressedByDevice(keyCode, 0)
    
    override this.keyReleased(keyCode: int) : unit =
        this.keyReleasedByDevice(keyCode, 0)
    
    override this.keyRepeated(keyCode: int) : unit =
        this.keyRepeatedByDevice(keyCode, 0)
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonSeps.getInstance().SPACE).appendint(keyCode).ToString(), this, this.gameInputStrings.KEY_PRESSED)
        this.addGameKeyEvent(keyCode, 0, false)
    
    override this.keyReleasedByDevice(keyCode: int, deviceId: int) : unit =
        this.removeGameKeyEvent(keyCode, deviceId, false)
    
    override this.keyRepeatedByDevice(keyCode: int, deviceId: int) : unit =
        if this.isSingleKeyRepeatableProcessing then
            this.addGameKeyEvent(keyCode, deviceId, true)
    
    member this.addGameKeyEvent(keyCode: int, deviceId: int, repeated: bool) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this, keyCode)
            if not (JR.same(gameKey, this.gameKeyFactory.NONE)) then
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this, gameKey)
                this.downGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.downGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
            else
                this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.ADD_KEY_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()
    
    member this.removeGameKeyEvent(keyCode: int, deviceId: int, repeated: bool) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this, keyCode)
            if not (JR.same(gameKey, this.gameKeyFactory.NONE)) then
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this, gameKey)
                this.upGameKeyEventHandler.fireEvent(gameKeyEvent)
                this.upGameKeyEventHandler.getInstanceForDevice(deviceId).fireEvent(gameKeyEvent)
            else
                this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.REMOVE_KEY_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.REMOVE_KEY_EVENT, e)
            | _ -> reraise ()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        this.menuPaintable.paint(graphics)
        this.repaintBehavior.repaint(this)
    
    member this.setMenuInputProcessor(menuInputProcessor: BasicMenuInputProcessor) : unit =
        this.menuInputProcessor <- menuInputProcessor
    
    abstract getMenuInputProcessor : unit -> BasicMenuInputProcessor
    default this.getMenuInputProcessor() : BasicMenuInputProcessor =
        this.menuInputProcessor
    interface MenuListener with
        member this.open_() : unit = this.open_()
        member this.close() : unit = this.close()
    interface DisplayChangeEventListener with
        member this.onDisplayChangeEvent(jp0: DisplayChangeEvent) : unit = this.onDisplayChangeEvent(jp0)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


