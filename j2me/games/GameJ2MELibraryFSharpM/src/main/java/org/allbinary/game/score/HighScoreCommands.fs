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
type HighScoreCommands =
    [<DefaultValue(false)>] val mutable DISPLAY : Command
    [<DefaultValue(false)>] val mutable PERSONAL : Command
    [<DefaultValue(false)>] val mutable WORLD : Command
    [<DefaultValue(false)>] static val mutable private jcell_instance : HighScoreCommands
    static member instance with get() : HighScoreCommands = (HighScoreCommands.jclinit(); HighScoreCommands.jcell_instance) and set (jvalue: HighScoreCommands) = (HighScoreCommands.jclinit(); HighScoreCommands.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreCommands.jclinitDone then
            HighScoreCommands.jclinitDone <- true
            HighScoreCommands.jclinitBody()
    static member private jclinitBody() : unit =
        HighScoreCommands.jcell_instance <- (new HighScoreCommands())
        ()
    new () as this =
        {  }
        then
            this.jfields_HighScoreCommands()
    member this.jfields_HighScoreCommands() : unit =
        this.DISPLAY <- (new Command("Scores", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.PERSONAL <- (new Command("Personal", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        this.WORLD <- (new Command("World", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        ()
    
    static member getInstance() : HighScoreCommands =
        HighScoreCommands.instance


