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
type GameCommandsFactory =
    [<DefaultValue(false)>] val mutable TOGGLE_FULLSCREEN : Command
    [<DefaultValue(false)>] val mutable TOGGLE_KEYBOARD : Command
    [<DefaultValue(false)>] val mutable SET_MENU_DISPLAYABLE : Command
    [<DefaultValue(false)>] val mutable APPLICATION_UPDATE : Command
    [<DefaultValue(false)>] val mutable DISPLAY_ABOUT : Command
    [<DefaultValue(false)>] val mutable OPEN_WEB_URL : Command
    [<DefaultValue(false)>] val mutable CLOSE_OPTIONS : Command
    [<DefaultValue(false)>] val mutable DISPLAY_OPTIONS : Command
    [<DefaultValue(false)>] val mutable START_TRACE : Command
    [<DefaultValue(false)>] val mutable STOP_TRACE : Command
    [<DefaultValue(false)>] val mutable DEFAULT_OPTIONS : Command
    [<DefaultValue(false)>] val mutable SHOW_GAME_CANVAS : Command
    [<DefaultValue(false)>] val mutable CLOSE_AND_SHOW_GAME_CANVAS : Command
    [<DefaultValue(false)>] val mutable QUIT_COMMAND : Command
    [<DefaultValue(false)>] val mutable RESTART_COMMAND : Command
    [<DefaultValue(false)>] val mutable DISPLAY_SAVE_FORM : Command
    [<DefaultValue(false)>] val mutable SAVE : Command
    [<DefaultValue(false)>] val mutable DISPLAY_LOAD_FORM : Command
    [<DefaultValue(false)>] val mutable LOAD_FILE : Command
    [<DefaultValue(false)>] val mutable DELETE_FILE : Command
    [<DefaultValue(false)>] val mutable EXIT_COMMAND : Command
    [<DefaultValue(false)>] val mutable EXIT_WITHOUT_PROGRESS_COMMAND : Command
    [<DefaultValue(false)>] val mutable START_COMMAND : Command
    [<DefaultValue(false)>] val mutable CONTINUE_COMMAND : Command
    [<DefaultValue(false)>] val mutable SELECT_COMMAND : Command
    [<DefaultValue(false)>] val mutable FEATURE_UPDATE : Command
    [<DefaultValue(false)>] val mutable BUY_COMMAND : Command
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GameCommandsFactory.jclinit(); GameCommandsFactory.jcell_instance) and set (jvalue: obj) = (GameCommandsFactory.jclinit(); GameCommandsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameCommandsFactory.jclinitDone then
            GameCommandsFactory.jclinitDone <- true
            GameCommandsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameCommandsFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_GameCommandsFactory() : unit =
        this.TOGGLE_FULLSCREEN <- (new Command("Toggle FullScreen", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.TOGGLE_KEYBOARD <- (new Command("Keyboard", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.SET_MENU_DISPLAYABLE <- (new Command("Set Menu Displayable", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.APPLICATION_UPDATE <- (new Command(CommonStrings.getInstance().UPDATE, StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.DISPLAY_ABOUT <- (new Command(CanvasStrings.getInstance().ABOUT, StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        this.OPEN_WEB_URL <- (new Command("Open Web URL", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        this.CLOSE_OPTIONS <- (new Command("Back", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.DISPLAY_OPTIONS <- (new Command(CanvasStrings.getInstance().OPTIONS, StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        this.START_TRACE <- (new Command("Start Trace", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.STOP_TRACE <- (new Command("Stop Trace", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.DEFAULT_OPTIONS <- (new Command("Default", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.SHOW_GAME_CANVAS <- (new Command("Back to Game", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.CLOSE_AND_SHOW_GAME_CANVAS <- (new Command("Back", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.QUIT_COMMAND <- (new Command("Quit", StringUtil.getInstance().EMPTY_STRING, Command.STOP, 1))
        this.RESTART_COMMAND <- (new Command("Restart", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 0))
        this.DISPLAY_SAVE_FORM <- (new Command("Save To", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 3))
        this.SAVE <- (new Command("Save", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 3))
        this.DISPLAY_LOAD_FORM <- (new Command("Load", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 3))
        this.LOAD_FILE <- (new Command("Load File", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 3))
        this.DELETE_FILE <- (new Command("Delete File", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.EXIT_COMMAND <- (new Command("Exit", StringUtil.getInstance().EMPTY_STRING, Command.EXIT, 2))
        this.EXIT_WITHOUT_PROGRESS_COMMAND <- (new Command("Exit Without Progress", StringUtil.getInstance().EMPTY_STRING, Command.EXIT, 2))
        this.START_COMMAND <- (new Command(CommonStrings.getInstance().START, StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.CONTINUE_COMMAND <- (new Command("Continue", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.SELECT_COMMAND <- (new Command("Select", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.FEATURE_UPDATE <- (new Command("Feature Update", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.BUY_COMMAND <- (new Command("BUY", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        ()
    
    static member getInstance() : GameCommandsFactory =
        if (JR.same(GameCommandsFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GameCommandsFactory.instance <- (new GameCommandsFactory())
        (box (GameCommandsFactory.instance) :?> GameCommandsFactory)
    
    new () as this =
        {  }
        then
            this.jfields_GameCommandsFactory()


