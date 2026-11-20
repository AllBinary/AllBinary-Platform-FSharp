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
type InApplicationPurchaseFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : InApplicationPurchaseFactory
    static member instance with get() : InApplicationPurchaseFactory = (InApplicationPurchaseFactory.jclinit(); InApplicationPurchaseFactory.jcell_instance) and set (jvalue: InApplicationPurchaseFactory) = (InApplicationPurchaseFactory.jclinit(); InApplicationPurchaseFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InApplicationPurchaseFactory.jclinitDone then
            InApplicationPurchaseFactory.jclinitDone <- true
            InApplicationPurchaseFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InApplicationPurchaseFactory.jcell_instance <- (new InApplicationPurchaseFactory())
        ()
    
    static member getInstance() : InApplicationPurchaseFactory =
        InApplicationPurchaseFactory.instance
    
    new () =
        {  }
    
    abstract init : anyType: obj * stateObject: obj -> unit
    default this.init(anyType: obj, stateObject: obj) : unit =
        ()
    
    abstract onCreate : anyType: obj * stateObject: obj -> unit
    default this.onCreate(anyType: obj, stateObject: obj) : unit =
        ()
    
    abstract onStart : unit -> unit
    default this.onStart() : unit =
        ()
    
    abstract onResult : requestCode: int * resultCode: int * data: obj -> unit
    default this.onResult(requestCode: int, resultCode: int, data: obj) : unit =
        ()
    
    abstract onSaveState : anyType: obj -> unit
    default this.onSaveState(anyType: obj) : unit =
        ()
    
    abstract onStop : unit -> unit
    default this.onStop() : unit =
        ()
    
    abstract onDestroy : unit -> unit
    default this.onDestroy() : unit =
        ()
    
    abstract purchase : lockableFeature: LockableFeature -> unit
    default this.purchase(lockableFeature: LockableFeature) : unit =
        ()
    
    abstract isPurchased : lockableFeature: LockableFeature -> bool
    default this.isPurchased(lockableFeature: LockableFeature) : bool =
        false
    
    abstract add : lockableFeature: LockableFeature -> unit
    default this.add(lockableFeature: LockableFeature) : unit =
        ()
    
    abstract getUserName : unit -> string
    default this.getUserName() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract isEnabled : unit -> bool
    default this.isEnabled() : bool =
        false


