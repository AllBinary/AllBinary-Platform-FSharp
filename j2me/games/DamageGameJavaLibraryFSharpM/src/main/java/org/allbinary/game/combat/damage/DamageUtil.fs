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
type DamageUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable COLLIDE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : DamageUtil
    static member instance with get() : DamageUtil = (DamageUtil.jclinit(); DamageUtil.jcell_instance) and set (jvalue: DamageUtil) = (DamageUtil.jclinit(); DamageUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DamageUtil.jclinitDone then
            DamageUtil.jclinitDone <- true
            DamageUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DamageUtil.jcell_instance <- (new DamageUtil())
        ()
    member this.jfields_DamageUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.COLLIDE <- "collide"
        ()
    
    static member getInstance() : DamageUtil =
        DamageUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_DamageUtil()
    
    abstract process_ : damageableInterface: DamageableInterface * damageableInterface2: DamageableInterface -> unit
    default this.process_(damageableInterface: DamageableInterface, damageableInterface2: DamageableInterface) : unit =
        damageableInterface.damage(damageableInterface2.getDamage(0), 0)
    
    abstract debugDamage : collidableInterfaceCompositeInterface1: CollidableCompositeLayer * collidableInterfaceCompositeInterface: CollidableCompositeLayer -> unit
    default this.debugDamage(collidableInterfaceCompositeInterface1: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableCompositeLayer) : unit =
        let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (collidableInterfaceCompositeInterface) :?> CollidableDestroyableDamageableLayer)
        let mutable damage : int = collidableDestroyableDamageableLayer.getDamage(0)
        if damage > 20000 then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("Collision "))
            ignore (stringBuffer.append(collidableInterfaceCompositeInterface1.ToString()))
            ignore (stringBuffer.append(" with: "))
            ignore (stringBuffer.append(collidableInterfaceCompositeInterface.ToString()))
            ignore (stringBuffer.append(" damage: "))
            ignore (stringBuffer.appendint(damage))
            this.logUtil.putF(stringBuffer.ToString(), collidableInterfaceCompositeInterface1, this.COLLIDE)


