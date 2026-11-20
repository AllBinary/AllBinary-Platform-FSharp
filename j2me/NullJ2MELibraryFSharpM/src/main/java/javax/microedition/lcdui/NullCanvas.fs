namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullCanvas =
    inherit Canvas
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CANVAS : NullCanvas
    static member NULL_CANVAS with get() : NullCanvas = (NullCanvas.jclinit(); NullCanvas.jcell_NULL_CANVAS) and set (jvalue: NullCanvas) = (NullCanvas.jclinit(); NullCanvas.jcell_NULL_CANVAS <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullCanvas.jclinitDone then
            NullCanvas.jclinitDone <- true
            NullCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        NullCanvas.jcell_NULL_CANVAS <- (new NullCanvas())
        ()
    
    new () =
        { inherit Canvas() }
    
    override this.setFullScreenMode(mode: bool) : unit =
        ()
    
    override this.sizeChanged(w: int, h: int) : unit =
        ()
    
    abstract getCommandStack : unit -> Stack
    default this.getCommandStack() : Stack =
        raise ((new JRuntimeException()))
    
    abstract isCommand : command: Command -> bool
    default this.isCommand(command: Command) : bool =
        raise ((new JRuntimeException()))
    
    override this.addCommand(command: Command) : unit =
        ()
    
    override this.removeCommand(command: Command) : unit =
        ()
    
    abstract removeAllCommands : unit -> unit
    default this.removeAllCommands() : unit =
        ()
    
    override this.setCommandListener(l: CommandListener) : unit =
        ()
    
    abstract getCustomCommandListener : unit -> CommandListener
    default this.getCustomCommandListener() : CommandListener =
        raise ((new JRuntimeException()))
    
    abstract isPaused : unit -> bool
    default this.isPaused() : bool =
        raise ((new JRuntimeException()))
    
    abstract removePauseCommand : unit -> unit
    default this.removePauseCommand() : unit =
        ()
    
    abstract pause : unit -> unit
    default this.pause() : unit =
        ()
    
    abstract unPause : unit -> unit
    default this.unPause() : unit =
        ()
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        ()
    
    override this.paint(graphics: Graphics) : unit =
        ()
    
    abstract destroy : unit -> unit
    default this.destroy() : unit =
        ()
    
    abstract setPaused : isPaused: bool -> unit
    default this.setPaused(isPaused: bool) : unit =
        raise ((new JRuntimeException()))
    
    override this.pointerDragged(x: int, y: int) : unit =
        ()
    
    override this.pointerPressed(x: int, y: int) : unit =
        ()
    
    override this.pointerReleased(x: int, y: int) : unit =
        ()


