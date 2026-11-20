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
type WeaponProperties =
    inherit SimpleWeaponProperties
    [<DefaultValue(false)>] val mutable reloadTime : int64
    [<DefaultValue(false)>] val mutable targetingTime : int64
    [<DefaultValue(false)>] val mutable speed : BasicDecimal
    [<DefaultValue(false)>] val mutable MAX : int64
    [<DefaultValue(false)>] val mutable ZERO : int16
    [<DefaultValue(false)>] static val mutable private jcell_NULL_WEAPON_PROPERTIES : WeaponProperties
    static member NULL_WEAPON_PROPERTIES with get() : WeaponProperties = (WeaponProperties.jclinit(); WeaponProperties.jcell_NULL_WEAPON_PROPERTIES) and set (jvalue: WeaponProperties) = (WeaponProperties.jclinit(); WeaponProperties.jcell_NULL_WEAPON_PROPERTIES <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_messageSent : bool
    static member messageSent with get() : bool = (WeaponProperties.jclinit(); WeaponProperties.jcell_messageSent) and set (jvalue: bool) = (WeaponProperties.jclinit(); WeaponProperties.jcell_messageSent <- jvalue)
    static member DAMAGE : string = "Damage: "
    static member RANGE : string = "Range: "
    static member RELOAD : string = "Reload: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WeaponProperties.jclinitDone then
            WeaponProperties.jclinitDone <- true
            WeaponProperties.jclinitBody()
    static member private jclinitBody() : unit =
        WeaponProperties.jcell_NULL_WEAPON_PROPERTIES <- (new WeaponProperties(0L, 0L, 0L, 0, int16 (0)))
        WeaponProperties.jcell_messageSent <- false
        ()
    member this.jfields_WeaponProperties() : unit =
        this.speed <- BasicDecimal.ZERO_BIGDECIMAL
        this.MAX <- 10240L
        this.ZERO <- (0s)
        ()
    
    new (reloadTime: int64, targetingTime: int64, speed: int64, damage: int, dissipation: int16) as this =
        { inherit SimpleWeaponProperties() }
        then
            this.jfields_WeaponProperties()
            this.jctor1(reloadTime, targetingTime, speed, damage, dissipation)
    member this.jctor1(reloadTime: int64, targetingTime: int64, speed: int64, damage: int, dissipation: int16) : unit =
        if ((speed < this.MAX) && (speed <> 0L)) && (not (WeaponProperties.messageSent)) then
            let mutable MESSAGE : string = "Danger Danger Danger: Speed probably to slow if using 1 degree calculations as velocity for a single axis could be below 1024: "
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            PreLogUtil.put((new StringMaker()).append(MESSAGE).appendlong(speed).ToString(), this, commonStrings.CONSTRUCTOR)
            WeaponProperties.messageSent <- true
        this.setReloadTime(reloadTime)
        this.setTargetingTime(targetingTime)
        this.setDamage(damage)
        this.setDissipation(dissipation)
        this.setSpeed((new BasicDecimal(speed)))
        if dissipation <> this.ZERO then
            let mutable unscaledDamage : int64 = this.speed.getUnscaled() * int64 (damage)
            let mutable scaledDissipation : int = int (int (dissipation)) * this.speed.getScaledFactorValue()
            let mutable value : int64 = (unscaledDamage / int64 (scaledDissipation))
            this.setRange((int ((value * 9L)) / 10))
        ()
    
    member this.setReloadTime(reloadTime: int64) : unit =
        this.reloadTime <- reloadTime
    
    abstract getReloadTime : unit -> int64
    default this.getReloadTime() : int64 =
        this.reloadTime
    
    member this.setTargetingTime(targetingTime: int64) : unit =
        this.targetingTime <- targetingTime
    
    abstract getTargetingTime : unit -> int64
    default this.getTargetingTime() : int64 =
        this.targetingTime
    
    abstract getSpeed : unit -> BasicDecimal
    default this.getSpeed() : BasicDecimal =
        this.speed
    
    abstract setSpeed : speed: BasicDecimal -> unit
    default this.setSpeed(speed: BasicDecimal) : unit =
        this.speed <- speed
    
    abstract getDamageI : range: int -> int
    default this.getDamageI(range: int) : int =
        this.getDamage() - ((int (int (this.getDissipation())) * range) / this.speed.getScaled())
    
    abstract toStringArray : unit -> string[]
    default this.toStringArray() : string[] =
        let mutable index : int = 0
        let mutable stringArray : string[] = (Array.zeroCreate<string> (3))
        let mutable stringBuffer : StringMaker = (new StringMaker())
        stringArray.[(let jt = index in index <- index + 1; jt)] <- stringBuffer.append(WeaponProperties.DAMAGE).appendint(this.getDamage()).ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        stringArray.[(let jt = index in index <- index + 1; jt)] <- stringBuffer.append(WeaponProperties.RANGE).appendint(this.getRange()).ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        stringArray.[(let jt = index in index <- index + 1; jt)] <- stringBuffer.append(WeaponProperties.RELOAD).appendlong(this.getReloadTime()).ToString()
        stringArray
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(WeaponProperties.DAMAGE).appendint(this.getDamage()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(WeaponProperties.RANGE).appendint(this.getRange()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(WeaponProperties.RELOAD).appendlong(this.getReloadTime()))
        stringBuffer.ToString()


