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
type MidletExitProcessorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : MidletExitProcessorFactory
    static member instance with get() : MidletExitProcessorFactory = (MidletExitProcessorFactory.jclinit(); MidletExitProcessorFactory.jcell_instance) and set (jvalue: MidletExitProcessorFactory) = (MidletExitProcessorFactory.jclinit(); MidletExitProcessorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MidletExitProcessorFactory.jclinitDone then
            MidletExitProcessorFactory.jclinitDone <- true
            MidletExitProcessorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MidletExitProcessorFactory.jcell_instance <- (new MidletExitProcessorFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : MidletExitProcessorFactory =
        MidletExitProcessorFactory.instance
    
    abstract getExitInstance : midlet: MIDlet -> Processor
    default this.getExitInstance(midlet: MIDlet) : Processor =
        let mutable jflow = 0
        let mutable jret : Processor = Unchecked.defaultof<Processor>
        if AppletUtil.isAppletLoader(midlet) || J2MEUtil.isJ2ME() then
            jret <- Processor.getInstance()
            jflow <- 1
        else
            jret <- (new MidletExitProcessor(midlet))
            jflow <- 1
        jret


