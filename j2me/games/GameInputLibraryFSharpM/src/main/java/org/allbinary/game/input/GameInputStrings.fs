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
type GameInputStrings =
    [<DefaultValue(false)>] val mutable PROCESS_INPUT : string
    [<DefaultValue(false)>] val mutable KEY_PRESSED : string
    [<DefaultValue(false)>] val mutable KEY_RELEASED : string
    [<DefaultValue(false)>] val mutable KEY_REPEATED : string
    [<DefaultValue(false)>] val mutable ON_PRESS_GAME_KEY : string
    [<DefaultValue(false)>] val mutable ON_DOWN_GAME_KEY : string
    [<DefaultValue(false)>] val mutable ON_UP_GAME_KEY : string
    [<DefaultValue(false)>] val mutable NO_KEY : string
    [<DefaultValue(false)>] val mutable ADD_KEY_EVENT : string
    [<DefaultValue(false)>] val mutable REMOVE_KEY_EVENT : string
    [<DefaultValue(false)>] val mutable STRAFE_LEFT : string
    [<DefaultValue(false)>] val mutable STRAFE_RIGHT : string
    [<DefaultValue(false)>] val mutable PROCESS_MOTION_INPUT : string
    [<DefaultValue(false)>] val mutable UDPATE_CURRENT_TOUCH_INPUT_FACTORY : string
    [<DefaultValue(false)>] val mutable ENABLE_PLAYER_GAME_INPUTS : string
    [<DefaultValue(false)>] val mutable ENABLE_PLAYER_GAME_INPUT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameInputStrings
    static member instance with get() : GameInputStrings = (GameInputStrings.jclinit(); GameInputStrings.jcell_instance) and set (jvalue: GameInputStrings) = (GameInputStrings.jclinit(); GameInputStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputStrings.jclinitDone then
            GameInputStrings.jclinitDone <- true
            GameInputStrings.jclinitBody()
    static member private jclinitBody() : unit =
        GameInputStrings.jcell_instance <- (new GameInputStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameInputStrings()
    member this.jfields_GameInputStrings() : unit =
        this.PROCESS_INPUT <- "processInput"
        this.KEY_PRESSED <- "keyPressed"
        this.KEY_RELEASED <- "keyReleased"
        this.KEY_REPEATED <- "keyRepeated"
        this.ON_PRESS_GAME_KEY <- "onPressGameKeyEvent"
        this.ON_DOWN_GAME_KEY <- "onDownGameKeyEvent"
        this.ON_UP_GAME_KEY <- "onUpGameKeyEvent"
        this.NO_KEY <- "Key Code Not Mapped For Game: "
        this.ADD_KEY_EVENT <- "addGameKeyEvent"
        this.REMOVE_KEY_EVENT <- "removeGameKeyEvent"
        this.STRAFE_LEFT <- "strafeLeft"
        this.STRAFE_RIGHT <- "strafeRight"
        this.PROCESS_MOTION_INPUT <- "processMotionInput"
        this.UDPATE_CURRENT_TOUCH_INPUT_FACTORY <- "updateCurrentTouchInputFactory"
        this.ENABLE_PLAYER_GAME_INPUTS <- "Enabling PlayerGameInputs: "
        this.ENABLE_PLAYER_GAME_INPUT <- "Enabling PlayerGameInput: "
        ()
    
    static member getInstance() : GameInputStrings =
        GameInputStrings.instance


