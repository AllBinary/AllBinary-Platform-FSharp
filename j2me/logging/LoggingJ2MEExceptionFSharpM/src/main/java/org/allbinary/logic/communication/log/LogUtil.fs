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
    [<DefaultValue(false)>] val mutable logFormatUtil : LogFormatUtil
    [<DefaultValue(false)>] val mutable LOG_SUCCESS : string
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
    member this.jfields_LogUtil() : unit =
        this.logFormatUtil <- LogFormatUtil.getInstance()
        this.LOG_SUCCESS <- "org.allbinary: "
        ()
    
    static member getInstance() : LogUtil =
        LogUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_LogUtil()
    
    abstract putL : log: Log -> unit
    default this.putL(log: Log) : unit =
        let mutable jflow = 0
        if (JR.same(log, LogFactory.LOG)) then
            jflow <- 1
        if jflow = 0 then
            let mutable exception_ : obj = log.getThrowable()
            if (JR.same(exception_, null)) then
                jflow <- 1
            if jflow = 0 then
                let mutable specialMessage : string = log.getSpecialMessage()
                let mutable anyType : obj = log.getObject()
                let mutable functionName : string = log.getFunctionName()
                this.put(specialMessage, anyType, functionName, exception_)
    
    abstract putF : specialMessage: string * anyType: obj * functionName: string -> unit
    default this.putF(specialMessage: string, anyType: obj, functionName: string) : unit =
        ()
    
    abstract putFS : specialMessage: string * className: string * functionName: string -> unit
    default this.putFS(specialMessage: string, className: string, functionName: string) : unit =
        ()
    
    abstract put : specialMessage: string * anyType: obj * functionName: string * exception_: obj -> unit
    default this.put(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : unit =
        let mutable className : string = CommonStrings.getInstance().EMPTY
        if not (JR.same(JR.getClass(anyType), null)) then
            className <- JString.newString(JR.getClass(anyType))
        let mutable message : string = this.logFormatUtil.get(className, functionName, specialMessage, exception_)
        JSystem.out.print(this.LOG_SUCCESS)
        JSystem.out.println(message)


