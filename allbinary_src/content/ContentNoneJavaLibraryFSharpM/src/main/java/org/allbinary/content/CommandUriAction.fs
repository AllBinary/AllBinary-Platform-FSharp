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
type CommandUriAction =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommandUriAction
    static member instance with get() : CommandUriAction = (CommandUriAction.jclinit(); CommandUriAction.jcell_instance) and set (jvalue: CommandUriAction) = (CommandUriAction.jclinit(); CommandUriAction.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandUriAction.jclinitDone then
            CommandUriAction.jclinitDone <- true
            CommandUriAction.jclinitBody()
    static member private jclinitBody() : unit =
        CommandUriAction.jcell_instance <- (new CommandUriAction())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommandUriAction()
    member this.jfields_CommandUriAction() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : CommandUriAction =
        CommandUriAction.instance
    
    abstract add : command: Command * url: string -> unit
    default this.add(command: Command, url: string) : unit =
        ()
    
    abstract process_ : command: Command -> unit
    default this.process_(command: Command) : unit =
        ()


