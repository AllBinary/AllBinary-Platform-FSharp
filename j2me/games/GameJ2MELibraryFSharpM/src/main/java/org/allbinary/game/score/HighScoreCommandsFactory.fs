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
type HighScoreCommandsFactory =
    inherit HighScoreCommandsBaseFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : HighScoreCommandsFactory
    static member instance with get() : HighScoreCommandsFactory = (HighScoreCommandsFactory.jclinit(); HighScoreCommandsFactory.jcell_instance) and set (jvalue: HighScoreCommandsFactory) = (HighScoreCommandsFactory.jclinit(); HighScoreCommandsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreCommandsFactory.jclinitDone then
            HighScoreCommandsFactory.jclinitDone <- true
            HighScoreCommandsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        HighScoreCommandsFactory.jcell_instance <- (new HighScoreCommandsFactory())
        ()
    
    static member getInstance() : HighScoreCommandsFactory =
        HighScoreCommandsFactory.instance
    
    new () =
        { inherit HighScoreCommandsBaseFactory(([| HighScoreCommands.getInstance().PERSONAL; HighScoreCommands.getInstance().WORLD |] : Command[])) }


