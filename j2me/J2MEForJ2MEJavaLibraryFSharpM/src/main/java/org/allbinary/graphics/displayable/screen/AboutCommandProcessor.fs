namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2022 AllBinary
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
type AboutCommandProcessor =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AboutCommandProcessor
    static member instance with get() : AboutCommandProcessor = (AboutCommandProcessor.jclinit(); AboutCommandProcessor.jcell_instance) and set (jvalue: AboutCommandProcessor) = (AboutCommandProcessor.jclinit(); AboutCommandProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AboutCommandProcessor.jclinitDone then
            AboutCommandProcessor.jclinitDone <- true
            AboutCommandProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        AboutCommandProcessor.jcell_instance <- (new AboutCommandProcessor())
        ()
    new () =
        {  }
    
    static member getInstance() : AboutCommandProcessor =
        AboutCommandProcessor.instance
    
    abstract process_ : midletCommandListener: CommandListener * command: Command * canvas: Canvas -> unit
    default this.process_(midletCommandListener: CommandListener, command: Command, canvas: Canvas) : unit =
        midletCommandListener.commandAction(command, canvas)


