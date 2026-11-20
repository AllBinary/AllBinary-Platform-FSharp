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
type DamageFloaters =
    inherit Paintable
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : DamageFloaters
    static member SINGLETON with get() : DamageFloaters = (DamageFloaters.jclinit(); DamageFloaters.jcell_SINGLETON) and set (jvalue: DamageFloaters) = (DamageFloaters.jclinit(); DamageFloaters.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DamageFloaters.jclinitDone then
            DamageFloaters.jclinitDone <- true
            DamageFloaters.jclinitBody()
    static member private jclinitBody() : unit =
        DamageFloaters.jcell_SINGLETON <- (new DamageFloaters())
        ()
    new () =
        { inherit Paintable() }
    
    static member getInstance() : DamageFloaters =
        DamageFloaters.SINGLETON
    
    abstract add : damage: int -> unit
    default this.add(damage: int) : unit =
        ()


