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
type WeaponLayerCircularPool =
    inherit AllBinaryLayerCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WeaponLayerCircularPool.jclinitDone then
            WeaponLayerCircularPool.jclinitDone <- true
            WeaponLayerCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit AllBinaryLayerCircularPool() }
    
    abstract getInstanceWeaponLayer : sourceLayerInterface: AllBinaryLayer * x: int * y: int * z: int * angle: int * otherAngle: int * weaponProperties: WeaponProperties * scoreable: ScoreableInterface -> WeaponLayer
    default this.getInstanceWeaponLayer(sourceLayerInterface: AllBinaryLayer, x: int, y: int, z: int, angle: int, otherAngle: int, weaponProperties: WeaponProperties, scoreable: ScoreableInterface) : WeaponLayer =
        let mutable weaponLayer : WeaponLayer = (box (base.getNextInstance()) :?> WeaponLayer)
        weaponLayer.initXYZ(x, y, z)
        weaponLayer.init(sourceLayerInterface, angle, otherAngle, weaponProperties, scoreable)
        weaponLayer


