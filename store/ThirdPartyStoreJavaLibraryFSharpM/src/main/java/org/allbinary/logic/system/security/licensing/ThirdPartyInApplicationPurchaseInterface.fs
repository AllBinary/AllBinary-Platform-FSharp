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
type ThirdPartyInApplicationPurchaseInterface =
    abstract isPurchased : lockableFeature: LockableFeature -> bool
    abstract onCreate : anyType: obj * stateObject: obj -> unit
    abstract onDestroy : unit -> unit
    abstract onStart : unit -> unit
    abstract onActivityResult : requestCode: int * resultCode: int * dataObject: obj -> unit
    abstract onSaveInstanceState : anyType: obj -> unit
    abstract onStop : unit -> unit
    abstract requestPurchase : lockableFeature: LockableFeature -> unit
    abstract requestReceipts : unit -> unit
    abstract add : lockableFeature: LockableFeature -> unit
    abstract getUserName : unit -> string
    abstract isEnabled : unit -> bool


