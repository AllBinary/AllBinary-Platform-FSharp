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
type GameInputMappingInstructionsCanvas =
    inherit GameCommandCanvas
    [<DefaultValue(false)>] val mutable drawStringUtil : DrawStringUtil
    [<DefaultValue(false)>] val mutable TITLE : string
    [<DefaultValue(false)>] val mutable instructions : string[]
    [<DefaultValue(false)>] val mutable colorFillPaintable : ColorFillBasePaintable
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jcell_DISPLAY : Command
    static member DISPLAY with get() : Command = (GameInputMappingInstructionsCanvas.jclinit(); GameInputMappingInstructionsCanvas.jcell_DISPLAY) and set (jvalue: Command) = (GameInputMappingInstructionsCanvas.jclinit(); GameInputMappingInstructionsCanvas.jcell_DISPLAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_CLOSE : Command
    static member CLOSE with get() : Command = (GameInputMappingInstructionsCanvas.jclinit(); GameInputMappingInstructionsCanvas.jcell_CLOSE) and set (jvalue: Command) = (GameInputMappingInstructionsCanvas.jclinit(); GameInputMappingInstructionsCanvas.jcell_CLOSE <- jvalue)
    static member NAME : string = "GameInputMappingInstructionsCanvas"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputMappingInstructionsCanvas.jclinitDone then
            GameInputMappingInstructionsCanvas.jclinitDone <- true
            GameInputMappingInstructionsCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        GameInputMappingInstructionsCanvas.jcell_DISPLAY <- (new Command("Help", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        GameInputMappingInstructionsCanvas.jcell_CLOSE <- (new Command("Close", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 1))
        ()
    member this.jfields_GameInputMappingInstructionsCanvas() : unit =
        this.drawStringUtil <- DrawStringUtil.getInstance()
        this.TITLE <- "Input Instructions"
        this.instructions <- ([| "Add Input Mapping:"; "1. Select the desired action by generating a currently defined input for a given action."; "(Example: Press the '1' key to select the Fire action)"; "2. Make the newly desired input for the selected action."; "(Example: Press 'f' to add it to the selected action)"; "Note: If the input is already mapped to another action then it will not be added. You"; "will need to deleted from the other action before adding it to another."; "Warning: Not all keys map for a given platform and show as Unknown."; StringUtil.getInstance().EMPTY_STRING; "Remove Input Mapping:"; "1. Select the desired action by generating a currently defined input for a given action."; "(Example: Press the key '1' to select the Fire action)"; "2. Select a mapped input for the selected action."; "(Example: Press the key '1' to select the '1' key input for the selected Fire action)"; "3. Press the Delete Key." |] : string[])
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager) as this =
        { inherit GameCommandCanvas(commandListener, GameInputMappingInstructionsCanvas.NAME, allBinaryGameLayerManager.getBackgroundBasicColor(), allBinaryGameLayerManager.getForegroundBasicColor()) }
        then
            this.jfields_GameInputMappingInstructionsCanvas()
            this.jctor1(commandListener, allBinaryGameLayerManager)
    member this.jctor1(commandListener: CommandListener, allBinaryGameLayerManager: AllBinaryGameLayerManager) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.colorFillPaintable <- ColorFillPaintableFactory.getInstance_jstatic().getInstance(allBinaryGameLayerManager.getBackgroundBasicColor(), false)
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.addCommand(GameInputMappingInstructionsCanvas.CLOSE)
        this.setCommandListener(cmdListener)
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        this.colorFillPaintable.paint(graphics)
        let mutable halfWidth : int = this.displayInfo.getLastHalfWidth()
        let mutable beginWidth : int = (graphics.getFont().stringWidth(this.TITLE) >>> 1)
        graphics.setColor(this.foregroundColor)
        graphics.drawString(this.TITLE, (halfWidth - beginWidth), this.fontHeight, this.anchor)
        this.drawStringUtil.drawCenterStrings(graphics, this.instructions, this.displayInfo.getLastWidth(), this.fontHeight, halfWidth, (3 * this.fontHeight))
        base.paint(graphics)


