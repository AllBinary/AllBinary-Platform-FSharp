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
type NullThread =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_THREAD : Thread
    static member NULL_THREAD with get() : Thread = (NullThread.jclinit(); NullThread.jcell_NULL_THREAD) and set (jvalue: Thread) = (NullThread.jclinit(); NullThread.jcell_NULL_THREAD <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullThread.jclinitDone then
            NullThread.jclinitDone <- true
            NullThread.jclinitBody()
    static member private jclinitBody() : unit =
        NullThread.jcell_NULL_THREAD <- (new Thread())
        ()
    new () =
        {  }


