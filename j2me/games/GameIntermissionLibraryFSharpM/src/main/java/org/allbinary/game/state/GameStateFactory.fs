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
type GameStateFactory =
    [<DefaultValue(false)>] val mutable index : int
    [<DefaultValue(false)>] val mutable NO_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable PLAYING_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable SHOW_END_RESULT_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable SHOW_HIGH_SCORE_GAME_STATE : GameState
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GameStateFactory.jclinit(); GameStateFactory.jcell_instance) and set (jvalue: obj) = (GameStateFactory.jclinit(); GameStateFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameStateFactory.jclinitDone then
            GameStateFactory.jclinitDone <- true
            GameStateFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameStateFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_GameStateFactory() : unit =
        this.index <- 0
        this.NO_GAME_STATE <- this.createGameState("NO_GAME_STATE")
        this.PLAYING_GAME_STATE <- this.createGameState("PLAYING_GAME_STATE")
        this.SHOW_END_RESULT_GAME_STATE <- this.createGameState("SHOW_END_RESULT_GAME_STATE")
        this.SHOW_HIGH_SCORE_GAME_STATE <- this.createGameState("SHOW_HIGH_SCORE_GAME_STATE")
        ()
    
    static member getInstance() : GameStateFactory =
        if (JR.same(GameStateFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GameStateFactory.instance <- (new GameStateFactory())
        (box (GameStateFactory.instance) :?> GameStateFactory)
    
    new () as this =
        {  }
        then
            this.jfields_GameStateFactory()
    
    abstract createGameState : name: string -> GameState
    default this.createGameState(name: string) : GameState =
        (new GameState(name, (let jt = this.index in this.index <- this.index + 1; jt)))


