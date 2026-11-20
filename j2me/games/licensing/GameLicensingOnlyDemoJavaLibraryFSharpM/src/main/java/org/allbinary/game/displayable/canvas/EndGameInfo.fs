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
type EndGameInfo =
    [<DefaultValue(false)>] val mutable NORMAL_GAME_OVER_WIN : string
    [<DefaultValue(false)>] val mutable TEASER_DEMO_GAME_END_LAST_LEVEL : string
    [<DefaultValue(false)>] val mutable TEASER_DEMO_GAME_END : string
    [<DefaultValue(false)>] val mutable gameOverStr : string
    [<DefaultValue(false)>] val mutable winStr : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EndGameInfo.jclinitDone then
            EndGameInfo.jclinitDone <- true
            EndGameInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_EndGameInfo()
    member this.jfields_EndGameInfo() : unit =
        this.NORMAL_GAME_OVER_WIN <- "You Won"
        this.TEASER_DEMO_GAME_END_LAST_LEVEL <- "End of Demo."
        this.TEASER_DEMO_GAME_END <- "Demo Game Over."
        this.gameOverStr <- StringUtil.getInstance().EMPTY_STRING
        this.winStr <- this.gameOverStr
        ()
    
    member this.update(gameInfo: GameInfo, myCanvas: MyCanvas) : unit =
        if gameInfo.isLastLevel() then
            this.setWinStr(this.TEASER_DEMO_GAME_END_LAST_LEVEL)
            this.setGameOverStr(this.TEASER_DEMO_GAME_END_LAST_LEVEL)
        else
            this.setWinStr(this.NORMAL_GAME_OVER_WIN)
            this.setGameOverStr(this.TEASER_DEMO_GAME_END)
    
    abstract getGameOverStr : unit -> string
    default this.getGameOverStr() : string =
        this.gameOverStr
    
    abstract setGameOverStr : gameOverStr: string -> unit
    default this.setGameOverStr(gameOverStr: string) : unit =
        this.gameOverStr <- gameOverStr
    
    abstract getWinStr : unit -> string
    default this.getWinStr() : string =
        this.winStr
    
    abstract setWinStr : winStr: string -> unit
    default this.setWinStr(winStr: string) : unit =
        this.winStr <- winStr


