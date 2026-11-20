namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullCommandListener =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COMMAND_LISTENER : NullCommandListener
    static member NULL_COMMAND_LISTENER with get() : NullCommandListener = (NullCommandListener.jclinit(); NullCommandListener.jcell_NULL_COMMAND_LISTENER) and set (jvalue: NullCommandListener) = (NullCommandListener.jclinit(); NullCommandListener.jcell_NULL_COMMAND_LISTENER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullCommandListener.jclinitDone then
            NullCommandListener.jclinitDone <- true
            NullCommandListener.jclinitBody()
    static member private jclinitBody() : unit =
        NullCommandListener.jcell_NULL_COMMAND_LISTENER <- (new NullCommandListener())
        ()
    new () =
        {  }
    
    abstract commandAction : c: Command * d: Displayable -> unit
    default this.commandAction(c: Command, d: Displayable) : unit =
        ()
    interface CommandListener with
        member this.commandAction(jp0: Command, jp1: Displayable) : unit = this.commandAction(jp0, jp1)


