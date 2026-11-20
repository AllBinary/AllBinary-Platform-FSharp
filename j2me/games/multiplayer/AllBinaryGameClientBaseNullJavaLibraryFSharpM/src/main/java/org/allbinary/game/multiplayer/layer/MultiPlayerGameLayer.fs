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
type MultiPlayerGameLayer =
    inherit CollidableDestroyableDamageableLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultiPlayerGameLayer.jclinitDone then
            MultiPlayerGameLayer.jclinitDone <- true
            MultiPlayerGameLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (remoteInfo: RemoteInfo, groupInterface: Group[], name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase) =
        { inherit CollidableDestroyableDamageableLayer(groupInterface, name, layerInfo, viewPosition) }
    
    abstract getMultiplayerBehavior : unit -> MultiplayerBehavior
    default this.getMultiplayerBehavior() : MultiplayerBehavior =
        MultiplayerBehavior.NULL_MULTIPLAYER_BEHAVIOR
    
    abstract setPingInfo : show: bool -> unit
    default this.setPingInfo(show: bool) : unit =
        ()
    
    abstract setFiring : firing: int16 -> unit
    default this.setFiring(firing: int16) : unit =
        ()
    
    abstract getFiring : unit -> int16
    default this.getFiring() : int16 =
        (0s)
    interface MultiPlayerGameLayerInterface with
        member this.getMultiplayerBehavior() : MultiplayerBehavior = this.getMultiplayerBehavior()


