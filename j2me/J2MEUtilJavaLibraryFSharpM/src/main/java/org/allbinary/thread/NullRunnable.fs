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
type NullRunnable =
    inherit ARunnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : NullRunnable
    static member instance with get() : NullRunnable = (NullRunnable.jclinit(); NullRunnable.jcell_instance) and set (jvalue: NullRunnable) = (NullRunnable.jclinit(); NullRunnable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRunnable.jclinitDone then
            NullRunnable.jclinitDone <- true
            NullRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        NullRunnable.jcell_instance <- (new NullRunnable())
        ()
    
    static member getInstance() : NullRunnable =
        NullRunnable.instance
    
    new () =
        { inherit ARunnable() }


