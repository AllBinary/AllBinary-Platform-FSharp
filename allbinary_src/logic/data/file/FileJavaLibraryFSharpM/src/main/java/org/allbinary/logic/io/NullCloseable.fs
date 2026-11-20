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
type NullCloseable =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CLOSEABLE : NullCloseable
    static member NULL_CLOSEABLE with get() : NullCloseable = (NullCloseable.jclinit(); NullCloseable.jcell_NULL_CLOSEABLE) and set (jvalue: NullCloseable) = (NullCloseable.jclinit(); NullCloseable.jcell_NULL_CLOSEABLE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullCloseable.jclinitDone then
            NullCloseable.jclinitDone <- true
            NullCloseable.jclinitBody()
    static member private jclinitBody() : unit =
        NullCloseable.jcell_NULL_CLOSEABLE <- (new NullCloseable())
        ()
    new () =
        {  }
    
    abstract close : unit -> unit
    default this.close() : unit =
        ()
    interface Closeable with
        member this.close() : unit = this.close()


