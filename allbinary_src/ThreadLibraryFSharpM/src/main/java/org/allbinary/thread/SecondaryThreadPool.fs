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
type SecondaryThreadPool =
    inherit ThreadPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadPool
    static member instance with get() : ThreadPool = (SecondaryThreadPool.jclinit(); SecondaryThreadPool.jcell_instance) and set (jvalue: ThreadPool) = (SecondaryThreadPool.jclinit(); SecondaryThreadPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SecondaryThreadPool.jclinitDone then
            SecondaryThreadPool.jclinitDone <- true
            SecondaryThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        SecondaryThreadPool.jcell_instance <- (new SecondaryThreadPool("Secondary", 1, ThreadPool.NORMAL_PRIORITY))
        ()
    
    static member getInstance() : ThreadPool =
        SecondaryThreadPool.instance
    
    new (poolName: string, numThreads: int, priority: int) =
        { inherit ThreadPool(poolName, numThreads, priority) }
    
    override this.runTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.threadPoolStrings.ADD_TASK)
        base.runTask(task)
    
    override this.startTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.START_TASK).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.commonStrings.RUN)
    
    override this.completedTask(task: Runnable) : unit =
        this.logUtil.putF((new StringMaker()).append(this.threadPoolStrings.COMPLETE_TASK).append(StringUtil.getInstance().toString(task)).appendlong(JSystem.currentTimeMillis()).ToString(), this, this.commonStrings.RUN)


