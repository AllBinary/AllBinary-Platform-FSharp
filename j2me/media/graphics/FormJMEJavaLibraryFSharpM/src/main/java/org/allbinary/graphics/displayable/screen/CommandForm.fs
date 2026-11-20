namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2002 AllBinary 
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
type CommandForm =
    inherit Form
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable repaintProcessor : Processor
    [<DefaultValue(false)>] val mutable commandStack : ABStack
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COMMAND_FORM : obj
    static member NULL_COMMAND_FORM with get() : obj = (CommandForm.jclinit(); CommandForm.jcell_NULL_COMMAND_FORM) and set (jvalue: obj) = (CommandForm.jclinit(); CommandForm.jcell_NULL_COMMAND_FORM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandForm.jclinitDone then
            CommandForm.jclinitDone <- true
            CommandForm.jclinitBody()
    static member private jclinitBody() : unit =
        CommandForm.jcell_NULL_COMMAND_FORM <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_CommandForm() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.repaintProcessor <- ScreenRepaintProcessorFactory.getInstance().create(this)
        ()
    
    static member getNullCommandForm() : CommandForm =
        if (JR.same(CommandForm.NULL_COMMAND_FORM, NullUtil.getInstance().NULL_OBJECT)) then
            CommandForm.NULL_COMMAND_FORM <- (new CommandForm(NullCommandListener.NULL_COMMAND_LISTENER, StringUtil.getInstance().EMPTY_STRING, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        (box (CommandForm.NULL_COMMAND_FORM) :?> CommandForm)
    
    new (commandListener: CommandListener, formTitle: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit Form(formTitle) }
        then
            this.jfields_CommandForm()
            this.jctor1(commandListener, formTitle, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, formTitle: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.commandStack <- StdUtil.getInstance().createStack()
        try
            this.repaintProcessor.process_()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    abstract initCommands : cmdListener: CommandListener -> unit
    default this.initCommands(cmdListener: CommandListener) : unit =
        ()
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        this.logUtil.putF(this.commonStrings.START, this, "open")
    
    abstract close : unit -> unit
    default this.close() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CLOSE)
    
    abstract update : unit -> unit
    default this.update() : unit =
        this.repaintProcessor.process_()
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        0
    
    override this.addCommand(command: Command) : unit =
        ignore (this.commandStack.push(command))
        base.addCommand(command)
    
    abstract removeAllCommands : unit -> unit
    default this.removeAllCommands() : unit =
        let mutable size : int = this.commandStack.size()
        let mutable index : int = 0
        while index < size do
            base.removeCommand((box (this.commandStack.pop()) :?> Command))
            index <- index + 1
    interface MyCommandInterface with
        member this.addCommand(jp0: Command) : unit = this.addCommand(jp0)
        member this.removeAllCommands() : unit = this.removeAllCommands()
    interface MenuListener with
        member this.open_() : unit = this.open_()
        member this.close() : unit = this.close()
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()


