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
type GameInputMappingCanvas =
    inherit GameCommandCanvas
    [<DefaultValue(false)>] val mutable paintable : ProcessPaintable
    [<DefaultValue(false)>] val mutable helpPaintable : InputMappingHelpPaintable
    [<DefaultValue(false)>] val mutable colorFillPaintable : ColorFillBasePaintable
    [<DefaultValue(false)>] val mutable inputMapping : PersistentInputMapping
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] val mutable selectedGameKey : GameKey
    [<DefaultValue(false)>] val mutable selectedInput : Input
    [<DefaultValue(false)>] val mutable inputFactory : InputFactory
    static member NAME : string = "GameInputMappingCanvas"
    [<DefaultValue(false)>] static val mutable private jcell_DISPLAY : Command
    static member DISPLAY with get() : Command = (GameInputMappingCanvas.jclinit(); GameInputMappingCanvas.jcell_DISPLAY) and set (jvalue: Command) = (GameInputMappingCanvas.jclinit(); GameInputMappingCanvas.jcell_DISPLAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_DEFAULT : Command
    static member DEFAULT with get() : Command = (GameInputMappingCanvas.jclinit(); GameInputMappingCanvas.jcell_DEFAULT) and set (jvalue: Command) = (GameInputMappingCanvas.jclinit(); GameInputMappingCanvas.jcell_DEFAULT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputMappingCanvas.jclinitDone then
            GameInputMappingCanvas.jclinitDone <- true
            GameInputMappingCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        GameInputMappingCanvas.jcell_DISPLAY <- (new Command("Controls", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        GameInputMappingCanvas.jcell_DEFAULT <- (new Command("Default", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        ()
    member this.jfields_GameInputMappingCanvas() : unit =
        this.NONE <- GameKeyFactory.getInstance().NONE
        this.selectedGameKey <- this.NONE
        this.selectedInput <- this.NONE
        this.inputFactory <- InputFactory.getInstance()
        ()
    
    new (abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager, helpPaintable: HelpPaintable) as this =
        { inherit GameCommandCanvas(commandListener, GameInputMappingCanvas.NAME, allBinaryGameLayerManager.getBackgroundBasicColor(), allBinaryGameLayerManager.getForegroundBasicColor()) }
        then
            this.jfields_GameInputMappingCanvas()
            this.jctor1(abeClientInformation, commandListener, allBinaryGameLayerManager, helpPaintable)
    member this.jctor1(abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager, helpPaintable: HelpPaintable) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        if (JR.same(helpPaintable, null)) then
            raise ((new JException("Help Paintable Exception")))
        this.abeClientInformation <- abeClientInformation
        this.helpPaintable <- (box (helpPaintable) :?> InputMappingHelpPaintable)
        this.inputMapping <- PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance()
        this.paintable <- (new ProcessPaintable())
        this.colorFillPaintable <- ColorFillPaintableFactory.getInstance_jstatic().getInstance(allBinaryGameLayerManager.getBackgroundBasicColor(), false)
        ()
    
    override this.close() : unit =
        base.close()
        this.paintable.process_()
        this.selectedGameKey <- this.NONE
        this.selectedInput <- this.NONE
        this.update()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommand(GameCommandsFactory.getInstance().CLOSE_AND_SHOW_GAME_CANVAS)
        this.addCommand(GameInputMappingCanvas.DEFAULT)
        this.addCommand(GameInputMappingInstructionsCanvas.DISPLAY)
        this.setCommandListener(cmdListener)
    
    override this.keyPressed(keyCode: int) : unit =
        this.keyPressedByDevice(keyCode, 0)
    
    override this.keyReleased(keyCode: int) : unit =
        this.keyReleasedByDevice(keyCode, 0)
    
    override this.keyRepeated(keyCode: int) : unit =
        this.keyRepeatedByDevice(keyCode, 0)
    
    override this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        this.addGameKey(keyCode, false)
        base.keyPressedByDevice(keyCode, 0)
    
    member this.addGameKey(keyCode: int, repeated: bool) : unit =
        try
            this.logUtil.putF((new StringMaker()).append("Raw Device Key Code: ").append(Integer.toHexString(keyCode)).ToString(), this, this.gameInputStrings.ADD_KEY_EVENT)
            let mutable gameKey : GameKey = this.inputToGameKeyMapping.getInstanceForCanvas(this, keyCode)
            let mutable input : Input = this.inputFactory.getInstanceById(keyCode)
            this.processInputMapping(gameKey, input)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put("Key Event Error", this, this.gameInputStrings.ADD_KEY_EVENT, e)
            | _ -> reraise ()
    
    abstract processInputMapping : gameKey: GameKey * input: Input -> unit
    default this.processInputMapping(gameKey: GameKey, input: Input) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Start Passed GameKey: "))
        ignore (stringBuffer.append(this.stringUtil.toString(gameKey)))
        ignore (stringBuffer.append(" Input: "))
        ignore (stringBuffer.append(this.stringUtil.toString(input)))
        this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.PROCESS)
        if not (JR.same(this.selectedGameKey, this.NONE)) then
            this.gameActionCrud(gameKey, input)
        else
            this.setSelectedAction(gameKey)
    
    member this.setSelectedAction(gameKey: GameKey) : unit =
        this.logUtil.putF((new StringMaker()).append("Selected GameKey: ").append(this.stringUtil.toString(gameKey)).ToString(), this, "setSelectedAction")
        this.selectedGameKey <- gameKey
        this.selectedInput <- this.NONE
        this.helpPaintable.update(this.selectedGameKey, this.selectedInput)
        this.repaintBehavior.onChangeRepaint(this)
    
    member this.gameActionCrud(gameKey: GameKey, input: Input) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Start GameKey: "))
        ignore (stringBuffer.append(this.stringUtil.toString(this.selectedGameKey)))
        ignore (stringBuffer.append(" Input: "))
        ignore (stringBuffer.append(this.stringUtil.toString(this.selectedInput)))
        this.logUtil.putF(stringBuffer.ToString(), this, "gameActionCrud")
        if (JR.same(this.selectedInput, this.NONE)) then
            let mutable list_ : BasicArrayList = this.inputMapping.getInputMapping().getMappedInput(this.selectedGameKey)
            let mutable isInputAlreadyMappedToSelectedAction : bool = list_.contains(input)
            if isInputAlreadyMappedToSelectedAction then
                this.logUtil.putF((new StringMaker()).append("Already Mapped Input: ").append(this.stringUtil.toString(input)).ToString(), this, "gameActionCrud")
                this.selectedInput <- input
                this.helpPaintable.update(this.selectedGameKey, this.selectedInput)
                this.repaintBehavior.onChangeRepaint(this)
            else
                this.addNewMapping(gameKey, input)
        elif this.inputMapping.isDelete(input) then
            this.deleteCurrentMapping()
        else
            this.setSelectedAction(gameKey)
    
    member this.addNewMapping(gameKey: GameKey, input: Input) : unit =
        let mutable METHOD_NAME : string = "addNewMapping"
        this.logUtil.putF(this.commonStrings.START, this, METHOD_NAME)
        let mutable isInputAlreadyMapped : bool = this.inputMapping.getInputMapping().isMapped(input)
        if (not (isInputAlreadyMapped)) && (not (this.inputMapping.isSystemInput(input))) then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("Add Key Mapping : GameKey: "))
            ignore (stringBuffer.append(this.stringUtil.toString(this.selectedGameKey)))
            ignore (stringBuffer.append(" Input: "))
            ignore (stringBuffer.append(this.stringUtil.toString(this.selectedInput)))
            this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
            this.inputMapping.getInputMapping().add(this.selectedGameKey, input)
            this.selectedInput <- input
            this.update()
        else
            this.logUtil.putF("Unable to add Mapping since one already exists or is MENU, HOME, or BACK key and setting selected action to what it is already mapped to", this, METHOD_NAME)
            this.setSelectedAction(gameKey)
    
    member this.deleteCurrentMapping() : unit =
        let mutable METHOD_NAME : string = "deleteCurrentMapping"
        let mutable list_ : BasicArrayList = this.inputMapping.getInputMapping().getMappedInput(this.selectedGameKey)
        if list_.size() > 1 then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("Start GameKey: "))
            ignore (stringBuffer.append("Remove Key Mapping: GameKey: "))
            ignore (stringBuffer.append(this.stringUtil.toString(this.selectedGameKey)))
            ignore (stringBuffer.append(" Input: "))
            ignore (stringBuffer.append(this.stringUtil.toString(this.selectedInput)))
            this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
            this.inputMapping.getInputMapping().remove(this.selectedGameKey, this.selectedInput)
            this.selectedInput <- this.NONE
            this.update()
        else
            this.logUtil.putF("Can't Remove Last Key Mapping", this, METHOD_NAME)
    
    abstract setDefault : unit -> unit
    default this.setDefault() : unit =
        this.inputMapping.setDefault(this.abeClientInformation)
        this.helpPaintable.update(this.NONE, this.NONE)
        this.repaintBehavior.onChangeRepaint(this)
    
    override this.update() : unit =
        this.inputMapping.update(this.abeClientInformation)
        this.helpPaintable.update(this.selectedGameKey, this.selectedInput)
        this.repaintBehavior.onChangeRepaint(this)
    
    override this.paint(graphics: Graphics) : unit =
        this.colorFillPaintable.paint(graphics)
        this.helpPaintable.paint(graphics)
        this.paintable.paint(graphics)
        base.paint(graphics)
    interface InputMappingInterface with
        member this.processInputMapping(jp0: GameKey, jp1: Input) : unit = this.processInputMapping(jp0, jp1)


