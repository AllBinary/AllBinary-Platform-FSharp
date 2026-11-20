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
type CombatBaseBehavior =
    [<DefaultValue(false)>] val mutable damageableBaseBehavior : DamageableBaseBehavior
    [<DefaultValue(false)>] val mutable destroyableBaseBehavior : DestroyableBaseBehavior
    [<DefaultValue(false)>] val mutable readyForExplosion : bool
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COMBAT_BEHAVIOR : CombatBaseBehavior
    static member NULL_COMBAT_BEHAVIOR with get() : CombatBaseBehavior = (CombatBaseBehavior.jclinit(); CombatBaseBehavior.jcell_NULL_COMBAT_BEHAVIOR) and set (jvalue: CombatBaseBehavior) = (CombatBaseBehavior.jclinit(); CombatBaseBehavior.jcell_NULL_COMBAT_BEHAVIOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CombatBaseBehavior.jclinitDone then
            CombatBaseBehavior.jclinitDone <- true
            CombatBaseBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        CombatBaseBehavior.jcell_NULL_COMBAT_BEHAVIOR <- (new CombatBaseBehavior(DamageableBaseBehavior.getInstance(), DestroyableBaseBehavior.getInstance()))
        ()
    
    new (damageableBaseBehavior: DamageableBaseBehavior, destroyableBaseBehavior: DestroyableBaseBehavior) as this =
        {  }
        then
            this.jctor1(damageableBaseBehavior, destroyableBaseBehavior)
    member this.jctor1(damageableBaseBehavior: DamageableBaseBehavior, destroyableBaseBehavior: DestroyableBaseBehavior) : unit =
        this.damageableBaseBehavior <- damageableBaseBehavior
        this.destroyableBaseBehavior <- destroyableBaseBehavior
        ()
    
    abstract getDamageableBaseBehavior : unit -> DamageableBaseBehavior
    default this.getDamageableBaseBehavior() : DamageableBaseBehavior =
        this.damageableBaseBehavior
    
    abstract getDestroyableBaseBehavior : unit -> DestroyableBaseBehavior
    default this.getDestroyableBaseBehavior() : DestroyableBaseBehavior =
        this.destroyableBaseBehavior
    
    member this.isReadyForExplosion() : bool =
        this.readyForExplosion
    
    member this.setReadyForExplosion(readyForExplosion: bool) : unit =
        this.readyForExplosion <- readyForExplosion


