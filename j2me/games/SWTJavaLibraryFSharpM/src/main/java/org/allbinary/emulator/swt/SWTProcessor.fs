namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type SWTProcessor =
    [<DefaultValue(false)>] val mutable runnable : Runnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : SWTProcessor
    static member instance with get() : SWTProcessor = (SWTProcessor.jclinit(); SWTProcessor.jcell_instance) and set (jvalue: SWTProcessor) = (SWTProcessor.jclinit(); SWTProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTProcessor.jclinitDone then
            SWTProcessor.jclinitDone <- true
            SWTProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        SWTProcessor.jcell_instance <- (new SWTProcessor())
        ()
    member this.jfields_SWTProcessor() : unit =
        this.runnable <- NullRunnable.getInstance()
        ()
    
    static member getInstance() : SWTProcessor =
        SWTProcessor.instance
    
    new () as this =
        {  }
        then
            this.jfields_SWTProcessor()
    
    abstract process_ : display: EclipseDisplay -> unit
    default this.process_(display: EclipseDisplay) : unit =
        ignore (display.sleep())


