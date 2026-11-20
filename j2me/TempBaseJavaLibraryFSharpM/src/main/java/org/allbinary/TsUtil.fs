namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type TsUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : TsUtil
    static member instance with get() : TsUtil = (TsUtil.jclinit(); TsUtil.jcell_instance) and set (jvalue: TsUtil) = (TsUtil.jclinit(); TsUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TsUtil.jclinitDone then
            TsUtil.jclinitDone <- true
            TsUtil.jclinitBody()
    static member private jclinitBody() : unit =
        TsUtil.jcell_instance <- (new TsUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : TsUtil =
        TsUtil.instance
    
    abstract longBitsToDouble : bits: int64 -> float
    default this.longBitsToDouble(bits: int64) : float =
        Double.longBitsToDouble(bits)
    
    abstract intBitsToFloat : bits: int -> float32
    default this.intBitsToFloat(bits: int) : float32 =
        Float.intBitsToFloat(bits)
    
    abstract hashCode : anyType: obj -> int
    default this.hashCode(anyType: obj) : int =
        JR.hashCode(anyType)
    
    abstract waitFor : any: obj * timeoutMillis: int64 -> unit
    default this.waitFor(any: obj, timeoutMillis: int64) : unit =
        let mutable anyType : obj = (box (any))
        ignore (JR.wait(anyType, timeoutMillis))
    
    abstract compareTo : a: string * b: string -> int
    default this.compareTo(a: string, b: string) : int =
        JString.compareTo(a, b)


