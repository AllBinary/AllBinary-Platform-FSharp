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
type CommandRunnable =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable commandFormInputProcessor : CommandFormInputProcessor
    [<DefaultValue(false)>] val mutable command : Command
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandRunnable.jclinitDone then
            CommandRunnable.jclinitDone <- true
            CommandRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CommandRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (commandFormInputProcessor: CommandFormInputProcessor, command: Command) as this =
        {  }
        then
            this.jfields_CommandRunnable()
            this.jctor1(commandFormInputProcessor, command)
    member this.jctor1(commandFormInputProcessor: CommandFormInputProcessor, command: Command) : unit =
        this.commandFormInputProcessor <- commandFormInputProcessor
        this.command <- command
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        try
            this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
            let mutable canvas : MyCanvas = this.commandFormInputProcessor.getCanvas()
            let mutable commandListener : CommandListener = canvas.getCustomCommandListener()
            commandListener.commandAction(this.command, canvas)
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
    interface Runnable with
        member this.run() : unit = this.run()


