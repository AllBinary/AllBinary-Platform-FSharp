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
type PathFindingThreadPool =
    inherit ThreadPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadPool
    static member instance with get() : ThreadPool = (PathFindingThreadPool.jclinit(); PathFindingThreadPool.jcell_instance) and set (jvalue: ThreadPool) = (PathFindingThreadPool.jclinit(); PathFindingThreadPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PathFindingThreadPool.jclinitDone then
            PathFindingThreadPool.jclinitDone <- true
            PathFindingThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        PathFindingThreadPool.jcell_instance <- (new PathFindingThreadPool("PathFinding", 1, 1))
        ()
    
    static member getInstance() : ThreadPool =
        PathFindingThreadPool.instance
    
    new (poolName: string, numThreads: int, priority: int) =
        { inherit ThreadPool(poolName, numThreads, ThreadPool.NORMAL_PRIORITY) }
    
    override this.runTaskWithPriority(task: PriorityRunnable) : unit =
        base.runTaskWithPriority(task)
    
    override this.runTask(task: Runnable) : unit =
        base.runTask(task)
    
    override this.startTask(task: Runnable) : unit =
        ()
    
    override this.completedTask(task: Runnable) : unit =
        ()


