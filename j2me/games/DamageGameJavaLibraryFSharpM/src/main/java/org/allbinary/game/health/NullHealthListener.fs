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
type NullHealthListener =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_HEALTH_LISTENER : NullHealthListener
    static member NULL_HEALTH_LISTENER with get() : NullHealthListener = (NullHealthListener.jclinit(); NullHealthListener.jcell_NULL_HEALTH_LISTENER) and set (jvalue: NullHealthListener) = (NullHealthListener.jclinit(); NullHealthListener.jcell_NULL_HEALTH_LISTENER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullHealthListener.jclinitDone then
            NullHealthListener.jclinitDone <- true
            NullHealthListener.jclinitBody()
    static member private jclinitBody() : unit =
        NullHealthListener.jcell_NULL_HEALTH_LISTENER <- (new NullHealthListener())
        ()
    new () =
        {  }
    
    abstract onHealthChange : unit -> unit
    default this.onHealthChange() : unit =
        ()
    interface HealthListenerInterface with
        member this.onHealthChange() : unit = this.onHealthChange()


