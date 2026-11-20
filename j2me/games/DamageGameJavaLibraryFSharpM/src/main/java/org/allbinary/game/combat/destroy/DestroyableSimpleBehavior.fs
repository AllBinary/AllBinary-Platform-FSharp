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
type DestroyableSimpleBehavior =
    inherit DestroyableBaseBehavior
    [<DefaultValue(false)>] val mutable ownerLayer : CollidableCompositeLayer
    [<DefaultValue(false)>] val mutable destroyed : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyableSimpleBehavior.jclinitDone then
            DestroyableSimpleBehavior.jclinitDone <- true
            DestroyableSimpleBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DestroyableSimpleBehavior() : unit =
        this.destroyed <- false
        ()
    
    new (ownerLayer: CollidableCompositeLayer) as this =
        { inherit DestroyableBaseBehavior() }
        then
            this.jfields_DestroyableSimpleBehavior()
            this.jctor1(ownerLayer)
    member this.jctor1(ownerLayer: CollidableCompositeLayer) : unit =
        this.ownerLayer <- ownerLayer
        ()
    
    override this.isDestroyed() : bool =
        this.destroyed
    
    override this.setDestroyed(destroyed: bool) : unit =
        this.destroyed <- destroyed
        if this.isDestroyed() then
            ignore (DestroyedLayerProcessor.getInstance().add(this.ownerLayer))


