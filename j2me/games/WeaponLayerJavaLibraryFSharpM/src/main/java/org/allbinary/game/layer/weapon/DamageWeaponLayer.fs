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
type DamageWeaponLayer =
    inherit WeaponLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DamageWeaponLayer.jclinitDone then
            DamageWeaponLayer.jclinitDone <- true
            DamageWeaponLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, remoteInfo: RemoteInfo, movement: Movement, animationInterface: Animation, destroyedAnimationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase, username: string, actorSessionId: int, id_: int, multiPlayerType: int) as this =
        { inherit WeaponLayer(name, remoteInfo, multiPlayerType, movement, animationInterface, destroyedAnimationInterface, rectangle, viewPosition) }
        then
            this.jctor1(name, remoteInfo, movement, animationInterface, destroyedAnimationInterface, rectangle, viewPosition, username, actorSessionId, id_, multiPlayerType)
    member this.jctor1(name: string, remoteInfo: RemoteInfo, movement: Movement, animationInterface: Animation, destroyedAnimationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase, username: string, actorSessionId: int, id_: int, multiPlayerType: int) : unit =
        ()
        this.setCollidableInferface((new CollidableDamageWeaponBehavior(true)))
        ()


