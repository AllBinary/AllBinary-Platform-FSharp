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
type BasicHudFactory =
    [<DefaultValue(false)>] val mutable DIRECTION_EXCEPTION : string
    [<DefaultValue(false)>] val mutable VERTICAL : int
    [<DefaultValue(false)>] val mutable HORIZONTAL : int
    [<DefaultValue(false)>] val mutable BOTTOMLEFT : int
    [<DefaultValue(false)>] val mutable BOTTOMRIGHT : int
    [<DefaultValue(false)>] val mutable TOPLEFT : int
    [<DefaultValue(false)>] val mutable TOPRIGHT : int
    [<DefaultValue(false)>] val mutable BOTTOMCENTER : int
    [<DefaultValue(false)>] val mutable TOPCENTER : int
    [<DefaultValue(false)>] val mutable ABSOLUTE : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicHudFactory
    static member instance with get() : BasicHudFactory = (BasicHudFactory.jclinit(); BasicHudFactory.jcell_instance) and set (jvalue: BasicHudFactory) = (BasicHudFactory.jclinit(); BasicHudFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicHudFactory.jclinitDone then
            BasicHudFactory.jclinitDone <- true
            BasicHudFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicHudFactory.jcell_instance <- (new BasicHudFactory())
        ()
    member this.jfields_BasicHudFactory() : unit =
        this.DIRECTION_EXCEPTION <- "Only Horizontal Direction is Allowed Currently"
        this.VERTICAL <- 0
        this.HORIZONTAL <- 1
        this.BOTTOMLEFT <- 0
        this.BOTTOMRIGHT <- 1
        this.TOPLEFT <- 2
        this.TOPRIGHT <- 3
        this.BOTTOMCENTER <- 4
        this.TOPCENTER <- 5
        this.ABSOLUTE <- 6
        ()
    
    static member getInstance() : BasicHudFactory =
        BasicHudFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_BasicHudFactory()


