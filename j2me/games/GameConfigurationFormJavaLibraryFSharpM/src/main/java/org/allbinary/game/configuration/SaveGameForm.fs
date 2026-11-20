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
type SaveGameForm =
    inherit CommandForm
    [<DefaultValue(false)>] val mutable meUtil : MIDPUtil
    [<DefaultValue(false)>] static val mutable private jcell_FORM : CommandForm
    static member FORM with get() : CommandForm = (SaveGameForm.jclinit(); SaveGameForm.jcell_FORM) and set (jvalue: CommandForm) = (SaveGameForm.jclinit(); SaveGameForm.jcell_FORM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SaveGameForm.jclinitDone then
            SaveGameForm.jclinitDone <- true
            SaveGameForm.jclinitBody()
    static member private jclinitBody() : unit =
        SaveGameForm.jcell_FORM <- CommandForm.getNullCommandForm()
        ()
    member this.jfields_SaveGameForm() : unit =
        this.meUtil <- MIDPUtil.getInstance()
        ()
    
    static member createForm(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : CommandForm =
        SaveGameForm.FORM <- (new SaveGameForm(commandListener, title, backgrounBasicColor, foregroundBasicColor))
        SaveGameForm.FORM
    
    static member getInstance() : CommandForm =
        SaveGameForm.FORM
    
    new (commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CommandForm(commandListener, title, backgrounBasicColor, foregroundBasicColor) }
        then
            this.jfields_SaveGameForm()
            this.jctor1(commandListener, title, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        let mutable timeString : string = Long.toString(ABSystemWrapper.getInstance().currentTimeMillis())
        ignore (this.meUtil.appendItem(this, (new TextField("Name: ", timeString, 30, TextField.ANY))))
        this.initCommands(commandListener)
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        this.removeAllCommands()
        this.addCommand(gameCommandsFactory.SAVE)
        this.addCommand(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS)
        this.setCommandListener(cmdListener)


