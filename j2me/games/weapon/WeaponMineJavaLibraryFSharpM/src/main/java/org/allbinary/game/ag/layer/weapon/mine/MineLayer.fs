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
type MineLayer =
    inherit SimpleWeaponLayer
    [<DefaultValue(false)>] val mutable viewPositionEventHandler : ViewPositionEventHandler
    static member NAME : string = "MineLayer"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineLayer.jclinitDone then
            MineLayer.jclinitDone <- true
            MineLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MineLayer() : unit =
        this.viewPositionEventHandler <- ViewPositionEventHandler.getInstance()
        ()
    
    new (viewPosition: ViewPositionBase) as this =
        { inherit SimpleWeaponLayer(MineLayer.NAME, RemoteInfo.REMOTE_INFO, -1, NoMovementFactory.getInstance().getMovmentInstance(), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(MineWeaponResources.getInstance().RESOURCE).getInstance(0), SimpleWeaponLayer.createDestroyed(), (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 10, 10)), viewPosition) }
        then
            this.jfields_MineLayer()
    
    override this.initXYZ(x: int, y: int, z: int) : unit =
        this.setPosition((x + 5), (y + 5), z)
        this.viewPositionEventHandler.addListener((box (this) :?> AllBinaryLayer))
        ignore (SecondaryPlayerQueueFactory.getInstance().add(DropWeaponSound.getInstance()))
    
    override this.damage(damage: int, damageType: int) : unit =
        this.totalDamage <- this.getInitDamage() + 1
    
    override this.getDamage(damageType: int) : int =
        ignore (base.getDamage(damageType))
        this.getInitDamage()
    
    override this.setDestroyed(destroyed: bool) : unit =
        base.setDestroyed(destroyed)
        if this.isDestroyed() then
            this.viewPositionEventHandler.removeListener(this)


