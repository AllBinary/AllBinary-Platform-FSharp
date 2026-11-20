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
type ProgressMidlet =
    inherit AllBinaryMidlet
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ProgressMidlet.jclinitDone then
            ProgressMidlet.jclinitDone <- true
            ProgressMidlet.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (clientInformationFactory: ClientInformationFactory) as this =
        { inherit AllBinaryMidlet() }
        then
            this.jctor1(clientInformationFactory)
    member this.jctor1(clientInformationFactory: ClientInformationFactory) : unit =
        this.preInit()
        this.abeClientInformation <- clientInformationFactory.getInstance()
        ()
    
    abstract preInit : unit -> unit
    default this.preInit() : unit =
        ()
    
    abstract exitProgress : isProgress: bool -> unit
    default this.exitProgress(isProgress: bool) : unit =
        let mutable processor : Processor = MidletExitProcessorFactory.getInstance().getExitInstance(this)
        try
            let mutable primaryThreadPool : ThreadPool = PrimaryThreadPool.getInstance()
            let mutable runnable : Runnable = (new ExitRunnable(this, processor, isProgress))
            primaryThreadPool.runTask(runnable)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "exit", e)
                try
                    processor.process_()
                with jex ->
                    match JR.throwable(jex) with
                    | :? JException as e2 ->
                        this.logUtil.put(this.commonStrings.EXCEPTION, this, "exit", e)
                    | _ -> reraise ()
            | _ -> reraise ()


