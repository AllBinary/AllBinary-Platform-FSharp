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
type ABRunnable =
    [<DefaultValue(false)>] val mutable running : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABRunnable.jclinitDone then
            ABRunnable.jclinitDone <- true
            ABRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_ABRunnable()
    member this.jfields_ABRunnable() : unit =
        this.running <- false
        ()
    
    abstract setThread : thread: Thread -> unit
    default this.setThread(thread: Thread) : unit =
        ()
    
    abstract isRunning : unit -> bool
    default this.isRunning() : bool =
        this.running
    
    abstract setRunning : running: bool -> unit
    default this.setRunning(running: bool) : unit =
        this.running <- running
    
    abstract run : unit -> unit
    default this.run() : unit =
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        -1
    interface RunnableInterface with
        member this.isRunning() : bool = this.isRunning()
        member this.setRunning(jp0: bool) : unit = this.setRunning(jp0)
        member this.setThread(jp0: Thread) : unit = this.setThread(jp0)
    interface Runnable with
        member this.run() : unit = this.run()


