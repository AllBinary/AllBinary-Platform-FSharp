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
type CollidableAlwaysPickupNeverCollideBehaviorFactory =
    inherit CollidableBaseBehaviorFactory
    [<DefaultValue(false)>] val mutable instance : CollidableAlwaysPickupNeverCollideBehavior
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : CollidableAlwaysPickupNeverCollideBehaviorFactory
    static member instanceC with get() : CollidableAlwaysPickupNeverCollideBehaviorFactory = (CollidableAlwaysPickupNeverCollideBehaviorFactory.jclinit(); CollidableAlwaysPickupNeverCollideBehaviorFactory.jcell_instanceC) and set (jvalue: CollidableAlwaysPickupNeverCollideBehaviorFactory) = (CollidableAlwaysPickupNeverCollideBehaviorFactory.jclinit(); CollidableAlwaysPickupNeverCollideBehaviorFactory.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableAlwaysPickupNeverCollideBehaviorFactory.jclinitDone then
            CollidableAlwaysPickupNeverCollideBehaviorFactory.jclinitDone <- true
            CollidableAlwaysPickupNeverCollideBehaviorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CollidableAlwaysPickupNeverCollideBehaviorFactory.jcell_instanceC <- (new CollidableAlwaysPickupNeverCollideBehaviorFactory())
        ()
    new () as this =
        { inherit CollidableBaseBehaviorFactory() }
        then
            this.jfields_CollidableAlwaysPickupNeverCollideBehaviorFactory()
    member this.jfields_CollidableAlwaysPickupNeverCollideBehaviorFactory() : unit =
        this.instance <- (new CollidableAlwaysPickupNeverCollideBehavior())
        ()
    
    static member getInstance() : CollidableAlwaysPickupNeverCollideBehaviorFactory =
        CollidableAlwaysPickupNeverCollideBehaviorFactory.instanceC
    
    override this.createBehavior() : CollidableBaseBehavior =
        this.instance


