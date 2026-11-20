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
type NullGL10 =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GL10 : NullGL10
    static member NULL_GL10 with get() : NullGL10 = (NullGL10.jclinit(); NullGL10.jcell_NULL_GL10) and set (jvalue: NullGL10) = (NullGL10.jclinit(); NullGL10.jcell_NULL_GL10 <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullGL10.jclinitDone then
            NullGL10.jclinitDone <- true
            NullGL10.jclinitBody()
    static member private jclinitBody() : unit =
        NullGL10.jcell_NULL_GL10 <- (new NullGL10())
        ()
    new () =
        {  }
    interface GL10
    interface GL


