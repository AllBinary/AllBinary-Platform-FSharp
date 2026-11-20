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
type Sound =
    [<DefaultValue(false)>] val mutable resource : string
    [<DefaultValue(false)>] val mutable player : Player
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Sound.jclinitDone then
            Sound.jclinitDone <- true
            Sound.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Sound() : unit =
        this.player <- NoPlayer.NO_PLAYER
        ()
    
    new (resource: string) as this =
        {  }
        then
            this.jfields_Sound()
            this.jctor1(resource)
    member this.jctor1(resource: string) : unit =
        this.resource <- resource
        ()
    
    abstract getResource : unit -> string
    default this.getResource() : string =
        this.resource
    
    abstract getPlayerP : unit -> Player
    default this.getPlayerP() : Player =
        this.player
    
    abstract setPlayerP : player: Player -> unit
    default this.setPlayerP(player: Player) : unit =
        this.player <- player
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract getDuration : unit -> int
    default this.getDuration() : int =
        -1
    
    abstract run : unit -> unit
    default this.run() : unit =
        try
            this.player.start()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN)
            | _ -> reraise ()
    interface SoundInterface with
        member this.getResource() : string = this.getResource()
        member this.getPlayerP() : Player = this.getPlayerP()
        member this.init() : unit = this.init()
    interface Runnable with
        member this.run() : unit = this.run()


