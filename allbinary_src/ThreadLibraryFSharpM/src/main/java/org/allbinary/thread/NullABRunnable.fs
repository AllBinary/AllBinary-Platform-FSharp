namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullABRunnable =
    inherit ABRunnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : NullABRunnable
    static member instance with get() : NullABRunnable = (NullABRunnable.jclinit(); NullABRunnable.jcell_instance) and set (jvalue: NullABRunnable) = (NullABRunnable.jclinit(); NullABRunnable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullABRunnable.jclinitDone then
            NullABRunnable.jclinitDone <- true
            NullABRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        NullABRunnable.jcell_instance <- (new NullABRunnable())
        ()
    new () =
        { inherit ABRunnable() }
    
    static member getInstance() : NullABRunnable =
        NullABRunnable.instance
    
    override this.isRunning() : bool =
        false


