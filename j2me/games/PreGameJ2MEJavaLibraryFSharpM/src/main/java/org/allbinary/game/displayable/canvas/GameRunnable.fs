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
type GameRunnable =
    [<DefaultValue(false)>] val mutable WAIT : int
    [<DefaultValue(false)>] val mutable FAST : int
    [<DefaultValue(false)>] val mutable waitInMillis : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameRunnable.jclinitDone then
            GameRunnable.jclinitDone <- true
            GameRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameRunnable() : unit =
        this.WAIT <- 240
        this.FAST <- 60
        this.waitInMillis <- int64 (this.WAIT)
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GameRunnable()
    
    abstract run : unit -> unit
    default this.run() : unit =
        DisplayInfoSingleton.getInstance().process_()
    
    abstract processLoopSleep : unit -> unit
    default this.processLoopSleep() : unit =
        ignore (Thread.sleep(this.waitInMillis))
    interface Runnable with
        member this.run() : unit = this.run()


