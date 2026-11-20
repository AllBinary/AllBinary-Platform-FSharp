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
type SimpleWeaponProperties =
    [<DefaultValue(false)>] val mutable damage : int
    [<DefaultValue(false)>] val mutable dissipation : int16
    [<DefaultValue(false)>] val mutable range : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleWeaponProperties.jclinitDone then
            SimpleWeaponProperties.jclinitDone <- true
            SimpleWeaponProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract set : simpleWeaponProperties: SimpleWeaponProperties -> unit
    default this.set(simpleWeaponProperties: SimpleWeaponProperties) : unit =
        this.setDamage(simpleWeaponProperties.getDamage())
        this.setDissipation(simpleWeaponProperties.getDissipation())
        this.setRange(simpleWeaponProperties.getRange())
    
    abstract setDamage : damage: int -> unit
    default this.setDamage(damage: int) : unit =
        this.damage <- damage
    
    abstract getDamage : unit -> int
    default this.getDamage() : int =
        this.damage
    
    abstract setDissipation : dissipation: int16 -> unit
    default this.setDissipation(dissipation: int16) : unit =
        this.dissipation <- dissipation
    
    abstract getDissipation : unit -> int16
    default this.getDissipation() : int16 =
        this.dissipation
    
    abstract getRange : unit -> int
    default this.getRange() : int =
        this.range
    
    abstract setRange : range: int -> unit
    default this.setRange(range: int) : unit =
        this.range <- range


