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
type HighScoresCanvas =
    inherit GameCommandCanvas
    [<DefaultValue(false)>] val mutable paintable : Paintable
    [<DefaultValue(false)>] val mutable highScoreCommandsFactory : HighScoreCommandsFactory
    [<DefaultValue(false)>] val mutable waitPaintable : SimpleTextPaintable
    [<DefaultValue(false)>] val mutable highScoresPaintable : HighScoresPaintable
    [<DefaultValue(false)>] val mutable highScoresFactoryInterface : HighScoresFactoryInterface
    [<DefaultValue(false)>] val mutable colorFillPaintable : ColorFillBasePaintable
    [<DefaultValue(false)>] val mutable highScoresHelper : HighScoresHelperBase
    [<DefaultValue(false)>] val mutable gameInfo : GameInfo
    [<DefaultValue(false)>] val mutable highScoresCanvasInputProcessor : HighScoresCanvasInputProcessor
    [<DefaultValue(false)>] val mutable currentCommand : Command
    [<DefaultValue(false)>] val mutable hasPainted : bool
    static member NAME : string = "HighScoresCanvas"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresCanvas.jclinitDone then
            HighScoresCanvas.jclinitDone <- true
            HighScoresCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoresCanvas() : unit =
        this.paintable <- NullPaintable.getInstance()
        this.highScoreCommandsFactory <- HighScoreCommandsFactory.getInstance()
        this.waitPaintable <- (new SimpleTextPaintable(this.commonStrings.PLEASE_WAIT_FOR_SERVER, BasicColorFactory.getInstance().WHITE))
        this.highScoresHelper <- (new HighScoresHelperBase())
        this.currentCommand <- this.highScoreCommandsFactory.HIGH_SCORE_COMMANDS.[0]
        this.hasPainted <- false
        ()
    
    new (commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager, gameInfo: GameInfo, paintable: HighScoresPaintable, highScoresFactoryInterface: HighScoresFactoryInterface, highScoresCanvasInputProcessorFactoryInterface: HighScoresCanvasInputProcessorFactoryInterface) as this =
        { inherit GameCommandCanvas(commandListener, HighScoresCanvas.NAME, allBinaryGameLayerManager.getBackgroundBasicColor(), allBinaryGameLayerManager.getForegroundBasicColor()) }
        then
            this.jfields_HighScoresCanvas()
            this.jctor1(commandListener, allBinaryGameLayerManager, gameInfo, paintable, highScoresFactoryInterface, highScoresCanvasInputProcessorFactoryInterface)
    member this.jctor1(commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager, gameInfo: GameInfo, paintable: HighScoresPaintable, highScoresFactoryInterface: HighScoresFactoryInterface, highScoresCanvasInputProcessorFactoryInterface: HighScoresCanvasInputProcessorFactoryInterface) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.highScoresPaintable <- paintable
        this.highScoresFactoryInterface <- highScoresFactoryInterface
        this.highScoresCanvasInputProcessor <- highScoresCanvasInputProcessorFactoryInterface.getInstance(this)
        this.gameInfo <- gameInfo
        this.waitPaintable.setBasicColorP(allBinaryGameLayerManager.getForegroundBasicColor())
        this.getHighScoresPaintable().setBasicColorP(allBinaryGameLayerManager.getForegroundBasicColor())
        this.colorFillPaintable <- ColorFillPaintableFactory.getInstance_jstatic().getInstance(allBinaryGameLayerManager.getBackgroundBasicColor(), false)
        if this.highScoresHelper.getHighScoresArray().Length = NoHighScoresFactory.getInstance().NO_HIGH_SCORES.Length then
            this.setPaintable(this.waitPaintable)
        else
            this.logUtil.putF("Show HighScores that are already loaded", this, this.commonStrings.CONSTRUCTOR)
            this.updateCommand(this.currentCommand)
            this.setPaintable(this.getHighScoresPaintable())
        SecondaryThreadPool.getInstance().runTask((new HighScoreRunnable(this)))
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommand(GameCommandsFactory.getInstance().CLOSE_AND_SHOW_GAME_CANVAS)
        this.setCommandListener(cmdListener)
    
    override this.open_() : unit =
        base.open_()
        this.highScoresCanvasInputProcessor.open_()
    
    override this.close() : unit =
        base.close()
        this.highScoresCanvasInputProcessor.close()
    
    override this.paint(graphics: Graphics) : unit =
        this.colorFillPaintable.paint(graphics)
        this.paintable.paint(graphics)
        if not (JR.same(this.waitPaintable, this.paintable)) then
            this.highScoresCanvasInputProcessor.paint(graphics)
        base.paint(graphics)
        this.hasPainted <- true
    
    abstract executeUpdate : unit -> unit
    default this.executeUpdate() : unit =
        try
            this.highScoresFactoryInterface.fetchHighScores(this.getGameInfo(), this)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    member this.getHighScoresPaintable() : HighScoresPaintable =
        this.highScoresPaintable
    
    abstract setHighScoresArray : highScoresArray: HighScores[] -> unit
    default this.setHighScoresArray(highScoresArray: HighScores[]) : unit =
        try
            if not (JR.same(highScoresArray, null)) then
                this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).appendint(highScoresArray.Length).ToString(), this, "setHighScoresArray")
            else
                this.logUtil.putF(this.commonStrings.START, this, "setHighScoresArray")
            this.highScoresHelper.setHighScoresArray(highScoresArray)
            this.updateCommand(this.currentCommand)
            this.setPaintable(this.getHighScoresPaintable())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    abstract updateCommand : command: Command -> unit
    default this.updateCommand(command: Command) : unit =
        this.logUtil.putF((new StringMaker()).append(this.commonStrings.START).append(this.stringUtil.toString(command)).ToString(), this, this.commonStrings.UPDATE)
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        if this.highScoreCommandsFactory.isHighScoreCommand(command) then
            let mutable index : int = this.highScoreCommandsFactory.getIndex(command)
            let mutable nextIndex : int = index + 1
            let mutable highScoresArray : HighScores[] = this.highScoresHelper.getHighScoresArray()
            if nextIndex >= highScoresArray.Length then
                nextIndex <- 0
            if highScoresArray.Length > 0 then
                this.getHighScoresPaintable().setHighScores(highScoresArray.[index])
            else
                this.getHighScoresPaintable().setHighScores(NullHighScoresSingletonFactory.getInstance())
            if index <> nextIndex then
                this.removeAllCommands()
                this.addCommand(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS)
                this.addCommand(this.highScoreCommandsFactory.HIGH_SCORE_COMMANDS.[nextIndex])
        this.currentCommand <- command
        this.close()
        base.initMenu()
        this.open_()
        this.repaintBehavior.onChangeRepaint(this)
    
    abstract getGameInfo : unit -> GameInfo
    default this.getGameInfo() : GameInfo =
        this.gameInfo
    
    member this.setPaintable(paintable: Paintable) : unit =
        this.paintable <- paintable
        this.repaintBehavior.onChangeRepaint(this)
    interface HighScoresResultsListener with
        member this.setHighScoresArray(jp0: HighScores[]) : unit = this.setHighScoresArray(jp0)


