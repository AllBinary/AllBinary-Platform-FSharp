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
type StartCanvas =
    inherit RunnableCanvas
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable features : Features
    [<DefaultValue(false)>] val mutable openGLFeatureFactory : OpenGLFeatureFactory
    [<DefaultValue(false)>] val mutable myCommandsFactory : MyCommandsFactory
    [<DefaultValue(false)>] val mutable gameAdStateFactory : GameAdStateFactory
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] val mutable formUtil : FormUtil
    [<DefaultValue(false)>] val mutable basicGameDemoPaintable : StatePaintable
    [<DefaultValue(false)>] val mutable specialAnimationInterface : SpecialAnimation
    [<DefaultValue(false)>] val mutable paintedSpecialAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable fullScreenUtil : FullScreenUtil
    [<DefaultValue(false)>] val mutable highScoresHelper : HighScoresHelper
    [<DefaultValue(false)>] val mutable realHighScoresPaintable : HighScoresPaintable
    [<DefaultValue(false)>] val mutable highScoresPaintable : Paintable
    [<DefaultValue(false)>] val mutable state : int
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable highScoresFactoryInterface : HighScoresFactoryInterface
    [<DefaultValue(false)>] val mutable menuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable menuForm : ScrollSelectionForm
    [<DefaultValue(false)>] val mutable gameInitializationInterfaceFactoryInterface : BasicBuildGameInitializerFactory
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] val mutable defaultPaintableInterface : Paintable
    [<DefaultValue(false)>] val mutable paintableInterface : PaintableInterface
    [<DefaultValue(false)>] val mutable overlayPaintable : InitUpdatePaintable
    [<DefaultValue(false)>] val mutable tempWait : int
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] val mutable gameRunnable : GameRunnable
    [<DefaultValue(false)>] val mutable progressPaintable : PaintableInterface
    [<DefaultValue(false)>] val mutable isSingleKeyRepeatableProcessing : bool
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable SET_STATE : string
    [<DefaultValue(false)>] val mutable baseGameStatistics : BaseGameStatistics
    static member id : int = 0
    static member BOT_GAME_STATS : string = "Bot Game Statistics: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StartCanvas.jclinitDone then
            StartCanvas.jclinitDone <- true
            StartCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_StartCanvas() : unit =
        this.basicColorFactory <- BasicColorFactory.getInstance()
        this.features <- Features.getInstance()
        this.openGLFeatureFactory <- OpenGLFeatureFactory.getInstance()
        this.myCommandsFactory <- MyCommandsFactory.getInstance()
        this.gameAdStateFactory <- GameAdStateFactory.getInstance()
        this.gameStateFactory <- GameStateFactory.getInstance()
        this.gameInputStrings <- GameInputStrings.getInstance()
        this.formUtil <- FormUtil.getInstance()
        this.basicGameDemoPaintable <- StatePaintableFactory.getInstance()
        this.specialAnimationInterface <- SpecialAnimation.getInstance()
        this.paintedSpecialAnimationInterface <- SpecialAnimation.getInstance()
        this.fullScreenUtil <- FullScreenUtil.getInstance()
        this.highScoresHelper <- (new HighScoresHelper())
        this.realHighScoresPaintable <- (new HighScoresPaintable())
        this.highScoresPaintable <- NullPaintable.getInstance()
        this.state <- 0
        this.timeDelayHelper <- (new TimeDelayHelper(6000))
        this.menuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.menuForm <- ScrollSelectionForm.getNullScrollSelectionForm()
        this.defaultPaintableInterface <- NullPaintable.getInstance()
        this.paintableInterface <- NullPaintable.getInstance()
        this.tempWait <- NullWaitGameRunnable.getInstance().WAIT
        this.inputToGameKeyMapping <- PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping()
        this.gameRunnable <- NullWaitGameRunnable.getInstance()
        this.progressPaintable <- ProgressCanvasFactory.getLazyInstance()
        this.isSingleKeyRepeatableProcessing <- this.features.isFeature(InputFeatureFactory.getInstance().SINGLE_KEY_REPEAT_PRESS)
        this.NONE <- GameKeyFactory.getInstance().NONE
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.SET_STATE <- "setState"
        this.baseGameStatistics <- GameStatisticsFactory.getInstance()
        ()
    
    new (abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, highScoresFactoryInterface: HighScoresFactoryInterface, paintable: Paintable, overlayPaintable: InitUpdatePaintable, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, isContinue: bool) as this =
        { inherit RunnableCanvas(commandListener, CurrentDisplayableFactory.getInstance().DEFAULT_CHILD_NAME_LIST, true) }
        then
            this.jfields_StartCanvas()
            this.jctor1(abeClientInformation, commandListener, highScoresFactoryInterface, paintable, overlayPaintable, gameInitializationInterfaceFactoryInterface, isContinue)
    member this.jctor1(abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, highScoresFactoryInterface: HighScoresFactoryInterface, paintable: Paintable, overlayPaintable: InitUpdatePaintable, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, isContinue: bool) : unit =
        ()
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
        DisplayChangeEventHandler.getInstance().addListenerInterface(this)
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onDisplayChangeEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        try
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
        StartCanvas.id
    
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
    
    override this.unPause() : unit =
        this.open_()
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
    
    abstract createCanvas : unit -> unit
    default this.createCanvas() : unit =
        this.highScoresPaintable <- NullPaintable.getInstance()
        let mutable randomLevel : int = this.getNextRandom()
        ()
    
    abstract start : unit -> unit
    default this.start() : unit =
        ()
    
    abstract preDemoProcess : unit -> unit
    default this.preDemoProcess() : unit =
        ignore (this.overlayPaintable.update())
    
    override this.process_() : unit =
        ignore (this.getMenuInputProcessor().processInputList())
        this.preDemoProcess()
        if this.state = 0 then
            let mutable indexedAnimationBehavior : IndexedAnimationBehavior = (box (this.getSpecialAnimationInterface().getAnimationBehavior()) :?> IndexedAnimationBehavior)
            if indexedAnimationBehavior.loopIndex < 1 then
                this.timeDelayHelper.setStartTimeTNT()
            let mutable demoGameMidlet : DemoGameMidlet = (box (this.getCustomCommandListener()) :?> DemoGameMidlet)
            ()
    
    member this.startDemoGame() : unit =
        ()
    
    abstract processGame : unit -> unit
    default this.processGame() : unit =
        this.gameRunnable.run()
        this.specialAnimationInterface.nextFrame()
        this.process_()
    
    override this.run() : unit =
        this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
        try
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            progressCanvas.addNormalPortion(50, "Demo Thread")
            this.setCurrentThread()
            this.setRunning(true)
            if this.features.isFeature(MainFeatureFactory.getInstance().LOAD_ONDEMAND) then
                progressCanvas.end_()
            else
                progressCanvas.addNormalPortion(50, "Demo Thread Running")
            this.fullScreenUtil.initOnRun(this, this.getCustomCommandListener())
            this.initMenu()
            this.initPostPaint()
            this.updateDemoState()
            if this.features.isDefault(this.openGLFeatureFactory.OPENGL_AS_GAME_THREAD) then
                OpenGLThreadUtil.getInstance().onResume()
            if this.features.isDefault(this.openGLFeatureFactory.OPENGL_AS_GAME_THREAD) || J2MEUtil.isHTML() then
                ()
            else
                while this.isRunning() do
                    this.loopTimeHelper.setStartTimeTNT()
                    this.processGame()
                    this.processLoopSleep()
                this.end_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
        this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
    
    override this.setRunning(running: bool) : unit =
        base.setRunning(running)
        try
            if (this.features.isDefault(this.openGLFeatureFactory.OPENGL) || J2MEUtil.isHTML()) && (not (running)) then
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
        ignore (this.baseGameStatistics.add((new StringMaker()).append(StartCanvas.BOT_GAME_STATS).append(this.baseGameStatistics.ToString()).append(CommonSeps.getInstance().NEW_LINE).ToString()))
        this.baseGameStatistics.init()
        if this.features.isFeature(MainFeatureFactory.getInstance().LOAD_ONDEMAND) then
            progressCanvas.start()
        this.logUtil.putF("Demo End", this, this.commonStrings.RUN)
        this.close()
        DisplayChangeEventHandler.getInstance().removeListener(this)
    
    abstract setGameState : gameState: GameState -> unit
    default this.setGameState(gameState: GameState) : unit =
        ()
    
    abstract getGameState : unit -> GameState
    default this.getGameState() : GameState =
        this.gameStateFactory.PLAYING_GAME_STATE
    
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
    
    override this.getTitle() : string =
        base.getTitle()
    
    override this.isPaused() : bool =
        base.isPaused()
    
    override this.getType() : int =
        base.getType()
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


