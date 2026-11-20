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
type AllBinaryGameCanvas =
    inherit RunnableCanvas
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable touchFeatureFactory : TouchFeatureFactory
    [<DefaultValue(false)>] val mutable openGLFeatureFactory : OpenGLFeatureFactory
    [<DefaultValue(false)>] val mutable touchButtonFactory : TouchButtonFactory
    [<DefaultValue(false)>] val mutable gameAdStateFactory : GameAdStateFactory
    [<DefaultValue(false)>] val mutable gameStrings : GameStrings
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] val mutable gameTickDisplayInfoSingleton : GameTickDisplayInfoSingleton
    [<DefaultValue(false)>] val mutable gameRunnable : GameCanvasRunnable
    [<DefaultValue(false)>] val mutable gamePauseRunnable : GameCanvasPauseRunnable
    [<DefaultValue(false)>] val mutable formUtil : FormUtil
    [<DefaultValue(false)>] val mutable myFormUtil : MyFormUtil
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable gameSpecificPaintable : Paintable
    [<DefaultValue(false)>] val mutable sensorGameUpdateProcessor : SensorGameUpdateProcessor
    [<DefaultValue(false)>] val mutable endGameInfo : EndGameInfo
    [<DefaultValue(false)>] val mutable startIntermissionInterface : IntermissionInterface
    [<DefaultValue(false)>] val mutable endLevelIntermissionInterface : IntermissionInterface
    [<DefaultValue(false)>] val mutable gameLayerManager : AllBinaryGameLayerManager
    [<DefaultValue(false)>] val mutable gameState : GameState
    [<DefaultValue(false)>] val mutable gameOver : bool
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] val mutable gameStateTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable highScoresHelper : HighScoresHelperBaseInterface
    [<DefaultValue(false)>] val mutable highScoreSubmitted : bool
    [<DefaultValue(false)>] val mutable realHighScoresPaintable : HighScoresPaintable
    [<DefaultValue(false)>] val mutable highScoresPaintable : Paintable
    [<DefaultValue(false)>] val mutable localPlayerGameInputList : BasicArrayList
    [<DefaultValue(false)>] val mutable isCheating : bool
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable isSingleKeyRepeatableProcessing : bool
    [<DefaultValue(false)>] val mutable gameInitializationInterfaceFactoryInterface : BasicBuildGameInitializerFactory
    [<DefaultValue(false)>] val mutable touchButtonsPaintable : Paintable
    [<DefaultValue(false)>] val mutable touchPaintable : Paintable
    [<DefaultValue(false)>] val mutable cheatProcessor : PlayerGameInput
    [<DefaultValue(false)>] val mutable gameInputProcessor : Processor
    [<DefaultValue(false)>] val mutable endGameProcessor : Processor
    [<DefaultValue(false)>] val mutable realEndGameProcessor : Processor
    [<DefaultValue(false)>] val mutable startIntermissionProcessor : Processor
    [<DefaultValue(false)>] val mutable realStartIntermissionProcessor : Processor
    [<DefaultValue(false)>] val mutable endGamePaintable : Paintable
    [<DefaultValue(false)>] val mutable endGameStatePaintable : Paintable
    [<DefaultValue(false)>] val mutable nonBotPaintable : Paintable
    [<DefaultValue(false)>] val mutable intermissionPaintable : Paintable
    [<DefaultValue(false)>] val mutable startIntermissionPaintable : InitUpdatePaintable
    [<DefaultValue(false)>] val mutable mainStateProcessor : Processor
    [<DefaultValue(false)>] val mutable processGameProcessor : Processor
    [<DefaultValue(false)>] val mutable highScoresFactoryInterface : HighScoresFactoryInterface
    [<DefaultValue(false)>] val mutable startLevel : int
    [<DefaultValue(false)>] val mutable mainMenuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable popupMenuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable menuInputProcessor : BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable menuForm : ScrollSelectionForm
    [<DefaultValue(false)>] val mutable formPaintable : Paintable
    [<DefaultValue(false)>] val mutable openMenuPaintable : Paintable
    [<DefaultValue(false)>] val mutable menuPaintable : Paintable
    [<DefaultValue(false)>] val mutable currentTouchInputFactory : BaseTouchInput
    [<DefaultValue(false)>] val mutable colorFillPaintable : ColorFillBasePaintable
    [<DefaultValue(false)>] val mutable baseGameStatistics : BaseGameStatistics
    [<DefaultValue(false)>] val mutable primaryPlayerQueue : PlayerQueue
    [<DefaultValue(false)>] val mutable secondaryPlayerQueue : PlayerQueue
    [<DefaultValue(false)>] val mutable BUILD_GAME : string
    [<DefaultValue(false)>] val mutable gameTypeFactory : GameTypeFactory
    [<DefaultValue(false)>] val mutable screenCapture : ScreenCapture
    [<DefaultValue(false)>] val mutable basicMotionGesturesHandler : BasicMotionGesturesHandler
    [<DefaultValue(false)>] val mutable gameKeyEventHandler : GameKeyEventHandler
    [<DefaultValue(false)>] val mutable gameBehavior : DemoGameBehavior
    [<DefaultValue(false)>] val mutable menuBehavior : BaseMenuBehavior
    [<DefaultValue(false)>] val mutable progressPaintable : PaintableInterface
    [<DefaultValue(false)>] val mutable fontHeightP : int
    [<DefaultValue(false)>] val mutable gameCanvasStartListener : DemoPaintableInterface
    [<DefaultValue(false)>] val mutable rawGameInputProcessor : InputProcessor
    [<DefaultValue(false)>] val mutable rawInputProcessor : InputProcessor
    [<DefaultValue(false)>] val mutable inputProcessor : InputProcessor
    [<DefaultValue(false)>] val mutable YIELD_SLEEP : int64
    static member id : int = 0
    static member TYPE : int = 2
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryGameCanvas.jclinitDone then
            AllBinaryGameCanvas.jclinitDone <- true
            AllBinaryGameCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AllBinaryGameCanvas() : unit =
        this.basicColorFactory <- BasicColorFactory.getInstance()
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.touchFeatureFactory <- TouchFeatureFactory.getInstance()
        this.openGLFeatureFactory <- OpenGLFeatureFactory.getInstance()
        this.touchButtonFactory <- TouchButtonFactory.getInstance()
        this.gameAdStateFactory <- GameAdStateFactory.getInstance()
        this.gameStrings <- GameStrings.getInstance()
        this.gameInputStrings <- GameInputStrings.getInstance()
        this.gameStateFactory <- GameStateFactory.getInstance()
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        this.gameTickDisplayInfoSingleton <- GameTickDisplayInfoSingleton.getInstance()
        this.gameRunnable <- (new GameCanvasRunnable(this))
        this.gamePauseRunnable <- (new GameCanvasPauseRunnable(this))
        this.formUtil <- FormUtil.getInstance()
        this.myFormUtil <- MyFormUtil.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.gameSpecificPaintable <- NullPaintable.getInstance()
        this.sensorGameUpdateProcessor <- (new SingleSensorGameUpdateProcessor())
        this.endGameInfo <- (new EndGameInfo())
        this.startIntermissionInterface <- (new Intermission())
        this.endLevelIntermissionInterface <- (new Intermission())
        this.gameLayerManager <- AllBinaryGameLayerManager.getNullInstance()
        this.gameState <- this.gameStateFactory.NO_GAME_STATE
        this.gameStateTimeHelper <- (new TimeDelayHelper(0))
        this.realHighScoresPaintable <- (new HighScoresPaintable())
        this.highScoresPaintable <- NullPaintable.getInstance()
        this.localPlayerGameInputList <- (new BasicArrayListD())
        this.hashtable <- this.stdUtil.NULL_TABLE
        this.gameInitializationInterfaceFactoryInterface <- BasicBuildGameInitializerFactory.NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY
        this.touchButtonsPaintable <- NullPaintable.getInstance()
        this.touchPaintable <- NullPaintable.getInstance()
        this.cheatProcessor <- NoPlayerGameInput.getInstance()
        this.gameInputProcessor <- Processor.getInstance()
        this.endGameProcessor <- Processor.getInstance()
        this.realEndGameProcessor <- Processor.getInstance()
        this.startIntermissionProcessor <- Processor.getInstance()
        this.realStartIntermissionProcessor <- Processor.getInstance()
        this.endGamePaintable <- NullPaintable.getInstance()
        this.endGameStatePaintable <- NullPaintable.getInstance()
        this.nonBotPaintable <- NullPaintable.getInstance()
        this.intermissionPaintable <- NullPaintable.getInstance()
        this.startIntermissionPaintable <- NullInitUpdatePaintable.getInstance()
        this.mainStateProcessor <- Processor.getInstance()
        this.processGameProcessor <- Processor.getInstance()
        this.mainMenuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.popupMenuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.menuInputProcessor <- NoMenuInputProcessor.getInstance()
        this.menuForm <- ScrollSelectionForm.getNullScrollSelectionForm()
        this.formPaintable <- NullPaintable.getInstance()
        this.openMenuPaintable <- NullPaintable.getInstance()
        this.menuPaintable <- NullPaintable.getInstance()
        this.currentTouchInputFactory <- NoButtonsTouchInputFactory.getInstance()
        this.colorFillPaintable <- ColorFillPaintableFactory.getInstance_jstatic().getInstance(this.basicColorFactory.BLACK, true)
        this.baseGameStatistics <- GameStatisticsFactory.getInstance()
        this.primaryPlayerQueue <- PrimaryPlayerQueueFactory.getInstance()
        this.secondaryPlayerQueue <- SecondaryPlayerQueueFactory.getInstance()
        this.BUILD_GAME <- "buildGame"
        this.gameTypeFactory <- GameTypeFactory.getInstance()
        this.screenCapture <- ScreenCaptureFactory.getInstance()
        this.basicMotionGesturesHandler <- BasicMotionGesturesHandler.getInstance()
        this.gameKeyEventHandler <- GameKeyEventHandler.getInstance()
        this.progressPaintable <- ProgressCanvasFactory.getLazyInstance()
        this.gameCanvasStartListener <- NullDemoPaintable.NULL_DEMO_PAINTABLE
        this.rawGameInputProcessor <- (new GameCanvasInputProcessor(this))
        this.rawInputProcessor <- (new FormInputProcessor(this))
        this.inputProcessor <- this.getRawGameInputProcessor()
        this.YIELD_SLEEP <- 100L
        ()
    
    new (commandListener: CommandListener, gameLayerManager: AllBinaryGameLayerManager, highScoresFactoryInterface: HighScoresFactoryInterface, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, buffered: bool) as this =
        { inherit RunnableCanvas(commandListener, CanvasStrings.getInstance().EMPTY_CHILD_NAME_LIST, true) }
        then
            this.jfields_AllBinaryGameCanvas()
            this.jctor1(commandListener, gameLayerManager, highScoresFactoryInterface, gameInitializationInterfaceFactoryInterface, buffered)
    member this.jctor1(commandListener: CommandListener, gameLayerManager: AllBinaryGameLayerManager, highScoresFactoryInterface: HighScoresFactoryInterface, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, buffered: bool) : unit =
        ()
        this.highScoresHelper <- highScoresFactoryInterface.createHighScoresHelper()
        this.gameInitializationInterfaceFactoryInterface <- gameInitializationInterfaceFactoryInterface
        this.init(gameLayerManager, buffered)
        this.highScoresFactoryInterface <- highScoresFactoryInterface
        if ((JR.same(this.gameLayerManager.getGameInfo().getGameType(), this.gameTypeFactory.BOT))) || ((JR.same(this.gameLayerManager.getGameInfo().getGameType(), this.gameTypeFactory.NONE))) then
            this.gameBehavior <- DemoGameBehavior.getInstance()
            this.menuBehavior <- BaseMenuBehavior.getInstance()
        else
            this.gameBehavior <- BaseGameBehavior.getInstance()
            this.menuBehavior <- this.getInGameMenuBehavior()
        this.initPopupMenu()
        this.initMenu()
        this.initSpecialPaint()
        DisplayChangeEventHandler.getInstance().addListenerInterface(this)
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        try
            let mutable font : Font = graphics.getFont()
            this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(this.canvasStrings.FD_WIDTH).appendint(MyFontProcessor.defaultCharWidth(font)).append(this.canvasStrings.FD_HEIGHT).appendint(font.getHeight()).ToString(), this, this.canvasStrings.UPDATE_MEASUREMENT)
            this.fontHeightP <- font.getHeight()
            this.myFormUtil.updateMeasurement(graphics)
            let mutable popupMenuRectangle : Rectangle = this.myFormUtil.getPopupMenuRectangle()
            let mutable basicPopupMenuPaintable : BasicPopupMenuPaintable = ((box (this.getOpenMenuPaintable()) :?> BasicPopupMenuPaintable))
            basicPopupMenuPaintable.init(popupMenuRectangle)
            if not (JR.same(this.getPopupMenuInputProcessor(), NoMenuInputProcessor.getInstance())) then
                let mutable popupMenuInputProcessor : PopupMenuInputProcessor = ((box (this.getPopupMenuInputProcessor()) :?> PopupMenuInputProcessor))
                popupMenuInputProcessor.init(popupMenuRectangle)
            this.myFontProcessor <- MyFontProcessor.getInstance()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT, e)
            | _ -> reraise ()
    
    abstract getInGameMenuBehavior : unit -> BaseMenuBehavior
    default this.getInGameMenuBehavior() : BaseMenuBehavior =
        InGameMenuBehavior.getInstance()
    
    override this.setCurrentThread() : unit =
        if J2MEUtil.isHTML() then
            base.setCurrentThreadFake()
        else
            base.setCurrentThread()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onDisplayChangeEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        try
            this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(DisplayInfoSingleton.getInstance().ToString()).ToString(), this, this.canvasStrings.UPDATE_MEASUREMENT)
            this.myFontProcessor <- this.updateMyFontProcessor
            this.menuBehavior.onDisplayChangeEvent(this, displayChangeEvent)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT, e)
            | _ -> reraise ()
    
    abstract updateMenuFromEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.updateMenuFromEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        let mutable formType : FormType = FormTypeFactory.getInstance().getFormType()
        let mutable rectangle : Rectangle = this.formUtil.createFormRectangle()
        this.menuForm.init(rectangle, formType)
        if not (JR.same(this.currentTouchInputFactory, NoButtonsTouchInputFactory.getInstance())) then
            this.touchButtonFactory.toggle(this.isPaused(), this.currentTouchInputFactory.getList())
        this.myFontProcessor <- this.updateMyFontProcessor
    
    override this.processSleep() : unit =
        base.processSleep()
        if AllBinaryMediaManager.update() then
            if not (this.primaryPlayerQueue.process_()) then
                ignore (this.secondaryPlayerQueue.process_())
        if this.menuInputProcessor.processInputList() <> (-1) then
            ignore (this.runnableCanvasRefreshHelper.process_())
    
    abstract initPopupMenu : unit -> unit
    default this.initPopupMenu() : unit =
        if (JR.same(this.popupMenuInputProcessor, NoMenuInputProcessor.getInstance())) then
            let mutable features : Features = Features.getInstance()
            let mutable popupMenuRectangle : Rectangle = this.myFormUtil.getPopupMenuRectangle()
            if features.isFeature(this.touchFeatureFactory.TOUCH_ENABLED) then
                this.setOpenMenuPaintable((new BasicPopupMenuPaintable(popupMenuRectangle, this.gameLayerManager.getBackgroundBasicColor(), this.gameLayerManager.getForegroundBasicColor())))
                this.setPopupMenuInputProcessor((new PopupMenuInputProcessor((new BasicArrayListD()), -1, this, popupMenuRectangle)))
        else
            ()
    
    abstract initMenu : unit -> unit
    default this.initMenu() : unit =
        try
            this.menuBehavior.initMenu(this)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "initMenu", e)
            | _ -> reraise ()
    
    abstract initMenu2 : unit -> unit
    default this.initMenu2() : unit =
        this.closeMenu()
        let mutable formType : FormType = FormTypeFactory.getInstance().getFormType()
        let mutable gameLimitedCommandTextItemArrayFactory : GameLimitedCommandTextItemArrayFactory = GameLimitedCommandTextItemArrayFactory.getInstance()
        let mutable commandTextItemArrayFactory : CommandTextItemArrayFactory = gameLimitedCommandTextItemArrayFactory.getCommandTextItemArrayFactory()
        let mutable items : ABCustomItem[] = commandTextItemArrayFactory.getInstance(this.getCommandStack(), this.gameLayerManager.getBackgroundBasicColor(), this.gameLayerManager.getForegroundBasicColor())
        let mutable rectangle : Rectangle = this.formUtil.createFormRectangle()
        this.setMenuForm(CommandCurrentSelectionFormFactory.getInstance(StringUtil.getInstance().EMPTY_STRING, items, rectangle, formType, 25, false, this.gameLayerManager.getBackgroundBasicColor(), this.gameLayerManager.getForegroundBasicColor()))
        let mutable scrollSelectionForm : ScrollSelectionForm = this.getMenuForm()
        let mutable features : Features = Features.getInstance()
        if features.isFeature(this.touchFeatureFactory.TOUCH_ENABLED) then
            this.mainMenuInputProcessor <- (new PopupCommandFormInputProcessor((new BasicArrayListD()), -1, this, scrollSelectionForm, (box (this.getPopupMenuInputProcessor()) :?> PopupMenuInputProcessor)))
        else
            ()
        this.setMenuInputProcessor(this.getPopupMenuInputProcessor())
        if not (JR.same(scrollSelectionForm, ScrollSelectionFormNoneFactory.getInstance())) then
            this.setFormPaintable((new FormPaintable(scrollSelectionForm)))
        else
            ()
        this.closeMenu()
    
    abstract updateMenu : unit -> unit
    default this.updateMenu() : unit =
        try
            this.menuBehavior.updateMenu(this)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "initMenu", e)
            | _ -> reraise ()
    
    abstract updateMenu2 : unit -> unit
    default this.updateMenu2() : unit =
        let mutable scrollSelectionForm : ScrollSelectionForm = this.getMenuForm()
        scrollSelectionForm.deleteAll()
        let mutable gameLimitedCommandTextItemArrayFactory : GameLimitedCommandTextItemArrayFactory = GameLimitedCommandTextItemArrayFactory.getInstance()
        let mutable commandTextItemArrayFactory : CommandTextItemArrayFactory = gameLimitedCommandTextItemArrayFactory.getCommandTextItemArrayFactory()
        let mutable items : ABCustomItem[] = commandTextItemArrayFactory.getInstance(this.getCommandStack(), this.gameLayerManager.getBackgroundBasicColor(), this.gameLayerManager.getForegroundBasicColor())
        let mutable size : int = items.Length
        let mutable index : int = 0
        while index < size do
            ignore (scrollSelectionForm.append(items.[index]))
            index <- index + 1
        let mutable formType : FormType = FormTypeFactory.getInstance().getFormType()
        let mutable rectangle : Rectangle = this.formUtil.createFormRectangle()
        scrollSelectionForm.init(rectangle, formType)
    
    override this.pause() : unit =
        this.gameBehavior.pause(this)
        this.closeMenu()
        base.pause()
        this.touchButtonFactory.toggle(this.isPaused(), BasicArrayListUtil.getInstance().getImmutableInstance())
        this.tsUtil.gc()
    
    override this.unPause() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.gameStrings.UNPAUSE)
        this.closeMenu()
        this.tsUtil.gc()
        base.unPause()
        this.touchButtonFactory.toggle(this.isPaused(), BasicArrayListUtil.getInstance().getImmutableInstance())
        this.gameBehavior.unPause(this)
    
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
    
    abstract popupMenu : unit -> unit
    default this.popupMenu() : unit =
        this.menuBehavior.popupMenu(this)
    
    abstract popupMenu2 : unit -> unit
    default this.popupMenu2() : unit =
        ignore (this.primaryPlayerQueue.add(SelectSound.getInstance()))
        this.setMenuPaintable(this.getFormPaintable())
        this.setMenuInputProcessor(this.mainMenuInputProcessor)
        this.basicMotionGesturesHandler.addListenerInterface(this.mainMenuInputProcessor)
        this.gameKeyEventHandler.addListener(this.mainMenuInputProcessor)
    
    abstract toggleMenu : unit -> unit
    default this.toggleMenu() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.gameStrings.TOGGLE_MENU)
        if (JR.same(this.getMenuPaintable(), this.getOpenMenuPaintable())) then
            this.pause()
            this.updateMenu()
            this.popupMenu()
        elif (JR.same(this.getMenuPaintable(), this.getFormPaintable())) then
            ignore (this.primaryPlayerQueue.add(SelectSound.getInstance()))
            this.unPause()
    
    abstract closeMenu : unit -> unit
    default this.closeMenu() : unit =
        this.menuBehavior.closeMenu(this)
    
    abstract closeMenu2 : unit -> unit
    default this.closeMenu2() : unit =
        this.setMenuPaintable(this.getOpenMenuPaintable())
        this.basicMotionGesturesHandler.removeListener(this.mainMenuInputProcessor)
        this.gameKeyEventHandler.removeListener(this.mainMenuInputProcessor)
        this.setMenuInputProcessor(this.getPopupMenuInputProcessor())
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        this.basicMotionGesturesHandler.addListenerInterface(this.menuInputProcessor)
        this.gameKeyEventHandler.addListener(this.menuInputProcessor)
    
    abstract close : unit -> unit
    default this.close() : unit =
        this.basicMotionGesturesHandler.removeListener(this.menuInputProcessor)
        this.gameKeyEventHandler.removeListener(this.menuInputProcessor)
        this.primaryPlayerQueue.clear()
        this.secondaryPlayerQueue.clear()
    
    abstract processorInit : unit -> unit
    default this.processorInit() : unit =
        this.setMainStateProcessor(Processor.getInstance())
        this.setProcessGameProcessorInit()
    
    abstract setProcessGameProcessorInit : unit -> unit
    default this.setProcessGameProcessorInit() : unit =
        this.setProcessGameProcessor((new GameProcessor(this)))
    
    abstract initSpecialPaint : unit -> unit
    default this.initSpecialPaint() : unit =
        this.menuBehavior.initSpecialPaint(this)
    
    member this.init(gameLayerManager: AllBinaryGameLayerManager, buffered: bool) : unit =
        this.gameStateTimeHelper.setStartTimeTNT()
        this.setHighScoreSubmitted(false)
        this.setLayerManager(gameLayerManager)
        if not (buffered) then
            let mutable BUFF_MESSAGE : string = "XXX Not Buffering Causes Concurrency Issues XXX"
            this.logUtil.putF(BUFF_MESSAGE, this, this.commonStrings.CONSTRUCTOR)
        else
            raise ((new JException("Buffering is disabled")))
        this.setGameInputProcessor(Processor.getInstance())
        let mutable features : Features = Features.getInstance()
        if features.isFeature(GameFeatureFactory.getInstance().CHEATING) then
            this.isCheating <- true
            this.cheatProcessor <- (new CheatGameInputProcessor(this))
            this.gameKeyEventHandler.addListener(this.cheatProcessor)
        else
            this.isCheating <- false
            this.cheatProcessor <- NoPlayerGameInput.getInstance()
        this.realEndGameProcessor <- (new EndGameProcessor(this))
        this.setEndGameProcessor(Processor.getInstance())
        this.realStartIntermissionProcessor <- (new StartIntermissionProcessor(this))
        this.startIntermissionProcessor <- Processor.getInstance()
        this.setEndGameStatePaintable((new EndGamePaintable(this)))
        this.setEndGamePaintable(NullPaintable.getInstance())
        this.setIntermissionPaintable(NullPaintable.getInstance())
        this.getStartIntermissionInterface().setListener(this)
    
    abstract notifyIntermission : enable: bool -> unit
    default this.notifyIntermission(enable: bool) : unit =
        if enable then
            this.startIntermissionProcessor <- this.realStartIntermissionProcessor
        else
            this.startIntermissionProcessor <- Processor.getInstance()
        if enable then
            this.setIntermissionPaintable(this.getStartIntermissionPaintable())
        else
            this.setIntermissionPaintable(NullPaintable.getInstance())
    
    abstract mediaInit : unit -> unit
    default this.mediaInit() : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
    
    abstract initConfigurable : abeClientInformation: AbeClientInformationInterface -> unit
    default this.initConfigurable(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.addNormalPortion(50, "Setting Configurables")
        GameInitializationUtil.getInstance().initGame(abeClientInformation, this, this.gameInitializationInterfaceFactoryInterface)
        let mutable gameFeatureFactory : GameFeatureFactory = GameFeatureFactory.getInstance()
        let mutable changedGameFeatureListener : ChangedGameFeatureListener = ChangedGameFeatureListener.getInstance()
        if changedGameFeatureListener.isChangedFeature(gameFeatureFactory.SOUND) then
            let mutable features : Features = Features.getInstance()
            this.logUtil.putF((new StringMaker()).append("Sound Changing To: ").appendboolean(features.isFeature(gameFeatureFactory.SOUND)).ToString(), this, "initConfigurable")
            this.mediaInit()
            ignore (changedGameFeatureListener.remove(gameFeatureFactory.SOUND))
        let mutable sensorFeatureFactory : SensorFeatureFactory = SensorFeatureFactory.getInstance()
        if (changedGameFeatureListener.isChangedFeature(sensorFeatureFactory.ORIENTATION_SENSORS) || changedGameFeatureListener.isChangedFeature(sensorFeatureFactory.NO_ORIENTATION)) || changedGameFeatureListener.isChangedFeature(sensorFeatureFactory.SIMULATED_ORIENTATION_SENSORS) then
            ignore (changedGameFeatureListener.remove(sensorFeatureFactory.NO_ORIENTATION))
            ignore (changedGameFeatureListener.remove(sensorFeatureFactory.ORIENTATION_SENSORS))
            ignore (changedGameFeatureListener.remove(sensorFeatureFactory.SIMULATED_ORIENTATION_SENSORS))
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        this.loadResourceLoadingLevel(resourceLoadingLevelFactory.LOAD_GAME)
    
    abstract initApp : abeClientInformation: AbeClientInformationInterface -> unit
    default this.initApp(abeClientInformation: AbeClientInformationInterface) : unit =
        this.initConfigurable(abeClientInformation)
        this.processorInit()
        this.sensorGameUpdateProcessor.process_(this.gameLayerManager)
        this.sensorGameUpdateProcessor.sendNotifications(this.gameLayerManager)
        this.initTouch()
    
    abstract initTouch : unit -> unit
    default this.initTouch() : unit =
        let mutable gameInitializedEvent : GameInitializedEvent = GameInitializationUtil.getInstance().EVENT
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        gameInitializedEvent.setResourceLoadingLevel(resourceLoadingLevelFactory.LOAD_TOUCH)
        GameInitializedEventHandler.getInstance().fireEvent(gameInitializedEvent)
        this.touchButtonFactory.defaultList()
        this.updateTouch()
        this.postInitTouch()
    
    abstract updateCurrentTouchInputFactory : nextTouchInput: BaseTouchInput -> unit
    default this.updateCurrentTouchInputFactory(nextTouchInput: BaseTouchInput) : unit =
        if not (JR.same(nextTouchInput, this.currentTouchInputFactory)) then
            this.currentTouchInputFactory <- nextTouchInput
            PreLogUtil.put(this.currentTouchInputFactory.ToString(), this, this.gameInputStrings.UDPATE_CURRENT_TOUCH_INPUT_FACTORY)
            this.touchButtonFactory.toggle(this.isPaused(), this.currentTouchInputFactory.getList())
    
    abstract updateTouch : unit -> unit
    default this.updateTouch() : unit =
        this.gameBehavior.updateTouch(this)
    
    abstract updateTouch2 : unit -> unit
    default this.updateTouch2() : unit =
        let mutable features : Features = Features.getInstance()
        if features.isFeature(this.touchFeatureFactory.AUTO_HIDE_SHOW_SCREEN_BUTTONS) then
            if (this.gameLayerManager.getGameInfo().getCurrentLevel() - this.getStartLevel()) = 1 then
                this.setTouchPaintableP(NullPaintable.getInstance())
    
    abstract postInitTouch : unit -> unit
    default this.postInitTouch() : unit =
        this.setTouchButtonsPaintable(TouchButtonsPaintableFactory.getInstance(this.gameLayerManager.getForegroundBasicColor()))
        this.updateScreenButtonPaintable()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommands()
        this.setCommandListener(cmdListener)
    
    abstract addCommands : unit -> unit
    default this.addCommands() : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        let mutable myCommandsFactory : MyCommandsFactory = MyCommandsFactory.getInstance()
        if DebugFactory.getInstance() <> NoDebug.getInstance() then
            this.addCommand(gameCommandsFactory.START_TRACE)
        this.addCommand(gameCommandsFactory.RESTART_COMMAND)
        this.addCommand(myCommandsFactory.PAUSE_COMMAND)
        this.addCommand(gameCommandsFactory.QUIT_COMMAND)
        let mutable isOverScan : bool = OperatingSystemFactory.getInstance().getOperatingSystemInstance().isOverScan()
        if J2MEUtil.isHTML() then
            ()
        elif SWTUtil.isSWT then
            ()
        elif not (isOverScan) then
            if TouchScreenFactory.getInstance().isTouch() && (new InGameFeatures()).isAny() then
                this.addCommand(InGameOptionsForm.DISPLAY)
            this.addCommand(gameCommandsFactory.SAVE)
            this.addCommand(gameCommandsFactory.DISPLAY_LOAD_FORM)
    
    abstract itemStateChanged : item: LcduiItem -> unit
    default this.itemStateChanged(item: LcduiItem) : unit =
        try
            let mutable itemLabel : string = item.getLabel()
            this.logUtil.putF((new StringMaker()).append(this.commonLabels.ITEM_LABEL).append(itemLabel).ToString(), this, "itemStateChanged")
            if (box (item) :? ChoiceGroup) then
                let mutable gameFeatureUtil : GameFeatureUtil = GameFeatureUtil.getInstance()
                if gameFeatureUtil.isExclusive(itemLabel) then
                    gameFeatureUtil.updateExclusiveForChoiceGroup((box (item) :?> ChoiceGroup))
                else
                    gameFeatureUtil.updateMultiple((box (item) :?> ChoiceGroup))
            this.sensorGameUpdateProcessor.process_(this.gameLayerManager)
            this.updateTouch()
            this.updateScreenButtonPaintable()
            this.sensorGameUpdateProcessor.sendNotifications(this.gameLayerManager)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "itemStateChanged", e)
            | _ -> reraise ()
    
    abstract updateScreenButtonPaintable : unit -> unit
    default this.updateScreenButtonPaintable() : unit =
        this.gameBehavior.updateScreenButtonPaintable(this)
    
    abstract updateScreenButtonPaintable2 : unit -> unit
    default this.updateScreenButtonPaintable2() : unit =
        let mutable features : Features = Features.getInstance()
        if features.isFeature(this.touchFeatureFactory.AUTO_HIDE_SHOW_SCREEN_BUTTONS) then
            this.setTouchPaintableP(this.getTouchButtonsPaintable())
            this.setStartLevel(this.gameLayerManager.getGameInfo().getCurrentLevel())
        elif features.isFeature(this.touchFeatureFactory.SHOW_SCREEN_BUTTONS) then
            this.setTouchPaintableP(this.getTouchButtonsPaintable())
        elif features.isFeature(this.touchFeatureFactory.HIDE_SCREEN_BUTTONS) then
            this.setTouchPaintableP(NullPaintable.getInstance())
        else
            this.setTouchPaintableP(NullPaintable.getInstance())
    
    abstract getLayerManager : unit -> AllBinaryGameLayerManager
    default this.getLayerManager() : AllBinaryGameLayerManager =
        this.gameLayerManager
    
    abstract setLayerManager : layerManager: AllBinaryGameLayerManager -> unit
    default this.setLayerManager(layerManager: AllBinaryGameLayerManager) : unit =
        this.gameLayerManager <- layerManager
    
    abstract isGameOver : unit -> bool
    default this.isGameOver() : bool =
        this.gameOver
    
    abstract setGameOver : gameOver: bool -> unit
    default this.setGameOver(gameOver: bool) : unit =
        this.gameOver <- gameOver
    
    abstract processGameOver : unit -> unit
    default this.processGameOver() : unit =
        PreLogUtil.put(this.commonStrings.START, this, this.gameStrings.SET_GAME_OVER)
        this.setGameOver(true)
        this.removePauseCommand()
        this.setGameState(this.gameStateFactory.SHOW_END_RESULT_GAME_STATE)
        this.setEndGamePaintable(this.getEndGameStatePaintable())
    
    abstract isHighScoreSubmitted : unit -> bool
    default this.isHighScoreSubmitted() : bool =
        this.highScoreSubmitted
    
    abstract setHighScoreSubmitted : highScoreSubmitted: bool -> unit
    default this.setHighScoreSubmitted(highScoreSubmitted: bool) : unit =
        this.highScoreSubmitted <- highScoreSubmitted
        if highScoreSubmitted then
            this.highScoresHelper.setSelectedHighScores(NullHighScoresSingletonFactory.getInstance())
        this.logUtil.putF((new StringMaker()).append("isHighScoreSubmitted: ").appendboolean(highScoreSubmitted).ToString(), this, "setHighScoreSubmitted")
    
    abstract getGameState : unit -> GameState
    default this.getGameState() : GameState =
        this.gameState
    
    abstract setGameState : gameState: GameState -> unit
    default this.setGameState(gameState: GameState) : unit =
        this.logUtil.putF((new StringMaker()).append(this.gameStrings.GAME_STATE).append(this.stringUtil.toString(gameState)).ToString(), this, this.gameStrings.SET_GAME_STATE)
        this.gameState <- gameState
        this.gameStateTimeHelper.setStartTimeTNT()
        this.updateEndGameProcessor()
        this.updateGameKeyEventProcessor()
        this.gameBehavior.setGameState(this)
    
    abstract updateGameState : unit -> unit
    default this.updateGameState() : unit =
        let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
        gameAdState.processAdState(this.gameState, this.gameLayerManager.getGameInfo().getGameType())
        if not (JR.same(this.gameState, this.gameStateFactory.PLAYING_GAME_STATE)) then
            gameAdState.processPageAdState()
    
    member this.updateGameKeyEventProcessor() : unit =
        if (not (JR.same(this.getGameState(), this.gameStateFactory.PLAYING_GAME_STATE))) || this.isCheating then
            ()
        else
            ()
    
    abstract removeAllGameKeyInputListenersOnBuild : unit -> unit
    default this.removeAllGameKeyInputListenersOnBuild() : unit =
        this.removeAllGameKeyInputListeners()
    
    abstract removeAllGameKeyInputListeners : unit -> unit
    default this.removeAllGameKeyInputListeners() : unit =
        this.gameBehavior.removeAllGameKeyInputListeners(this)
    
    abstract removeAllGameKeyInputListeners2 : unit -> unit
    default this.removeAllGameKeyInputListeners2() : unit =
        this.logUtil.putF("Remove PlayerInput Listeners", this, "removeAllGameKeyInputListeners")
        let mutable index : int = this.localPlayerGameInputList.size() - 1
        while index >= 0 do
            let mutable playerGameInput : PlayerGameInput = (box (this.localPlayerGameInputList.get(index)) :?> PlayerGameInput)
            this.removeKeyInputListener(playerGameInput)
            playerGameInput.removeNonAIInputGameKeyEvents()
            index <- index - 1
    
    abstract removeKeyInputListener : playerGameInput: PlayerGameInput -> unit
    default this.removeKeyInputListener(playerGameInput: PlayerGameInput) : unit =
        this.gameKeyEventHandler.removeListener(playerGameInput)
    
    abstract updateEndGameProcessor : unit -> unit
    default this.updateEndGameProcessor() : unit =
        this.gameBehavior.updateEndGameProcessor(this)
    
    abstract updateEndGameProcessor2 : unit -> unit
    default this.updateEndGameProcessor2() : unit =
        if ((JR.same(this.getGameState(), this.gameStateFactory.SHOW_END_RESULT_GAME_STATE))) || ((JR.same(this.getGameState(), this.gameStateFactory.SHOW_HIGH_SCORE_GAME_STATE))) then
            this.setEndGameProcessor(this.realEndGameProcessor)
        else
            this.setEndGameProcessor(Processor.getInstance())
    
    abstract buildGameInit : isPortion: bool -> unit
    default this.buildGameInit(isPortion: bool) : unit =
        ()
    
    abstract cleanupGame : unit -> unit
    default this.cleanupGame() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CLEANUP)
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.addNormalPortion(10, "Cleaning Up")
        this.primaryPlayerQueue.clear()
        this.secondaryPlayerQueue.clear()
        GameLevelDisplayChangeEventListenersFactory.getInstance().clear()
    
    abstract loadResourceLoadingLevel : resourceLoadingLevel: ResourceLoadingLevel -> unit
    default this.loadResourceLoadingLevel(resourceLoadingLevel: ResourceLoadingLevel) : unit =
        let mutable gameInitializedEvent : GameInitializedEvent = GameInitializationUtil.getInstance().EVENT
        gameInitializedEvent.setResourceLoadingLevel(resourceLoadingLevel)
        GameInitializedEventHandler.getInstance().fireEvent(gameInitializedEvent)
    
    abstract loadResources : level: int -> unit
    default this.loadResources(level: int) : unit =
        let mutable gameInitializedEvent : GameInitializedEvent = GameInitializationUtil.getInstance().EVENT
        gameInitializedEvent.setLevel(level)
        GameInitializedEventHandler.getInstance().fireEvent(gameInitializedEvent)
    
    abstract updateColor : unit -> unit
    default this.updateColor() : unit =
        ()
    
    abstract buildGame : portion: int -> unit
    default this.buildGame(portion: int) : unit =
        let mutable jflow = 0
        this.screenCapture.endRecording()
        this.screenCapture.startRecording()
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        let mutable features : Features = Features.getInstance()
        progressCanvas.addNormalPortion(portion, "Generic Build")
        this.removeAllGameKeyInputListenersOnBuild()
        this.updateTouch()
        progressCanvas.addNormalPortion(portion, "High Scores")
        this.highScoresFactoryInterface.fetchHighScores(this.gameLayerManager.getGameInfo(), this.highScoresHelper)
        this.setHighScoresPaintable(NullPaintable.getInstance())
        progressCanvas.addNormalPortion(portion, "Finishing.")
        this.getEndGameInfoP().update(this.getLayerManager().getGameInfo(), this)
        this.isSingleKeyRepeatableProcessing <- features.isFeature(InputFeatureFactory.getInstance().SINGLE_KEY_REPEAT_PRESS)
        this.setGameOver(false)
        progressCanvas.addNormalPortion(portion, "Finishing..")
        this.updateColor()
        ignore (this.getStartIntermissionPaintable().update())
        if not (this.isRunningInAnotherThread()) then
            jflow <- 1
        if jflow = 0 then
            progressCanvas.addNormalPortion(portion, "Finishing...")
            if this.isMainCanvas() || (not (this.isInitialized())) then
                if features.isFeature(MainFeatureFactory.getInstance().LOAD_ONDEMAND) then
                    if not (JR.same(this.getCustomCommandListener(), null)) then
                        progressCanvas.end_()
                else
                    progressCanvas.end_()
                this.setInitialized(true)
            if (JR.same(this.getCustomCommandListener(), NullCommandListener.NULL_COMMAND_LISTENER)) then
                this.logUtil.putF("Show Game Paintable in DemoCanvas Thread", this, this.BUILD_GAME)
                this.gameCanvasStartListener.showGamePaintable()
            else
                this.logUtil.putF("No GameCanvasStartListener", this, this.BUILD_GAME)
            this.colorFillPaintable.setBasicColorP(this.gameLayerManager.getBackgroundBasicColor())
            this.gameBehavior.buildGame(this)
    
    abstract buildGame2 : unit -> unit
    default this.buildGame2() : unit =
        PreLogUtil.put((new StringMaker()).append(this.gameInputStrings.ENABLE_PLAYER_GAME_INPUTS).appendint(this.localPlayerGameInputList.size()).ToString(), this, this.BUILD_GAME)
        let mutable playerGameInput : PlayerGameInput = null
        let mutable index : int = this.localPlayerGameInputList.size() - 1
        while index >= 0 do
            playerGameInput <- (box (this.localPlayerGameInputList.get(index)) :?> PlayerGameInput)
            PreLogUtil.put((new StringMaker()).append(this.gameInputStrings.ENABLE_PLAYER_GAME_INPUT).append(playerGameInput.ToString()).ToString(), this, this.BUILD_GAME)
            playerGameInput.removeNonAIInputGameKeyEvents()
            this.addKeyInputListener(playerGameInput)
            index <- index - 1
    
    abstract addKeyInputListener : playerGameInput: PlayerGameInput -> unit
    default this.addKeyInputListener(playerGameInput: PlayerGameInput) : unit =
        GameKeyEventHandler.getInstance().addListenerForPlayer(playerGameInput, playerGameInput.getPlayerInputId())
    
    abstract setGameCanvasStartListener : gameCanvasStartListener: DemoPaintableInterface -> unit
    default this.setGameCanvasStartListener(gameCanvasStartListener: DemoPaintableInterface) : unit =
        this.gameCanvasStartListener <- gameCanvasStartListener
    
    abstract loadState : unit -> unit
    default this.loadState() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.LOAD)
        let mutable hashtable : ABHashtable = this.getLoadStateHashtable()
        if (not (JR.same(hashtable, null))) && (hashtable.size() > 0) then
            let mutable levelAsString : string = (box (hashtable.get((box (GameInfo.LEVEL_NAME)))) :?> string)
            let mutable level : int = Integer.valueOf(levelAsString).intValue()
            let mutable gameInfo : GameInfo = this.gameLayerManager.getGameInfo()
            gameInfo.setCurrentLevel(level)
    
    abstract getLoadStateHashtable : unit -> ABHashtable
    default this.getLoadStateHashtable() : ABHashtable =
        this.logUtil.putF((new StringMaker()).append(this.commonLabels.START_LABEL).append(this.stringUtil.toString(this.hashtable)).ToString(), this, "getLoadStateHashtable")
        this.hashtable
    
    abstract setLoadStateHashtable : hashtable: ABHashtable -> unit
    default this.setLoadStateHashtable(hashtable: ABHashtable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.commonLabels.START_LABEL).append(this.stringUtil.toString(hashtable)).ToString(), this, "setLoadStateHashtable")
        this.hashtable <- hashtable
    
    abstract getCurrentStateHashtable : unit -> ABHashtable
    default this.getCurrentStateHashtable() : ABHashtable =
        let mutable hashtable : ABHashtable = this.stdUtil.createHashtable()
        let mutable level : int = this.gameLayerManager.getGameInfo().getCurrentLevel()
        ignore (hashtable.put(GameInfo.LEVEL_NAME, Integer.toString(level)))
        this.logUtil.putF((new StringMaker()).append("End: ").append(this.stringUtil.toString(hashtable)).ToString(), this, "getCurrentStateHashtable")
        hashtable
    
    abstract paintGameOver : graphics: Graphics -> unit
    default this.paintGameOver(graphics: Graphics) : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
    
    override this.draw(graphics: Graphics) : unit =
        ignore (this.colorFillPaintable.paint(graphics))
        this.basicSetColorUtil.setBasicColorP(graphics, this.gameLayerManager.getForegroundBasicColor())
        ignore (this.gameSpecificPaintable.paint(graphics))
    
    abstract clear : graphics: Graphics -> unit
    default this.clear(graphics: Graphics) : unit =
        ignore (this.colorFillPaintable.paint(graphics))
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        this.baseGameStatistics.nextRefresh()
        this.draw(graphics)
        ignore (this.menuPaintable.paint(graphics))
        ignore (this.progressPaintable.paint(graphics))
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract processEndLevelIntermissionGameState : unit -> unit
    default this.processEndLevelIntermissionGameState() : unit =
        ()
    
    abstract nonBotPaint : graphics: Graphics -> unit
    default this.nonBotPaint(graphics: Graphics) : unit =
        ignore (this.endGamePaintable.paint(graphics))
        ignore (this.intermissionPaintable.paint(graphics))
        this.paintIntermission(graphics)
        ignore (this.touchPaintable.paint(graphics))
    
    abstract paintIntermission : graphics: Graphics -> unit
    default this.paintIntermission(graphics: Graphics) : unit =
        ()
    
    override this.keyPressed(keyCode: int) : unit =
        this.keyPressedByDevice(keyCode, 0)
    
    override this.keyReleased(keyCode: int) : unit =
        this.keyReleasedByDevice(keyCode, 0)
    
    override this.keyRepeated(keyCode: int) : unit =
        this.keyRepeatedByDevice(keyCode, 0)
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        this.inputProcessor.keyPressedByDevice(keyCode, deviceId)
    
    override this.keyRepeatedByDevice(keyCode: int, deviceId: int) : unit =
        if this.isSingleKeyRepeatableProcessing then
            this.inputProcessor.keyPressedByDevice(keyCode, deviceId)
    
    override this.keyReleasedByDevice(keyCode: int, deviceId: int) : unit =
        this.inputProcessor.keyReleasedByDevice(this, keyCode, deviceId)
    
    abstract handleRawKey : keyCode: int * deviceId: int * repeated: bool -> unit
    default this.handleRawKey(keyCode: int, deviceId: int, repeated: bool) : unit =
        ()
    
    abstract endProgress : isProgress: bool -> int
    default this.endProgress(isProgress: bool) : int =
        let mutable portion : int = 30
        if isProgress && this.isMainCanvas() then
            let mutable myCommandsFactory : MyCommandsFactory = MyCommandsFactory.getInstance()
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            progressCanvas.start()
            this.getCustomCommandListener().commandAction(myCommandsFactory.SET_DISPLAYABLE, progressCanvas)
            portion <- 4
        portion
    
    abstract processPlayingGame : unit -> unit
    default this.processPlayingGame() : unit =
        ignore (this.cheatProcessor.update())
        ignore (this.sensorGameUpdateProcessor.getInputSensor().update())
        ignore (this.gameInputProcessor.process_())
        ignore (this.gameLayerManager.process_())
        ignore (this.startIntermissionProcessor.process_())
    
    abstract threadInit : unit -> unit
    default this.threadInit() : unit =
        ()
    
    abstract processGame : unit -> unit
    default this.processGame() : unit =
        ignore (base.process_())
        if AllBinaryMediaManager.update() then
            if not (this.primaryPlayerQueue.process_()) then
                ignore (this.secondaryPlayerQueue.process_())
        ignore (this.mainStateProcessor.process_())
        ignore (this.menuInputProcessor.processInputList())
        ignore (this.endGameProcessor.process_())
        this.baseGameStatistics.nextFrame()
    
    abstract notifyDonePainting : unit -> unit
    default this.notifyDonePainting() : unit =
        if true then
            this.threadObjectUtil.notifyObject(this)
    
    abstract shouldWait : unit -> unit
    default this.shouldWait() : unit =
        let mutable features : Features = Features.getInstance()
        if AndroidUtil.isAndroid() then
            ()
        elif features.isFeature(this.openGLFeatureFactory.OPENGL_2D) then
            ()
        else
            if features.isDefault(this.openGLFeatureFactory.OPENGL) then
                let mutable openGLImageSpecificFactory : OpenGLImageSpecificFactory = OpenGLImageSpecificFactory.getInstance()
                while openGLImageSpecificFactory.updating do
                    ignore (Thread.sleep(this.YIELD_SLEEP))
    
    override this.run() : unit =
        try
            this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            progressCanvas.addNormalPortion(50, "Game Thread")
            this.setCurrentThread()
            this.setRunning(true)
            if (JR.same(this.getCustomCommandListener(), NullCommandListener.NULL_COMMAND_LISTENER)) then
                ignore (Thread.sleep(this.YIELD_SLEEP))
            this.shouldWait()
            this.threadInit()
            if (JR.same(this.getCustomCommandListener(), NullCommandListener.NULL_COMMAND_LISTENER)) then
                ignore (Thread.sleep(this.YIELD_SLEEP))
            this.open_()
            let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
            gameAdState.init()
            gameAdState.setGameIsReady(true)
            this.gameBehavior.run(this)
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
    
    abstract run2 : unit -> unit
    default this.run2() : unit =
        let mutable features : Features = Features.getInstance()
        if features.isDefault(this.openGLFeatureFactory.OPENGL_AS_GAME_THREAD) || J2MEUtil.isHTML() then
            if features.isDefault(this.openGLFeatureFactory.OPENGL_AS_GAME_THREAD) then
                this.logUtil.putF(this.openGLFeatureFactory.OPENGL_AS_GAME_THREAD.getName(), this, this.commonStrings.RUN)
            if J2MEUtil.isHTML() then
                this.logUtil.putF(GraphicsStrings.getInstance().HTML, this, this.commonStrings.RUN)
            let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
            currentDisplayableFactory.setRunnable(this.gameRunnable)
            currentDisplayableFactory.setDisplayable(this)
            OpenGLThreadUtil.getInstance().onResume()
        elif features.isDefault(this.openGLFeatureFactory.OPENGL_AND_GAME_HAVE_DIFFERENT_THREADS) then
            this.logUtil.putF(this.openGLFeatureFactory.OPENGL_AND_GAME_HAVE_DIFFERENT_THREADS.getName(), this, this.commonStrings.RUN)
            OpenGLThreadUtil.getInstance().onResume()
            while this.isRunning() do
                this.run3()
            this.end_()
        else
            this.logUtil.putF("this thread", this, this.commonStrings.RUN)
            while this.isRunning() do
                this.run3()
            this.end_()
    
    abstract run3 : unit -> unit
    default this.run3() : unit =
        this.loopTimeHelper.setStartTime(this.gameTickTimeDelayHelper.setStartTime())
        ignore (this.gameTickDisplayInfoSingleton.update())
        this.processGame()
        this.processLoopSleep()
    
    override this.setRunning(running: bool) : unit =
        base.setRunning(running)
        try
            let mutable features : Features = Features.getInstance()
            if running then
                ()
            else
                if features.isDefault(this.openGLFeatureFactory.OPENGL) || SWTUtil.isSWT then
                    if not (JR.same(this.gameLayerManager.getGameInfo().getGameType(), this.gameTypeFactory.BOT)) then
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
        this.screenCapture.endRecording()
        ignore (this.baseGameStatistics.add((new StringMaker()).append(this.baseGameStatistics.ToString()).append(CommonSeps.getInstance().NEW_LINE).ToString()))
        this.baseGameStatistics.init()
        this.gameKeyEventHandler.removeListener(this.cheatProcessor)
        this.close()
        this.removeAllGameKeyInputListeners()
        this.endGameThread()
    
    abstract endGameThread : unit -> unit
    default this.endGameThread() : unit =
        DisplayChangeEventHandler.getInstance().removeListener(this)
        GameLevelDisplayChangeEventListenersFactory.getInstance().clear()
        let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
        gameAdState.notPlayingAdState()
    
    abstract createHighScore : score: int64 -> HighScore
    default this.createHighScore(score: int64) : HighScore =
        let mutable gameInfo : GameInfo = this.gameLayerManager.getGameInfo()
        (new HighScore(0, "NONE", (new GameInfo(gameInfo.getGameType(), gameInfo.getGameMode(), PlayerTypesFactory.getInstance().PLAYER_TYPE_ONE, 0, 0)), score))
    
    abstract setHighScore : abeClientInformation: AbeClientInformationInterface * name: string * score: int64 * autoSubmit: bool * isLast: bool -> unit
    default this.setHighScore(abeClientInformation: AbeClientInformationInterface, name: string, score: int64, autoSubmit: bool, isLast: bool) : unit =
        this.gameBehavior.setHighScore(abeClientInformation, this, name, score, autoSubmit, isLast)
    
    abstract setHighScore2 : abeClientInformation: AbeClientInformationInterface * name: string * score: int64 * autoSubmit: bool * isLast: bool -> unit
    default this.setHighScore2(abeClientInformation: AbeClientInformationInterface, name: string, score: int64, autoSubmit: bool, isLast: bool) : unit =
        let mutable highScore : HighScore = this.createHighScore(score)
        let mutable textBox : HighScoreTextBox = (new HighScoreTextBox(this.highScoresFactoryInterface, this.highScoresHelper, abeClientInformation, this.gameLayerManager.getGameInfo(), this.getCustomCommandListener(), name, highScore, this.gameLayerManager.getBackgroundBasicColor(), this.gameLayerManager.getForegroundBasicColor()))
        if isLast then
            this.getCustomCommandListener().commandAction(GameCommandsFactory.getInstance().SET_MENU_DISPLAYABLE, textBox)
        if autoSubmit then
            SecondaryThreadPool.getInstance().runTask((new SaveHighScoreRunnable(isLast, textBox)))
    
    abstract getGameStateTimeHelper : unit -> TimeDelayHelper
    default this.getGameStateTimeHelper() : TimeDelayHelper =
        this.gameStateTimeHelper
    
    abstract setInitialized : initialized: bool -> unit
    default this.setInitialized(initialized: bool) : unit =
        this.initialized <- initialized
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        AllBinaryGameCanvas.id
    
    abstract setProgressPaintable : paintable: PaintableInterface -> unit
    default this.setProgressPaintable(paintable: PaintableInterface) : unit =
        this.progressPaintable <- paintable
    
    abstract getStartIntermissionInterface : unit -> IntermissionInterface
    default this.getStartIntermissionInterface() : IntermissionInterface =
        this.startIntermissionInterface
    
    abstract getEndLevelIntermissionInterface : unit -> IntermissionInterface
    default this.getEndLevelIntermissionInterface() : IntermissionInterface =
        this.endLevelIntermissionInterface
    
    abstract setTouchPaintableP : paintable: Paintable -> unit
    default this.setTouchPaintableP(paintable: Paintable) : unit =
        this.touchPaintable <- paintable
    
    abstract getTouchPaintableP : unit -> Paintable
    default this.getTouchPaintableP() : Paintable =
        this.touchPaintable
    
    abstract setEndGamePaintable : endGamePaintable: Paintable -> unit
    default this.setEndGamePaintable(endGamePaintable: Paintable) : unit =
        this.endGamePaintable <- endGamePaintable
    
    abstract getEndGamePaintable : unit -> Paintable
    default this.getEndGamePaintable() : Paintable =
        this.endGamePaintable
    
    abstract setIntermissionPaintable : intermissionPaintable: Paintable -> unit
    default this.setIntermissionPaintable(intermissionPaintable: Paintable) : unit =
        this.intermissionPaintable <- intermissionPaintable
    
    abstract getIntermissionPaintable : unit -> Paintable
    default this.getIntermissionPaintable() : Paintable =
        this.intermissionPaintable
    
    abstract getEndGameInfoP : unit -> EndGameInfo
    default this.getEndGameInfoP() : EndGameInfo =
        this.endGameInfo
    
    abstract setHighScoresPaintable : highScoresPaintable: Paintable -> unit
    default this.setHighScoresPaintable(highScoresPaintable: Paintable) : unit =
        this.highScoresPaintable <- highScoresPaintable
    
    abstract getHighScoresPaintable : unit -> Paintable
    default this.getHighScoresPaintable() : Paintable =
        this.highScoresPaintable
    
    abstract getRealHighScoresPaintable : unit -> HighScoresPaintable
    default this.getRealHighScoresPaintable() : HighScoresPaintable =
        this.realHighScoresPaintable
    
    abstract clearPlayerGameInputList : unit -> unit
    default this.clearPlayerGameInputList() : unit =
        let mutable playerGameInput : PlayerGameInput = null
        let mutable index : int = this.localPlayerGameInputList.size() - 1
        while index >= 0 do
            playerGameInput <- (box (this.localPlayerGameInputList.get(index)) :?> PlayerGameInput)
            this.gameKeyEventHandler.removeListener(playerGameInput)
            index <- index - 1
        this.localPlayerGameInputList.clear()
    
    abstract addPlayerGameInput : playerGameInput: PlayerGameInput -> unit
    default this.addPlayerGameInput(playerGameInput: PlayerGameInput) : unit =
        ignore (this.localPlayerGameInputList.add(playerGameInput))
    
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
    
    abstract getStartLevel : unit -> int
    default this.getStartLevel() : int =
        this.startLevel
    
    abstract setStartLevel : startLevel: int -> unit
    default this.setStartLevel(startLevel: int) : unit =
        this.startLevel <- startLevel
    
    abstract setTouchButtonsPaintable : touchButtonsPaintable: Paintable -> unit
    default this.setTouchButtonsPaintable(touchButtonsPaintable: Paintable) : unit =
        this.touchButtonsPaintable <- touchButtonsPaintable
    
    abstract getTouchButtonsPaintable : unit -> Paintable
    default this.getTouchButtonsPaintable() : Paintable =
        this.touchButtonsPaintable
    
    abstract setGameInputProcessor : gameInputProcessor: Processor -> unit
    default this.setGameInputProcessor(gameInputProcessor: Processor) : unit =
        this.gameInputProcessor <- gameInputProcessor
    
    abstract getGameInputProcessor : unit -> Processor
    default this.getGameInputProcessor() : Processor =
        this.gameInputProcessor
    
    abstract setEndGameProcessor : endGameProcessor: Processor -> unit
    default this.setEndGameProcessor(endGameProcessor: Processor) : unit =
        this.endGameProcessor <- endGameProcessor
    
    abstract getEndGameProcessor : unit -> Processor
    default this.getEndGameProcessor() : Processor =
        this.endGameProcessor
    
    abstract setEndGameStatePaintable : endGameStatePaintable: Paintable -> unit
    default this.setEndGameStatePaintable(endGameStatePaintable: Paintable) : unit =
        this.endGameStatePaintable <- endGameStatePaintable
    
    abstract getEndGameStatePaintable : unit -> Paintable
    default this.getEndGameStatePaintable() : Paintable =
        this.endGameStatePaintable
    
    abstract setNonBotPaintableP : nonBotPaintable: Paintable -> unit
    default this.setNonBotPaintableP(nonBotPaintable: Paintable) : unit =
        this.nonBotPaintable <- nonBotPaintable
    
    abstract getNonBotPaintableP : unit -> Paintable
    default this.getNonBotPaintableP() : Paintable =
        this.nonBotPaintable
    
    abstract setStartIntermissionPaintable : startIntermissionPaintable: InitUpdatePaintable -> unit
    default this.setStartIntermissionPaintable(startIntermissionPaintable: InitUpdatePaintable) : unit =
        this.startIntermissionPaintable <- startIntermissionPaintable
    
    abstract getStartIntermissionPaintable : unit -> InitUpdatePaintable
    default this.getStartIntermissionPaintable() : InitUpdatePaintable =
        this.startIntermissionPaintable
    
    abstract setMainStateProcessor : mainStateProcessor: Processor -> unit
    default this.setMainStateProcessor(mainStateProcessor: Processor) : unit =
        this.mainStateProcessor <- mainStateProcessor
    
    abstract getMainStateProcessor : unit -> Processor
    default this.getMainStateProcessor() : Processor =
        this.mainStateProcessor
    
    abstract setProcessGameProcessor : processGameProcessor: Processor -> unit
    default this.setProcessGameProcessor(processGameProcessor: Processor) : unit =
        this.processGameProcessor <- processGameProcessor
    
    abstract getProcessGameProcessor : unit -> Processor
    default this.getProcessGameProcessor() : Processor =
        this.processGameProcessor
    
    abstract setOpenMenuPaintable : openMenuPaintable: Paintable -> unit
    default this.setOpenMenuPaintable(openMenuPaintable: Paintable) : unit =
        this.openMenuPaintable <- openMenuPaintable
    
    abstract getOpenMenuPaintable : unit -> Paintable
    default this.getOpenMenuPaintable() : Paintable =
        this.openMenuPaintable
    
    abstract setPopupMenuInputProcessor : popupMenuInputProcessor: BasicMenuInputProcessor -> unit
    default this.setPopupMenuInputProcessor(popupMenuInputProcessor: BasicMenuInputProcessor) : unit =
        this.popupMenuInputProcessor <- popupMenuInputProcessor
    
    abstract getPopupMenuInputProcessor : unit -> BasicMenuInputProcessor
    default this.getPopupMenuInputProcessor() : BasicMenuInputProcessor =
        this.popupMenuInputProcessor
    
    abstract getSensorGameUpdateProcessor : unit -> SensorGameUpdateProcessor
    default this.getSensorGameUpdateProcessor() : SensorGameUpdateProcessor =
        this.sensorGameUpdateProcessor
    
    abstract getRawGameInputProcessor : unit -> InputProcessor
    default this.getRawGameInputProcessor() : InputProcessor =
        this.rawGameInputProcessor
    
    abstract getRawInputProcessor : unit -> InputProcessor
    default this.getRawInputProcessor() : InputProcessor =
        this.rawInputProcessor
    
    abstract setInputProcessor : inputProcessor: InputProcessor -> unit
    default this.setInputProcessor(inputProcessor: InputProcessor) : unit =
        this.inputProcessor <- inputProcessor
    
    abstract getInputProcessor : unit -> InputProcessor
    default this.getInputProcessor() : InputProcessor =
        this.inputProcessor
    
    abstract setMenuPaintable : menuPaintable: Paintable -> unit
    default this.setMenuPaintable(menuPaintable: Paintable) : unit =
        this.menuPaintable <- menuPaintable
    
    abstract getMenuPaintable : unit -> Paintable
    default this.getMenuPaintable() : Paintable =
        this.menuPaintable
    
    member this.setFormPaintable(formPaintable: Paintable) : unit =
        this.formPaintable <- formPaintable
    
    abstract getFormPaintable : unit -> Paintable
    default this.getFormPaintable() : Paintable =
        this.formPaintable
    
    abstract setGameSpecificPaintableP : gameSpecificPaintable: Paintable -> unit
    default this.setGameSpecificPaintableP(gameSpecificPaintable: Paintable) : unit =
        this.gameSpecificPaintable <- gameSpecificPaintable
    
    abstract getGameSpecificPaintableP : unit -> Paintable
    default this.getGameSpecificPaintableP() : Paintable =
        this.gameSpecificPaintable
    
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
    
    override this.getType() : int =
        AllBinaryGameCanvas.TYPE
    
    override this.getTitle() : string =
        base.getTitle()
    
    override this.isPaused() : bool =
        base.isPaused()
    interface AllBinaryGameCanvasInterface with
        member this.getLayerManager() : AllBinaryGameLayerManager = this.getLayerManager()
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
    interface IntermissionCompositeInterface with
        member this.getStartIntermissionInterface() : IntermissionInterface = this.getStartIntermissionInterface()
        member this.getEndLevelIntermissionInterface() : IntermissionInterface = this.getEndLevelIntermissionInterface()
    interface IntermissionEnableListenerInterface with
        member this.notifyIntermission(jp0: bool) : unit = this.notifyIntermission(jp0)
    interface PopupMenuInterface with
        member this.popupMenu() : unit = this.popupMenu()
        member this.closeMenu() : unit = this.closeMenu()
        member this.toggleMenu() : unit = this.toggleMenu()
    interface DisplayChangeEventListener with
        member this.onDisplayChangeEvent(jp0: DisplayChangeEvent) : unit = this.onDisplayChangeEvent(jp0)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)
    interface DisplayableInterface with
        member this.addCommand(jp0: Command) : unit = this.addCommand(jp0)
        member this.getHeight() : int = this.getHeight()
        member this.getWidth() : int = this.getWidth()
        member this.removeCommand(jp0: Command) : unit = this.removeCommand(jp0)
        member this.setCommandListener(jp0: CommandListener) : unit = this.setCommandListener(jp0)
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


