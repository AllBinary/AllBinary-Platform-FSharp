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
type NoDebug =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : DebugInterface
    static member SINGLETON with get() : DebugInterface = (NoDebug.jclinit(); NoDebug.jcell_SINGLETON) and set (jvalue: DebugInterface) = (NoDebug.jclinit(); NoDebug.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoDebug.jclinitDone then
            NoDebug.jclinitDone <- true
            NoDebug.jclinitBody()
    static member private jclinitBody() : unit =
        NoDebug.jcell_SINGLETON <- (new NoDebug())
        ()
    new () =
        {  }
    
    static member getInstance() : DebugInterface =
        NoDebug.SINGLETON
    
    abstract start : unit -> unit
    default this.start() : unit =
        ()
    
    abstract stop : unit -> unit
    default this.stop() : unit =
        ()
    
    abstract getMaxTime : unit -> int64
    default this.getMaxTime() : int64 =
        10000L
    
    abstract getStartTime : unit -> int64
    default this.getStartTime() : int64 =
        0L
    
    abstract isRunning : unit -> bool
    default this.isRunning() : bool =
        false
    interface DebugInterface with
        member this.start() : unit = this.start()
        member this.stop() : unit = this.stop()
        member this.getStartTime() : int64 = this.getStartTime()
        member this.getMaxTime() : int64 = this.getMaxTime()
        member this.isRunning() : bool = this.isRunning()


