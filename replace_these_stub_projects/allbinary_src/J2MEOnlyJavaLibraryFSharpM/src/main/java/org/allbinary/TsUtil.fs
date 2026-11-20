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
    
    abstract hashCode : anyType: obj -> int
    default this.hashCode(anyType: obj) : int =
        JR.hashCode(anyType)
    
    abstract waitFor : any: obj * timeoutMillis: int64 -> unit
    default this.waitFor(any: obj, timeoutMillis: int64) : unit =
        let mutable anyType : obj = (box (any))
        ignore (JR.wait(anyType, timeoutMillis))
    
    abstract getRecord : anyType: obj * recordId: int -> sbyte[]
    default this.getRecord(anyType: obj, recordId: int) : sbyte[] =
        let mutable recordStore : RecordStore = (box (anyType) :?> RecordStore)
        let mutable data : sbyte[] = null
        if true then
            data <- (Array.zeroCreate<sbyte> (recordStore.getRecordSize(recordId)))
            ignore (recordStore.getRecord(recordId, data, 0))
        (if data.Length < 1 then NullUtil.getInstance().NULL_BYTE_ARRAY else data)
    
    abstract compareTo : a: string * b: string -> int
    default this.compareTo(a: string, b: string) : int =
        JString.compareTo(a, b)
    
    abstract equalIgnoreCase : a: string * b: string -> bool
    default this.equalIgnoreCase(a: string, b: string) : bool =
        JString.equalsIgnoreCase(a, b)
    
    abstract equalsNotstring : anyType: obj * object2: obj -> bool
    default this.equalsNotstring(anyType: obj, object2: obj) : bool =
        JR.equals(anyType, object2)
    
    abstract toNumberFromChar : value: char -> int
    default this.toNumberFromChar(value: char) : int =
        int (value)
    
    abstract toNumber : value: int -> int
    default this.toNumber(value: int) : int =
        value
    
    abstract getByteArray : string_: string -> sbyte[]
    default this.getByteArray(string_: string) : sbyte[] =
        JString.getBytes(string_)
    
    abstract isItemListener : owner: Displayable -> bool
    default this.isItemListener(owner: Displayable) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (box (owner) :? Form) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract printAvailableMethods : anyType: obj -> unit
    default this.printAvailableMethods(anyType: obj) : unit =
        ()
    
    abstract gc : unit -> unit
    default this.gc() : unit =
        JSystem.gc()


