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
type PlayerComposite =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable player : Player
    [<DefaultValue(false)>] val mutable timeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerComposite.jclinitDone then
            PlayerComposite.jclinitDone <- true
            PlayerComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PlayerComposite() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.timeElapsedHelper <- (new TimeDelayHelper(0))
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        ()
    
    new (player: Player, repeatTime: int) as this =
        {  }
        then
            this.jfields_PlayerComposite()
            this.jctor1(player, repeatTime)
    member this.jctor1(player: Player, repeatTime: int) : unit =
        this.player <- player
        this.timeElapsedHelper.delay <- repeatTime
        ()
    
    abstract addPlayerListener : playerListener: PlayerListener -> unit
    default this.addPlayerListener(playerListener: PlayerListener) : unit =
        this.player.addPlayerListener(playerListener)
    
    abstract removePlayerListener : playerListener: PlayerListener -> unit
    default this.removePlayerListener(playerListener: PlayerListener) : unit =
        this.player.removePlayerListener(playerListener)
    
    abstract close : unit -> unit
    default this.close() : unit =
        this.player.close()
    
    abstract deallocate : unit -> unit
    default this.deallocate() : unit =
        this.player.deallocate()
    
    abstract getContentType : unit -> string
    default this.getContentType() : string =
        this.player.getContentType()
    
    abstract getDuration : unit -> int64
    default this.getDuration() : int64 =
        this.player.getDuration()
    
    abstract getMediaTime : unit -> int64
    default this.getMediaTime() : int64 =
        this.player.getMediaTime()
    
    abstract prefetch : unit -> unit
    default this.prefetch() : unit =
        try
            this.player.prefetch()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "prefetch", e)
            | _ -> reraise ()
    
    abstract realize : unit -> unit
    default this.realize() : unit =
        try
            this.player.realize()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "realize", e)
            | _ -> reraise ()
    
    abstract getState : unit -> int
    default this.getState() : int =
        this.player.getState()
    
    abstract setLoopCount : count: int -> unit
    default this.setLoopCount(count: int) : unit =
        this.player.setLoopCount(count)
    
    abstract setMediaTime : now: int64 -> int64
    default this.setMediaTime(now: int64) : int64 =
        let mutable jflow = 0
        let mutable jret : int64 = Unchecked.defaultof<int64>
        try
            jret <- this.player.setMediaTime(now)
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "setMediaTime", e)
                jret <- int64 (-1)
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract start : unit -> unit
    default this.start() : unit =
        try
            if this.timeElapsedHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
                this.player.start()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.START_METHOD_NAME, e)
            | _ -> reraise ()
    
    abstract stop : unit -> unit
    default this.stop() : unit =
        try
            this.player.stop()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "stop", e)
            | _ -> reraise ()
    
    abstract getControl : controlType: string -> Control
    default this.getControl(controlType: string) : Control =
        this.player.getControl(controlType)
    
    abstract getControls : unit -> Control[]
    default this.getControls() : Control[] =
        raise ((new JRuntimeException()))
    
    abstract setVolume : leftVolume: int * rightVolume: int -> unit
    default this.setVolume(leftVolume: int, rightVolume: int) : unit =
        let mutable controllable2 : Controllable2 = ((box (this.player) :?> Controllable2))
        controllable2.setVolume(leftVolume, rightVolume)
    
    abstract getPlayerP : unit -> Player
    default this.getPlayerP() : Player =
        this.player
    interface Controllable with
        member this.getControls() : Control[] = this.getControls()
        member this.getControl(jp0: string) : Control = this.getControl(jp0)
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


