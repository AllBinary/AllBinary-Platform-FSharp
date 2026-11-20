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
type LockableFeatureFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : LockableFeatureFactory
    static member instance with get() : LockableFeatureFactory = (LockableFeatureFactory.jclinit(); LockableFeatureFactory.jcell_instance) and set (jvalue: LockableFeatureFactory) = (LockableFeatureFactory.jclinit(); LockableFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockableFeatureFactory.jclinitDone then
            LockableFeatureFactory.jclinitDone <- true
            LockableFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LockableFeatureFactory.jcell_instance <- (new LockableFeatureFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_LockableFeatureFactory()
    member this.jfields_LockableFeatureFactory() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : LockableFeatureFactory =
        LockableFeatureFactory.instance
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


