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
type NullWaitGameRunnable =
    inherit GameRunnable
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameRunnable
    static member instance with get() : GameRunnable = (NullWaitGameRunnable.jclinit(); NullWaitGameRunnable.jcell_instance) and set (jvalue: GameRunnable) = (NullWaitGameRunnable.jclinit(); NullWaitGameRunnable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullWaitGameRunnable.jclinitDone then
            NullWaitGameRunnable.jclinitDone <- true
            NullWaitGameRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        NullWaitGameRunnable.jcell_instance <- (new NullWaitGameRunnable())
        ()
    new () =
        { inherit GameRunnable() }
    
    static member getInstance() : GameRunnable =
        NullWaitGameRunnable.instance


