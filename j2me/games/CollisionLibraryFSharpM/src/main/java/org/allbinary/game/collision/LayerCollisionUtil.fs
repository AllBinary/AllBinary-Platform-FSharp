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
type LayerCollisionUtil =
    [<DefaultValue(false)>] val mutable collisionProcessor : CollisionProcessor
    [<DefaultValue(false)>] static val mutable private jcell_instance : LayerCollisionUtil
    static member instance with get() : LayerCollisionUtil = (LayerCollisionUtil.jclinit(); LayerCollisionUtil.jcell_instance) and set (jvalue: LayerCollisionUtil) = (LayerCollisionUtil.jclinit(); LayerCollisionUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerCollisionUtil.jclinitDone then
            LayerCollisionUtil.jclinitDone <- true
            LayerCollisionUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LayerCollisionUtil.jcell_instance <- (new LayerCollisionUtil())
        ()
    
    static member getInstance() : LayerCollisionUtil =
        LayerCollisionUtil.instance
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable features : Features = Features.getInstance()
        let mutable gameFeatureFactory : GameFeatureFactory = GameFeatureFactory.getInstance()
        if OpenGLFeatureUtil.getInstance().isAnyThreed() && (not (features.isFeature(gameFeatureFactory.COLLISIONS_FORCED_TWO_DIMENSIONAL))) then
            this.collisionProcessor <- (new CollisionThreedProcessor())
        else
            this.collisionProcessor <- (new Collision2DProcessor())
        ()
    
    abstract isCollision : myLayer: AllBinaryLayer * myLayer2: AllBinaryLayer -> bool
    default this.isCollision(myLayer: AllBinaryLayer, myLayer2: AllBinaryLayer) : bool =
        this.collisionProcessor.isCollision(myLayer, myLayer2)


