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
type SWTProcessorUtil =
    [<DefaultValue(false)>] val mutable swtProcessor : SWTProcessor
    [<DefaultValue(false)>] static val mutable private jcell_instance : SWTProcessorUtil
    static member instance with get() : SWTProcessorUtil = (SWTProcessorUtil.jclinit(); SWTProcessorUtil.jcell_instance) and set (jvalue: SWTProcessorUtil) = (SWTProcessorUtil.jclinit(); SWTProcessorUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTProcessorUtil.jclinitDone then
            SWTProcessorUtil.jclinitDone <- true
            SWTProcessorUtil.jclinitBody()
    static member private jclinitBody() : unit =
        SWTProcessorUtil.jcell_instance <- (new SWTProcessorUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_SWTProcessorUtil()
    member this.jfields_SWTProcessorUtil() : unit =
        this.swtProcessor <- SWTProcessor.getInstance()
        ()
    
    static member getInstance() : SWTProcessorUtil =
        SWTProcessorUtil.instance


