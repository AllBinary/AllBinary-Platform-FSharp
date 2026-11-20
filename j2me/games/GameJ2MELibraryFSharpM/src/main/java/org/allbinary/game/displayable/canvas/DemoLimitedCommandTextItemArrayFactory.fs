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
type DemoLimitedCommandTextItemArrayFactory =
    [<DefaultValue(false)>] val mutable commandTextItemArrayFactory : CommandTextItemArrayFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : DemoLimitedCommandTextItemArrayFactory
    static member instance with get() : DemoLimitedCommandTextItemArrayFactory = (DemoLimitedCommandTextItemArrayFactory.jclinit(); DemoLimitedCommandTextItemArrayFactory.jcell_instance) and set (jvalue: DemoLimitedCommandTextItemArrayFactory) = (DemoLimitedCommandTextItemArrayFactory.jclinit(); DemoLimitedCommandTextItemArrayFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoLimitedCommandTextItemArrayFactory.jclinitDone then
            DemoLimitedCommandTextItemArrayFactory.jclinitDone <- true
            DemoLimitedCommandTextItemArrayFactory.jclinitBody()
    static member private jclinitBody() : unit =
        DemoLimitedCommandTextItemArrayFactory.jcell_instance <- (new DemoLimitedCommandTextItemArrayFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_DemoLimitedCommandTextItemArrayFactory()
    member this.jfields_DemoLimitedCommandTextItemArrayFactory() : unit =
        this.commandTextItemArrayFactory <- (new CommandTextItemArrayFactory((new LimitCommandsVisitor())))
        ()
    
    static member getInstance() : DemoLimitedCommandTextItemArrayFactory =
        DemoLimitedCommandTextItemArrayFactory.instance
    
    abstract getCommandTextItemArrayFactory : unit -> CommandTextItemArrayFactory
    default this.getCommandTextItemArrayFactory() : CommandTextItemArrayFactory =
        this.commandTextItemArrayFactory


