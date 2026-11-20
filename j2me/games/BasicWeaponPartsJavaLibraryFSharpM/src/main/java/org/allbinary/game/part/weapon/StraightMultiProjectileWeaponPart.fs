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
type StraightMultiProjectileWeaponPart =
    inherit BasicWeaponPart
    [<DefaultValue(false)>] val mutable weaponLayerCircularStaticPool : WeaponLayerCircularPool
    [<DefaultValue(false)>] val mutable total : int
    [<DefaultValue(false)>] val mutable noDecimalTrigTable : NoDecimalTrigTable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StraightMultiProjectileWeaponPart.jclinitDone then
            StraightMultiProjectileWeaponPart.jclinitDone <- true
            StraightMultiProjectileWeaponPart.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_StraightMultiProjectileWeaponPart() : unit =
        this.noDecimalTrigTable <- NoDecimalTrigTable.getInstance()
        ()
    
    static member createStraightMultiProjectileWeaponPart(animationInterface: Animation, weaponLayerCircularStaticPool: WeaponLayerCircularPool) : StraightMultiProjectileWeaponPart =
        (new StraightMultiProjectileWeaponPart(animationInterface, AllBinaryLayer.NULL_ALLBINARY_LAYER, weaponLayerCircularStaticPool, 2, WeaponProperties.NULL_WEAPON_PROPERTIES, NoScoreable.getInstance(), RelativeRelationship.NULL_RELATIVE_RELATIONSHIP))
    
    new (animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, total: int, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) as this =
        { inherit BasicWeaponPart(animationInterface, sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship) }
        then
            this.jfields_StraightMultiProjectileWeaponPart()
            this.jctor1(animationInterface, sourceLayerInterface, weaponLayerCircularStaticPool, total, weaponProperties, scoreableInterface, relativeRelationship)
    member this.jctor1(animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponLayerCircularStaticPool: WeaponLayerCircularPool, total: int, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : unit =
        ()
        this.total <- total
        this.weaponLayerCircularStaticPool <- weaponLayerCircularStaticPool
        ()
    
    override this.processScore(allbinaryLayerManager: AllBinaryLayerManager, angle: int16, otherAngle: int16, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface) : unit =
        let mutable sourceLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable reducedWidth : int = ((sourceLayerInterface.getWidth() * 8) / 10)
        let mutable halfWidth : int = (reducedWidth >>> 1)
        let mutable x : int = this.relativeRelationship.getX()
        let mutable y : int = this.relativeRelationship.getY()
        let mutable sine : int64 = 0L
        let mutable beamX : int = 0
        let mutable cosine : int64 = 0L
        let mutable beamY : int = 0
        let mutable weaponLayer : WeaponLayer = null
        let mutable increment : int = reducedWidth / (this.total - 1)
        let mutable next : int = -(halfWidth)
        let mutable index : int = 0
        while index < this.total do
            sine <- (int64 (next) * this.noDecimalTrigTable.sin(int (angle)))
            beamX <- int ((sine / int64 (this.noDecimalTrigTable.SCALE)))
            cosine <- (int64 (next) * this.noDecimalTrigTable.cos(int (angle)))
            beamY <- -(int ((cosine / int64 (this.noDecimalTrigTable.SCALE))))
            weaponLayer <- this.weaponLayerCircularStaticPool.getInstanceWeaponLayer(sourceLayerInterface, (x + beamX), (y + beamY), 0, int (angle), int (otherAngle), weaponProperties, scoreableInterface)
            allbinaryLayerManager.append(weaponLayer)
            next <- next + increment
            index <- index + 1


