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
type GameMidlet =
    inherit ProgressMidlet
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable features : Features
    [<DefaultValue(false)>] val mutable midletStrings : MidletStrings
    [<DefaultValue(false)>] val mutable myCommandsFactory : MyCommandsFactory
    [<DefaultValue(false)>] val mutable gameStrings : GameStrings
    [<DefaultValue(false)>] val mutable gameAdStateFactory : GameAdStateFactory
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable DISPLAYABLE : string
    [<DefaultValue(false)>] val mutable COMMAND_NAME : string
    [<DefaultValue(false)>] val mutable NO_COMMAND : string
    [<DefaultValue(false)>] val mutable NO_DISPLAYABLE : string
    [<DefaultValue(false)>] val mutable COMMAND_ACTION : string
    [<DefaultValue(false)>] val mutable PAUSE_APP_BACKGROUND : string
    [<DefaultValue(false)>] val mutable UN_PAUSE_APP_BACKGROUND : string
    [<DefaultValue(false)>] val mutable aboutCommandProcessor : AboutCommandProcessor
    [<DefaultValue(false)>] val mutable webCommandProcessor : WebCommandProcessor
    [<DefaultValue(false)>] val mutable gameMidletStateFactory : GameMidletStateFactory
    [<DefaultValue(false)>] val mutable gameStartTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable fullScreenUtil : FullScreenUtil
    [<DefaultValue(false)>] val mutable debugInterface : DebugInterface
    [<DefaultValue(false)>] val mutable allbinaryGameCanvasRunnableInterface : GameCanvasRunnableInterface
    [<DefaultValue(false)>] val mutable thread : Thread
    [<DefaultValue(false)>] val mutable loadGameForm : CommandForm
    [<DefaultValue(false)>] val mutable isFullScreen : bool
    [<DefaultValue(false)>] val mutable resized : bool
    [<DefaultValue(false)>] val mutable startedBefore : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameMidlet.jclinitDone then
            GameMidlet.jclinitDone <- true
            GameMidlet.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameMidlet() : unit =
        this.enumerationUtil <- EnumerationUtil.getInstance()
        this.basicColorFactory <- BasicColorFactory.getInstance()
        this.features <- Features.getInstance()
        this.midletStrings <- MidletStrings.getInstance()
        this.myCommandsFactory <- MyCommandsFactory.getInstance()
        this.gameStrings <- GameStrings.getInstance()
        this.gameAdStateFactory <- GameAdStateFactory.getInstance()
        this.gameStateFactory <- GameStateFactory.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.DISPLAYABLE <- " Displayable: "
        this.COMMAND_NAME <- "command Name/Label: "
        this.NO_COMMAND <- "No Command"
        this.NO_DISPLAYABLE <- "No Displayable"
        this.COMMAND_ACTION <- (new StringMaker()).append("GameMidlet::").append(this.midletStrings.COMMAND_ACTION).ToString()
        this.PAUSE_APP_BACKGROUND <- "pauseAppBackground"
        this.UN_PAUSE_APP_BACKGROUND <- "unPauseAppBackground"
        this.aboutCommandProcessor <- AboutCommandProcessor.getInstance()
        this.webCommandProcessor <- WebCommandProcessor.getInstance()
        this.gameMidletStateFactory <- GameMidletStateFactory.getInstance()
        this.gameStartTimeHelper <- (new TimeDelayHelper(240))
        this.fullScreenUtil <- FullScreenUtil.getInstance()
        this.allbinaryGameCanvasRunnableInterface <- NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE
        this.thread <- NullThread.NULL_THREAD
        this.startedBefore <- false
        ()
    
    new (clientInformationFactory: ClientInformationFactory) as this =
        { inherit ProgressMidlet(clientInformationFactory) }
        then
            this.jfields_GameMidlet()
            this.jctor1(clientInformationFactory)
    member this.jctor1(clientInformationFactory: ClientInformationFactory) : unit =
        ()
        SmallIntegerSingletonFactory.getInstance().initWithRange(0x291, 6)
        this.loadGameForm <- CommandForm.getNullCommandForm()
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.init(this)
        GameFeatureEventHandler.getInstance().addListenerInterface(ChangedGameFeatureListener.getInstance())
        GamePersistanceSingleton.getInstance().clear()
        this.debugInterface <- DebugFactory.getInstance()
        this.init()
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract setDemo : unit -> unit
    default this.setDemo() : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract createGame : unit -> unit
    default this.createGame() : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract mediaShutdown : unit -> unit
    default this.mediaShutdown() : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract stopAll : unit -> unit
    default this.stopAll() : unit =
        ()
    
    override this.pauseApp() : unit =
        this.pauseAppBackground(true)
        let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
        gameAdState.getAdvertisements().stopAll()
    
    abstract pauseAppBackground : background: bool -> unit
    default this.pauseAppBackground(background: bool) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.PAUSE_APP_BACKGROUND)
        if not (JR.same(this.allbinaryGameCanvasRunnableInterface, NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)) then
            this.allbinaryGameCanvasRunnableInterface.pause()
        else
            this.logUtil.putF("<<<<<< Null", this, this.PAUSE_APP_BACKGROUND)
        AllBinarySensorManager.getInstance().shutdown()
    
    abstract unPauseApp : unit -> unit
    default this.unPauseApp() : unit =
        this.unPauseAppBackground(true)
        let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
        gameAdState.getAdvertisements().startAll()
    
    abstract unPauseAppBackground : background: bool -> unit
    default this.unPauseAppBackground(background: bool) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.UN_PAUSE_APP_BACKGROUND)
        AllBinarySensorManager.getInstance().init()
        let mutable gameCanvasRunnableInterface : GameCanvasRunnableInterface = this.allbinaryGameCanvasRunnableInterface
        if not (JR.same(gameCanvasRunnableInterface, NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)) then
            gameCanvasRunnableInterface.unPause()
        else
            this.logUtil.putF("<<<<<< Null", this, this.UN_PAUSE_APP_BACKGROUND)
    
    override this.destroyAppInRunnable(unconditional: bool, isProgress: bool) : unit =
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        if isProgress then
            progressCanvas.start()
            this.commandAction(this.myCommandsFactory.SET_DISPLAYABLE, progressCanvas)
        this.destroyApp(unconditional)
        if isProgress then
            progressCanvas.end_()
    
    override this.destroyApp(unconditional: bool) : unit =
        let mutable METHOD_NAME : string = "GameMidlet::destroyApp"
        try
            PreLogUtil.put(GameStatisticsFactory.getInstance().ToString(), this, METHOD_NAME)
            let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
            gameAdState.getAdvertisements().stopAll()
            if not (this.isDestroyed()) then
                this.stopGameCanvasRunnableInterface()
                this.setGameCanvasRunnableInterface(NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)
                this.mediaShutdown()
            else
                this.logUtil.putF("Midlet Managment Error: Midlet Should Only Be Destroyed Once", this, METHOD_NAME)
            base.destroyApp(true)
            PreLogUtil.put(this.commonStrings.END, this, METHOD_NAME)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, METHOD_NAME, e)
            | _ -> reraise ()
        this.logUtil.putF(this.commonStrings.END, this, METHOD_NAME)
    
    override this.startApp() : unit =
        try
            let mutable gameAdState : GameAdState = this.gameAdStateFactory.getCurrentInstance()
            gameAdState.getAdvertisements().startAll()
            let mutable START_APP : string = "startApp"
            this.logUtil.putF(this.commonStrings.START, this, START_APP)
            let mutable gameCanvasRunnableInterface : obj = this.allbinaryGameCanvasRunnableInterface
            if (JR.same(gameCanvasRunnableInterface, NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)) then
                this.gameMidletStateFactory.setCurrentGameState(this.gameStateFactory.NO_GAME_STATE)
                this.setDemo()
            else
                this.logUtil.putF("GameCanvasRunnableInterface is available", this, START_APP)
                if (JR.same(gameCanvasRunnableInterface, this.getCurrentDisplayable())) then
                    this.unPauseAppBackground(false)
                else
                    this.logUtil.putF("GameCanvasRunnableInterface is not current displayable", this, START_APP)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "startApp", e)
                this.destroyApp(false)
                this.notifyDestroyed()
            | _ -> reraise ()
    
    override this.commandAction(command: Command, displayable: Displayable) : unit =
        try
            let mutable displayableAsString : string = this.NO_DISPLAYABLE
            if not (JR.same(displayable, null)) then
                displayableAsString <- displayable.ToString()
            let mutable label : string = this.NO_COMMAND
            if not (JR.same(command, null)) then
                label <- command.getLabel()
            PreLogUtil.put((new StringMaker()).append(this.COMMAND_NAME).append(label).append(this.DISPLAYABLE).append(displayableAsString).ToString(), this, this.COMMAND_ACTION)
            let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
            let mutable allbinaryGameCanvasRunnableInterface : GameCanvasRunnableInterface = this.allbinaryGameCanvasRunnableInterface
            let mutable gameCanvasRunnableInterface : obj = allbinaryGameCanvasRunnableInterface
            if (JR.same(command, gameCommandsFactory.SHOW_GAME_CANVAS)) then
                if (not (JR.same(this.getDisplay().getCurrent(), gameCanvasRunnableInterface))) && (allbinaryGameCanvasRunnableInterface.getType() <> NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE.getType()) then
                    this.setDisplay((box (gameCanvasRunnableInterface) :?> Displayable))
                this.unPauseAppBackground(false)
            elif (JR.same(command, gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS)) then
                let mutable menuListener : MenuListener = (box (displayable) :?> MenuListener)
                menuListener.close()
                this.setDisplay((box (gameCanvasRunnableInterface) :?> Displayable))
                this.unPauseAppBackground(false)
            elif (JR.same(command, gameCommandsFactory.EXIT_COMMAND)) then
                if GameMidletEventHandler.getInstance().getEventListenerInterfaceListP().size() = 0 then
                    this.exitProgress(true)
                GameMidletEventHandler.getInstance().fireEvent((new DemoGameMidletEvent(this, DemoGameMidletStateFactory.getInstance().NONE)))
            elif (JR.same(command, gameCommandsFactory.EXIT_WITHOUT_PROGRESS_COMMAND)) then
                this.exitProgress(false)
            elif (((JR.same(command, gameCommandsFactory.START_COMMAND))) || ((JR.same(command, gameCommandsFactory.RESTART_COMMAND)))) || ((JR.same(command, gameCommandsFactory.CONTINUE_COMMAND))) then
                if (not (JR.same(this.gameMidletStateFactory.getCurrentGameState(), this.gameStateFactory.PLAYING_GAME_STATE))) || ((JR.same(command, gameCommandsFactory.RESTART_COMMAND))) then
                    if this.gameStartTimeHelper.isTimeTNT() then
                        if ((JR.same(command, gameCommandsFactory.START_COMMAND))) && this.isDemoLoading() then
                            this.logUtil.putF("Trying to Start Game Before Loading Complete", this, this.midletStrings.COMMAND_ACTION)
                        else
                            this.startedBefore <- true
                            this.createGame()
                            this.gameMidletStateFactory.setCurrentGameState(this.gameStateFactory.PLAYING_GAME_STATE)
                    else
                        this.logUtil.putF("Starting Game Too Often", this, this.midletStrings.COMMAND_ACTION)
                else
                    this.logUtil.putF("Already in playing state", this, this.COMMAND_ACTION)
            elif (JR.same(command, gameCommandsFactory.BUY_COMMAND)) then
                let mutable inApplicationPurchaseFactory : InApplicationPurchaseFactory = InApplicationPurchaseFactory.getInstance()
                let mutable list_ : BasicArrayList = LockableFeatureFactory.getInstance().getList()
                let mutable lockableFeature : LockableFeature = (box (list_.get(0)) :?> LockableFeature)
                if (list_.size() > 0) && (not (inApplicationPurchaseFactory.isPurchased(lockableFeature))) then
                    inApplicationPurchaseFactory.purchase(lockableFeature)
                else
                    TextNotificationUtil.getInstance().fireSuccess("Already Purchased")
            elif (JR.same(command, gameCommandsFactory.QUIT_COMMAND)) then
                if this.gameStartTimeHelper.isTimeTNT() then
                    if (box (displayable) :? HighScoreTextBox) then
                        let mutable menuListener : MenuListener = (box (displayable) :?> MenuListener)
                        menuListener.close()
                    this.stopGameCanvasRunnableInterface()
                    this.gameMidletStateFactory.setCurrentGameState(this.gameStateFactory.NO_GAME_STATE)
                    this.setDemo()
            elif (JR.same(command, this.myCommandsFactory.RESUME_COMMAND)) then
                this.unPauseAppBackground(false)
            elif (JR.same(command, this.myCommandsFactory.PAUSE_COMMAND)) then
                this.pauseAppBackground(false)
            elif (JR.same(command, this.myCommandsFactory.SET_DISPLAYABLE)) then
                this.pauseAppBackground(false)
                this.setDisplay(displayable)
            elif (JR.same(command, gameCommandsFactory.SET_MENU_DISPLAYABLE)) then
                this.pauseAppBackground(false)
                let mutable menuListener : MenuListener = (box (displayable) :?> MenuListener)
                menuListener.open_()
                this.setDisplay(displayable)
            elif (JR.same(command, gameCommandsFactory.START_TRACE)) then
                this.debugInterface.start()
                let mutable gameCanvas : AllBinaryGameCanvas = (box (allbinaryGameCanvasRunnableInterface) :?> AllBinaryGameCanvas)
                gameCanvas.addCommand(gameCommandsFactory.STOP_TRACE)
                gameCanvas.removeCommand(gameCommandsFactory.START_TRACE)
            elif (JR.same(command, gameCommandsFactory.STOP_TRACE)) then
                this.pauseAppBackground(false)
                this.debugInterface.stop()
                this.unPauseAppBackground(false)
                let mutable gameCanvas : AllBinaryGameCanvas = (box (allbinaryGameCanvasRunnableInterface) :?> AllBinaryGameCanvas)
                gameCanvas.addCommand(gameCommandsFactory.START_TRACE)
                gameCanvas.removeCommand(gameCommandsFactory.STOP_TRACE)
            elif (JR.same(command, gameCommandsFactory.DEFAULT_OPTIONS)) then
                let mutable tempDisplayable : Displayable = displayable
                if (box (tempDisplayable) :? GameOptionsForm) then
                    GameFeatureFormUtil.getInstance().setDefault((box (tempDisplayable) :?> CommandForm))
            elif (JR.same(command, GameInputMappingInstructionsCanvas.DISPLAY)) then
                let mutable tempDisplayable : Displayable = displayable
                if (box (tempDisplayable) :? GameInputMappingCanvas) then
                    let mutable gameInputMappingCanvas : GameInputMappingCanvas = (box (tempDisplayable) :?> GameInputMappingCanvas)
                    ignore (gameInputMappingCanvas.update())
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, this.getInputMappingInstructionsCanvas())
            elif HighScoreCommandsFactory.getInstance().isHighScoreCommand(command) then
                let mutable tempDisplayable : Displayable = displayable
                if (box (tempDisplayable) :? HighScoresCanvas) then
                    let mutable highScoresCanvas : HighScoresCanvas = (box (tempDisplayable) :?> HighScoresCanvas)
                    highScoresCanvas.updateCommand(command)
            elif (JR.same(command, HighScoreCommands.getInstance().DISPLAY)) then
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, this.createHighScoresCanvas())
            elif (JR.same(command, GameInputMappingInstructionsCanvas.CLOSE)) then
                let mutable menuListener : MenuListener = (box (displayable) :?> MenuListener)
                menuListener.close()
                this.commandAction(GameInputMappingCanvas.DISPLAY, NullCanvas.NULL_CANVAS)
            elif (JR.same(command, GameInputMappingCanvas.DISPLAY)) then
                if J2MEUtil.isHTML() then
                    this.pauseAppBackground(false)
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, this.getInputMappingCanvas())
            elif (JR.same(command, GameInputMappingCanvas.DEFAULT)) then
                let mutable tempDisplayable : Displayable = displayable
                if (box (tempDisplayable) :? GameInputMappingCanvas) then
                    let mutable gameInputMappingCanvas : GameInputMappingCanvas = (box (tempDisplayable) :?> GameInputMappingCanvas)
                    gameInputMappingCanvas.setDefault()
            elif (JR.same(command, InGameOptionsForm.DISPLAY)) then
                this.pauseAppBackground(false)
                let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
                progressCanvas.addNormalPortion(50, "In Game Options")
                let mutable layerManager : AllBinaryGameLayerManager = this.createGameLayerManager()
                let mutable inGameOptionsFormFactory : InGameOptionsFormFactory = InGameOptionsFormFactory.getInstance()
                inGameOptionsFormFactory.init(this, (new InGameFeatures()), "Options In Game", layerManager.getBackgroundBasicColor(), layerManager.getForegroundBasicColor())
                let mutable inGameOptionsForm : CommandForm = inGameOptionsFormFactory.get()
                inGameOptionsForm.setItemStateListener(allbinaryGameCanvasRunnableInterface)
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, inGameOptionsForm)
            elif (JR.same(command, InGameOptionsForm.DEFAULT)) then
                let mutable inGameOptionsForm : InGameOptionsForm = (box (InGameOptionsFormFactory.getInstance().get()) :?> InGameOptionsForm)
                GameFeatureFormUtil.getInstance().setDefault(inGameOptionsForm)
            elif (JR.same(command, gameCommandsFactory.DISPLAY_OPTIONS)) then
                AllBinaryMediaManager.setMuted(true)
                this.stopAll()
                let mutable mainFeatureFactory : MainFeatureFactory = MainFeatureFactory.getInstance()
                this.isFullScreen <- this.features.isFeature(mainFeatureFactory.FULL_SCREEN)
                ResizableListenerHandler.getInstance().fireEvent(true)
                this.setResized(false)
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, this.getGameOptionsForm())
            elif (JR.same(command, gameCommandsFactory.CLOSE_OPTIONS)) then
                ResizableListenerHandler.getInstance().fireEvent(false)
                this.commandAction(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS, displayable)
                let mutable stringBuffer : StringMaker = (new StringMaker())
                ignore (stringBuffer.append("Close isFullScreen/change: "))
                ignore (stringBuffer.appendboolean(this.isFullScreen))
                ignore (stringBuffer.appendboolean(this.fullScreenUtil.isScreenChange(this.isFullScreen)))
                ignore (stringBuffer.append(" isResized: "))
                ignore (stringBuffer.appendboolean(this.isResized()))
                PreLogUtil.put(stringBuffer.ToString(), this, this.COMMAND_ACTION)
                if this.isResized() || this.fullScreenUtil.isScreenChange(this.isFullScreen) then
                    this.updateFullScreen()
                AllBinaryMediaManager.setMuted(false)
            elif (JR.same(command, gameCommandsFactory.DISPLAY_LOAD_FORM)) then
                this.pauseAppBackground(false)
                let mutable keyValuePersistance : KeyValuePersistance = GamePersistanceSingleton.getInstance()
                keyValuePersistance.clear()
                keyValuePersistance.loadAll(this.abeClientInformation)
                if (JR.same(this.getLoadGameForm(), CommandForm.getNullCommandForm())) then
                    let mutable layerManager : AllBinaryGameLayerManager = this.createGameLayerManager()
                    this.setLoadGameForm((new LoadGameForm(this, "Load Game", layerManager.getBackgroundBasicColor(), layerManager.getForegroundBasicColor())))
                else
                    ignore (this.getLoadGameForm().update())
                this.commandAction(gameCommandsFactory.SET_MENU_DISPLAYABLE, this.getLoadGameForm())
            elif (JR.same(command, gameCommandsFactory.LOAD_FILE)) then
                let mutable loadGameForm : LoadGameForm = (box (this.getLoadGameForm()) :?> LoadGameForm)
                let mutable index : int = loadGameForm.getSelectedId()
                if index <> (-1) then
                    let mutable keyValuePersistance : KeyValuePersistance = GamePersistanceSingleton.getInstance()
                    this.setStartStateHashtable(keyValuePersistance.get(index))
                    let mutable menuListener : MenuListener = this.getLoadGameForm()
                    menuListener.close()
                    PreLogUtil.put(BasicMotionGesturesHandler.getInstance().ToString(), this, this.COMMAND_ACTION)
                    this.commandAction(gameCommandsFactory.START_COMMAND, NullCanvas.NULL_CANVAS)
                    PreLogUtil.put(BasicMotionGesturesHandler.getInstance().ToString(), this, this.COMMAND_ACTION)
            elif (JR.same(command, gameCommandsFactory.DELETE_FILE)) then
                let mutable loadGameForm : LoadGameForm = (box (this.getLoadGameForm()) :?> LoadGameForm)
                let mutable index : int = loadGameForm.getSelectedText()
                if index <> (-1) then
                    let mutable keyValuePersistance : KeyValuePersistance = GamePersistanceSingleton.getInstance()
                    ignore (keyValuePersistance.delete(this.abeClientInformation, index))
                    keyValuePersistance.clear()
                    keyValuePersistance.loadAllSize(this.abeClientInformation, 1)
                    ignore (this.getLoadGameForm().update())
            elif (JR.same(command, gameCommandsFactory.SAVE)) then
                let mutable keyValuePersistance : KeyValuePersistance = GamePersistanceSingleton.getInstance()
                this.pauseAppBackground(false)
                keyValuePersistance.save(this.abeClientInformation, this.getCurrentStateHashtable())
                this.unPauseAppBackground(false)
            elif (JR.same(command, HighScoreUtil.SUBMIT_TEXTBOX_COMMAND)) then
                this.logUtil.putF("Submitted Score", this, this.COMMAND_ACTION)
                if (box (displayable) :? HighScoreTextBox) then
                    let mutable highScoreTextBox : HighScoreTextBox = (box (displayable) :?> HighScoreTextBox)
                    highScoreTextBox.submitted <- true
                allbinaryGameCanvasRunnableInterface.setHighScoreSubmitted(true)
                this.commandAction(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS, displayable)
            elif (JR.same(command, gameCommandsFactory.DISPLAY_ABOUT)) then
                this.aboutCommandProcessor.process_(this, gameCommandsFactory.SET_MENU_DISPLAYABLE, this.getAboutCanvas())
            elif (JR.same(command, gameCommandsFactory.OPEN_WEB_URL)) then
                this.webCommandProcessor.process_(this, gameCommandsFactory.OPEN_WEB_URL, NullCanvas.NULL_CANVAS)
            elif (JR.same(command, gameCommandsFactory.TOGGLE_KEYBOARD)) then
                let mutable virtualKeyboardEventHandler : VirtualKeyboardEventHandler = VirtualKeyboardEventHandler.getInstance()
                virtualKeyboardEventHandler.fireEvent(virtualKeyboardEventHandler.SHOW_EVENT)
            elif this.tsUtil.compareTo(command.getLabel(), gameCommandsFactory.TOGGLE_FULLSCREEN.getLabel()) = 0 then
                let mutable mainFeatureFactory : MainFeatureFactory = MainFeatureFactory.getInstance()
                let mutable isFullScreen : bool = this.features.isFeature(mainFeatureFactory.FULL_SCREEN)
                if isFullScreen then
                    this.features.removeDefault(mainFeatureFactory.FULL_SCREEN)
                else
                    this.features.addDefault(mainFeatureFactory.FULL_SCREEN)
                this.updateFullScreen()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put((new StringMaker()).append(this.commonStrings.EXCEPTION_LABEL).append(command.getLabel()).ToString(), this, this.midletStrings.COMMAND_ACTION, e)
                if not (JR.same(command, GameCommandsFactory.getInstance().EXIT_COMMAND)) then
                    this.exitProgress(false)
            | _ -> reraise ()
    
    member this.updateFullScreen() : unit =
        let mutable mainFeatureFactory : MainFeatureFactory = MainFeatureFactory.getInstance()
        let mutable isFullScreen : bool = this.features.isFeature(mainFeatureFactory.FULL_SCREEN)
        let mutable displayable : Displayable = this.getDisplay().getCurrent()
        if (box (displayable) :? Canvas) then
            let mutable canvas : Canvas = (box (displayable) :?> Canvas)
            canvas.setFullScreenMode(isFullScreen)
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract getInputMappingInstructionsCanvas : unit -> MyCanvas
    default this.getInputMappingInstructionsCanvas() : MyCanvas =
        (new GameInputMappingInstructionsCanvas(this, this.createGameLayerManager()))
    
    abstract getInputMappingCanvas : unit -> MyCanvas
    default this.getInputMappingCanvas() : MyCanvas =
        (new GameInputMappingCanvas(this.abeClientInformation, this, this.createGameLayerManager(), this.getHelpPaintable()))
    
    abstract getAboutCanvas : unit -> MyCanvas
    default this.getAboutCanvas() : MyCanvas =
        (new BasicPaintablesCanvas(this, CanvasStrings.getInstance().ABOUT, this.createGameLayerManager(), AboutPaintableFactory.getInstance().paintableArray))
    
    abstract getHelpPaintable : unit -> HelpPaintable
    default this.getHelpPaintable() : HelpPaintable =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract createHighScoresCanvas : unit -> HighScoresCanvas
    default this.createHighScoresCanvas() : HighScoresCanvas =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract startGameCanvasRunnableInterface : unit -> unit
    default this.startGameCanvasRunnableInterface() : unit =
        let mutable threadFactoryUtil : ThreadFactoryUtil = ThreadFactoryUtil.getInstance()
        this.thread <- threadFactoryUtil.getInstanceGameCanvasRunnable(this.allbinaryGameCanvasRunnableInterface)
        this.logUtil.putF((new StringMaker()).append("Thread Priority: ").appendint(this.thread.getPriority()).ToString(), this, "startGameCanvasRunnableInterface")
        this.allbinaryGameCanvasRunnableInterface.setThread(this.thread)
        threadFactoryUtil.start(this.thread)
    
    abstract stopGameCanvasRunnableInterface : unit -> unit
    default this.stopGameCanvasRunnableInterface() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.gameStrings.STOP_GAME_CANVAS_RUNNABLE_INTERFACE)
        GameNotificationEventHandler.getInstance().removeAllListeners()
        ColorChangeEventHandler.getInstance().removeAllListeners()
        GameEventHandlerUtil.removeAllListeners()
        let mutable gameCanvasRunnableInterface : GameCanvasRunnableInterface = this.allbinaryGameCanvasRunnableInterface
        if not (JR.same(gameCanvasRunnableInterface, NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)) then
            this.logUtil.putF((new StringMaker()).append("Set Running False: ").append(gameCanvasRunnableInterface.ToString()).ToString(), this, this.gameStrings.STOP_GAME_CANVAS_RUNNABLE_INTERFACE)
            gameCanvasRunnableInterface.setRunning(false)
        else
            this.logUtil.putF("StopGame - Could Not Stop", this, this.gameStrings.STOP_GAME_CANVAS_RUNNABLE_INTERFACE)
        ThreadUtil.getInstance().join(this.thread)
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        if this.features.isFeature(MainFeatureFactory.getInstance().LOAD_ALL) then
            progressCanvas.addNormalPortion(50, "Stopped Game Runnable")
        else
            progressCanvas.addNormalPortion(50, "Stopped Main Runnable")
        this.logUtil.putF(this.commonStrings.END, this, this.gameStrings.STOP_GAME_CANVAS_RUNNABLE_INTERFACE)
    
    abstract getGameCanvasRunnableInterface : unit -> GameCanvasRunnableInterface
    default this.getGameCanvasRunnableInterface() : GameCanvasRunnableInterface =
        this.allbinaryGameCanvasRunnableInterface
    
    abstract setGameCanvasRunnableInterface : gameCanvasRunnableInterface: GameCanvasRunnableInterface -> unit
    default this.setGameCanvasRunnableInterface(gameCanvasRunnableInterface: GameCanvasRunnableInterface) : unit =
        this.allbinaryGameCanvasRunnableInterface <- gameCanvasRunnableInterface
    
    abstract createGameLayerManager : unit -> AllBinaryGameLayerManager
    default this.createGameLayerManager() : AllBinaryGameLayerManager =
        let mutable gameInfo : GameInfo = (new GameInfo(GameTypeFactory.getInstance().SINGLE_PLAYER, GameMode.SERVER, PlayerTypesFactory.getInstance().PLAYER_TYPE_ONE, 1, 1))
        (new AllBinaryGameLayerManager(this.basicColorFactory.BLACK, this.basicColorFactory.WHITE, gameInfo))
    
    abstract getGameOptionsForm : unit -> CommandForm
    default this.getGameOptionsForm() : CommandForm =
        let mutable layerManager : AllBinaryGameLayerManager = this.createGameLayerManager()
        GameOptionsFormFactory.getInstance().init(this, "Game Options", layerManager.getBackgroundBasicColor(), layerManager.getForegroundBasicColor())
    
    abstract save : unit -> unit
    default this.save() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.SAVE)
        let mutable hashtable : ABHashtable = this.getCurrentStateHashtable()
        GamePersistanceSingleton.getInstance().save(this.abeClientInformation, hashtable)
    
    override this.getCurrentStateHashtable() : ABHashtable =
        this.logUtil.putF(this.commonStrings.START, this, "getCurrentStateHashtable")
        let mutable hashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        if not (JR.same(this.allbinaryGameCanvasRunnableInterface, NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE)) then
            let mutable currentHashtable : ABHashtable = this.allbinaryGameCanvasRunnableInterface.getCurrentStateHashtable()
            let mutable enumeration : Enumeration = currentHashtable.keys()
            let mutable key : obj = null
            while this.enumerationUtil.hasMoreElements(enumeration) do
                key <- this.enumerationUtil.nextElement(enumeration)
                ignore (hashtable.put(key, currentHashtable.get(key)))
        hashtable
    
    abstract setLoadGameForm : loadGameForm: LoadGameForm -> unit
    default this.setLoadGameForm(loadGameForm: LoadGameForm) : unit =
        this.loadGameForm <- loadGameForm
    
    abstract getLoadGameForm : unit -> CommandForm
    default this.getLoadGameForm() : CommandForm =
        this.loadGameForm
    
    abstract setResized : resized: bool -> unit
    default this.setResized(resized: bool) : unit =
        this.resized <- resized
    
    abstract isResized : unit -> bool
    default this.isResized() : bool =
        this.resized
    
    abstract isDemoLoading : unit -> bool
    default this.isDemoLoading() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.startedBefore then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            let mutable displayable : Displayable = this.getDisplay().getCurrent()
            if (box (displayable) :? DemoCanvas) then
                let mutable demoCanvas : DemoCanvas = (box (displayable) :?> DemoCanvas)
                if demoCanvas.isDemoLoading() then
                    jret <- true
                    jflow <- 1
            if jflow = 0 then
                jret <- false
                jflow <- 1
        jret
    interface CommandListener with
        member this.commandAction(jp0: Command, jp1: Displayable) : unit = this.commandAction(jp0, jp1)


