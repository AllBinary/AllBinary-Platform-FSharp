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
type ThreadUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable JOIN : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadUtil
    static member instance with get() : ThreadUtil = (ThreadUtil.jclinit(); ThreadUtil.jcell_instance) and set (jvalue: ThreadUtil) = (ThreadUtil.jclinit(); ThreadUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreadUtil.jclinitDone then
            ThreadUtil.jclinitDone <- true
            ThreadUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ThreadUtil.jcell_instance <- (new ThreadUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ThreadUtil()
    member this.jfields_ThreadUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.JOIN <- "join"
        ()
    
    static member getInstance() : ThreadUtil =
        ThreadUtil.instance
    
    abstract isRunning : thread: Thread -> bool
    default this.isRunning(thread: Thread) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (not (JR.same(thread, null))) && thread.isAlive() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract join : thread: Thread -> unit
    default this.join(thread: Thread) : unit =
        if ThreadUtil.getInstance().isRunning(thread) then
            this.logUtil.putF("Waiting for Thread To Join/End", this, this.JOIN)
            ignore (thread.join())


