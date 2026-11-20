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
type DemoGameMidletStateFactory =
    [<DefaultValue(false)>] val mutable NONE : DemoGameMidletState
    [<DefaultValue(false)>] val mutable START_DEMO : DemoGameMidletState
    [<DefaultValue(false)>] val mutable START_GAME : DemoGameMidletState
    [<DefaultValue(false)>] val mutable START_INPUT_MAPPING : DemoGameMidletState
    [<DefaultValue(false)>] static val mutable private jcell_STATE : DemoGameMidletStateFactory
    static member STATE with get() : DemoGameMidletStateFactory = (DemoGameMidletStateFactory.jclinit(); DemoGameMidletStateFactory.jcell_STATE) and set (jvalue: DemoGameMidletStateFactory) = (DemoGameMidletStateFactory.jclinit(); DemoGameMidletStateFactory.jcell_STATE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameMidletStateFactory.jclinitDone then
            DemoGameMidletStateFactory.jclinitDone <- true
            DemoGameMidletStateFactory.jclinitBody()
    static member private jclinitBody() : unit =
        DemoGameMidletStateFactory.jcell_STATE <- (new DemoGameMidletStateFactory())
        ()
    member this.jfields_DemoGameMidletStateFactory() : unit =
        this.NONE <- (new DemoGameMidletState())
        this.START_DEMO <- (new DemoGameMidletState())
        this.START_GAME <- (new DemoGameMidletState())
        this.START_INPUT_MAPPING <- (new DemoGameMidletState())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_DemoGameMidletStateFactory()
    
    static member getInstance() : DemoGameMidletStateFactory =
        DemoGameMidletStateFactory.STATE


