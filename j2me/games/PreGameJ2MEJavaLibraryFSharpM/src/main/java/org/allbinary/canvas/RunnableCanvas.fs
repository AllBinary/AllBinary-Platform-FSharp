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
type RunnableCanvas =
    inherit MyCanvas
    [<DefaultValue(false)>] val mutable nullUtil : NullUtil
    [<DefaultValue(false)>] val mutable stdUtil : StdUtil
    [<DefaultValue(false)>] val mutable systemWrapper : ABSystemWrapper
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable thread : Thread
    [<DefaultValue(false)>] val mutable currentThread : Thread
    [<DefaultValue(false)>] val mutable running : bool
    [<DefaultValue(false)>] val mutable loopTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable runnableCanvasRefreshHelper : Processor
    [<DefaultValue(false)>] val mutable commonLabels : CommonLabels
    [<DefaultValue(false)>] val mutable threadObjectUtil : ThreadObjectUtil
    [<DefaultValue(false)>] val mutable SET_RUNNING : string
    [<DefaultValue(false)>] val mutable IS_RUNNING : string
    [<DefaultValue(false)>] val mutable THREAD : string
    [<DefaultValue(false)>] val mutable NOT_EQUAL : string
    [<DefaultValue(false)>] val mutable PAUSE_SLEEP : string
    [<DefaultValue(false)>] val mutable START_PAUSE : string
    [<DefaultValue(false)>] val mutable END_PAUSE : string
    [<DefaultValue(false)>] val mutable PROCESS_LOOP_SLEEP : string
    [<DefaultValue(false)>] val mutable pauseWait : int64
    [<DefaultValue(false)>] val mutable notified : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RunnableCanvas.jclinitDone then
            RunnableCanvas.jclinitDone <- true
            RunnableCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RunnableCanvas() : unit =
        this.nullUtil <- NullUtil.getInstance()
        this.stdUtil <- StdUtil.getInstance()
        this.systemWrapper <- ABSystemWrapper.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.thread <- NullThread.NULL_THREAD
        this.currentThread <- NullThread.NULL_THREAD
        this.loopTimeHelper <- (new TimeDelayHelper(NullWaitGameRunnable.getInstance().WAIT))
        this.runnableCanvasRefreshHelper <- Processor.getInstance()
        this.commonLabels <- CommonLabels.getInstance()
        this.threadObjectUtil <- ThreadObjectUtil.getInstance()
        this.SET_RUNNING <- "setRunning"
        this.IS_RUNNING <- "isRunning"
        this.THREAD <- "Thread: "
        this.NOT_EQUAL <- " != "
        this.PAUSE_SLEEP <- "pause sleep"
        this.START_PAUSE <- "start pause - game thread sleep at: "
        this.END_PAUSE <- "end pause - game thread sleep at: "
        this.PROCESS_LOOP_SLEEP <- "processLoopSleep"
        this.pauseWait <- 0L
        this.notified <- false
        ()
    
    new (commandListener: CommandListener, childNameList: BasicArrayList, hasParam: bool) as this =
        { inherit MyCanvas(CommonStrings.getInstance().UNKNOWN, childNameList) }
        then
            this.jfields_RunnableCanvas()
            this.jctor1(commandListener, childNameList, hasParam)
    member this.jctor1(commandListener: CommandListener, childNameList: BasicArrayList, hasParam: bool) : unit =
        ()
        this.logUtil.putF((new StringMaker()).append("RunnableCanvas delay: ").appendint(this.loopTimeHelper.delay).ToString(), this, this.commonStrings.CONSTRUCTOR)
        this.runnableCanvasRefreshHelper <- (new RunnableCanvasRefreshHelper(this))
        if not (JR.same(commandListener, null)) then
            this.initCommands(commandListener)
        elif hasParam then
            this.logUtil.putF("commandListener was null", this, "initCommands")
        ()
    
    abstract initCommands : cmdListener: CommandListener -> unit
    default this.initCommands(cmdListener: CommandListener) : unit =
        this.logUtil.putF(this.commonStrings.NOT_IMPLEMENTED, this, "initCommands")
    
    abstract isMainCanvas : unit -> bool
    default this.isMainCanvas() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if not (JR.same(this.getCustomCommandListener(), null)) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract setThread : thread: Thread -> unit
    default this.setThread(thread: Thread) : unit =
        this.thread <- thread
    
    abstract setRunning : running: bool -> unit
    default this.setRunning(running: bool) : unit =
        this.running <- running
        if not (this.running) then
            this.thread <- NullThread.NULL_THREAD
            if true then
                this.threadObjectUtil.notifyObject(this)
        this.logUtil.putF((new StringMaker()).append(this.IS_RUNNING).appendboolean(this.running).ToString(), this, this.SET_RUNNING)
    
    abstract isRunning : unit -> bool
    default this.isRunning() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this.thread, this.currentThread)) then
            jret <- this.running
            jflow <- 1
        else
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(this.THREAD))
            if not (JR.same(this.thread, null)) then
                ignore (stringBuffer.append(this.thread.ToString()))
            ignore (stringBuffer.append(this.NOT_EQUAL))
            if not (JR.same(this.currentThread, null)) then
                ignore (stringBuffer.append(StringUtil.getInstance().toString(this.currentThread)))
            this.logUtil.putF(stringBuffer.ToString(), this, this.IS_RUNNING)
            jret <- false
            jflow <- 1
        jret
    
    abstract getLoopTimeHelperP : unit -> TimeDelayHelper
    default this.getLoopTimeHelperP() : TimeDelayHelper =
        this.loopTimeHelper
    
    abstract setWait : wait: int -> unit
    default this.setWait(wait: int) : unit =
        this.loopTimeHelper.delay <- wait
        this.pauseWait <- int64 (wait) * 3L
        this.logUtil.putF((new StringMaker()).append("setWait - delay: ").appendint(this.loopTimeHelper.delay).ToString(), this, this.commonStrings.CONSTRUCTOR)
    
    abstract getWait : unit -> int
    default this.getWait() : int =
        this.loopTimeHelper.delay
    
    abstract setCurrentThread : unit -> unit
    default this.setCurrentThread() : unit =
        this.currentThread <- Thread.currentThread()
    
    abstract setCurrentThreadFake : unit -> unit
    default this.setCurrentThreadFake() : unit =
        this.currentThread <- this.thread
    
    override this.showNotify() : unit =
        try
            this.stopWaiting()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "showNotify", e)
            | _ -> reraise ()
    
    member this.stopWaiting() : unit =
        this.notified <- true
        if true then
            this.threadObjectUtil.notifyObject(this)
        this.repaint()
    
    abstract waitOnNotify : wait: int64 -> unit
    default this.waitOnNotify(wait: int64) : unit =
        if not (this.notified) then
            if wait > 0L then
                this.threadObjectUtil.waitObjectFor(this, wait)
            else
                this.threadObjectUtil.waitObject(this)
    
    abstract processSleep : unit -> unit
    default this.processSleep() : unit =
        ignore (Thread.sleep(this.pauseWait))
    
    abstract isPausable : unit -> bool
    default this.isPausable() : bool =
        false
    
    abstract processGameSleep : sleep: int64 -> unit
    default this.processGameSleep(sleep: int64) : unit =
        ignore (Thread.sleep(sleep))
    
    abstract processLoopSleep : unit -> unit
    default this.processLoopSleep() : unit =
        let mutable jflow = 0
        this.runnableCanvasRefreshHelper.process_()
        if this.isPaused() then
            let mutable stringMaker : StringMaker = (new StringMaker())
            if this.isRunning() && (not (this.isSingleThread())) then
                ignore (stringMaker.delete(0, stringMaker.length()))
                let mutable currentTimeMillis : int64 = this.systemWrapper.currentTimeMillis()
                this.logUtil.putF(stringMaker.append(this.START_PAUSE).appendlong(currentTimeMillis).append(this.PAUSE_SLEEP).appendlong(this.pauseWait).ToString(), this, this.PROCESS_LOOP_SLEEP)
                while jflow = 0 && ((this.isPaused() && this.isRunning()) && (not (this.isSingleThread()))) do
                    this.processSleep()
                    if not (this.isPausable()) then
                        ignore (stringMaker.delete(0, stringMaker.length()))
                        this.logUtil.putF(stringMaker.append(this.END_PAUSE).appendlong(currentTimeMillis).ToString(), this, this.PROCESS_LOOP_SLEEP)
                        jflow <- 1
                    if jflow = 200001 then jflow <- 0
                if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            let mutable elapsedTime : int64 = this.loopTimeHelper.getElapsedTNT()
            let mutable wait : int64 = int64 (this.loopTimeHelper.delay)
            if elapsedTime > wait then
                elapsedTime <- wait
            else
                this.processGameSleep((wait - elapsedTime))
    
    abstract isSingleThread : unit -> bool
    default this.isSingleThread() : bool =
        false
    
    abstract run : unit -> unit
    default this.run() : unit =
        this.setCurrentThread()
    
    abstract end2 : unit -> unit
    default this.end2() : unit =
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        -1
    interface RunnableInterface with
        member this.isRunning() : bool = this.isRunning()
        member this.setRunning(jp0: bool) : unit = this.setRunning(jp0)
        member this.setThread(jp0: Thread) : unit = this.setThread(jp0)
    interface Runnable with
        member this.run() : unit = this.run()


