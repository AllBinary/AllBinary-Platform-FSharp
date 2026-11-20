namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type PooledThread =
    inherit Thread
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable threadObjectUtil : ThreadObjectUtil
    [<DefaultValue(false)>] val mutable threadPool : ThreadPool
    [<DefaultValue(false)>] val mutable INTERRUPT_EXCEPTION : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PooledThread.jclinitDone then
            PooledThread.jclinitDone <- true
            PooledThread.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PooledThread() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.threadObjectUtil <- ThreadObjectUtil.getInstance()
        this.INTERRUPT_EXCEPTION <- "Exit InterruptedException"
        ()
    
    new (threadPool: ThreadPool) as this =
        { inherit Thread(threadPool.createName()) }
        then
            this.jfields_PooledThread()
            this.jctor1(threadPool)
    member this.jctor1(threadPool: ThreadPool) : unit =
        ()
        this.logUtil.putF(this.commonStrings.CONSTRUCTOR, this, this.commonStrings.CONSTRUCTOR)
        this.threadPool <- threadPool
        ()
    
    override this.run() : unit =
        let mutable jflow = 0
        this.threadPool.threadStarted()
        while jflow = 0 && (true) do
            let mutable task2 : Runnable = this.threadObjectUtil.NULL_PRIORITY_RUNNABLE
            try
                task2 <- this.threadPool.getTask()
                this.threadPool.runningTask <- true
                this.threadPool.startTask(task2)
            with jex ->
                match JR.throwable(jex) with
                | :? JInterruptedException as ex ->
                    let mutable logUtil : LogUtil = LogUtil.getInstance()
                    logUtil.putF(this.INTERRUPT_EXCEPTION, this, this.commonStrings.RUN)
                    jflow <- 100001
                | _ -> reraise ()
            if jflow = 0 then
                if (JR.same(task2, this.threadObjectUtil.NULL_PRIORITY_RUNNABLE)) then
                    jflow <- 100001
                if jflow = 0 then
                    try
                        task2.run()
                        this.threadPool.completedTask(task2)
                        this.threadPool.runningTask <- false
                    with jex ->
                        match JR.throwable(jex) with
                        | :? JException as e ->
                            let mutable logUtil : LogUtil = LogUtil.getInstance()
                            logUtil.put((new StringMaker()).append(this.commonStrings.EXCEPTION_LABEL).append(StringUtil.getInstance().toString(task2)).ToString(), this, this.commonStrings.RUN, e)
                        | _ -> reraise ()
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            this.threadPool.threadStopped()


