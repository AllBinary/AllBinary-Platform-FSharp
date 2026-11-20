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
type ShakeEventFactory =
    [<DefaultValue(false)>] val mutable MICRO : ShakeEvent
    [<DefaultValue(false)>] val mutable SMALL : ShakeEvent
    [<DefaultValue(false)>] val mutable MEDIUM : ShakeEvent
    [<DefaultValue(false)>] val mutable LARGE : ShakeEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : ShakeEventFactory
    static member instance with get() : ShakeEventFactory = (ShakeEventFactory.jclinit(); ShakeEventFactory.jcell_instance) and set (jvalue: ShakeEventFactory) = (ShakeEventFactory.jclinit(); ShakeEventFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShakeEventFactory.jclinitDone then
            ShakeEventFactory.jclinitDone <- true
            ShakeEventFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ShakeEventFactory.jcell_instance <- (new ShakeEventFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ShakeEventFactory()
    member this.jfields_ShakeEventFactory() : unit =
        this.MICRO <- (new ShakeEvent())
        this.SMALL <- (new ShakeEvent())
        this.MEDIUM <- (new ShakeEvent())
        this.LARGE <- (new ShakeEvent())
        ()
    
    static member getInstance() : ShakeEventFactory =
        ShakeEventFactory.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()


