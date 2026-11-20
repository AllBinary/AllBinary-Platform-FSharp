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
        let mutable specialMessage : string = log.getSpecialMessage()
        let mutable anyType : obj = log.getObject()
        let mutable functionName : string = log.getFunctionName()
        let mutable exception_ : obj = log.getThrowable()
        this.put(specialMessage, anyType, functionName, exception_)
    
    abstract putF : specialMessage: string * anyType: obj * functionName: string -> unit
    default this.putF(specialMessage: string, anyType: obj, functionName: string) : unit =
        let mutable className : string = CommonStrings.getInstance().EMPTY
        if not (JR.same(JR.getClass(anyType), null)) then
            className <- JString.newString((new StringMaker()).append(JR.getClass(anyType)).append(CommonSeps.getInstance().COLON).append(Integer.toHexString(TsUtil.getInstance().hashCode(anyType))).ToString())
        let mutable message : string = this.logFormatUtil.getS(className, functionName, specialMessage)
        JSystem.out.print(this.LOG_SUCCESS)
        JSystem.out.println(message)
    
    abstract putFS : specialMessage: string * className: string * functionName: string -> unit
    default this.putFS(specialMessage: string, className: string, functionName: string) : unit =
        let mutable message : string = this.logFormatUtil.getS(className, functionName, specialMessage)
        JSystem.out.print(this.LOG_SUCCESS)
        JSystem.out.println(message)
    
    abstract put : specialMessage: string * anyType: obj * functionName: string * exception_: obj -> unit
    default this.put(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : unit =
        let mutable className : string = CommonStrings.getInstance().EMPTY
        if not (JR.same(JR.getClass(anyType), null)) then
            let mutable hashCodeValue : int = TsUtil.getInstance().hashCode(anyType)
            let mutable hexString : string = Integer.toHexString(hashCodeValue)
            className <- JString.newString((new StringMaker()).append(JR.getClass(anyType)).append(CommonSeps.getInstance().COLON).append(hexString).ToString())
        let mutable message : string = this.logFormatUtil.get(className, functionName, specialMessage, exception_)
        JSystem.out.print(this.LOG_SUCCESS)
        JSystem.out.println(message)


