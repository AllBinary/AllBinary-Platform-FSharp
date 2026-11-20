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
type PrimaryThreadPool =
    inherit ThreadPool
    [<DefaultValue(false)>] static val mutable private jcell_THREAD_POOL : ThreadPool
    static member THREAD_POOL with get() : ThreadPool = (PrimaryThreadPool.jclinit(); PrimaryThreadPool.jcell_THREAD_POOL) and set (jvalue: ThreadPool) = (PrimaryThreadPool.jclinit(); PrimaryThreadPool.jcell_THREAD_POOL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PrimaryThreadPool.jclinitDone then
            PrimaryThreadPool.jclinitDone <- true
            PrimaryThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        PrimaryThreadPool.jcell_THREAD_POOL <- (new ThreadPool("Primary", 1, ThreadPool.NORMAL_PRIORITY))
        ()
    
    static member getInstance() : ThreadPool =
        PrimaryThreadPool.THREAD_POOL
    
    new (poolName: string, numThreads: int, priority: int) =
        { inherit ThreadPool(poolName, numThreads, priority) }
    
    override this.runTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.threadPoolStrings.ADD_TASK)
        base.runTask(task)
    
    override this.startTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.START_TASK).append(StringUtil.getInstance().toString(task)).ToString(), this, this.commonStrings.RUN)
    
    override this.completedTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.COMPLETE_TASK).append(StringUtil.getInstance().toString(task)).ToString(), this, this.commonStrings.RUN)


