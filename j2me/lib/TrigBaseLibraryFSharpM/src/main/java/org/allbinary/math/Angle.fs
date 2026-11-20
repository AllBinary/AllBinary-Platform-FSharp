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
type Angle =
    [<DefaultValue(false)>] val mutable value : int16
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Angle.jclinitDone then
            Angle.jclinitDone <- true
            Angle.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (angle: int16) as this =
        {  }
        then
            this.jctor1(angle)
    member this.jctor1(angle: int16) : unit =
        this.value <- angle
        ()
    
    abstract getValue : unit -> int16
    default this.getValue() : int16 =
        this.value


