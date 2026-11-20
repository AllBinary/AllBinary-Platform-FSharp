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
type PreLogUtil =
    static member LOG_SUCCESS : string = "org.allbinary: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PreLogUtil.jclinitDone then
            PreLogUtil.jclinitDone <- true
            PreLogUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member put(specialMessage: string, anyType: obj, functionName: string) : unit =
        PreLogUtil.putOE(specialMessage, anyType, functionName, NullUtil.getInstance().NULL_OBJECT)
    
    static member putOE(specialMessage: string, anyType: obj, functionName: string, exception_: obj) : unit =
        let mutable className : string = CommonStrings.getInstance().EMPTY
        if not (JR.same(JR.getClass(anyType), null)) then
            className <- JString.newString(JR.getClass(anyType))
        let mutable message : string = LogFormatUtil.getInstance().get(className, functionName, specialMessage, exception_)
        JSystem.out.print(PreLogUtil.LOG_SUCCESS)
        JSystem.out.println(message)
    
    static member putS(specialMessage: string, className: string, functionName: string) : unit =
        PreLogUtil.putSE(specialMessage, className, functionName, NullUtil.getInstance().NULL_OBJECT)
    
    static member putSE(specialMessage: string, className: string, functionName: string, exception_: obj) : unit =
        let mutable message : string = LogFormatUtil.getInstance().get(className, functionName, specialMessage, exception_)
        JSystem.out.print(PreLogUtil.LOG_SUCCESS)
        JSystem.out.println(message)


