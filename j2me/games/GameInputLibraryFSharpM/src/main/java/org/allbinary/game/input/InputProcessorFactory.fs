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
type InputProcessorFactory =
    [<DefaultValue(false)>] val mutable inputProcessor : InputProcessor
    [<DefaultValue(false)>] static val mutable private jcell_instance : InputProcessorFactory
    static member instance with get() : InputProcessorFactory = (InputProcessorFactory.jclinit(); InputProcessorFactory.jcell_instance) and set (jvalue: InputProcessorFactory) = (InputProcessorFactory.jclinit(); InputProcessorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputProcessorFactory.jclinitDone then
            InputProcessorFactory.jclinitDone <- true
            InputProcessorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InputProcessorFactory.jcell_instance <- (new InputProcessorFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_InputProcessorFactory()
    member this.jfields_InputProcessorFactory() : unit =
        this.inputProcessor <- (new InputProcessor())
        ()
    
    static member getInstance() : InputProcessorFactory =
        InputProcessorFactory.instance
    
    abstract getInputProcessor : unit -> InputProcessor
    default this.getInputProcessor() : InputProcessor =
        this.inputProcessor


