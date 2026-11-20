namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type TempExplosionWeaponLayer =
    inherit SimpleWeaponLayer
    [<DefaultValue(false)>] val mutable weaponProperties : WeaponProperties
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TempExplosionWeaponLayer.jclinitDone then
            TempExplosionWeaponLayer.jclinitDone <- true
            TempExplosionWeaponLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TempExplosionWeaponLayer() : unit =
        this.weaponProperties <- (new WeaponProperties(-1L, -1L, 0L, 1000, int16 (0)))
        this.timeDelayHelper <- (new TimeDelayHelper(0))
        ()
    
    new (name: string, movement: Movement, animationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase, timeDelay: int) as this =
        { inherit SimpleWeaponLayer(name, RemoteInfo.REMOTE_INFO, -1, movement, animationInterface, SimpleWeaponLayer.createDestroyed(), rectangle, viewPosition) }
        then
            this.jfields_TempExplosionWeaponLayer()
            this.jctor1(name, movement, animationInterface, rectangle, viewPosition, timeDelay)
    member this.jctor1(name: string, movement: Movement, animationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase, timeDelay: int) : unit =
        ()
        this.timeDelayHelper.delay <- timeDelay
        ()
    
    override this.processTick(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.timeDelayHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            this.getCollidableInferface().collide(this, this)
            this.totalDamage <- this.getInitDamage() + 1
        base.processTick(allBinaryLayerManager)


