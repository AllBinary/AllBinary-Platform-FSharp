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
type BasicAccelerationProperties =
    [<DefaultValue(false)>] val mutable forward : int
    [<DefaultValue(false)>] val mutable reverse : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicAccelerationProperties.jclinitDone then
            BasicAccelerationProperties.jclinitDone <- true
            BasicAccelerationProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (forward: int, reverse: int) as this =
        {  }
        then
            this.jctor1(forward, reverse)
    member this.jctor1(forward: int, reverse: int) : unit =
        this.setForward(forward)
        this.setReverse(reverse)
        ()
    
    abstract setReverse : reverse: int -> unit
    default this.setReverse(reverse: int) : unit =
        this.reverse <- reverse
    
    abstract getReverse : unit -> int
    default this.getReverse() : int =
        this.reverse
    
    abstract setForward : forward: int -> unit
    default this.setForward(forward: int) : unit =
        this.forward <- forward
    
    abstract getForward : unit -> int
    default this.getForward() : int =
        this.forward


