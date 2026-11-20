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
type SWTRunnableProcessor =
    inherit SWTProcessor
    [<DefaultValue(false)>] static val mutable private jcell_instanceR : SWTRunnableProcessor
    static member instanceR with get() : SWTRunnableProcessor = (SWTRunnableProcessor.jclinit(); SWTRunnableProcessor.jcell_instanceR) and set (jvalue: SWTRunnableProcessor) = (SWTRunnableProcessor.jclinit(); SWTRunnableProcessor.jcell_instanceR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTRunnableProcessor.jclinitDone then
            SWTRunnableProcessor.jclinitDone <- true
            SWTRunnableProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        SWTRunnableProcessor.jcell_instanceR <- (new SWTRunnableProcessor())
        ()
    
    static member getInstance() : SWTRunnableProcessor =
        SWTRunnableProcessor.instanceR
    
    new () =
        { inherit SWTProcessor() }
    
    override this.process_(display: EclipseDisplay) : unit =
        ignore (this.runnable.run())


