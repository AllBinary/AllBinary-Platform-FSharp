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
type DamageableBaseBehavior =
    [<DefaultValue(false)>] static val mutable private jcell_instance : DamageableBaseBehavior
    static member instance with get() : DamageableBaseBehavior = (DamageableBaseBehavior.jclinit(); DamageableBaseBehavior.jcell_instance) and set (jvalue: DamageableBaseBehavior) = (DamageableBaseBehavior.jclinit(); DamageableBaseBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DamageableBaseBehavior.jclinitDone then
            DamageableBaseBehavior.jclinitDone <- true
            DamageableBaseBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        DamageableBaseBehavior.jcell_instance <- (new DamageableBaseBehavior())
        ()
    new () =
        {  }
    
    static member getInstance() : DamageableBaseBehavior =
        DamageableBaseBehavior.instance
    
    abstract getName : unit -> string
    default this.getName() : string =
        JR.getClass(this)
    
    abstract damage : damage: int * damageType: int -> unit
    default this.damage(damage: int, damageType: int) : unit =
        ()
    
    abstract getDamage : damageType: int -> int
    default this.getDamage(damageType: int) : int =
        6000
    interface DamageableInterface with
        member this.damage(jp0: int, jp1: int) : unit = this.damage(jp0, jp1)
        member this.getDamage(jp0: int) : int = this.getDamage(jp0)
    interface NamedInterface with
        member this.getName() : string = this.getName()


