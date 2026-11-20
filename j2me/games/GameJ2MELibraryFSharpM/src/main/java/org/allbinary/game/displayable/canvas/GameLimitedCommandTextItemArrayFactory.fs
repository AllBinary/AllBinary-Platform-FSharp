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
type GameLimitedCommandTextItemArrayFactory =
    [<DefaultValue(false)>] val mutable commandTextItemArrayFactory : CommandTextItemArrayFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameLimitedCommandTextItemArrayFactory
    static member instance with get() : GameLimitedCommandTextItemArrayFactory = (GameLimitedCommandTextItemArrayFactory.jclinit(); GameLimitedCommandTextItemArrayFactory.jcell_instance) and set (jvalue: GameLimitedCommandTextItemArrayFactory) = (GameLimitedCommandTextItemArrayFactory.jclinit(); GameLimitedCommandTextItemArrayFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameLimitedCommandTextItemArrayFactory.jclinitDone then
            GameLimitedCommandTextItemArrayFactory.jclinitDone <- true
            GameLimitedCommandTextItemArrayFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameLimitedCommandTextItemArrayFactory.jcell_instance <- (new GameLimitedCommandTextItemArrayFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameLimitedCommandTextItemArrayFactory()
    member this.jfields_GameLimitedCommandTextItemArrayFactory() : unit =
        this.commandTextItemArrayFactory <- (new CommandTextItemArrayFactory((new LimitCommandsVisitor())))
        ()
    
    static member getInstance() : GameLimitedCommandTextItemArrayFactory =
        GameLimitedCommandTextItemArrayFactory.instance
    
    abstract getCommandTextItemArrayFactory : unit -> CommandTextItemArrayFactory
    default this.getCommandTextItemArrayFactory() : CommandTextItemArrayFactory =
        this.commandTextItemArrayFactory


