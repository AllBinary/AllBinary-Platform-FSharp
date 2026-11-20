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
type LogFormatUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LogFormatUtil
    static member instance with get() : LogFormatUtil = (LogFormatUtil.jclinit(); LogFormatUtil.jcell_instance) and set (jvalue: LogFormatUtil) = (LogFormatUtil.jclinit(); LogFormatUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogFormatUtil.jclinitDone then
            LogFormatUtil.jclinitDone <- true
            LogFormatUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LogFormatUtil.jcell_instance <- (new LogFormatUtil())
        ()
    
    static member getInstance() : LogFormatUtil =
        LogFormatUtil.instance
    
    new () =
        {  }
    
    abstract get : className: string * functionName: string * specialMessage: string * exception_: obj -> string
    default this.get(className: string, functionName: string, specialMessage: string, exception_: obj) : string =
        raise ((new JRuntimeException()))
    
    abstract getS : className: string * functionName: string * specialMessage: string -> string
    default this.getS(className: string, functionName: string, specialMessage: string) : string =
        raise ((new JRuntimeException()))
    
    abstract getO : exception_: obj -> string
    default this.getO(exception_: obj) : string =
        raise ((new JRuntimeException()))


