namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type MusicThreadPool =
    inherit ThreadPool
    [<DefaultValue(false)>] static val mutable private jcell_THREAD_POOL : ThreadPool
    static member THREAD_POOL with get() : ThreadPool = (MusicThreadPool.jclinit(); MusicThreadPool.jcell_THREAD_POOL) and set (jvalue: ThreadPool) = (MusicThreadPool.jclinit(); MusicThreadPool.jcell_THREAD_POOL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MusicThreadPool.jclinitDone then
            MusicThreadPool.jclinitDone <- true
            MusicThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        MusicThreadPool.jcell_THREAD_POOL <- (new ThreadPool("Music", 2, ThreadPool.NORMAL_PRIORITY))
        ()
    
    static member getInstance() : ThreadPool =
        MusicThreadPool.THREAD_POOL
    
    new (poolName: string, numThreads: int, priority: int) =
        { inherit ThreadPool(poolName, numThreads, priority) }
    
    override this.runTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.threadPoolStrings.ADD_TASK)
        base.runTask(task)
    
    override this.startTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.START_TASK).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.commonStrings.RUN)
    
    override this.completedTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.COMPLETE_TASK).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.commonStrings.RUN)


