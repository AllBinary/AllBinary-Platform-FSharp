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
type Movement =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Movement.jclinitDone then
            Movement.jclinitDone <- true
            Movement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    abstract init : speedBasicDecimal: BasicDecimal * angle: int * otherAngle: int -> unit
    default this.init(speedBasicDecimal: BasicDecimal, angle: int, otherAngle: int) : unit =
        ()
    
    abstract process_ : layer: AllBinaryGameLayer -> unit
    default this.process_(layer: AllBinaryGameLayer) : unit =
        ()
    
    abstract stop : unit -> unit
    default this.stop() : unit =
        ()
    interface MovementInterface with
        member this.init(jp0: BasicDecimal, jp1: int, jp2: int) : unit = this.init(jp0, jp1, jp2)
        member this.process_(jp0: AllBinaryGameLayer) : unit = this.process_(jp0)
        member this.stop() : unit = this.stop()


