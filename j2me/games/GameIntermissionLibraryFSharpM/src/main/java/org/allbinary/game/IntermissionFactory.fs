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
type IntermissionFactory =
    [<DefaultValue(false)>] val mutable START_LEVEL_INTERMISSION_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable WAIT_LEVEL_INTERMISSION_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable SHOW_RESULTS_LEVEL_INTERMISSION_GAME_STATE : GameState
    [<DefaultValue(false)>] val mutable SHOW_HIGH_SCORE_LEVEL_INTERMISSION_GAME_STATE : GameState
    [<DefaultValue(false)>] static val mutable private jcell_instance : IntermissionFactory
    static member instance with get() : IntermissionFactory = (IntermissionFactory.jclinit(); IntermissionFactory.jcell_instance) and set (jvalue: IntermissionFactory) = (IntermissionFactory.jclinit(); IntermissionFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IntermissionFactory.jclinitDone then
            IntermissionFactory.jclinitDone <- true
            IntermissionFactory.jclinitBody()
    static member private jclinitBody() : unit =
        IntermissionFactory.jcell_instance <- (new IntermissionFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_IntermissionFactory()
    member this.jfields_IntermissionFactory() : unit =
        this.START_LEVEL_INTERMISSION_GAME_STATE <- GameStateFactory.getInstance().createGameState("START_LEVEL_INTERMISSION_GAME_STATE")
        this.WAIT_LEVEL_INTERMISSION_GAME_STATE <- GameStateFactory.getInstance().createGameState("WAIT_LEVEL_INTERMISSION_GAME_STATE")
        this.SHOW_RESULTS_LEVEL_INTERMISSION_GAME_STATE <- GameStateFactory.getInstance().createGameState("SHOW_RESULTS_LEVEL_INTERMISSION_GAME_STATE")
        this.SHOW_HIGH_SCORE_LEVEL_INTERMISSION_GAME_STATE <- GameStateFactory.getInstance().createGameState("SHOW_HIGH_SCORE_LEVEL_INTERMISSION_GAME_STATE")
        ()
    
    static member getInstance() : IntermissionFactory =
        IntermissionFactory.instance


