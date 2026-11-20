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
type WeaponLayer =
    inherit MultiPlayerGameLayer
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable initAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable destroyedAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable sourceLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable totalDamage : int
    [<DefaultValue(false)>] val mutable initDamage : int
    [<DefaultValue(false)>] val mutable destroyed : bool
    [<DefaultValue(false)>] val mutable scoreableInterface : ScoreableInterface
    [<DefaultValue(false)>] val mutable movement : Movement
    [<DefaultValue(false)>] val mutable weaponProperties : WeaponProperties
    [<DefaultValue(false)>] val mutable multiPlayerType : int
    [<DefaultValue(false)>] val mutable collidableWeaponBehavior : CollidableWeaponBehavior
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WeaponLayer.jclinitDone then
            WeaponLayer.jclinitDone <- true
            WeaponLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_WeaponLayer() : unit =
        this.animationInterface <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        this.sourceLayerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        this.destroyed <- true
        this.scoreableInterface <- NoScoreable.getInstance()
        this.weaponProperties <- WeaponProperties.NULL_WEAPON_PROPERTIES
        this.collidableWeaponBehavior <- CollidableWeaponBehavior.getNullInstance()
        ()
    
    new (name: string, remoteInfo: RemoteInfo, multiPlayerType: int, movement: Movement, animationInterface: Animation, destroyedAnimationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase) as this =
        { inherit MultiPlayerGameLayer(remoteInfo, BasicGroupFactory.getInstance().NONE_ARRAY, name, rectangle, viewPosition) }
        then
            this.jfields_WeaponLayer()
            this.jctor1(name, remoteInfo, multiPlayerType, movement, animationInterface, destroyedAnimationInterface, rectangle, viewPosition)
    member this.jctor1(name: string, remoteInfo: RemoteInfo, multiPlayerType: int, movement: Movement, animationInterface: Animation, destroyedAnimationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase) : unit =
        ()
        this.initAnimationInterface <- animationInterface
        this.setAnimationInterface(animationInterface)
        this.destroyedAnimationInterface <- destroyedAnimationInterface
        this.movement <- movement
        this.multiPlayerType <- multiPlayerType
        ()
    
    override this.setCollidableInferface(collidableInferface: CollidableBaseBehavior) : unit =
        base.setCollidableInferface(collidableInferface)
        this.collidableWeaponBehavior <- (box (this.getCollidableInferface()) :?> CollidableWeaponBehavior)
    
    abstract initXYZ : x: int * y: int * z: int -> unit
    default this.initXYZ(x: int, y: int, z: int) : unit =
        this.x <- x
        this.y <- y
        this.z <- z
    
    abstract init : sourceLayerInterface: AllBinaryLayer * angle: int * otherAngle: int * weaponProperties: WeaponProperties * scoreable: ScoreableInterface -> unit
    default this.init(sourceLayerInterface: AllBinaryLayer, angle: int, otherAngle: int, weaponProperties: WeaponProperties, scoreable: ScoreableInterface) : unit =
        this.setWeaponPropertiesP(weaponProperties)
        this.setReadyForExplosion(false)
        this.setAnimationInterface(this.getInitAnimationInterfaceP())
        this.setOwnerLayerInterface(sourceLayerInterface)
        this.collidableWeaponBehavior.init(sourceLayerInterface)
        this.setGroupInterfaces()
        if not (JR.same(scoreable, null)) then
            this.scoreableInterface <- scoreable
        this.totalDamage <- 0
        this.initDamage <- weaponProperties.getDamage()
        this.setDestroyed(false)
        this.movement.init(weaponProperties.getSpeed(), angle, otherAngle)
    
    abstract setGroupInterfaces : unit -> unit
    default this.setGroupInterfaces() : unit =
        let mutable basicGroupFactory : BasicGroupFactory = BasicGroupFactory.getInstance()
        if (JR.same(this.sourceLayerInterface.getGroupInterface().[0], basicGroupFactory.ENEMY)) then
            this.setGroupInterface(basicGroupFactory.ENEMY_ARRAY)
        else
            this.setGroupInterface(this.sourceLayerInterface.getGroupInterface())
    
    override this.processTick(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.isExhausted() && (not (this.isDestroyed())) then
            if this.isReadyForExplosion() then
                let mutable indexedAnimationInterface : IndexedAnimation = (box (this.getAnimationInterface()) :?> IndexedAnimation)
                let mutable currentFrame : int = indexedAnimationInterface.getFrame()
                if currentFrame < (indexedAnimationInterface.getAnimationSize() - 1) then
                    indexedAnimationInterface.nextFrame()
                else
                    this.setDestroyed(true)
            else
                let mutable collidableWeaponBehavior : CollidableWeaponBehavior = (box (this.getCollidableInferface()) :?> CollidableWeaponBehavior)
                if collidableWeaponBehavior.isCollided() then
                    this.setAnimationInterface(this.destroyedAnimationInterface)
                    this.getMovement().stop()
                    this.setReadyForExplosion(true)
                else
                    this.setDestroyed(true)
        this.movement.process_(this)
        this.totalDamage <- this.totalDamage + int (this.weaponProperties.getDissipation())
    
    override this.isDestroyed() : bool =
        this.destroyed
    
    override this.damage(damage: int, damageType: int) : unit =
        this.totalDamage <- this.totalDamage + (damage * damage)
    
    abstract givePoints : total: int -> unit
    default this.givePoints(total: int) : unit =
        this.scoreableInterface.addPoints((GameConfigurationUtil.getInstance().getCompetitionValue() * total))
    
    abstract isExhausted : unit -> bool
    default this.isExhausted() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (this.totalDamage > this.getInitDamage()) || (this.totalDamage < 0) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    override this.getDamage(damageType: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if not (this.isExhausted()) then
            let mutable total : int = this.getInitDamage() - this.totalDamage
            this.givePoints(total)
            jret <- total
            jflow <- 1
        if jflow = 0 then
            jret <- 0
            jflow <- 1
        jret
    
    abstract setDestroyed : destroyed: bool -> unit
    default this.setDestroyed(destroyed: bool) : unit =
        this.destroyed <- destroyed
        if this.isDestroyed() then
            this.scoreableInterface <- NoScoreable.getInstance()
            ignore (DestroyedLayerProcessor.getInstance().add(this))
    
    abstract getInitDamage : unit -> int
    default this.getInitDamage() : int =
        this.initDamage
    
    abstract setAnimationInterface : animationInterface: Animation -> unit
    default this.setAnimationInterface(animationInterface: Animation) : unit =
        this.animationInterface <- animationInterface
    
    abstract getAnimationInterface : unit -> Animation
    default this.getAnimationInterface() : Animation =
        this.animationInterface
    
    abstract getInitAnimationInterfaceP : unit -> Animation
    default this.getInitAnimationInterfaceP() : Animation =
        this.initAnimationInterface
    
    abstract setInitAnimationInterfaceP : initAnimationInterface: Animation -> unit
    default this.setInitAnimationInterfaceP(initAnimationInterface: Animation) : unit =
        this.initAnimationInterface <- initAnimationInterface
    
    abstract getDestroyedAnimationInterface : unit -> Animation
    default this.getDestroyedAnimationInterface() : Animation =
        this.destroyedAnimationInterface
    
    abstract getOwnerLayerInterface : unit -> AllBinaryLayer
    default this.getOwnerLayerInterface() : AllBinaryLayer =
        this.sourceLayerInterface
    
    abstract setOwnerLayerInterface : sourceLayerInterface: AllBinaryLayer -> unit
    default this.setOwnerLayerInterface(sourceLayerInterface: AllBinaryLayer) : unit =
        this.sourceLayerInterface <- sourceLayerInterface
    
    override this.paint(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getViewPosition()
        this.animationInterface.paintXY(graphics, (viewPosition.getX() - this.getHalfWidth()), (viewPosition.getY() - this.getHalfHeight()))
    
    override this.paintThreed(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getViewPosition()
        this.animationInterface.paintThreedXYZ(graphics, (viewPosition.getX() - this.getHalfWidth()), (viewPosition.getY() - this.getHalfHeight()), (viewPosition.getZ() - this.getHalfDepth()))
    
    abstract getMovement : unit -> Movement
    default this.getMovement() : Movement =
        this.movement
    
    abstract setMovement : movement: Movement -> unit
    default this.setMovement(movement: Movement) : unit =
        this.movement <- movement
    
    override this.getType() : int =
        WeaponLayer.getStaticType()
    
    static member getStaticType() : int =
        0
    
    override this.getMultiPlayerType() : int =
        this.multiPlayerType
    
    abstract setWeaponPropertiesP : weaponProperties: WeaponProperties -> unit
    default this.setWeaponPropertiesP(weaponProperties: WeaponProperties) : unit =
        this.weaponProperties <- weaponProperties
    
    abstract getWeaponPropertiesP : unit -> WeaponProperties
    default this.getWeaponPropertiesP() : WeaponProperties =
        this.weaponProperties
    
    override this.implmentsTickableInterface() : bool =
        true
    
    override this.set(gl: GL) : unit =
        this.initAnimationInterface.set(gl)
    interface TickableInterface with
        member this.processTick(jp0: AllBinaryLayerManager) : unit = this.processTick(jp0)
    interface NamedInterface with
        member this.getName() : string = this.getName()


