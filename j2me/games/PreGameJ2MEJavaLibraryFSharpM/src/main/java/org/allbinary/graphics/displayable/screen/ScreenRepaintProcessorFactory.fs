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
type ScreenRepaintProcessorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScreenRepaintProcessorFactory
    static member instance with get() : ScreenRepaintProcessorFactory = (ScreenRepaintProcessorFactory.jclinit(); ScreenRepaintProcessorFactory.jcell_instance) and set (jvalue: ScreenRepaintProcessorFactory) = (ScreenRepaintProcessorFactory.jclinit(); ScreenRepaintProcessorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenRepaintProcessorFactory.jclinitDone then
            ScreenRepaintProcessorFactory.jclinitDone <- true
            ScreenRepaintProcessorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ScreenRepaintProcessorFactory.jcell_instance <- (new ScreenRepaintProcessorFactory())
        ()
    
    static member getInstance() : ScreenRepaintProcessorFactory =
        ScreenRepaintProcessorFactory.instance
    
    new () =
        {  }
    
    abstract create : displayable: Displayable -> Processor
    default this.create(displayable: Displayable) : Processor =
        let mutable jflow = 0
        let mutable jret : Processor = Unchecked.defaultof<Processor>
        if not (J2MEUtil.isJ2ME()) then
            jret <- (new ScreenRepaintProcessor(displayable))
            jflow <- 1
        else
            jret <- Processor.getInstance()
            jflow <- 1
        jret


