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
type NullPriorityRunnable =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullPriorityRunnable.jclinitDone then
            NullPriorityRunnable.jclinitDone <- true
            NullPriorityRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getPriority : unit -> int
    default this.getPriority() : int =
        0
    
    abstract isDone : unit -> bool
    default this.isDone() : bool =
        true
    
    abstract reset : unit -> unit
    default this.reset() : unit =
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        ()
    interface PriorityRunnable with
        member this.getPriority() : int = this.getPriority()
        member this.isDone() : bool = this.isDone()
        member this.reset() : unit = this.reset()
    interface Runnable with
        member this.run() : unit = this.run()


