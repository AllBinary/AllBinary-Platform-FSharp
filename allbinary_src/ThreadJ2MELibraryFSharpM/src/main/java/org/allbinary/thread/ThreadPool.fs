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
type ThreadPool =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable NULL_RUNNABLE : NullRunnable
    [<DefaultValue(false)>] val mutable threadPoolStrings : ThreadPoolStrings
    [<DefaultValue(false)>] val mutable threadObjectUtil : ThreadObjectUtil
    [<DefaultValue(false)>] val mutable poolName : string
    [<DefaultValue(false)>] val mutable priority : int
    [<DefaultValue(false)>] val mutable isAlive : bool
    [<DefaultValue(false)>] val mutable taskQueue : BasicArrayList
    [<DefaultValue(false)>] val mutable threadID : int
    [<DefaultValue(false)>] val mutable numThreads : int
    [<DefaultValue(false)>] val mutable runningTask : bool
    static member ROOT_NAME : string = "-PooledThread-"
    [<DefaultValue(false)>] static val mutable private jcell_NORMAL_PRIORITY : int
    static member NORMAL_PRIORITY with get() : int = (ThreadPool.jclinit(); ThreadPool.jcell_NORMAL_PRIORITY) and set (jvalue: int) = (ThreadPool.jclinit(); ThreadPool.jcell_NORMAL_PRIORITY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreadPool.jclinitDone then
            ThreadPool.jclinitDone <- true
            ThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        ThreadPool.jcell_NORMAL_PRIORITY <- Thread.NORM_PRIORITY
        ()
    member this.jfields_ThreadPool() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.NULL_RUNNABLE <- NullRunnable.getInstance()
        this.threadPoolStrings <- ThreadPoolStrings.getInstance()
        this.threadObjectUtil <- ThreadObjectUtil.getInstance()
        this.isAlive <- false
        this.taskQueue <- BasicArrayListUtil.getInstance().getImmutableInstance()
        ()
    
    new (poolName: string, numThreads: int, priority: int) as this =
        {  }
        then
            this.jfields_ThreadPool()
            this.jctor1(poolName, numThreads, priority)
    member this.jctor1(poolName: string, numThreads: int, priority: int) : unit =
        this.poolName <- poolName
        this.priority <- priority
        this.numThreads <- numThreads
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        if not (this.isAlive) then
            this.isAlive <- true
            this.taskQueue <- (new BasicArrayListD())
            let mutable pooledThread : PooledThread = null
            let mutable i : int = 0
            while i < this.numThreads do
                pooledThread <- (new PooledThread(this))
                ignore (pooledThread.setPriority(this.priority))
                ignore (pooledThread.start())
                i <- i + 1
    
    abstract runAPriorityTask : unit -> unit
    default this.runAPriorityTask() : unit =
        raise ((new JRuntimeException()))
    
    abstract runTaskWithPriority : task: PriorityRunnable -> unit
    default this.runTaskWithPriority(task: PriorityRunnable) : unit =
        let mutable jflow = 0
        if true then
            if not (this.isAlive) then
                this.init()
            if not (JR.same(task, null)) then
                let mutable size : int = this.taskQueue.size()
                let mutable runnable : PriorityRunnable = null
                let mutable lowerPriorityRunnable : PriorityRunnable = this.threadObjectUtil.NULL_PRIORITY_RUNNABLE
                let mutable index : int = 0
                while jflow = 0 && (index < size) do
                    runnable <- (box (this.taskQueue.get(index)) :?> PriorityRunnable)
                    if runnable.getPriority() > task.getPriority() then
                        lowerPriorityRunnable <- runnable
                        jflow <- 100002
                    if jflow = 200002 then jflow <- 0
                    if jflow = 0 then index <- index + 1
                if jflow = 100002 then jflow <- 0
                if jflow = 0 then
                    if (JR.same(lowerPriorityRunnable, this.threadObjectUtil.NULL_PRIORITY_RUNNABLE)) then
                        ignore (this.taskQueue.add(task))
                    else
                        let mutable index : int = this.taskQueue.indexOf(lowerPriorityRunnable)
                        this.taskQueue.addAt(index, task)
                    ignore (JR.notify(this))
    
    abstract runTask : task: Runnable -> unit
    default this.runTask(task: Runnable) : unit =
        if true then
            if not (this.isAlive) then
                this.init()
            if not (JR.same(task, null)) then
                ignore (this.taskQueue.add(task))
                ignore (JR.notify(this))
    
    abstract getTask : unit -> Runnable
    default this.getTask() : Runnable =
        let mutable jflow = 0
        let mutable jret : Runnable = Unchecked.defaultof<Runnable>
        if true then
            while jflow = 0 && (this.taskQueue.size() = 0) do
                if not (this.isAlive) then
                    jret <- this.NULL_RUNNABLE
                    jflow <- 1
                if jflow = 0 then
                    ignore (JR.wait(this))
                if jflow = 200003 then jflow <- 0
            if jflow = 100003 then jflow <- 0
            if jflow = 0 then
                let mutable runnable : Runnable = (box (this.taskQueue.removeAt(0)) :?> Runnable)
                jret <- runnable
                jflow <- 1
        jret
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        if true then
            if this.isAlive then
                this.taskQueue.clear()
    
    abstract close : unit -> unit
    default this.close() : unit =
        if true then
            if this.isAlive then
                this.isAlive <- false
                this.taskQueue.clear()
    
    abstract join : unit -> unit
    default this.join() : unit =
        if true then
            this.isAlive <- false
            this.taskQueue.clear()
            ignore (JR.notifyAll(this))
    
    abstract isBusy : unit -> bool
    default this.isBusy() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if not (this.isAlive) then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            if this.taskQueue.size() > 0 then
                jret <- true
                jflow <- 1
            if jflow = 0 then
                if this.runningTask then
                    jret <- true
                    jflow <- 1
                if jflow = 0 then
                    jret <- false
                    jflow <- 1
        jret
    
    abstract threadStarted : unit -> unit
    default this.threadStarted() : unit =
        ()
    
    abstract threadStopped : unit -> unit
    default this.threadStopped() : unit =
        if this.numThreads = 1 then
            this.isAlive <- false
            this.taskQueue.clear()
    
    abstract startTask : task: Runnable -> unit
    default this.startTask(task: Runnable) : unit =
        ()
    
    abstract completedTask : task: Runnable -> unit
    default this.completedTask(task: Runnable) : unit =
        ()
    
    abstract createName : unit -> string
    default this.createName() : string =
        (new StringMaker()).append(this.poolName).append(ThreadPool.ROOT_NAME).appendint((let jt = this.threadID in this.threadID <- this.threadID + 1; jt)).ToString()


