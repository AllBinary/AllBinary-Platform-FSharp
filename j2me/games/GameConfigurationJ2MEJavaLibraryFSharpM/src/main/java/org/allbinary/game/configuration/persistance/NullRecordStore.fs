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
type NullRecordStore =
    inherit RecordStore
    [<DefaultValue(false)>] static val mutable private jcell_NULL_RECORD_STORE : NullRecordStore
    static member NULL_RECORD_STORE with get() : NullRecordStore = (NullRecordStore.jclinit(); NullRecordStore.jcell_NULL_RECORD_STORE) and set (jvalue: NullRecordStore) = (NullRecordStore.jclinit(); NullRecordStore.jcell_NULL_RECORD_STORE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRecordStore.jclinitDone then
            NullRecordStore.jclinitDone <- true
            NullRecordStore.jclinitBody()
    static member private jclinitBody() : unit =
        NullRecordStore.jcell_NULL_RECORD_STORE <- (new NullRecordStore())
        ()
    new () =
        { inherit RecordStore() }


