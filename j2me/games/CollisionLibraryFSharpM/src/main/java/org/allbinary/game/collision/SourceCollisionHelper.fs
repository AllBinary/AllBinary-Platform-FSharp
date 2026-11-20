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
type SourceCollisionHelper =
    inherit CollisionHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SourceCollisionHelper.jclinitDone then
            SourceCollisionHelper.jclinitDone <- true
            SourceCollisionHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (layerInterface: AllBinaryLayer) =
        { inherit CollisionHelper(layerInterface) }
    
    override this.isCollidable(layerInterface: CollidableCompositeLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if not (JR.same(this.sourceLayerInterface, layerInterface)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret


