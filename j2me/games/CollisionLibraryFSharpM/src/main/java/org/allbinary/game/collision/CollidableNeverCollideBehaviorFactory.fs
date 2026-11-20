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
type CollidableNeverCollideBehaviorFactory =
    inherit CollidableBaseBehaviorFactory
    [<DefaultValue(false)>] val mutable instance : CollidableNeverCollideBehavior
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : CollidableNeverCollideBehaviorFactory
    static member instanceC with get() : CollidableNeverCollideBehaviorFactory = (CollidableNeverCollideBehaviorFactory.jclinit(); CollidableNeverCollideBehaviorFactory.jcell_instanceC) and set (jvalue: CollidableNeverCollideBehaviorFactory) = (CollidableNeverCollideBehaviorFactory.jclinit(); CollidableNeverCollideBehaviorFactory.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableNeverCollideBehaviorFactory.jclinitDone then
            CollidableNeverCollideBehaviorFactory.jclinitDone <- true
            CollidableNeverCollideBehaviorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CollidableNeverCollideBehaviorFactory.jcell_instanceC <- (new CollidableNeverCollideBehaviorFactory())
        ()
    new () as this =
        { inherit CollidableBaseBehaviorFactory() }
        then
            this.jfields_CollidableNeverCollideBehaviorFactory()
    member this.jfields_CollidableNeverCollideBehaviorFactory() : unit =
        this.instance <- (new CollidableNeverCollideBehavior(false))
        ()
    
    static member getInstance() : CollidableNeverCollideBehaviorFactory =
        CollidableNeverCollideBehaviorFactory.instanceC
    
    override this.createBehavior() : CollidableBaseBehavior =
        this.instance


