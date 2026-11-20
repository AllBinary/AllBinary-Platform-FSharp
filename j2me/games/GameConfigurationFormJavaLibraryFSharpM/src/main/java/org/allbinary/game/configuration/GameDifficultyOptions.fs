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
type GameDifficultyOptions =
    inherit CommandForm
    [<DefaultValue(false)>] val mutable meUtil : MIDPUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameDifficultyOptions.jclinitDone then
            GameDifficultyOptions.jclinitDone <- true
            GameDifficultyOptions.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameDifficultyOptions() : unit =
        this.meUtil <- MIDPUtil.getInstance()
        ()
    
    new (commandListener: CommandListener, title: string, list_: BasicArrayList, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CommandForm(commandListener, title, backgrounBasicColor, foregroundBasicColor) }
        then
            this.jfields_GameDifficultyOptions()
            this.jctor1(commandListener, title, list_, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, title: string, list_: BasicArrayList, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.list <- list_
        this.update()
        this.initCommands(commandListener)
        let mutable gameDifficultyFactory : GameDifficultyFactory = GameDifficultyFactory.getInstance()
        this.setSelectedId(gameDifficultyFactory.getLevel())
        ()
    
    override this.open_() : unit =
        base.open_()
    
    override this.close() : unit =
        base.close()
        this.save()
    
    abstract save : unit -> unit
    default this.save() : unit =
        let mutable gameDifficultyFactory : GameDifficultyFactory = GameDifficultyFactory.getInstance()
        gameDifficultyFactory.setLevel(this.getSelectedId())
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        this.removeAllCommands()
        this.addCommand(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS)
        this.setCommandListener(cmdListener)
    
    override this.update() : unit =
        this.deleteAll()
        this.add(this.list, "Difficulty", Choice.EXCLUSIVE)
        base.update()
    
    member this.add(list_: BasicArrayList, name: string, option_: int) : unit =
        let mutable choiceGroup : ChoiceGroup = this.getChoiceGroup(list_, name, option_)
        if list_.size() > 0 then
            choiceGroup.setSelectedIndex(0, true)
        ignore (this.meUtil.appendItem(this, choiceGroup))
    
    member this.getChoiceGroup(list_: BasicArrayList, name: string, option_: int) : ChoiceGroup =
        let mutable METHOD_NAME : string = "addChoiceGroup"
        let mutable NAME : string = "Adding Choice: "
        let mutable choiceGroup : ChoiceGroup = (new ChoiceGroup(name, option_, StringUtil.getInstance().getArrayInstance(), NullImage.NULL_IMAGE_ARRAY))
        let mutable size : int = list_.size()
        let mutable anyType : obj = null
        let mutable index : int = 0
        while index < size do
            anyType <- list_.objectArray.[index]
            this.logUtil.putF((new StringMaker()).append(NAME).append(anyType.ToString()).ToString(), this, METHOD_NAME)
            ignore (choiceGroup.append(anyType.ToString(), NullImage.NULL_IMAGE))
            index <- index + 1
        choiceGroup
    
    abstract setSelectedId : id_: int -> unit
    default this.setSelectedId(id_: int) : unit =
        let mutable choiceGroup : ChoiceGroup = (box (this.get(0)) :?> ChoiceGroup)
        choiceGroup.setSelectedIndex(id_, true)
    
    abstract getSelectedId : unit -> int
    default this.getSelectedId() : int =
        let mutable choiceGroup : ChoiceGroup = (box (this.get(0)) :?> ChoiceGroup)
        choiceGroup.getSelectedIndex()
    
    abstract getSelectedText : unit -> int
    default this.getSelectedText() : int =
        let mutable choiceGroup : ChoiceGroup = (box (this.get(0)) :?> ChoiceGroup)
        let mutable value : int = Integer.valueOf(choiceGroup.getString(choiceGroup.getSelectedIndex())).intValue()
        value


