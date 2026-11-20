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
type BasicWeaponPart =
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable ownerLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable weaponProperties : WeaponProperties
    [<DefaultValue(false)>] val mutable scoreableInterface : ScoreableInterface
    [<DefaultValue(false)>] val mutable relativeRelationship : RelativeRelationship
    [<DefaultValue(false)>] static val mutable private jcell_NULL_BASIC_WEAPON_PART : BasicWeaponPart
    static member NULL_BASIC_WEAPON_PART with get() : BasicWeaponPart = (BasicWeaponPart.jclinit(); BasicWeaponPart.jcell_NULL_BASIC_WEAPON_PART) and set (jvalue: BasicWeaponPart) = (BasicWeaponPart.jclinit(); BasicWeaponPart.jcell_NULL_BASIC_WEAPON_PART <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicWeaponPart.jclinitDone then
            BasicWeaponPart.jclinitDone <- true
            BasicWeaponPart.jclinitBody()
    static member private jclinitBody() : unit =
        BasicWeaponPart.jcell_NULL_BASIC_WEAPON_PART <- BasicWeaponPart.createBasicWeaponPart(NullAnimationFactory.getFactoryInstance().getInstance(0))
        ()
    member this.jfields_BasicWeaponPart() : unit =
        this.animationInterface <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        this.ownerLayerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        this.weaponProperties <- WeaponProperties.NULL_WEAPON_PROPERTIES
        this.scoreableInterface <- NoScoreable.getInstance()
        this.relativeRelationship <- RelativeRelationship.NULL_RELATIVE_RELATIONSHIP
        ()
    
    static member createBasicWeaponPart(animationInterface: Animation) : BasicWeaponPart =
        (new BasicWeaponPart(animationInterface, AllBinaryLayer.NULL_ALLBINARY_LAYER, WeaponProperties.NULL_WEAPON_PROPERTIES, NoScoreable.getInstance(), RelativeRelationship.NULL_RELATIVE_RELATIONSHIP))
    
    new (animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) as this =
        {  }
        then
            this.jfields_BasicWeaponPart()
            this.jctor1(animationInterface, sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship)
    member this.jctor1(animationInterface: Animation, sourceLayerInterface: AllBinaryLayer, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : unit =
        this.init(sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship)
        this.setAnimationInterface(animationInterface)
        ()
    
    abstract init : sourceLayerInterface: AllBinaryLayer * weaponProperties: WeaponProperties * scoreableInterface: ScoreableInterface * relativeRelationship: RelativeRelationship -> unit
    default this.init(sourceLayerInterface: AllBinaryLayer, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : unit =
        this.setOwnerLayerInterface(sourceLayerInterface)
        this.setWeaponProperties(weaponProperties)
        this.scoreableInterface <- scoreableInterface
        this.relativeRelationship <- relativeRelationship
    
    abstract process_ : allbinaryLayerManager: AllBinaryLayerManager * angle: int16 * otherAngle: int16 -> unit
    default this.process_(allbinaryLayerManager: AllBinaryLayerManager, angle: int16, otherAngle: int16) : unit =
        this.processScore(allbinaryLayerManager, angle, otherAngle, this.getWeaponProperties(), this.scoreableInterface)
    
    abstract processScore : allbinaryLayerManager: AllBinaryLayerManager * angle: int16 * otherAngle: int16 * weaponProperties: WeaponProperties * scoreableInterface: ScoreableInterface -> unit
    default this.processScore(allbinaryLayerManager: AllBinaryLayerManager, angle: int16, otherAngle: int16, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface) : unit =
        raise ((new JException(CommonStrings.getInstance().NOT_IMPLEMENTED)))
    
    abstract getOwnerLayerInterface : unit -> AllBinaryLayer
    default this.getOwnerLayerInterface() : AllBinaryLayer =
        this.ownerLayerInterface
    
    abstract setOwnerLayerInterface : ownerLayerInterface: AllBinaryLayer -> unit
    default this.setOwnerLayerInterface(ownerLayerInterface: AllBinaryLayer) : unit =
        this.ownerLayerInterface <- ownerLayerInterface
    
    abstract getAnimationInterface : unit -> Animation
    default this.getAnimationInterface() : Animation =
        this.animationInterface
    
    abstract setAnimationInterface : animationInterface: Animation -> unit
    default this.setAnimationInterface(animationInterface: Animation) : unit =
        this.animationInterface <- animationInterface
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getOwnerLayerInterface().getViewPosition()
        let mutable viewX : int = viewPosition.getX()
        let mutable viewY : int = viewPosition.getY()
        this.animationInterface.paintXY(graphics, viewX, viewY)
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract getWeaponProperties : unit -> WeaponProperties
    default this.getWeaponProperties() : WeaponProperties =
        this.weaponProperties
    
    abstract setWeaponProperties : weaponProperties: WeaponProperties -> unit
    default this.setWeaponProperties(weaponProperties: WeaponProperties) : unit =
        this.weaponProperties <- weaponProperties
    interface PartInterface
    interface SalvoInterface with
        member this.process_(jp0: AllBinaryLayerManager, jp1: int16, jp2: int16) : unit = this.process_(jp0, jp1, jp2)
        member this.processScore(jp0: AllBinaryLayerManager, jp1: int16, jp2: int16, jp3: WeaponProperties, jp4: ScoreableInterface) : unit = this.processScore(jp0, jp1, jp2, jp3, jp4)
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface AnimationInterfaceCompositeInterface with
        member this.getAnimationInterface() : Animation = this.getAnimationInterface()


