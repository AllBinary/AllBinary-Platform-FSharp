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
type NullRecordFilter =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_RECORD_FILTER : NullRecordFilter
    static member NULL_RECORD_FILTER with get() : NullRecordFilter = (NullRecordFilter.jclinit(); NullRecordFilter.jcell_NULL_RECORD_FILTER) and set (jvalue: NullRecordFilter) = (NullRecordFilter.jclinit(); NullRecordFilter.jcell_NULL_RECORD_FILTER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRecordFilter.jclinitDone then
            NullRecordFilter.jclinitDone <- true
            NullRecordFilter.jclinitBody()
    static member private jclinitBody() : unit =
        NullRecordFilter.jcell_NULL_RECORD_FILTER <- (new NullRecordFilter())
        ()
    new () =
        {  }
    
    abstract matches : candidate: sbyte[] -> bool
    default this.matches(candidate: sbyte[]) : bool =
        true
    interface RecordFilter with
        member this.matches(jp0: sbyte[]) : bool = this.matches(jp0)


