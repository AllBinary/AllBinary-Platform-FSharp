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
type BasicPlayer =
    [<DefaultValue(false)>] val mutable listenersList : BasicArrayList
    [<DefaultValue(false)>] val mutable timeBase : TimeBase
    [<DefaultValue(false)>] val mutable stateP : int
    [<DefaultValue(false)>] val mutable loopCountP : int
    [<DefaultValue(false)>] static val mutable private jcell_CONTROL_TYPE : string
    static member CONTROL_TYPE with get() : string = (BasicPlayer.jclinit(); BasicPlayer.jcell_CONTROL_TYPE) and set (jvalue: string) = (BasicPlayer.jclinit(); BasicPlayer.jcell_CONTROL_TYPE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicPlayer.jclinitDone then
            BasicPlayer.jclinitDone <- true
            BasicPlayer.jclinitBody()
    static member private jclinitBody() : unit =
        BasicPlayer.jcell_CONTROL_TYPE <- "ToneControl"
        ()
    member this.jfields_BasicPlayer() : unit =
        this.listenersList <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicPlayer()
            this.jctor1()
    member this.jctor1() : unit =
        this.setLoopCount(0)
        this.setState(Player.UNREALIZED)
        ()
    
    abstract getContentType : unit -> string
    default this.getContentType() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract getControl : controlType: string -> Control
    default this.getControl(controlType: string) : Control =
        (new NullControl())
    
    abstract getControls : unit -> Control[]
    default this.getControls() : Control[] =
        (Array.zeroCreate<Control> (0))
    
    abstract close : unit -> unit
    default this.close() : unit =
        ()
    
    abstract addPlayerListener : playerListener: PlayerListener -> unit
    default this.addPlayerListener(playerListener: PlayerListener) : unit =
        if not (this.listenersList.contains(playerListener)) then
            ignore (this.listenersList.add(playerListener))
    
    abstract removePlayerListener : playerListener: PlayerListener -> unit
    default this.removePlayerListener(playerListener: PlayerListener) : unit =
        ignore (this.listenersList.remove(playerListener))
    
    abstract getState : unit -> int
    default this.getState() : int =
        this.stateP
    
    abstract setState : state: int -> unit
    default this.setState(state: int) : unit =
        this.stateP <- state
    
    abstract getDuration : unit -> int64
    default this.getDuration() : int64 =
        0L
    
    abstract getMediaTime : unit -> int64
    default this.getMediaTime() : int64 =
        0L
    
    abstract getTimeBase : unit -> TimeBase
    default this.getTimeBase() : TimeBase =
        this.timeBase
    
    abstract setTimeBase : timeBase: TimeBase -> unit
    default this.setTimeBase(timeBase: TimeBase) : unit =
        this.timeBase <- timeBase
    
    abstract deallocate : unit -> unit
    default this.deallocate() : unit =
        ()
    
    abstract prefetch : unit -> unit
    default this.prefetch() : unit =
        ()
    
    abstract realize : unit -> unit
    default this.realize() : unit =
        ()
    
    abstract setLoopCount : count: int -> unit
    default this.setLoopCount(count: int) : unit =
        this.loopCountP <- count
    
    abstract getLoopCount : unit -> int
    default this.getLoopCount() : int =
        this.loopCountP
    
    abstract setMediaTime : now: int64 -> int64
    default this.setMediaTime(now: int64) : int64 =
        0L
    
    abstract start : unit -> unit
    default this.start() : unit =
        this.setState(Player.STARTED)
    
    abstract stop : unit -> unit
    default this.stop() : unit =
        this.setState(Player.PREFETCHED)
    
    abstract setVolume : leftVolume: int * rightVolume: int -> unit
    default this.setVolume(leftVolume: int, rightVolume: int) : unit =
        ()
    interface Player with
        member this.realize() : unit = this.realize()
        member this.prefetch() : unit = this.prefetch()
        member this.start() : unit = this.start()
        member this.stop() : unit = this.stop()
        member this.deallocate() : unit = this.deallocate()
        member this.close() : unit = this.close()
        member this.setMediaTime(jp0: int64) : int64 = this.setMediaTime(jp0)
        member this.getMediaTime() : int64 = this.getMediaTime()
        member this.getState() : int = this.getState()
        member this.getDuration() : int64 = this.getDuration()
        member this.getContentType() : string = this.getContentType()
        member this.setLoopCount(jp0: int) : unit = this.setLoopCount(jp0)
        member this.addPlayerListener(jp0: PlayerListener) : unit = this.addPlayerListener(jp0)
        member this.removePlayerListener(jp0: PlayerListener) : unit = this.removePlayerListener(jp0)
    interface TimeBaseInterface with
        member this.getTimeBase() : TimeBase = this.getTimeBase()
        member this.setTimeBase(jp0: TimeBase) : unit = this.setTimeBase(jp0)
    interface Controllable2 with
        member this.setVolume(jp0: int, jp1: int) : unit = this.setVolume(jp0, jp1)
    interface Controllable with
        member this.getControls() : Control[] = this.getControls()
        member this.getControl(jp0: string) : Control = this.getControl(jp0)


