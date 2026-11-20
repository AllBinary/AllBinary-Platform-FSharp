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
type CommandFormInputProcessor =
    inherit BasicMenuInputProcessor
    [<DefaultValue(false)>] val mutable MOTION_GESTURE_SOURCE_ID : int
    [<DefaultValue(false)>] val mutable CLICK_DELAY : int
    [<DefaultValue(false)>] val mutable clickTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable DOUBLE_CLICK_DELAY : int
    [<DefaultValue(false)>] val mutable doubleClickTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable isSingleKeyProcessing : bool
    [<DefaultValue(false)>] val mutable form : ScrollSelectionForm
    [<DefaultValue(false)>] val mutable hasPressed : bool
    [<DefaultValue(false)>] val mutable PROCESS_COMMAND : string
    [<DefaultValue(false)>] val mutable NAME_LABEL : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandFormInputProcessor.jclinitDone then
            CommandFormInputProcessor.jclinitDone <- true
            CommandFormInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CommandFormInputProcessor() : unit =
        this.MOTION_GESTURE_SOURCE_ID <- GameKeyEventFactory.getInstance().MOTION_GESTURE_SOURCE_ID
        this.CLICK_DELAY <- 150
        this.clickTimeHelper <- (new TimeDelayHelper(this.CLICK_DELAY))
        this.DOUBLE_CLICK_DELAY <- 1200
        this.doubleClickTimeHelper <- (new TimeDelayHelper(this.DOUBLE_CLICK_DELAY))
        this.isSingleKeyProcessing <- InputFeatureFactory.getInstance().isSingleKeyProcessing()
        this.hasPressed <- false
        this.PROCESS_COMMAND <- "processCommand"
        this.NAME_LABEL <- " ScrollSelectionForm: "
        ()
    
    new (gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: MyCanvas, form: ScrollSelectionForm) as this =
        { inherit BasicMenuInputProcessor(gameKeyEventList, playerInputId, gameCanvas) }
        then
            this.jfields_CommandFormInputProcessor()
            this.jctor1(gameKeyEventList, playerInputId, gameCanvas, form)
    member this.jctor1(gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: MyCanvas, form: ScrollSelectionForm) : unit =
        ()
        this.form <- form
        ()
    
    abstract processInput : key: int -> int
    default this.processInput(key: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if (((key = Canvas.LEFT) || (key = Canvas.RIGHT)) || (key = Canvas.UP)) || (key = Canvas.DOWN) then
            ignore (PrimaryPlayerQueueFactory.getInstance().add(SelectSound.getInstance()))
            ignore (this.form.processInputKey(key))
            jret <- 1
            jflow <- 1
        elif key = Canvas.FIRE then
            ignore (PrimaryPlayerQueueFactory.getInstance().add(SelectSound.getInstance()))
            jret <- this.processCommand()
            jflow <- 1
        if jflow = 0 then
            jret <- 0
            jflow <- 1
        jret
    
    member this.processCommand() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable commandCurrentSelectionForm : CommandCurrentSelectionForm = (box (this.form) :?> CommandCurrentSelectionForm)
        let mutable command : Command = commandCurrentSelectionForm.getSelectedCommand()
        this.logUtil.putF(command.ToString(), this, this.PROCESS_COMMAND)
        let mutable features : Features = Features.getInstance()
        let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
        if (SWTUtil.isSWT && features.isFeature(openGLFeatureFactory.OPENGL)) && (not (JR.same(command, GameCommandsFactory.getInstance().EXIT_COMMAND))) then
            (new CommandRunnable(this, command)).run()
        else
            PrimaryThreadPool.getInstance().runTask((new CommandRunnable(this, command)))
        if (JR.same(command, GameCommandsFactory.getInstance().QUIT_COMMAND)) then
            jret <- -1
            jflow <- 1
        else
            jret <- 1
            jflow <- 1
        jret
    
    override this.processInputList() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        try
            let mutable motionInputsIndex : int = this.processMotionInputs()
            let mutable list_ : BasicArrayList = this.getGameKeyEventList()
            let mutable size : int = list_.size()
            let mutable key : int = 0
            let mutable gameKeyEvent : GameKeyEvent = null
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                gameKeyEvent <- (box (list_.objectArray.[index]) :?> GameKeyEvent)
                key <- gameKeyEvent.getKey()
                if gameKeyEvent.getSourceId() <> this.MOTION_GESTURE_SOURCE_ID then
                    if this.processInput(key) = 1 then
                        jflow <- 100001
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                this.clear()
                if (size > 0) || (motionInputsIndex >= 0) then
                    jret <- 1
                    jflow <- 1
                else
                    jret <- -1
                    jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.gameInputStrings.PROCESS_INPUT, e)
                jret <- -1
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract processMotionInputs : unit -> int
    default this.processMotionInputs() : int =
        let mutable lastIndex : int = this.motionGestureEventList.size() - 1
        if lastIndex >= 0 then
            let mutable motionGestureEvent : MotionGestureEvent = (box (this.motionGestureEventList.objectArray.[lastIndex]) :?> MotionGestureEvent)
            this.processMotionInput(motionGestureEvent)
        this.motionGestureEventList.clear()
        lastIndex
    
    abstract processMotionInput : motionGestureEvent: MotionGestureEvent -> unit
    default this.processMotionInput(motionGestureEvent: MotionGestureEvent) : unit =
        let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
        let mutable motionGestureInput : MotionGestureInput = motionGestureEvent.getMotionGesture()
        if (JR.same(motionGestureInput, touchMotionGestureFactory.RELEASED)) then
            let mutable point : GPoint = motionGestureEvent.getCurrentPoint()
            if this.form.isInForm(point) then
                let mutable index : int = this.form.getSelectedIndexForPoint(point)
                if index <> (-1) then
                    ignore (PrimaryPlayerQueueFactory.getInstance().add(SelectSound.getInstance()))
                    if index = this.form.getSelectedIndex() then
                        if this.clickTimeHelper.isTimeTNT() then
                            ignore (this.processCommand())
                    else
                        this.form.setSelectedIndex(index)
                else
                    ()
            if this.hasPressed then
                if not (this.doubleClickTimeHelper.isTimeTNT()) then
                    this.logUtil.putF("Double Press", this, this.gameInputStrings.PROCESS_MOTION_INPUT)
                    ignore (this.processCommand())
                this.doubleClickTimeHelper.delay <- this.DOUBLE_CLICK_DELAY
                this.doubleClickTimeHelper.setStartTimeTNT()
            this.hasPressed <- false
        elif (JR.same(motionGestureInput, touchMotionGestureFactory.PRESSED)) then
            this.doubleClickTimeHelper.delay <- 0
            this.hasPressed <- true
    
    override this.ToString() : string =
        (new StringMaker()).append(base.ToString()).append(this.NAME_LABEL).append(this.form.ToString()).ToString()


