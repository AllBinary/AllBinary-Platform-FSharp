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
type BasicProjectileWeaponPart =
    inherit BasicWeaponPart
    [<DefaultValue(false)>] val mutable weaponLayerCircularStaticPool : WeaponLayerCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicProjectileWeaponPart.jclinitDone then
            BasicProjectileWeaponPart.jclinitDone <- true
            BasicProjectileWeaponPart.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createBasicProjectileWeaponPart(animationInterface: Animation, weaponLayerCircularStaticPool: WeaponLayerCircularPool) : BasicProjectileWeaponPart =
        (new BasicProjectileWeaponPart(animationInterface, AllBinaryLayer.NULL_ALLBINARY_LAYER, weaponLayerCircularStaticPool, WeaponProperties.NULL_WEAPON_PROPERTIES, NoScoreable.getInstance(), RelativeRelationship.NULL_RELATIVE_RELATIONSHIP))
    
    new (animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) as this =
        { inherit BasicWeaponPart(animationInterface, sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship) }
        then
            this.jctor1(animationInterface, sourceLayerInterface, weaponLayerCircularStaticPool, weaponProperties, scoreableInterface, relativeRelationship)
    member this.jctor1(animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : unit =
        ()
        this.weaponLayerCircularStaticPool <- weaponLayerCircularStaticPool
        ()
    
    override this.processScore(allbinaryLayerManager: AllBinaryLayerManager, angle: int16, otherAngle: int16, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface) : unit =
        let mutable weaponLayer : WeaponLayer = this.weaponLayerCircularStaticPool.getInstanceWeaponLayer(this.getOwnerLayerInterface(), this.relativeRelationship.getX(), this.relativeRelationship.getY(), this.relativeRelationship.getZ(), int (angle), int (otherAngle), weaponProperties, scoreableInterface)
        allbinaryLayerManager.append(weaponLayer)


