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
type ThreadFactoryUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadFactoryUtil
    static member instance with get() : ThreadFactoryUtil = (ThreadFactoryUtil.jclinit(); ThreadFactoryUtil.jcell_instance) and set (jvalue: ThreadFactoryUtil) = (ThreadFactoryUtil.jclinit(); ThreadFactoryUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreadFactoryUtil.jclinitDone then
            ThreadFactoryUtil.jclinitDone <- true
            ThreadFactoryUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ThreadFactoryUtil.jcell_instance <- (new ThreadFactoryUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ThreadFactoryUtil()
    member this.jfields_ThreadFactoryUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : ThreadFactoryUtil =
        ThreadFactoryUtil.instance
    
    abstract getInstanceGameCanvasRunnable : runnable: GameCanvasRunnableInterface -> Thread
    default this.getInstanceGameCanvasRunnable(runnable: GameCanvasRunnableInterface) : Thread =
        this.getInstanceType(runnable, runnable.getType())
    
    abstract getInstanceForRunnable : runnable: ABRunnable -> Thread
    default this.getInstanceForRunnable(runnable: ABRunnable) : Thread =
        this.getInstanceType(runnable, runnable.getType())
    
    member this.getInstanceType(runnable: Runnable, type_: int) : Thread =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        if J2MEUtil.isHTML() then
            if (type_ = DemoCanvas.TYPE) || (type_ = AllBinaryGameCanvas.TYPE) then
                let mutable demoGameSingleThreadStartRunnable : RunnableCanvasSingleThreadStartRunnable = (new RunnableCanvasSingleThreadStartRunnable((box (runnable) :?> RunnableCanvas)))
                PreLogUtil.put((new StringMaker()).append("Using Pseudo Thread for DemoCanvas/AllBinaryGameCanvas under PlayN/HTML5: ").append(StringUtil.getInstance().toString(runnable)).ToString(), this, commonStrings.CONSTRUCTOR)
                let mutable primaryThreadPool : ThreadPool = PrimaryThreadPool.getInstance()
                primaryThreadPool.runTask(demoGameSingleThreadStartRunnable)
            else
                PreLogUtil.put((new StringMaker()).append("Using Pseudo Thread for Runnable under PlayN/HTML5: ").append(StringUtil.getInstance().toString(runnable)).ToString(), this, commonStrings.CONSTRUCTOR)
                let mutable primaryThreadPool : ThreadPool = PrimaryThreadPool.getInstance()
                primaryThreadPool.runTask(runnable)
        let mutable thread : Thread = (new Thread(runnable, runnable.ToString()))
        this.logUtil.putF(thread.ToString(), this, commonStrings.CONSTRUCTOR)
        thread
    
    abstract start : thread: Thread -> unit
    default this.start(thread: Thread) : unit =
        thread.start()


