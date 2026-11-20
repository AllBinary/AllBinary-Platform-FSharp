namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type NoDragVelocityBehavior =
    inherit VelocityBehaviorBase
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoDragVelocityBehavior
    static member instance with get() : NoDragVelocityBehavior = (NoDragVelocityBehavior.jclinit(); NoDragVelocityBehavior.jcell_instance) and set (jvalue: NoDragVelocityBehavior) = (NoDragVelocityBehavior.jclinit(); NoDragVelocityBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoDragVelocityBehavior.jclinitDone then
            NoDragVelocityBehavior.jclinitDone <- true
            NoDragVelocityBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        NoDragVelocityBehavior.jcell_instance <- (new NoDragVelocityBehavior())
        ()
    new () =
        { inherit VelocityBehaviorBase() }


