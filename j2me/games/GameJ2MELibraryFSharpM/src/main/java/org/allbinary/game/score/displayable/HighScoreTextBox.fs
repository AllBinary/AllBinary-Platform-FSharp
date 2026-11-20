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
type HighScoreTextBox =
    inherit CustomTextBox
    [<DefaultValue(false)>] val mutable virtualKeyboardEventHandler : VirtualKeyboardEventHandler
    [<DefaultValue(false)>] val mutable highScoreUtil : HighScoreUtil
    [<DefaultValue(false)>] val mutable pleaseWait : Paintable
    [<DefaultValue(false)>] val mutable paintable : Paintable
    [<DefaultValue(false)>] val mutable submitted : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreTextBox.jclinitDone then
            HighScoreTextBox.jclinitDone <- true
            HighScoreTextBox.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoreTextBox() : unit =
        this.virtualKeyboardEventHandler <- VirtualKeyboardEventHandler.getInstance()
        this.pleaseWait <- (new SimpleTextPaintable(this.commonStrings.PLEASE_WAIT, BasicColorFactory.getInstance().WHITE))
        this.paintable <- NullPaintable.getInstance()
        this.submitted <- false
        ()
    
    new (highScoresFactoryInterface: HighScoresFactoryInterface, highScoresHelper: HighScoresHelperBaseInterface, abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, cmdListener: CommandListener, name: string, highScore: HighScore, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CustomTextBox(cmdListener, "New High Score Enter Name:", name, 12, TextField.ANY, Font.getDefaultFont(), backgrounBasicColor, foregroundBasicColor) }
        then
            this.jfields_HighScoreTextBox()
            this.jctor1(highScoresFactoryInterface, highScoresHelper, abeClientInformation, gameInfo, cmdListener, name, highScore, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(highScoresFactoryInterface: HighScoresFactoryInterface, highScoresHelper: HighScoresHelperBaseInterface, abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, cmdListener: CommandListener, name: string, highScore: HighScore, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.highScoreUtil <- (new HighScoreUtil(highScoresFactoryInterface, highScoresHelper, abeClientInformation, gameInfo, cmdListener, name, highScore))
        let mutable operatingSystemInterface : GenericOperatingSystem = OperatingSystemFactory.getInstance().getOperatingSystemInstance()
        if operatingSystemInterface.isOverScan() then
            let mutable username : string = InApplicationPurchaseFactory.getInstance().getUserName()
            this.getTextFieldItem().setString(username)
        ()
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        PostGameCommandFactory.getInstance().addCommands(this)
        this.addCommand(HighScoreUtil.SUBMIT_TEXTBOX_COMMAND)
        this.setCommandListener(cmdListener)
    
    override this.open_() : unit =
        this.virtualKeyboardEventHandler.open_()
        this.paintable <- NullPaintable.getInstance()
        base.open_()
    
    override this.close() : unit =
        this.virtualKeyboardEventHandler.close()
        this.paintable <- this.pleaseWait
        this.repaintBehavior.onChangeRepaint(this)
        base.close()
        this.removeCommand(HighScoreUtil.SUBMIT_TEXTBOX_COMMAND)
        this.update()
        if this.submitted then
            this.highScoreUtil.saveHighScore()
        else
            ()
        this.paintable <- NullPaintable.getInstance()
        this.repaintBehavior.onChangeRepaint(this)
    
    override this.update() : unit =
        let mutable name : string = this.getTextFieldItem().getString()
        this.highScoreUtil.update(name)
        base.update()
    
    override this.paint(graphics: Graphics) : unit =
        base.paint(graphics)
        ignore (this.paintable.paint(graphics))
    
    abstract saveHighScore : unit -> unit
    default this.saveHighScore() : unit =
        this.highScoreUtil.saveHighScore()
    
    override this.submit() : unit =
        this.highScoreUtil.submit(this)


