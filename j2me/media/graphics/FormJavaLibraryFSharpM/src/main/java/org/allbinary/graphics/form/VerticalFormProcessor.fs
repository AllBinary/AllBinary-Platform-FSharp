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
type VerticalFormProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable scrollCurrentSelectionForm : ScrollCurrentSelectionForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VerticalFormProcessor.jclinitDone then
            VerticalFormProcessor.jclinitDone <- true
            VerticalFormProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (scrollCurrentSelectionForm: ScrollCurrentSelectionForm) as this =
        { inherit Processor() }
        then
            this.jctor1(scrollCurrentSelectionForm)
    member this.jctor1(scrollCurrentSelectionForm: ScrollCurrentSelectionForm) : unit =
        this.scrollCurrentSelectionForm <- scrollCurrentSelectionForm
        ()
    
    override this.process_() : unit =
        this.scrollCurrentSelectionForm.processVerticalForm()
        this.scrollCurrentSelectionForm.processor <- Processor.getInstance()


