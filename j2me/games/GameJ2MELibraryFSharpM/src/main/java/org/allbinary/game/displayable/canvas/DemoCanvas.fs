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
type DemoCanvas =
    inherit RunnableCanvas
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable myCommandsFactory : MyCommandsFactory
    [<DefaultValue(false)>] val mutable gameAdStateFactory : GameAdStateFactory
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] val mutable threadFactoryUtil : ThreadFactoryUtil
    [<DefaultValue(false)>] val mutable formUtil : FormUtil
    [<DefaultValue(false)>] val mutable fullscreenPaintable : Paintable
    [<DefaultValue(false)>] val mutable basicGameDemoPaintable : StatePaintable
    [<DefaultValue(false)>] val mutable specialAnimationInterface : SpecialAnimation
    [<DefaultValue(false)>] val mutable paintedSpecialAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable fullScreenUtil : FullScreenUtil
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable highScoresHelper : HighScoresHelperBase
    [<DefaultValue(false)>] val mutable realHighScoresPaintable : HighScoresPaintable
    [<DefaultValue(false)>] val mutable highScoresPaintable : Paintable
    [<DefaultValue(false)>] val mutable state : int
    [<DefaultValue(false)>] val mutable canvasThread : Thread
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] val mutable highScoresFactoryInterface : HighScoresFactoryInterface
    [<DefaultValue(false)>] val mutable menuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable menuForm : ScrollSelectionForm
    [<DefaultValue(false)>] val mutable gameInitializationInterfaceFactoryInterface : BasicBuildGameInitializerFactory
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] val mutable demoGameRunnable : DemoGameStartupRunnable
    [<DefaultValue(false)>] val mutable defaultPaintableInterface : Paintable
    [<DefaultValue(false)>] val mutable paintableInterface : PaintableInterface
    [<DefaultValue(false)>] val mutable overlayPaintable : InitUpdatePaintable
    [<DefaultValue(false)>] val mutable progressPaintable : PaintableInterface
    [<DefaultValue(false)>] val mutable tempWait : int
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] val mutable gameRunnable : GameRunnable
    [<DefaultValue(false)>] val mutable isSingleKeyRepeatableProcessing : bool
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable lastKeyNotMapped : int
    [<DefaultValue(false)>] val mutable SET_STATE : string
    [<DefaultValue(false)>] val mutable baseGameStatistics : BaseGameStatistics
    static member id : int = 0
    static member BOT_GAME_STATS : string = "Bot Game Statistics: "
    static member TYPE : int = 3
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoCanvas.jclinitDone then
            DemoCanvas.jclinitDone <- true
            DemoCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DemoCanvas() : unit =
        this.basicColorFactory <- BasicColorFactory.getInstance()
        this.myCommandsFactory <- MyCommandsFactory.getInstance()
        this.gameAdStateFactory <- GameAdStateFactory.getInstance()
        this.gameInputStrings <- GameInputStrings.getInstance()
        this.gameStateFactory <- GameStateFactory.getInstance()
        this.threadFactoryUtil <- ThreadFactoryUtil.getInstance()
        this.formUtil <- FormUtil.getInstance()
        this.fullscreenPaintable <- FullScreenPaintableFactory.getInstance().paintable
        this.basicGameDemoPaintable <- StatePaintableFactory.getInstance()
        this.specialAnimationInterface <- SpecialAnimation.getInstance()
        this.paintedSpecialAnimationInterface <- SpecialAnimation.getInstance()
        this.fullScreenUtil <- FullScreenUtil.getInstance()
        this.gameCanvas <- NullGameCanvas.getInstance()
        this.highScoresHelper <- (new HighScoresHelper())
        this.realHighScoresPaintable <- (new HighScoresPaintable())
        this.highScoresPaintable <- NullPaintable.getInstance()
        this.state <- 0
        this.canvasThread <- NullThread.NULL_THREAD
        this.timeDelayHelper <- (new TimeDelayHelper(6000))
        this.basicColor <- this.basicColorFactory.RED
        this.menuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.menuForm <- ScrollSelectionForm.getNullScrollSelectionForm()
        this.defaultPaintableInterface <- NullPaintable.getInstance()
        this.paintableInterface <- NullPaintable.getInstance()
        this.progressPaintable <- ProgressCanvasFactory.getLazyInstance()
        this.tempWait <- NullWaitGameRunnable.getInstance().WAIT
        this.inputToGameKeyMapping <- PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()
        this.gameRunnable <- NullWaitGameRunnable.getInstance()
        this.isSingleKeyRepeatableProcessing <- Features.getInstance().isFeature(InputFeatureFactory.getInstance().SINGLE_KEY_REPEAT_PRESS)
        this.NONE <- GameKeyFactory.getInstance().NONE
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.lastKeyNotMapped <- -1
        this.SET_STATE <- "setState"
        this.baseGameStatistics <- GameStatisticsFactory.getInstance()
        ()
    
    new (abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, highScoresFactoryInterface: HighScoresFactoryInterface, paintable: Paintable, overlayPaintable: InitUpdatePaintable, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, isContinue: bool) as this =
        { inherit RunnableCanvas(commandListener, CurrentDisplayableFactory.getInstance().DEFAULT_CHILD_NAME_LIST, true) }
        then
            this.jfields_DemoCanvas()
            this.jctor1(abeClientInformation, commandListener, highScoresFactoryInterface, paintable, overlayPaintable, gameInitializationInterfaceFactoryInterface, isContinue)
    member this.jctor1(abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, highScoresFactoryInterface: HighScoresFactoryInterface, paintable: Paintable, overlayPaintable: InitUpdatePaintable, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, isContinue: bool) : unit =
        ()
        this.abeClientInformation <- abeClientInformation
        this.setWait(NullWaitGameRunnable.getInstance().WAIT)
        this.gameInitializationInterfaceFactoryInterface <- gameInitializationInterfaceFactoryInterface
        GameInitializationUtil.getInstance().initDemo(abeClientInformation, this, gameInitializationInterfaceFactoryInterface)
        ResizableListenerHandler.getInstance().fireEvent(false)
        this.overlayPaintable <- overlayPaintable
        this.highScoresFactoryInterface <- highScoresFactoryInterface
        this.setDefaultPaintableInterface(paintable)
        this.setPaintableInterface(this.getDefaultPaintableInterface())
        if isContinue then
            this.addCommand(GameCommandsFactory.getInstance().CONTINUE_COMMAND)
        if ChangedGameFeatureListener.getInstance().isChangedFeature(GameFeatureFactory.getInstance().SOUND) then
            this.mediaInit()
        this.demoGameRunnable <- (new DemoGameStartupRunnable(this))
        DisplayChangeEventHandler.getInstance().addListenerInterface(this)
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onDisplayChangeEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        try
            this.logUtil.putF((new StringMaker()).append(this.commonLabels.START_LABEL).append(this.displayInfo.ToString()).ToString(), this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT)
            let mutable scrollSelectionForm : ScrollSelectionForm = this.getMenuForm()
            if not (JR.same(scrollSelectionForm, null)) then
                let mutable formType : FormType = FormTypeFactory.getInstance().getFormType()
                let mutable rectangle : Rectangle = this.formUtil.createFormRectangle()
                scrollSelectionForm.init(rectangle, formType)
            this.overlayPaintable.init()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT, e)
            | _ -> reraise ()
    
    abstract getCustomCommands : unit -> obj[]
    default this.getCustomCommands() : obj[] =
        let mutable jflow = 0
        let mutable jret : obj[] = Unchecked.defaultof<obj[]>
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        if J2MEUtil.isHTML() then
            let mutable commandArray : obj[] = ([| gameCommandsFactory.START_COMMAND; HighScoreCommands.getInstance().DISPLAY; GameInputMappingCanvas.DISPLAY; gameCommandsFactory.DISPLAY_ABOUT |] : obj[])
            jret <- commandArray
            jflow <- 1
        else
            let mutable commandList : BasicArrayList = (new BasicArrayListD())
            ignore (commandList.add(gameCommandsFactory.START_COMMAND))
            let mutable inApplicationPurchaseFactory : InApplicationPurchaseFactory = InApplicationPurchaseFactory.getInstance()
            if inApplicationPurchaseFactory.isEnabled() then
                let mutable list_ : BasicArrayList = LockableFeatureFactory.getInstance().getList()
                if (list_.size() > 0) && (not (inApplicationPurchaseFactory.isPurchased((box (list_.get(0)) :?> LockableFeature)))) then
                    ignore (commandList.add(gameCommandsFactory.BUY_COMMAND))
            ignore (commandList.add(HighScoreCommands.getInstance().DISPLAY))
            try
                let mutable isOverScan : bool = OperatingSystemFactory.getInstance().getOperatingSystemInstance().isOverScan()
                if SWTUtil.isSWT then
                    ignore (commandList.add(GameInputMappingCanvas.DISPLAY))
                elif not (isOverScan) then
                    ignore (commandList.add(gameCommandsFactory.DISPLAY_OPTIONS))
                    ignore (commandList.add(gameCommandsFactory.DISPLAY_LOAD_FORM))
                    ignore (commandList.add(GameInputMappingCanvas.DISPLAY))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    ()
                | _ -> reraise ()
            ignore (commandList.add(gameCommandsFactory.DISPLAY_ABOUT))
            let mutable commandArray : obj[] = commandList.toArray()
            jret <- commandArray
            jflow <- 1
        jret
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        let mutable commandArray : obj[] = this.getCustomCommands()
        let mutable size : int = commandArray.Length
        let mutable index : int = 0
        while index < size do
            this.addCommand((box (commandArray.[index]) :?> Command))
            index <- index + 1
        ignore (CustomGameMenuUtil.add(this))
        this.setCommandListener(cmdListener)
    
    abstract initPostPaint : unit -> unit
    default this.initPostPaint() : unit =
        ()
    
    abstract mediaInit : unit -> unit
    default this.mediaInit() : unit =
        AllBinaryMediaManager.init(EarlySoundsFactory.getInstance())
    
    abstract itemStateChanged : item: LcduiItem -> unit
    default this.itemStateChanged(item: LcduiItem) : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
    
    abstract initMenu : unit -> unit
    default this.initMenu() : unit =
        this.close()
        let mutable commandTextItemArrayFactory : CommandTextItemArrayFactory = DemoLimitedCommandTextItemArrayFactory.getInstance().getCommandTextItemArrayFactory()
        let mutable items : ABCustomItem[] = commandTextItemArrayFactory.getInstance(this.getCommandStack(), this.basicColorFactory.BLACK, this.basicColorFactory.WHITE)
        let mutable formType : FormType = FormTypeFactory.getInstance().getFormType()
        let mutable rectangle : Rectangle = this.formUtil.createFormRectangle()
        PreLogUtil.put((new StringMaker()).append(this.commonLabels.START_LABEL).append(this.displayInfo.ToString()).ToString(), this, "initMenu")
        let mutable scrollSelectionForm : ScrollSelectionForm = CommandCurrentSelectionFormFactory.getInstance(StringUtil.getInstance().EMPTY_STRING, items, rectangle, formType, 15, true, this.basicColorFactory.BLACK, this.basicColorFactory.WHITE)
        this.setMenuForm(scrollSelectionForm)
        let mutable formType2 : FormType = FormTypeFactory.getInstance().getFormType()
        let mutable rectangle2 : Rectangle = this.formUtil.createFormRectangle()
        scrollSelectionForm.init(rectangle2, formType2)
        if not (JR.same(this.getMenuForm(), ScrollSelectionFormNoneFactory.getInstance())) then
            this.setMenuInputProcessor((new CommandFormInputProcessor((new BasicArrayListD()), -1, this, this.getMenuForm())))
        this.open_()
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        BasicMotionGesturesHandler.getInstance().addListenerInterface(this.getMenuInputProcessor())
        GameKeyEventHandler.getInstance().addListener(this.getMenuInputProcessor())
    
    abstract close : unit -> unit
    default this.close() : unit =
        BasicMotionGesturesHandler.getInstance().removeListener(this.getMenuInputProcessor())
        GameKeyEventHandler.getInstance().removeListener(this.getMenuInputProcessor())
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        DemoCanvas.id
    
    override this.keyPressed(keyCode: int) : unit =
        this.keyPressedByDevice(keyCode, 0)
    
    override this.keyReleased(keyCode: int) : unit =
        this.keyReleasedByDevice(keyCode, 0)
    
    override this.keyRepeated(keyCode: int) : unit =
        this.keyRepeatedByDevice(keyCode, 0)
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        this.addGameKeyEvent(keyCode, false)
    
    override this.keyReleasedByDevice(keyCode: int, deviceId: int) : unit =
        this.removeGameKeyEvent(keyCode, false)
    
    override this.keyRepeatedByDevice(keyCode: int, deviceId: int) : unit =
        if this.isSingleKeyRepeatableProcessing then
            this.addGameKeyEvent(keyCode, true)
    
    member this.addGameKeyEvent(keyCode: int, repeated: bool) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this, keyCode)
            if not (JR.same(gameKey, this.NONE)) then
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this, gameKey)
                DownGameKeyEventHandler.getInstance().fireEvent(gameKeyEvent)
            else
                if this.lastKeyNotMapped <> keyCode then
                    this.lastKeyNotMapped <- keyCode
                    this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.ADD_KEY_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()
    
    member this.removeGameKeyEvent(keyCode: int, repeated: bool) : unit =
        try
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this, keyCode)
            if not (JR.same(gameKey, this.NONE)) then
                let mutable gameKeyEvent : GameKeyEvent = this.gameKeyEventFactory.getInstanceForInput(this, gameKey)
                UpGameKeyEventHandler.getInstance().fireEvent(gameKeyEvent)
            else
                this.logUtil.putF((new StringMaker()).append(this.gameInputStrings.NO_KEY).appendint(keyCode).ToString(), this, this.gameInputStrings.REMOVE_KEY_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.REMOVE_KEY_EVENT, e)
            | _ -> reraise ()
    
    override this.pause() : unit =
        this.close()
        this.setPaused(true)
        this.gameRunnable <- NullWaitGameRunnable.getInstance()
        this.gameCanvas.pause()
    
    override this.unPause() : unit =
        this.open_()
        this.gameCanvas.unPause()
        this.gameRunnable <- this.gameCanvas.gameRunnable
        this.setPaused(false)
    
    override this.isPausable() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(CurrentDisplayableFactory.getInstance().getUsedRunnable(), NullWaitGameRunnable.getInstance())) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract isGameOver : unit -> bool
    default this.isGameOver() : bool =
        this.logUtil.putF((new StringMaker()).append(this.commonStrings.NOT_IMPLEMENTED).append(" since not a game").ToString(), this, "isGameOver")
        false
    
    abstract setLoadStateHashtable : hashtable: ABHashtable -> unit
    default this.setLoadStateHashtable(hashtable: ABHashtable) : unit =
        this.logUtil.putF("Trying to continue a demo lol - only continue a game canvas not the demo", this, "setLoadStateHashtable")
    
    abstract getLoadStateHashtable : unit -> ABHashtable
    default this.getLoadStateHashtable() : ABHashtable =
        this.logUtil.putF("Trying to continue a demo lol - only continue a game canvas not the demo", this, "getLoadStateHashtable")
        this.stdUtil.NULL_TABLE
    
    abstract getCurrentStateHashtable : unit -> ABHashtable
    default this.getCurrentStateHashtable() : ABHashtable =
        this.logUtil.putF("Trying to save the AI lol", this, "getCurrentStateHashtable")
        this.stdUtil.NULL_TABLE
    
    abstract setHighScoreSubmitted : isNotUsed: bool -> unit
    default this.setHighScoreSubmitted(isNotUsed: bool) : unit =
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.paintableInterface.paint(graphics)
        this.paintedSpecialAnimationInterface.paintXY(graphics, 0, 0)
        this.highScoresPaintable.paint(graphics)
        this.getBasicGameDemoPaintable().paint(graphics)
        this.overlayPaintable.paint(graphics)
        this.fullscreenPaintable.paint(graphics)
        this.progressPaintable.paint(graphics)
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        this.paintableInterface.paintThreed(graphics)
        this.paintedSpecialAnimationInterface.paintThreedXYZ(graphics, 0, 0, 0)
    
    abstract processGameOver : unit -> unit
    default this.processGameOver() : unit =
        this.logUtil.putF("Not Implemented since not a game", this, "setGameOver")
    
    abstract demoStateChange : unit -> unit
    default this.demoStateChange() : unit =
        let mutable newState : int = this.state + 1
        if newState > 2 then
            newState <- 0
        elif newState = 2 then
            if not (this.highScoresHelper.isAnyHighScores()) then
                newState <- 0
            else
                let mutable highScores : HighScores = this.highScoresHelper.getNextHighScores()
                if (JR.same(highScores, NullHighScoresSingletonFactory.getInstance())) then
                    newState <- 0
                else
                    this.getRealHighScoresPaintable().setHighScores(highScores)
        this.setState(newState)
        this.updateDemoState()
    
    abstract updateDemoState : unit -> unit
    default this.updateDemoState() : unit =
        PreLogUtil.put(SmallIntegerSingletonFactory.getInstance().createInstance(this.state).ToString(), this, this.SET_STATE)
        this.getBasicGameDemoPaintable().setState(this.state)
        if this.state = 0 then
            this.highScoresPaintable <- NullPaintable.getInstance()
            this.paintedSpecialAnimationInterface <- this.getSpecialAnimationInterface()
            if (not (this.demoGameRunnable.isRunning())) && this.gameCanvas.isInitialized() then
                this.getSpecialAnimationInterface().reset()
        elif this.state = 1 then
            this.paintedSpecialAnimationInterface <- SpecialAnimation.getInstance()
        elif this.state = 2 then
            this.highScoresPaintable <- this.getRealHighScoresPaintable()
        let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
        gameAdState.processPageAdState()
    
    abstract getNextRandom : unit -> int
    default this.getNextRandom() : int =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract createGameLayerManager : randomValue: int -> AllBinaryGameLayerManager
    default this.createGameLayerManager(randomValue: int) : AllBinaryGameLayerManager =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract createRunnable : randomLevel: int -> GameCanvasRunnableInterface
    default this.createRunnable(randomLevel: int) : GameCanvasRunnableInterface =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract create : unit -> unit
    default this.create() : unit =
        PreLogUtil.put(this.commonStrings.START, this, "create")
        this.highScoresPaintable <- NullPaintable.getInstance()
        let mutable randomLevel : int = this.getNextRandom()
        this.gameCanvas <- (box (this.createRunnable(randomLevel)) :?> AllBinaryGameCanvas)
        this.basicColor <- this.gameCanvas.getLayerManager().getForegroundBasicColor()
        this.getRealHighScoresPaintable().setBasicColorP(this.basicColor)
        this.gameCanvas.setGameCanvasStartListener(this)
        let mutable gameInfo : GameInfo = this.gameCanvas.getLayerManager().getGameInfo()
        this.getHighScoresFactoryInterface().fetchHighScores(gameInfo, this.highScoresHelper)
    
    abstract start : unit -> unit
    default this.start() : unit =
        let mutable gameCanvas : AllBinaryGameCanvas = this.gameCanvas
        PreLogUtil.put((new StringMaker()).append("Game Thread in DemoCanvas: ").append(this.stringUtil.toString(gameCanvas)).ToString(), this, this.commonStrings.START)
        this.canvasThread <- this.threadFactoryUtil.getInstanceGameCanvasRunnable(gameCanvas)
        this.gameCanvas.setThread(this.canvasThread)
        this.threadFactoryUtil.start(this.canvasThread)
        if this.getWait() = NullWaitGameRunnable.getInstance().WAIT then
            this.setWait(this.getTempWait())
    
    abstract preDemoProcess : unit -> unit
    default this.preDemoProcess() : unit =
        if (not (this.gameCanvas.isInitialized())) || ((JR.sameString(this.gameCanvas.getTitle(), NullGameCanvas.NO_GAME))) then
            if AllBinaryMediaManager.update() then
                if not (PrimaryPlayerQueueFactory.getInstance().process_()) then
                    ignore (SecondaryPlayerQueueFactory.getInstance().process_())
        ignore (this.overlayPaintable.update())
    
    override this.process_() : unit =
        base.process_()
        ignore (this.getMenuInputProcessor().processInputList())
        this.preDemoProcess()
        if this.state = 0 then
            let mutable indexedAnimationBehavior : IndexedAnimationBehavior = ((box (this.getSpecialAnimationInterface().getAnimationBehavior()) :?> IndexedAnimationBehavior))
            if indexedAnimationBehavior.loopIndex < 1 then
                this.timeDelayHelper.setStartTimeTNT()
            let mutable demoGameMidlet : DemoGameMidlet = (box (this.getCustomCommandListener()) :?> DemoGameMidlet)
            if (not (JR.same(this.gameCanvas, NullGameCanvas.getInstance()))) && this.gameCanvas.isGameOver() then
                this.stopGameDemo()
                let mutable randomLevel : int = this.getNextRandom()
                let mutable gameInfo : GameInfo = this.gameCanvas.getLayerManager().getGameInfo()
                gameInfo.setCurrentLevel(randomLevel)
                this.gameCanvas.setGameOver(false)
                this.start()
            elif ((JR.same(this.gameCanvas, NullGameCanvas.getInstance()))) && demoGameMidlet.isReady() then
                if not (this.demoGameRunnable.isRunning()) then
                    this.startDemoGame()
                    this.demoGameRunnable.setRunning(true)
                    let mutable thread : Thread = this.threadFactoryUtil.getInstanceForRunnable(this.demoGameRunnable)
                    this.demoGameRunnable.setThread(thread)
                    this.threadFactoryUtil.start(thread)
    
    member this.startDemoGame() : unit =
        DemoCanvasProgressUtil.showProgress(this)
    
    abstract stopGameDemo : unit -> unit
    default this.stopGameDemo() : unit =
        if not (JR.same(this.gameCanvas, NullGameCanvas.getInstance())) then
            this.logUtil.putF("Set Running False", this, "stopGameDemo")
            this.gameCanvas.setRunning(false)
        ThreadUtil.getInstance().join(this.canvasThread)
    
    abstract showGamePaintable : unit -> unit
    default this.showGamePaintable() : unit =
        let mutable METHOD_NAME : string = "showGamePaintable"
        PreLogUtil.put(this.commonStrings.START, this, METHOD_NAME)
        let mutable isDefault : bool = J2MEUtil.isHTML()
        if ((not (JR.same(this.gameCanvas, NullGameCanvas.getInstance()))) && ((this.gameCanvas.isRunning() || isDefault) || SWTUtil.isSWT)) && (not ((this.gameCanvas.getType() = NullGameCanvas.TYPE))) then
            this.gameRunnable <- this.gameCanvas.gameRunnable
            PreLogUtil.put("Showing Game", this, METHOD_NAME)
            this.setPaintableInterface(this.gameCanvas)
        else
            this.gameRunnable <- NullWaitGameRunnable.getInstance()
            PreLogUtil.put("Not Showing Game", this, METHOD_NAME)
            this.setPaintableInterface(this.getDefaultPaintableInterface())
    
    abstract isReadyForStateChange : unit -> bool
    default this.isReadyForStateChange() : bool =
        (not (this.demoGameRunnable.isRunning())) && this.gameCanvas.isInitialized()
    
    abstract processGame : unit -> unit
    default this.processGame() : unit =
        this.gameRunnable.run()
        if (not (this.specialAnimationInterface.isComplete())) && this.isReadyForStateChange() then
            this.specialAnimationInterface.nextFrame()
        if this.timeDelayHelper.isTimeTNT() && this.isReadyForStateChange() then
            this.demoStateChange()
        else
            this.process_()
    
    override this.run() : unit =
        this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
        try
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            let mutable features : Features = Features.getInstance()
            let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
            progressCanvas.addNormalPortion(50, "Demo Thread")
            this.setCurrentThread()
            this.setRunning(true)
            if features.isFeature(MainFeatureFactory.getInstance().LOAD_ONDEMAND) then
                progressCanvas.end_()
            else
                progressCanvas.addNormalPortion(50, "Demo Thread Running")
            this.fullScreenUtil.initOnRun(this, this.getCustomCommandListener())
            this.initMenu()
            this.initPostPaint()
            this.updateDemoState()
            if features.isDefault(openGLFeatureFactory.OPENGL_AS_GAME_THREAD) then
                while ((JR.same(this.gameCanvas, NullGameCanvas.getInstance()))) || (not (this.gameCanvas.isInitialized())) do
                    this.loopTimeHelper.setStartTimeTNT()
                    this.processGame()
                    this.processLoopSleep()
                let mutable demoGameRunnable : DemoGameRunnable = (new DemoGameRunnable(this))
                let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
                currentDisplayableFactory.setRunnable(demoGameRunnable)
                currentDisplayableFactory.setMyCanvas(this)
                OpenGLThreadUtil.getInstance().onResume()
            if features.isDefault(openGLFeatureFactory.OPENGL_AS_GAME_THREAD) || J2MEUtil.isHTML() then
                let mutable demoGameRunnable : DemoGameRunnable = (new DemoGameRunnable(this))
                let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
                currentDisplayableFactory.setRunnable(demoGameRunnable)
                currentDisplayableFactory.setMyCanvas(this)
            else
                while this.isRunning() do
                    this.run3()
                this.end_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
        this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
    
    abstract run3 : unit -> unit
    default this.run3() : unit =
        this.loopTimeHelper.setStartTimeTNT()
        this.processGame()
        this.processLoopSleep()
    
    override this.setRunning(running: bool) : unit =
        base.setRunning(running)
        try
            let mutable features : Features = Features.getInstance()
            let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
            if running then
                ()
            else
                if (features.isDefault(openGLFeatureFactory.OPENGL) || J2MEUtil.isHTML()) || SWTUtil.isSWT then
                    let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
                    currentDisplayableFactory.clearRunnable()
                    this.end_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.SET_RUNNING, e)
            | _ -> reraise ()
    
    abstract end_ : unit -> unit
    default this.end_() : unit =
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        let mutable features : Features = Features.getInstance()
        ignore (this.baseGameStatistics.add((new StringMaker()).append(DemoCanvas.BOT_GAME_STATS).append(this.baseGameStatistics.ToString()).append(CommonSeps.getInstance().NEW_LINE).ToString()))
        this.baseGameStatistics.init()
        if features.isFeature(MainFeatureFactory.getInstance().LOAD_ONDEMAND) then
            progressCanvas.start()
        this.logUtil.putF("Demo End", this, this.commonStrings.RUN)
        this.close()
        DisplayChangeEventHandler.getInstance().removeListener(this)
        this.stopGameDemo()
    
    abstract setGameState : gameState: GameState -> unit
    default this.setGameState(gameState: GameState) : unit =
        ()
    
    abstract getGameState : unit -> GameState
    default this.getGameState() : GameState =
        this.gameStateFactory.PLAYING_GAME_STATE
    
    abstract getGameCanvasRunnableInterface : unit -> AllBinaryGameCanvas
    default this.getGameCanvasRunnableInterface() : AllBinaryGameCanvas =
        this.gameCanvas
    
    abstract isDemoLoading : unit -> bool
    default this.isDemoLoading() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable gameCanvas : AllBinaryGameCanvas = this.gameCanvas
        if (JR.same(gameCanvas, NullGameCanvas.getInstance())) then
            jret <- true
            jflow <- 1
        elif gameCanvas.isInitialized() then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract getState : unit -> int
    default this.getState() : int =
        this.state
    
    abstract setState : state: int -> unit
    default this.setState(state: int) : unit =
        this.state <- state
    
    abstract isHighScoreSubmitted : unit -> bool
    default this.isHighScoreSubmitted() : bool =
        this.logUtil.putF("Wow the AI got a high score!", this, "isHighScoreSubmitted")
        false
    
    abstract getRealHighScoresPaintable : unit -> HighScoresPaintable
    default this.getRealHighScoresPaintable() : HighScoresPaintable =
        this.realHighScoresPaintable
    
    abstract setSpecialAnimationInterface : specialAnimationInterface: SpecialAnimation -> unit
    default this.setSpecialAnimationInterface(specialAnimationInterface: SpecialAnimation) : unit =
        specialAnimationInterface.setFrame(0)
        this.specialAnimationInterface <- specialAnimationInterface
    
    abstract getSpecialAnimationInterface : unit -> SpecialAnimation
    default this.getSpecialAnimationInterface() : SpecialAnimation =
        this.specialAnimationInterface
    
    abstract setPaintableInterface : paintableInterface: PaintableInterface -> unit
    default this.setPaintableInterface(paintableInterface: PaintableInterface) : unit =
        this.paintableInterface <- paintableInterface
    
    abstract getPaintableInterface : unit -> PaintableInterface
    default this.getPaintableInterface() : PaintableInterface =
        this.paintableInterface
    
    abstract setDefaultPaintableInterface : defaultPaintableInterface: Paintable -> unit
    default this.setDefaultPaintableInterface(defaultPaintableInterface: Paintable) : unit =
        this.defaultPaintableInterface <- defaultPaintableInterface
    
    abstract getDefaultPaintableInterface : unit -> Paintable
    default this.getDefaultPaintableInterface() : Paintable =
        this.defaultPaintableInterface
    
    abstract getHighScoresFactoryInterface : unit -> HighScoresFactoryInterface
    default this.getHighScoresFactoryInterface() : HighScoresFactoryInterface =
        this.highScoresFactoryInterface
    
    abstract setMenuInputProcessor : menuInputProcessor: BasicMenuInputProcessor -> unit
    default this.setMenuInputProcessor(menuInputProcessor: BasicMenuInputProcessor) : unit =
        this.menuInputProcessor <- menuInputProcessor
    
    abstract getMenuInputProcessor : unit -> BasicMenuInputProcessor
    default this.getMenuInputProcessor() : BasicMenuInputProcessor =
        this.menuInputProcessor
    
    abstract getMenuForm : unit -> ScrollSelectionForm
    default this.getMenuForm() : ScrollSelectionForm =
        this.menuForm
    
    abstract setMenuForm : menuForm: ScrollSelectionForm -> unit
    default this.setMenuForm(menuForm: ScrollSelectionForm) : unit =
        this.menuForm <- menuForm
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    
    abstract getOverlayPaintable : unit -> Paintable
    default this.getOverlayPaintable() : Paintable =
        this.overlayPaintable
    
    abstract setBasicGameDemoPaintable : basicGameDemoPaintable: StatePaintable -> unit
    default this.setBasicGameDemoPaintable(basicGameDemoPaintable: StatePaintable) : unit =
        this.basicGameDemoPaintable <- basicGameDemoPaintable
    
    abstract getBasicGameDemoPaintable : unit -> StatePaintable
    default this.getBasicGameDemoPaintable() : StatePaintable =
        this.basicGameDemoPaintable
    
    abstract setTempWait : tempWait: int -> unit
    default this.setTempWait(tempWait: int) : unit =
        this.tempWait <- tempWait
    
    abstract getTempWait : unit -> int
    default this.getTempWait() : int =
        this.tempWait
    
    override this.isSingleThread() : bool =
        OpenGLFeatureUtil.getInstance().isAnyThreed() || SWTUtil.isSWT
    
    abstract isRunningInAnotherThread : unit -> bool
    default this.isRunningInAnotherThread() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable features : Features = Features.getInstance()
        let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
        if features.isDefault(openGLFeatureFactory.OPENGL_AS_GAME_THREAD) then
            jret <- true
            jflow <- 1
        else
            jret <- this.isRunning()
            jflow <- 1
        jret
    
    abstract getGameInitializationInterfaceFactoryInterface : unit -> BasicBuildGameInitializerFactory
    default this.getGameInitializationInterfaceFactoryInterface() : BasicBuildGameInitializerFactory =
        this.gameInitializationInterfaceFactoryInterface
    
    override this.getType() : int =
        DemoCanvas.TYPE
    
    override this.getTitle() : string =
        base.getTitle()
    
    override this.isPaused() : bool =
        base.isPaused()
    interface GameCanvasRunnableInterface with
        member this.getTitle() : string = this.getTitle()
        member this.isInitialized() : bool = this.isInitialized()
        member this.isPaused() : bool = this.isPaused()
        member this.unPause() : unit = this.unPause()
        member this.pause() : unit = this.pause()
        member this.isHighScoreSubmitted() : bool = this.isHighScoreSubmitted()
        member this.setHighScoreSubmitted(jp0: bool) : unit = this.setHighScoreSubmitted(jp0)
        member this.processGameOver() : unit = this.processGameOver()
        member this.isGameOver() : bool = this.isGameOver()
        member this.initCommands(jp0: CommandListener) : unit = this.initCommands(jp0)
        member this.getCurrentStateHashtable() : ABHashtable = this.getCurrentStateHashtable()
        member this.getLoadStateHashtable() : ABHashtable = this.getLoadStateHashtable()
        member this.setLoadStateHashtable(jp0: ABHashtable) : unit = this.setLoadStateHashtable(jp0)
        member this.getType() : int = this.getType()
    interface MenuListener with
        member this.open_() : unit = this.open_()
        member this.close() : unit = this.close()
    interface DisplayChangeEventListener with
        member this.onDisplayChangeEvent(jp0: DisplayChangeEvent) : unit = this.onDisplayChangeEvent(jp0)
    interface DemoPaintableInterface with
        member this.showGamePaintable() : unit = this.showGamePaintable()
    interface RunnableInterface with
        member this.isRunning() : bool = this.isRunning()
        member this.setRunning(jp0: bool) : unit = this.setRunning(jp0)
        member this.setThread(jp0: Thread) : unit = this.setThread(jp0)
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface ItemStateListener with
        member this.itemStateChanged(jp0: LcduiItem) : unit = this.itemStateChanged(jp0)
    interface GameStateCompositeInterface with
        member this.setGameState(jp0: GameState) : unit = this.setGameState(jp0)
        member this.getGameState() : GameState = this.getGameState()
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)
    interface Runnable with
        member this.run() : unit = this.run()


