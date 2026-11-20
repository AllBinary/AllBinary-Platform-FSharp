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
type ExceptionUtil =
    [<DefaultValue(false)>] val mutable NONE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ExceptionUtil
    static member instance with get() : ExceptionUtil = (ExceptionUtil.jclinit(); ExceptionUtil.jcell_instance) and set (jvalue: ExceptionUtil) = (ExceptionUtil.jclinit(); ExceptionUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_PRETEND_EXCEPTION : JException
    static member PRETEND_EXCEPTION with get() : JException = (ExceptionUtil.jclinit(); ExceptionUtil.jcell_PRETEND_EXCEPTION) and set (jvalue: JException) = (ExceptionUtil.jclinit(); ExceptionUtil.jcell_PRETEND_EXCEPTION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ExceptionUtil.jclinitDone then
            ExceptionUtil.jclinitDone <- true
            ExceptionUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ExceptionUtil.jcell_instance <- (new ExceptionUtil())
        ExceptionUtil.jcell_PRETEND_EXCEPTION <- (new JException("Not Really An Exception"))
        ()
    member this.jfields_ExceptionUtil() : unit =
        this.NONE <- "No Stack Trace"
        ()
    
    static member getInstance() : ExceptionUtil =
        ExceptionUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_ExceptionUtil()
    
    abstract getStackTrace : e: JThrowable -> string
    default this.getStackTrace(e: JThrowable) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if not (JR.same(e, null)) then
            let mutable byteArrayOutputStream : ByteArrayOutputStream = (new ByteArrayOutputStream())
            let mutable printStream : PrintStream = (new PrintStream(byteArrayOutputStream))
            ignore (e.printStackTrace(printStream))
            let mutable output : string = byteArrayOutputStream.ToString()
            jret <- JString.newString(output)
            jflow <- 1
        if jflow = 0 then
            jret <- this.NONE
            jflow <- 1
        jret


