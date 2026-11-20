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
type Health =
    [<DefaultValue(false)>] val mutable health : int
    [<DefaultValue(false)>] val mutable maxHealth : int
    [<DefaultValue(false)>] val mutable healthListenerInterface : HealthListenerInterface
    [<DefaultValue(false)>] static val mutable private jcell_NULL_HEALTH : Health
    static member NULL_HEALTH with get() : Health = (Health.jclinit(); Health.jcell_NULL_HEALTH) and set (jvalue: Health) = (Health.jclinit(); Health.jcell_NULL_HEALTH <- jvalue)
    static member NAME : string = "Health Resource"
    static member HEALTH_LABEL : string = "Health: "
    static member MAX_HEALTH_LABEL : string = " Max: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Health.jclinitDone then
            Health.jclinitDone <- true
            Health.jclinitBody()
    static member private jclinitBody() : unit =
        Health.jcell_NULL_HEALTH <- (new Health(0))
        ()
    member this.jfields_Health() : unit =
        this.healthListenerInterface <- NullHealthListener.NULL_HEALTH_LISTENER
        ()
    
    new (maxHealth: int) as this =
        {  }
        then
            this.jfields_Health()
            this.jctor1(maxHealth)
    member this.jctor1(maxHealth: int) : unit =
        this.setMaxHealth(maxHealth)
        this.setHealth(maxHealth)
        ()
    
    abstract heal : ahealth: int -> unit
    default this.heal(ahealth: int) : unit =
        let mutable newHealth : int = this.getHealth() + ahealth
        if newHealth > this.getMaxHealth() then
            this.setHealth(this.getMaxHealth())
        else
            this.setHealth(newHealth)
    
    abstract healMax : unit -> unit
    default this.healMax() : unit =
        this.setHealth(this.getMaxHealth())
    
    abstract isDamaged : unit -> bool
    default this.isDamaged() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getHealth() <> this.getMaxHealth() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract damage : ahealth: int -> unit
    default this.damage(ahealth: int) : unit =
        let mutable jflow = 0
        if ahealth < 0 then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("******* Trying to heal when damaging. Damage: "))
            ignore (stringBuffer.appendint(ahealth))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(this.ToString()))
            ForcedLogUtil.log(stringBuffer.ToString(), this)
            jflow <- 1
        if jflow = 0 then
            let mutable health : int = this.getHealth() - ahealth
            this.setHealth(health)
    
    abstract isAlive : unit -> bool
    default this.isAlive() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getHealth() <= 0 then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    abstract getMaxHealth : unit -> int
    default this.getMaxHealth() : int =
        this.maxHealth
    
    abstract setMaxHealth : maxHealth: int -> unit
    default this.setMaxHealth(maxHealth: int) : unit =
        this.maxHealth <- maxHealth
    
    abstract setHealth : health: int -> unit
    default this.setHealth(health: int) : unit =
        if health > this.getMaxHealth() then
            this.health <- this.getMaxHealth()
        elif health < 0 then
            this.health <- 0
        else
            this.health <- health
        if not (JR.same(this.healthListenerInterface, null)) then
            this.healthListenerInterface.onHealthChange()
    
    abstract getHealth : unit -> int
    default this.getHealth() : int =
        this.health
    
    abstract addListener : healthGraphic: HealthListenerInterface -> unit
    default this.addListener(healthGraphic: HealthListenerInterface) : unit =
        this.healthListenerInterface <- healthGraphic
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(Health.HEALTH_LABEL))
        ignore (stringBuffer.appendint(this.health))
        ignore (stringBuffer.append(Health.MAX_HEALTH_LABEL))
        ignore (stringBuffer.appendint(this.maxHealth))
        stringBuffer.ToString()
    interface HealthInterface with
        member this.isAlive() : bool = this.isAlive()
        member this.damage(jp0: int) : unit = this.damage(jp0)
        member this.heal(jp0: int) : unit = this.heal(jp0)
        member this.healMax() : unit = this.healMax()
        member this.getMaxHealth() : int = this.getMaxHealth()
        member this.setMaxHealth(jp0: int) : unit = this.setMaxHealth(jp0)
        member this.getHealth() : int = this.getHealth()
        member this.addListener(jp0: HealthListenerInterface) : unit = this.addListener(jp0)


