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
type GameInfoData =
    [<DefaultValue(false)>] val mutable GAME_TYPE : string
    [<DefaultValue(false)>] val mutable GAME_MODE : string
    [<DefaultValue(false)>] val mutable PLAYER_TYPE : string
    [<DefaultValue(false)>] val mutable HIGHEST_LEVEL : string
    [<DefaultValue(false)>] val mutable CURRENT_LEVEL : string
    [<DefaultValue(false)>] val mutable SOFTWARE_INFORMATION : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameInfoData
    static member instance with get() : GameInfoData = (GameInfoData.jclinit(); GameInfoData.jcell_instance) and set (jvalue: GameInfoData) = (GameInfoData.jclinit(); GameInfoData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInfoData.jclinitDone then
            GameInfoData.jclinitDone <- true
            GameInfoData.jclinitBody()
    static member private jclinitBody() : unit =
        GameInfoData.jcell_instance <- (new GameInfoData())
        ()
    member this.jfields_GameInfoData() : unit =
        this.GAME_TYPE <- "GAME_TYPE"
        this.GAME_MODE <- "GAME_MODE"
        this.PLAYER_TYPE <- "PLAYER_TYPE"
        this.HIGHEST_LEVEL <- "HIGHEST_LEVEL"
        this.CURRENT_LEVEL <- "CURRENT_LEVEL"
        this.SOFTWARE_INFORMATION <- "SOFTWARE_INFORMATION"
        ()
    
    static member getInstance() : GameInfoData =
        GameInfoData.instance
    
    new () as this =
        {  }
        then
            this.jfields_GameInfoData()


