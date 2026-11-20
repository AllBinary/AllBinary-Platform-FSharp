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
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogFactory.jclinitDone then
            LogFactory.jclinitDone <- true
            LogFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstanceD() : Log =
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        let mutable nullUtil : NullUtil = NullUtil.getInstance()
        (new Log(stringUtil.EMPTY_STRING, nullUtil.NULL_OBJECT, stringUtil.EMPTY_STRING, nullUtil.NULL_OBJECT))
    
    static member getInstanceNoF(specialMessage: string, anyType: obj, exception_: obj) : Log =
        (new Log(specialMessage, anyType, StringUtil.getInstance().EMPTY_STRING, exception_))
    
    static member getInstance(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : Log =
        (new Log(specialMessage, anyType, functionName, exception_))
    
    static member getInstanceF(specialMessage: string, anyType: obj, functionName: string) : Log =
        let mutable nullUtil : NullUtil = NullUtil.getInstance()
        (new Log(specialMessage, anyType, functionName, nullUtil.NULL_OBJECT))


