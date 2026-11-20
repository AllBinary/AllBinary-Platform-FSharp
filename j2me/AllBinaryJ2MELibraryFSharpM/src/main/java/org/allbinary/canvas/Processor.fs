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
type Processor =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : Processor
    static member SINGLETON with get() : Processor = (Processor.jclinit(); Processor.jcell_SINGLETON) and set (jvalue: Processor) = (Processor.jclinit(); Processor.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Processor.jclinitDone then
            Processor.jclinitDone <- true
            Processor.jclinitBody()
    static member private jclinitBody() : unit =
        Processor.jcell_SINGLETON <- (new Processor())
        ()
    new () =
        {  }
    
    static member getInstance() : Processor =
        Processor.SINGLETON
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        ()
    
    abstract processt : timeDelta: int64 -> unit
    default this.processt(timeDelta: int64) : unit =
        ()


