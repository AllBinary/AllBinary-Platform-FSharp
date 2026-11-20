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
type NullRecordComparator =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_RECORD_COMPARATOR : NullRecordComparator
    static member NULL_RECORD_COMPARATOR with get() : NullRecordComparator = (NullRecordComparator.jclinit(); NullRecordComparator.jcell_NULL_RECORD_COMPARATOR) and set (jvalue: NullRecordComparator) = (NullRecordComparator.jclinit(); NullRecordComparator.jcell_NULL_RECORD_COMPARATOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRecordComparator.jclinitDone then
            NullRecordComparator.jclinitDone <- true
            NullRecordComparator.jclinitBody()
    static member private jclinitBody() : unit =
        NullRecordComparator.jcell_NULL_RECORD_COMPARATOR <- (new NullRecordComparator())
        ()
    new () =
        {  }
    
    abstract compare : rec1: sbyte[] * rec2: sbyte[] -> int
    default this.compare(rec1: sbyte[], rec2: sbyte[]) : int =
        0
    interface RecordComparator with
        member this.compare(jp0: sbyte[], jp1: sbyte[]) : int = this.compare(jp0, jp1)


