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
type LoadGameForm =
    inherit CommandForm
    [<DefaultValue(false)>] val mutable meUtil : MIDPUtil
    [<DefaultValue(false)>] val mutable areChoices : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LoadGameForm.jclinitDone then
            LoadGameForm.jclinitDone <- true
            LoadGameForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LoadGameForm() : unit =
        this.meUtil <- MIDPUtil.getInstance()
        ()
    
    new (commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CommandForm(commandListener, title, backgrounBasicColor, foregroundBasicColor) }
        then
            this.jfields_LoadGameForm()
            this.jctor1(commandListener, title, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.update()
        this.initCommands(commandListener)
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        this.removeAllCommands()
        this.addCommand(gameCommandsFactory.LOAD_FILE)
        this.addCommand(gameCommandsFactory.DELETE_FILE)
        this.addCommand(gameCommandsFactory.CLOSE_AND_SHOW_GAME_CANVAS)
        this.setCommandListener(cmdListener)
    
    override this.update() : unit =
        let mutable list_ : BasicArrayList = GamePersistanceSingleton.getInstance().getIds()
        this.deleteAll()
        if list_.size() > 0 then
            this.add(list_, "Select A Saved Game", Choice.EXCLUSIVE)
            this.areChoices <- true
        else
            ignore (this.meUtil.appendItem(this, (new StringItem("No Saved Games", StringUtil.getInstance().EMPTY_STRING, LcduiItem.PLAIN))))
            this.areChoices <- false
        base.update()
    
    member this.add(list_: BasicArrayList, name: string, option_: int) : unit =
        let mutable choiceGroup : ChoiceGroup = this.getChoiceGroup(list_, name, option_)
        if list_.size() > 0 then
            choiceGroup.setSelectedIndex(0, true)
        ignore (this.meUtil.appendItem(this, choiceGroup))
    
    member this.getChoiceGroup(list_: BasicArrayList, name: string, option_: int) : ChoiceGroup =
        let mutable METHOD_NAME : string = "getChoiceGroup"
        let mutable ADDING_CHOICE : string = "Adding Choice: "
        let mutable choiceGroup : ChoiceGroup = (new ChoiceGroup(name, option_, StringUtil.getInstance().getArrayInstance(), NullImage.NULL_IMAGE_ARRAY))
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable anyType : obj = list_.objectArray.[index]
            this.logUtil.putF((new StringMaker()).append(ADDING_CHOICE).append(anyType.ToString()).ToString(), this, METHOD_NAME)
            ignore (choiceGroup.append(anyType.ToString(), NullImage.NULL_IMAGE))
            index <- index + 1
        choiceGroup
    
    abstract getSelectedId : unit -> int
    default this.getSelectedId() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if this.areChoices then
            let mutable choiceGroup : ChoiceGroup = (box (this.get(0)) :?> ChoiceGroup)
            jret <- choiceGroup.getSelectedIndex()
            jflow <- 1
        else
            jret <- -1
            jflow <- 1
        jret
    
    abstract getSelectedText : unit -> int
    default this.getSelectedText() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if this.areChoices then
            let mutable choiceGroup : ChoiceGroup = (box (this.get(0)) :?> ChoiceGroup)
            let mutable value : int = Integer.valueOf(choiceGroup.getString(choiceGroup.getSelectedIndex())).intValue()
            jret <- value
            jflow <- 1
        else
            jret <- -1
            jflow <- 1
        jret


