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
type GameStrings =
    [<DefaultValue(false)>] val mutable PROCESS_TICK : string
    [<DefaultValue(false)>] val mutable ON_GAME_INITIALIZED : string
    [<DefaultValue(false)>] val mutable UPDATESURFACE : string
    [<DefaultValue(false)>] val mutable ON_SET_DISPLAYABLE : string
    [<DefaultValue(false)>] val mutable UNPAUSE : string
    [<DefaultValue(false)>] val mutable TOGGLE_MENU : string
    [<DefaultValue(false)>] val mutable SET_GAME_OVER : string
    [<DefaultValue(false)>] val mutable GAME_STATE : string
    [<DefaultValue(false)>] val mutable SET_GAME_STATE : string
    [<DefaultValue(false)>] val mutable STOP_GAME_CANVAS_RUNNABLE_INTERFACE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameStrings
    static member instance with get() : GameStrings = (GameStrings.jclinit(); GameStrings.jcell_instance) and set (jvalue: GameStrings) = (GameStrings.jclinit(); GameStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameStrings.jclinitDone then
            GameStrings.jclinitDone <- true
            GameStrings.jclinitBody()
    static member private jclinitBody() : unit =
        GameStrings.jcell_instance <- (new GameStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameStrings()
    member this.jfields_GameStrings() : unit =
        this.PROCESS_TICK <- "processTick"
        this.ON_GAME_INITIALIZED <- "onGameInitialized"
        this.UPDATESURFACE <- "updateSurface"
        this.ON_SET_DISPLAYABLE <- "onSetDisplayable"
        this.UNPAUSE <- "unPause"
        this.TOGGLE_MENU <- "toggleMenu"
        this.SET_GAME_OVER <- "setGameOver"
        this.GAME_STATE <- "Game State: "
        this.SET_GAME_STATE <- "setGameState"
        this.STOP_GAME_CANVAS_RUNNABLE_INTERFACE <- "stopGameCanvasRunnableInterface"
        ()
    
    static member getInstance() : GameStrings =
        GameStrings.instance


