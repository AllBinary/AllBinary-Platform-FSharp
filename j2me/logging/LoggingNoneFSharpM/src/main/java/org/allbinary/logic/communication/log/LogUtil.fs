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
type LogUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LogUtil
    static member instance with get() : LogUtil = (LogUtil.jclinit(); LogUtil.jcell_instance) and set (jvalue: LogUtil) = (LogUtil.jclinit(); LogUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogUtil.jclinitDone then
            LogUtil.jclinitDone <- true
            LogUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LogUtil.jcell_instance <- (new LogUtil())
        ()
    
    static member getInstance() : LogUtil =
        LogUtil.instance
    
    new () =
        {  }
    
    abstract putP : log: Log -> unit
    default this.putP(log: Log) : unit =
        ()
    
    abstract putF : specialMessage: string * anyType: obj * functionName: string -> unit
    default this.putF(specialMessage: string, anyType: obj, functionName: string) : unit =
        ()
    
    abstract putFS : specialMessage: string * className: string * functionName: string -> unit
    default this.putFS(specialMessage: string, className: string, functionName: string) : unit =
        ()
    
    abstract put : specialMessage: string * anyType: obj * functionName: string * exception_: obj -> unit
    default this.put(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : unit =
        ()


