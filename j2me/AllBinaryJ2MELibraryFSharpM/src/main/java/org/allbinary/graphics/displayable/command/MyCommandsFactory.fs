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
type MyCommandsFactory =
    [<DefaultValue(false)>] val mutable NO_COMMAND : Command
    [<DefaultValue(false)>] val mutable GAUGE_CHANGE : Command
    [<DefaultValue(false)>] val mutable SET_DISPLAYABLE : Command
    [<DefaultValue(false)>] val mutable PAUSE_COMMAND : Command
    [<DefaultValue(false)>] val mutable RESUME_COMMAND : Command
    [<DefaultValue(false)>] static val mutable private jcell_instance : MyCommandsFactory
    static member instance with get() : MyCommandsFactory = (MyCommandsFactory.jclinit(); MyCommandsFactory.jcell_instance) and set (jvalue: MyCommandsFactory) = (MyCommandsFactory.jclinit(); MyCommandsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MyCommandsFactory.jclinitDone then
            MyCommandsFactory.jclinitDone <- true
            MyCommandsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MyCommandsFactory.jcell_instance <- (new MyCommandsFactory())
        ()
    member this.jfields_MyCommandsFactory() : unit =
        this.NO_COMMAND <- (new Command(StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING, -1, -1))
        this.GAUGE_CHANGE <- (new Command("GAUGE_CHANGE", StringUtil.getInstance().EMPTY_STRING, Command.ITEM, 1))
        this.SET_DISPLAYABLE <- (new Command("Display", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 2))
        this.PAUSE_COMMAND <- (new Command("Pause", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 0))
        this.RESUME_COMMAND <- (new Command("Resume", StringUtil.getInstance().EMPTY_STRING, Command.SCREEN, 0))
        ()
    
    static member getInstance() : MyCommandsFactory =
        MyCommandsFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_MyCommandsFactory()


