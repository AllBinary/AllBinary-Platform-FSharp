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
type FallingPickupLayerFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FallingPickupLayerFactory.jclinitDone then
            FallingPickupLayerFactory.jclinitDone <- true
            FallingPickupLayerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : unit -> AllBinaryLayer
    default this.getInstance() : AllBinaryLayer =
        (new FallingPickupLayer(RemoteInfo.REMOTE_INFO))
    interface AllBinaryLayerFactoryInterface with
        member this.getInstance() : AllBinaryLayer = this.getInstance()


