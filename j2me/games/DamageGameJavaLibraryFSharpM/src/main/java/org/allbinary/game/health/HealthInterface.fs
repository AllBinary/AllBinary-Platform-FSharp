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
type HealthInterface =
    abstract isAlive : unit -> bool
    abstract damage : ahealth: int -> unit
    abstract heal : ahealth: int -> unit
    abstract healMax : unit -> unit
    abstract getMaxHealth : unit -> int
    abstract setMaxHealth : maxHealth: int -> unit
    abstract getHealth : unit -> int
    abstract addListener : healthListenerInterface: HealthListenerInterface -> unit


