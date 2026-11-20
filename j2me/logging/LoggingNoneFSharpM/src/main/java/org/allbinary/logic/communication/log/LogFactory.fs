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
type LogFactory =
    [<DefaultValue(false)>] static val mutable private jcell_LOG : Log
    static member LOG with get() : Log = (LogFactory.jclinit(); LogFactory.jcell_LOG) and set (jvalue: Log) = (LogFactory.jclinit(); LogFactory.jcell_LOG <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogFactory.jclinitDone then
            LogFactory.jclinitDone <- true
            LogFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LogFactory.jcell_LOG <- (new Log(StringUtil.getInstance().EMPTY_STRING, NullUtil.getInstance().NULL_OBJECT, StringUtil.getInstance().EMPTY_STRING, NullUtil.getInstance().NULL_OBJECT))
        ()
    new () =
        {  }
    
    static member getInstanceD() : Log =
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        let mutable nullUtil : NullUtil = NullUtil.getInstance()
        (new Log(stringUtil.EMPTY_STRING, nullUtil.NULL_OBJECT, stringUtil.EMPTY_STRING, nullUtil.NULL_OBJECT))
    
    static member getInstance(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : Log =
        LogFactory.LOG
    
    static member getInstanceF(specialMessage: string, anyType: obj, functionName: string) : Log =
        LogFactory.LOG


