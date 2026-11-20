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
type ArcedMultiBeamWeaponPart =
    inherit BasicWeaponPart
    [<DefaultValue(false)>] val mutable weaponLayerCircularStaticPool : WeaponLayerCircularPool
    [<DefaultValue(false)>] val mutable total : int
    [<DefaultValue(false)>] val mutable TOTAL_ANGLE : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArcedMultiBeamWeaponPart.jclinitDone then
            ArcedMultiBeamWeaponPart.jclinitDone <- true
            ArcedMultiBeamWeaponPart.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ArcedMultiBeamWeaponPart() : unit =
        this.TOTAL_ANGLE <- int (AngleFactory.getInstance().TOTAL_ANGLE)
        ()
    
    new (animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, total: int, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) as this =
        { inherit BasicWeaponPart(animationInterface, sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship) }
        then
            this.jfields_ArcedMultiBeamWeaponPart()
            this.jctor1(animationInterface, sourceLayerInterface, weaponLayerCircularStaticPool, total, weaponProperties, scoreableInterface, relativeRelationship)
    member this.jctor1(animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, total: int, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : unit =
        ()
        this.total <- total
        this.weaponLayerCircularStaticPool <- weaponLayerCircularStaticPool
        ()
    
    override this.processScore(allbinaryLayerManager: AllBinaryLayerManager, angle: int16, otherAngle: int16, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface) : unit =
        let mutable increment : int16 = int16 (((this.total - 1) / this.TOTAL_ANGLE))
        let mutable minAngle : int16 = int16 ((int (int (angle)) - ((int (int (increment)) * this.total) >>> 1)))
        let mutable next : int = 0
        let mutable weaponLayer : WeaponLayer = null
        let mutable index : int = 0
        while index < this.total do
            weaponLayer <- this.weaponLayerCircularStaticPool.getInstanceWeaponLayer(this.getOwnerLayerInterface(), this.relativeRelationship.getX(), this.relativeRelationship.getY(), 0, (int (minAngle) + int (increment)), int (otherAngle), weaponProperties, scoreableInterface)
            allbinaryLayerManager.append(weaponLayer)
            next <- next + int (increment)
            index <- index + 1


