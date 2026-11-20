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
type Log =
    [<DefaultValue(false)>] val mutable logFormatUtil : LogFormatUtil
    [<DefaultValue(false)>] val mutable specialMessage : string
    [<DefaultValue(false)>] val mutable anyType : obj
    [<DefaultValue(false)>] val mutable functionName : string
    [<DefaultValue(false)>] val mutable exception_ : obj
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Log.jclinitDone then
            Log.jclinitDone <- true
            Log.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Log() : unit =
        this.logFormatUtil <- LogFormatUtil.getInstance()
        ()
    
    new (specialMessage: string, anyType: obj, functionName: string, exception_: obj) as this =
        {  }
        then
            this.jfields_Log()
            this.jctor1(specialMessage, anyType, functionName, exception_)
    member this.jctor1(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : unit =
        this.specialMessage <- specialMessage
        this.anyType <- anyType
        this.functionName <- functionName
        this.exception_ <- exception_
        ()
    
    abstract getSpecialMessage : unit -> string
    default this.getSpecialMessage() : string =
        this.specialMessage
    
    abstract getObject : unit -> obj
    default this.getObject() : obj =
        this.anyType
    
    abstract getFunctionName : unit -> string
    default this.getFunctionName() : string =
        this.functionName
    
    abstract getThrowable : unit -> obj
    default this.getThrowable() : obj =
        this.exception_
    
    override this.ToString() : string =
        let mutable className : string = CommonStrings.getInstance().EMPTY
        let mutable clazz : string = JR.getClass(this.anyType)
        if not (JR.same(clazz, null)) then
            className <- clazz
        this.logFormatUtil.get(className, this.functionName, this.specialMessage, this.exception_)


