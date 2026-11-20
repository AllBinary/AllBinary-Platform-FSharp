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
    [<DefaultValue(false)>] val mutable timeStampUtil : TimeStampUtil
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] val mutable NONE : string
    [<DefaultValue(false)>] val mutable LOG_ERROR : string
    [<DefaultValue(false)>] val mutable EMPTY : string
    [<DefaultValue(false)>] val mutable STACK_TRACE : string
    [<DefaultValue(false)>] val mutable TIME : string
    [<DefaultValue(false)>] val mutable CLASS_NAME : string
    [<DefaultValue(false)>] val mutable FUNCTION_CALL : string
    [<DefaultValue(false)>] val mutable SPECIAL_MESSAGE : string
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable exceptionUtil : ExceptionUtil
    [<DefaultValue(false)>] val mutable nullUtil : NullUtil
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
    member this.jfields_LogFormatUtil() : unit =
        this.timeStampUtil <- TimeStampUtil.getInstance()
        this.commonSeps <- CommonSeps.getInstance()
        this.NONE <- "None"
        this.LOG_ERROR <- "\nLog-Error: "
        this.EMPTY <- "Empty"
        this.STACK_TRACE <- "\nStack Trace: "
        this.TIME <- "Time: "
        this.CLASS_NAME <- this.commonSeps.SPACE
        this.FUNCTION_CALL <- CommonLabels.getInstance().COLON_SEP
        this.SPECIAL_MESSAGE <- "> "
        this.stringUtil <- StringUtil.getInstance()
        this.exceptionUtil <- ExceptionUtil.getInstance()
        this.nullUtil <- NullUtil.getInstance()
        ()
    
    static member getInstance() : LogFormatUtil =
        LogFormatUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_LogFormatUtil()
    
    abstract get : className: string * functionName: string * specialMessage: string * exception_: obj -> string
    default this.get(className: string, functionName: string, specialMessage: string, exception_: obj) : string =
        let mutable stringBuffer : StringMaker = this.getF(className, functionName)
        ignore (stringBuffer.append(this.getO(exception_)))
        ignore (stringBuffer.append(this.SPECIAL_MESSAGE))
        ignore (stringBuffer.append(specialMessage))
        ignore (stringBuffer.append(this.commonSeps.NEW_LINE))
        stringBuffer.ToString()
    
    abstract getS : className: string * functionName: string * specialMessage: string -> string
    default this.getS(className: string, functionName: string, specialMessage: string) : string =
        let mutable stringBuffer : StringMaker = this.getF(className, functionName)
        ignore (stringBuffer.append(this.SPECIAL_MESSAGE))
        ignore (stringBuffer.append(specialMessage))
        ignore (stringBuffer.append(this.commonSeps.NEW_LINE))
        stringBuffer.ToString()
    
    member this.getF(className: string, functionName: string) : StringMaker =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.TIME))
        ignore (stringBuffer.append(this.timeStampUtil.getAsString()))
        ignore (stringBuffer.append(this.CLASS_NAME))
        ignore (stringBuffer.append(className))
        ignore (stringBuffer.append(this.FUNCTION_CALL))
        ignore (stringBuffer.append(functionName))
        stringBuffer
    
    abstract getO : exception_: obj -> string
    default this.getO(exception_: obj) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if not (JR.same(exception_, this.nullUtil.NULL_OBJECT)) then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(this.LOG_ERROR))
            let mutable exceptionAsString : string = exception_.ToString()
            ignore (stringBuffer.append(exceptionAsString))
            ignore (stringBuffer.append(this.STACK_TRACE))
            if not (JR.same(exception_, this.nullUtil.NULL_OBJECT)) then
                ignore (stringBuffer.append(this.exceptionUtil.getStackTrace((box (exception_) :?> JThrowable))))
            else
                ignore (stringBuffer.append(this.stringUtil.NULL_STRING))
            jret <- stringBuffer.ToString()
            jflow <- 1
        else
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        jret


