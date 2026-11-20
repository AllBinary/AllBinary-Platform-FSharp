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
type MyCanvas =
    inherit Canvas
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable canvasStrings : CanvasStrings
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable childNameList : BasicArrayList
    [<DefaultValue(false)>] val mutable commandStack : ABStack
    [<DefaultValue(false)>] val mutable commandListener : CommandListener
    [<DefaultValue(false)>] val mutable paused : bool
    [<DefaultValue(false)>] val mutable touchME : TouchJ2ME
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MyCanvas.jclinitDone then
            MyCanvas.jclinitDone <- true
            MyCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MyCanvas() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.canvasStrings <- CanvasStrings.getInstance()
        this.stringUtil <- StringUtil.getInstance()
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.commandListener <- NullCommandListener.NULL_COMMAND_LISTENER
        this.touchME <- (new TouchJ2ME())
        ()
    
    new (name: string, childNameList: BasicArrayList) as this =
        { inherit Canvas() }
        then
            this.jfields_MyCanvas()
            this.jctor1(name, childNameList)
    member this.jctor1(name: string, childNameList: BasicArrayList) : unit =
        this.logUtil.putF(this.commonStrings.CONSTRUCTOR, this, this.commonStrings.CONSTRUCTOR)
        this.displayInfo.update(this, this.canvasStrings.CONSTRUCTOR)
        this.name <- name
        this.childNameList <- childNameList
        this.commandStack <- StdUtil.getInstance().createStack()
        ()
    
    override this.getWidth() : int =
        base.getWidth()
    
    override this.getHeight() : int =
        base.getHeight()
    
    override this.setFullScreenMode(mode: bool) : unit =
        base.setFullScreenMode(mode)
        this.displayInfo.update(this, this.canvasStrings.SET_FULL_SCREEN_MODE)
    
    override this.sizeChanged(w: int, h: int) : unit =
        this.displayInfo.update(this, this.canvasStrings.SIZE_CHANGED)
    
    abstract getCommandStack : unit -> ABStack
    default this.getCommandStack() : ABStack =
        this.commandStack
    
    abstract isCommand : command: Command -> bool
    default this.isCommand(command: Command) : bool =
        this.commandStack.contains(command)
    
    override this.addCommand(command: Command) : unit =
        if not (this.commandStack.contains(command)) then
            ignore (this.commandStack.push(command))
            base.addCommand(command)
    
    override this.removeCommand(command: Command) : unit =
        ignore (this.commandStack.removeElement(command))
        base.removeCommand(command)
    
    abstract removeAllCommands : unit -> unit
    default this.removeAllCommands() : unit =
        let mutable size : int = this.commandStack.size()
        let mutable index : int = 0
        while index < size do
            base.removeCommand((box (this.commandStack.pop()) :?> Command))
            index <- index + 1
    
    override this.setCommandListener(l: CommandListener) : unit =
        base.setCommandListener(l)
        this.commandListener <- l
    
    abstract getCustomCommandListener : unit -> CommandListener
    default this.getCustomCommandListener() : CommandListener =
        this.commandListener
    
    abstract isPaused : unit -> bool
    default this.isPaused() : bool =
        this.paused
    
    abstract removePauseCommand : unit -> unit
    default this.removePauseCommand() : unit =
        this.removeCommand(MyCommandsFactory.getInstance().PAUSE_COMMAND)
    
    abstract pause : unit -> unit
    default this.pause() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.canvasStrings.PAUSE)
        this.removePauseCommand()
        this.addCommand(MyCommandsFactory.getInstance().RESUME_COMMAND)
        this.setPaused(true)
    
    abstract unPause : unit -> unit
    default this.unPause() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.canvasStrings.UN_PAUSE)
        this.removeCommand(MyCommandsFactory.getInstance().RESUME_COMMAND)
        this.addCommand(MyCommandsFactory.getInstance().PAUSE_COMMAND)
        this.setPaused(false)
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        this.displayInfo.process_()
    
    override this.paint(graphics: Graphics) : unit =
        ()
    
    abstract draw : graphics: Graphics -> unit
    default this.draw(graphics: Graphics) : unit =
        ()
    
    abstract hasChild : displayable: MyCanvas -> bool
    default this.hasChild(displayable: MyCanvas) : bool =
        this.childNameList.contains(displayable.name)
    
    abstract destroy : unit -> unit
    default this.destroy() : unit =
        this.logUtil.putF("Destroyed MyCanvas", this, "destroy")
    
    abstract setPaused : isPaused: bool -> unit
    default this.setPaused(isPaused: bool) : unit =
        this.paused <- isPaused
    
    abstract keyPressedByDevice : keyCode: int * deviceId: int -> unit
    default this.keyPressedByDevice(keyCode: int, deviceId: int) : unit =
        ()
    
    abstract keyRepeatedByDevice : keyCode: int * deviceId: int -> unit
    default this.keyRepeatedByDevice(keyCode: int, deviceId: int) : unit =
        ()
    
    abstract keyReleasedByDevice : keyCode: int * deviceId: int -> unit
    default this.keyReleasedByDevice(keyCode: int, deviceId: int) : unit =
        ()
    
    override this.pointerDragged(x: int, y: int) : unit =
        this.touchME.pointerDragged(x, y)
    
    override this.pointerPressed(x: int, y: int) : unit =
        this.touchME.pointerPressed(x, y)
    
    override this.pointerReleased(x: int, y: int) : unit =
        this.touchME.pointerReleased(x, y)
    
    abstract nextSong : nextSongSound: Sound * leftVolume: int * rightVolume: int -> unit
    default this.nextSong(nextSongSound: Sound, leftVolume: int, rightVolume: int) : unit =
        ()
    interface DisplayableInterface with
        member this.addCommand(jp0: Command) : unit = this.addCommand(jp0)
        member this.getHeight() : int = this.getHeight()
        member this.getWidth() : int = this.getWidth()
        member this.removeCommand(jp0: Command) : unit = this.removeCommand(jp0)
        member this.setCommandListener(jp0: CommandListener) : unit = this.setCommandListener(jp0)
    interface MyCommandInterface with
        member this.addCommand(jp0: Command) : unit = this.addCommand(jp0)
        member this.removeAllCommands() : unit = this.removeAllCommands()


