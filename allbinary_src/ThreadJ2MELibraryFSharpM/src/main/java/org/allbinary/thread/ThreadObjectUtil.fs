namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ThreadObjectUtil =
    [<DefaultValue(false)>] val mutable NULL_PRIORITY_RUNNABLE : PriorityRunnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadObjectUtil
    static member instance with get() : ThreadObjectUtil = (ThreadObjectUtil.jclinit(); ThreadObjectUtil.jcell_instance) and set (jvalue: ThreadObjectUtil) = (ThreadObjectUtil.jclinit(); ThreadObjectUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreadObjectUtil.jclinitDone then
            ThreadObjectUtil.jclinitDone <- true
            ThreadObjectUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ThreadObjectUtil.jcell_instance <- (new ThreadObjectUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ThreadObjectUtil()
    member this.jfields_ThreadObjectUtil() : unit =
        this.NULL_PRIORITY_RUNNABLE <- (new NullPriorityRunnable())
        ()
    
    static member getInstance() : ThreadObjectUtil =
        ThreadObjectUtil.instance
    
    abstract notifyObject : anyType: obj -> unit
    default this.notifyObject(anyType: obj) : unit =
        ignore (JR.notify(anyType))
    
    abstract waitObject : anyType: obj -> unit
    default this.waitObject(anyType: obj) : unit =
        ignore (JR.wait(anyType))
    
    abstract waitObjectFor : anyType: obj * delay: int64 -> unit
    default this.waitObjectFor(anyType: obj, delay: int64) : unit =
        TsUtil.getInstance().waitFor(anyType, delay)
    
    abstract processThread : runnable: Runnable -> unit
    default this.processThread(runnable: Runnable) : unit =
        let mutable thread : Thread = (new Thread(runnable))
        ignore (thread.start())


