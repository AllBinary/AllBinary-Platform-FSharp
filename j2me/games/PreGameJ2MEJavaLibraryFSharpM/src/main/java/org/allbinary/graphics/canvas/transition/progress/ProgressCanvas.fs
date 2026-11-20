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
type ProgressCanvas =
    inherit RunnableCanvas
    [<DefaultValue(false)>] val mutable hasPainted : bool
    [<DefaultValue(false)>] val mutable backgroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable GAUGE_PAINTABLE : Paintable
    [<DefaultValue(false)>] val mutable maxValue : float32
    [<DefaultValue(false)>] val mutable gauge : ABCustomGaugeItem
    [<DefaultValue(false)>] val mutable TEXT : string
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable allbinaryMidlet : AllBinaryMidlet
    [<DefaultValue(false)>] val mutable value : float32
    [<DefaultValue(false)>] val mutable text : string
    [<DefaultValue(false)>] val mutable background : bool
    [<DefaultValue(false)>] val mutable paintable : PaintableInterface
    [<DefaultValue(false)>] val mutable inProgress : bool
    [<DefaultValue(false)>] val mutable IN_GAME_PROCESSOR : Processor
    [<DefaultValue(false)>] val mutable inGameProcessor : Processor
    [<DefaultValue(false)>] val mutable progressEndListener : ProgressEndListener
    [<DefaultValue(false)>] val mutable backgroundLabel : string
    [<DefaultValue(false)>] val mutable START_BACKGROUND : string
    [<DefaultValue(false)>] val mutable ADD_PORTION : string
    [<DefaultValue(false)>] val mutable ADD_EARLY_PORTION : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ProgressCanvas.jclinitDone then
            ProgressCanvas.jclinitDone <- true
            ProgressCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ProgressCanvas() : unit =
        this.GAUGE_PAINTABLE <- (new ProgressPaintable(this))
        this.maxValue <- 100.0f
        this.TEXT <- this.commonStrings.LOADING
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.allbinaryMidlet <- AllBinaryMidlet.getNullInstance()
        this.text <- this.TEXT
        this.background <- true
        this.paintable <- this.GAUGE_PAINTABLE
        this.inProgress <- false
        this.IN_GAME_PROCESSOR <- (new ProgressCanvas_jAnon1(this))
        this.inGameProcessor <- Processor.getInstance()
        this.progressEndListener <- ProgressEndListener.instance
        this.backgroundLabel <- "Background AI Game Loading..."
        this.START_BACKGROUND <- "startBackground"
        this.ADD_PORTION <- "addPortion"
        this.ADD_EARLY_PORTION <- "addEarlyPortion"
        ()
    
    new (title: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit RunnableCanvas(NullCommandListener.NULL_COMMAND_LISTENER, CanvasStrings.getInstance().EMPTY_CHILD_NAME_LIST, false) }
        then
            this.jfields_ProgressCanvas()
            this.jctor1(title, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.backgroundBasicColor <- backgroundBasicColor
        this.gauge <- (new ABCustomGaugeItem(StringUtil.getInstance().EMPTY_STRING, JR.d2i(float (this.maxValue)), 0, backgroundBasicColor, foregroundBasicColor))
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.gauge.setHeight((font.getHeight() + 2))
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract init : gameMidlet: AllBinaryMidlet -> unit
    default this.init(gameMidlet: AllBinaryMidlet) : unit =
        this.allbinaryMidlet <- gameMidlet
    
    abstract update : graphics: Graphics -> unit
    default this.update(graphics: Graphics) : unit =
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        ()
    
    member this.getMaxValue() : float32 =
        this.maxValue
    
    abstract start : unit -> unit
    default this.start() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.START_METHOD_NAME)
        this.setBackground(true)
        this.gauge.setHeight(30)
        this.gauge.setLabel(this.commonStrings.PLEASE_WAIT)
        this.setText(this.TEXT)
        this.setValue(0)
        this.inGameProcessor <- Processor.getInstance()
        this.paintable <- this.GAUGE_PAINTABLE
        this.inProgress <- true
    
    abstract startBackground : background: bool -> unit
    default this.startBackground(background: bool) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.START_BACKGROUND)
        this.setBackground(background)
        this.myFontProcessor <- this.updateMyFontProcessor
        this.gauge.setLabel(this.backgroundLabel)
        this.setText(this.TEXT)
        this.setValue(0)
        this.inGameProcessor <- Processor.getInstance()
        this.paintable <- this.GAUGE_PAINTABLE
    
    abstract endActual : unit -> unit
    default this.endActual() : unit =
        this.allbinaryMidlet.commandAction(GameCommandsFactory.getInstance().SHOW_GAME_CANVAS, NullCanvas.NULL_CANVAS)
        this.inProgress <- false
        this.inGame()
    
    abstract inGame : unit -> unit
    default this.inGame() : unit =
        this.progressEndListener.onEndEvent()
        this.inGameProcessor <- this.IN_GAME_PROCESSOR
    
    abstract end_ : unit -> unit
    default this.end_() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.END_METHOD_NAME)
        this.gauge.setValue(this.getMaxValue())
        this.endActual()
        this.paintable <- NullPaintable.getInstance()
    
    abstract endFromInitialLazyLoadingComplete : unit -> unit
    default this.endFromInitialLazyLoadingComplete() : unit =
        this.progressEndListener.onEndEvent()
        this.gauge.setValue(this.getMaxValue())
        this.inGameProcessor <- this.IN_GAME_PROCESSOR
    
    abstract isInGame : unit -> bool
    default this.isInGame() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this.inGameProcessor, this.IN_GAME_PROCESSOR)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract endIfPaintedSinceStart : unit -> unit
    default this.endIfPaintedSinceStart() : unit =
        ()
    
    abstract addEarlyPortion : value: int * text: string * index: int -> unit
    default this.addEarlyPortion(value: int, text: string, index: int) : unit =
        this.setText((new StringMaker()).append(text).append(SmallIntegerSingletonFactory.getInstance().getAt(index).ToString()).ToString())
        this.gauge.setValue((float32 (this.gauge.getValue()) + (this.getMaxValue() / float32 (value))))
    
    abstract addPortion : value: int * text: string * index: int -> unit
    default this.addPortion(value: int, text: string, index: int) : unit =
        this.setText((new StringMaker()).append(text).append(SmallIntegerSingletonFactory.getInstance().getAt(index).ToString()).ToString())
        PreLogUtil.put(this.text, this, this.ADD_PORTION)
        this.gauge.setValue((float32 (this.gauge.getValue()) + (this.getMaxValue() / float32 (value))))
    
    abstract addNormalPortion : value: int * text: string -> unit
    default this.addNormalPortion(value: int, text: string) : unit =
        if not (JR.sameString(this.text, text)) then
            PreLogUtil.put(text, this, this.ADD_PORTION)
        this.setText(text)
        this.gauge.setValue((float32 (this.gauge.getValue()) + (this.getMaxValue() / float32 (value))))
    
    abstract setValue : value: int -> unit
    default this.setValue(value: int) : unit =
        this.value <- float32 (value)
        this.gauge.setValue(float32 (value))
    
    override this.paint(graphics: Graphics) : unit =
        this.paintable.paint(graphics)
    
    abstract paint2 : graphics: Graphics -> unit
    default this.paint2(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        graphics.setColor(this.backgroundBasicColor.intValue())
        graphics.fillRect(0, 0, this.displayInfo.getLastWidth(), this.displayInfo.getLastHeight())
        this.gauge.paintXY(graphics, 0, 0)
        this.hasPainted <- true
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract getValue : unit -> float32
    default this.getValue() : float32 =
        this.value
    
    abstract setText : text: string -> unit
    default this.setText(text: string) : unit =
        this.text <- text
    
    abstract getText : unit -> string
    default this.getText() : string =
        this.text
    
    abstract setBackground : background: bool -> unit
    default this.setBackground(background: bool) : unit =
        this.background <- background
    
    abstract isBackground : unit -> bool
    default this.isBackground() : bool =
        this.background
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


[<AllowNullLiteral>]
type ProgressCanvas_jAnon1 =
    inherit Processor
    [<DefaultValue(false)>] val mutable jouter : ProgressCanvas
    [<DefaultValue(false)>] val mutable pathFindingThreadPool : ThreadPool
    new (jouter: ProgressCanvas) as this =
        { inherit Processor() }
        then
            this.jouter <- jouter
            this.pathFindingThreadPool <- PathFindingThreadPool.getInstance()
            ()
    override this.process_() : unit =
        this.pathFindingThreadPool.runAPriorityTask()


