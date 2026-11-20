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
type CollisionTypeFactory =
    [<DefaultValue(false)>] val mutable NONE : CollisionType
    [<DefaultValue(false)>] val mutable DAMAGE : CollisionType
    [<DefaultValue(false)>] val mutable PICKUP : CollisionType
    [<DefaultValue(false)>] val mutable COLLISION : CollisionType
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : CollisionTypeFactory
    static member SINGLETON with get() : CollisionTypeFactory = (CollisionTypeFactory.jclinit(); CollisionTypeFactory.jcell_SINGLETON) and set (jvalue: CollisionTypeFactory) = (CollisionTypeFactory.jclinit(); CollisionTypeFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollisionTypeFactory.jclinitDone then
            CollisionTypeFactory.jclinitDone <- true
            CollisionTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CollisionTypeFactory.jcell_SINGLETON <- (new CollisionTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_CollisionTypeFactory()
    member this.jfields_CollisionTypeFactory() : unit =
        this.NONE <- (new CollisionType("None"))
        this.DAMAGE <- (new CollisionType("Damage"))
        this.PICKUP <- (new CollisionType("Pickup"))
        this.COLLISION <- (new CollisionType("Collision"))
        ()
    
    static member getInstance() : CollisionTypeFactory =
        CollisionTypeFactory.SINGLETON


