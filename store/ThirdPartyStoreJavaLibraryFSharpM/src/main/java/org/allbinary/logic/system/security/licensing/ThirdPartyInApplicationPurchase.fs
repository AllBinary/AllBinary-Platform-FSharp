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
type ThirdPartyInApplicationPurchase =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThirdPartyInApplicationPurchase.jclinitDone then
            ThirdPartyInApplicationPurchase.jclinitDone <- true
            ThirdPartyInApplicationPurchase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract isPurchased : lockableFeature: LockableFeature -> bool
    default this.isPurchased(lockableFeature: LockableFeature) : bool =
        false
    
    abstract onCreate : anyType: obj * stateObject: obj -> unit
    default this.onCreate(anyType: obj, stateObject: obj) : unit =
        ()
    
    abstract onDestroy : unit -> unit
    default this.onDestroy() : unit =
        ()
    
    abstract onStart : unit -> unit
    default this.onStart() : unit =
        ()
    
    abstract onActivityResult : requestCode: int * resultCode: int * dataObject: obj -> unit
    default this.onActivityResult(requestCode: int, resultCode: int, dataObject: obj) : unit =
        ()
    
    abstract onSaveInstanceState : anyType: obj -> unit
    default this.onSaveInstanceState(anyType: obj) : unit =
        ()
    
    abstract onStop : unit -> unit
    default this.onStop() : unit =
        ()
    
    abstract requestPurchase : lockableFeature: LockableFeature -> unit
    default this.requestPurchase(lockableFeature: LockableFeature) : unit =
        ()
    
    abstract requestReceipts : unit -> unit
    default this.requestReceipts() : unit =
        ()
    
    abstract add : lockableFeature: LockableFeature -> unit
    default this.add(lockableFeature: LockableFeature) : unit =
        ()
    
    abstract getUserName : unit -> string
    default this.getUserName() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract isEnabled : unit -> bool
    default this.isEnabled() : bool =
        false
    
    abstract requestProducts : unit -> unit
    default this.requestProducts() : unit =
        ()
    interface ThirdPartyInApplicationPurchaseInterface with
        member this.isPurchased(jp0: LockableFeature) : bool = this.isPurchased(jp0)
        member this.onCreate(jp0: obj, jp1: obj) : unit = this.onCreate(jp0, jp1)
        member this.onDestroy() : unit = this.onDestroy()
        member this.onStart() : unit = this.onStart()
        member this.onActivityResult(jp0: int, jp1: int, jp2: obj) : unit = this.onActivityResult(jp0, jp1, jp2)
        member this.onSaveInstanceState(jp0: obj) : unit = this.onSaveInstanceState(jp0)
        member this.onStop() : unit = this.onStop()
        member this.requestPurchase(jp0: LockableFeature) : unit = this.requestPurchase(jp0)
        member this.requestReceipts() : unit = this.requestReceipts()
        member this.add(jp0: LockableFeature) : unit = this.add(jp0)
        member this.getUserName() : string = this.getUserName()
        member this.isEnabled() : bool = this.isEnabled()


