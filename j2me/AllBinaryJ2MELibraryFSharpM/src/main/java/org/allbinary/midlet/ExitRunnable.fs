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
type ExitRunnable =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable midlet : AllBinaryMidlet
    [<DefaultValue(false)>] val mutable processor : Processor
    [<DefaultValue(false)>] val mutable isProgress : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ExitRunnable.jclinitDone then
            ExitRunnable.jclinitDone <- true
            ExitRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ExitRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (midlet: AllBinaryMidlet, processor: Processor, isProgress: bool) as this =
        {  }
        then
            this.jfields_ExitRunnable()
            this.jctor1(midlet, processor, isProgress)
    member this.jctor1(midlet: AllBinaryMidlet, processor: Processor, isProgress: bool) : unit =
        this.midlet <- midlet
        this.isProgress <- isProgress
        this.processor <- processor
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        try
            this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
            this.midlet.destroyAppInRunnable(false, this.isProgress)
            this.midlet.setDisplay(NullCanvas.NULL_CANVAS)
            this.midlet.notifyDestroyed()
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
            this.processor.process_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
                try
                    this.processor.process_()
                with jex ->
                    match JR.throwable(jex) with
                    | :? JException as e2 ->
                        this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
                    | _ -> reraise ()
            | _ -> reraise ()
    interface Runnable with
        member this.run() : unit = this.run()


