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
type PrimitiveArrayToString =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PrimitiveArrayToString.jclinitDone then
            PrimitiveArrayToString.jclinitDone <- true
            PrimitiveArrayToString.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member toString(floats: float32[]) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable index : int = 0
        while index < floats.Length do
            ignore (stringBuffer.appendfloat(floats.[index]))
            index <- index + 1
        stringBuffer.ToString()


