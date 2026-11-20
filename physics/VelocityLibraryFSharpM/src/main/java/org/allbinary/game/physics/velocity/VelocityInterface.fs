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
type VelocityInterface =
    inherit BasicVelocityInterface
    abstract getMaxForwardVelocity : unit -> int
    abstract getMaxReverseVelocity : unit -> int
    abstract limitMaxXYForwardVelocity : unit -> unit
    abstract limitMaxXYReverseVelocity : unit -> unit
    abstract limitXYToForwardAndReverseMaxVelocity : unit -> unit
    abstract limitMaxXYVelocity : maxVelocity: int -> unit
    abstract setMaxForwardVelocity : maxForwardVelocity: int -> unit
    abstract setMaxReverseVelocity : maxReverseVelocity: int -> unit


