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
type StatePaintable =
    inherit Paintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StatePaintable.jclinitDone then
            StatePaintable.jclinitDone <- true
            StatePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit Paintable() }
    
    abstract setState : state: int -> unit
    default this.setState(state: int) : unit =
        ()
    interface StateControlledInterface with
        member this.setState(jp0: int) : unit = this.setState(jp0)


