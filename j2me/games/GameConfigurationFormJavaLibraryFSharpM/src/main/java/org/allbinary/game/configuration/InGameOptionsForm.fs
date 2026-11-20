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
type InGameOptionsForm =
    inherit CommandForm
    [<DefaultValue(false)>] static val mutable private jcell_DISPLAY : Command
    static member DISPLAY with get() : Command = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_DISPLAY) and set (jvalue: Command) = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_DISPLAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SAVE : Command
    static member SAVE with get() : Command = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_SAVE) and set (jvalue: Command) = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_SAVE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_DEFAULT : Command
    static member DEFAULT with get() : Command = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_DEFAULT) and set (jvalue: Command) = (InGameOptionsForm.jclinit(); InGameOptionsForm.jcell_DEFAULT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InGameOptionsForm.jclinitDone then
            InGameOptionsForm.jclinitDone <- true
            InGameOptionsForm.jclinitBody()
    static member private jclinitBody() : unit =
        InGameOptionsForm.jcell_DISPLAY <- (new Command("Options In Game", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        InGameOptionsForm.jcell_SAVE <- (new Command("Save", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        InGameOptionsForm.jcell_DEFAULT <- (new Command("Default", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        ()
    
    new (commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CommandForm(commandListener, title, backgrounBasicColor, foregroundBasicColor) }
        then
            this.jctor1(commandListener, title, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        let mutable gameFeatureFormUtil : GameFeatureFormUtil = GameFeatureFormUtil.getInstance()
        gameFeatureFormUtil.addChoiceGroup(this, InGameFeatureChoiceGroups.getExclusiveInstance().get(), Choice.EXCLUSIVE)
        gameFeatureFormUtil.addChoiceGroup(this, InGameFeatureChoiceGroups.getMultipleInstance().get(), Choice.MULTIPLE)
        this.initCommands(commandListener)
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommand(GameCommandsFactory.getInstance().CLOSE_AND_SHOW_GAME_CANVAS)
        this.addCommand(InGameOptionsForm.DEFAULT)
        this.setCommandListener(cmdListener)


