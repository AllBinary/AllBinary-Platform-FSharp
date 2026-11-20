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
type CollidableHelperFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableHelperFactory.jclinitDone then
            CollidableHelperFactory.jclinitDone <- true
            CollidableHelperFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstance() : CollisionHelper =
        let mutable jflow = 0
        let mutable jret : CollisionHelper = Unchecked.defaultof<CollisionHelper>
        if Features.getInstance().isFeature(GameFeatureFactory.getInstance().COLLISIONS_WITH_SOURCE) then
            jret <- (new CollisionHelper(AllBinaryLayer.NULL_ALLBINARY_LAYER))
            jflow <- 1
        else
            jret <- (new SourceCollisionHelper(AllBinaryLayer.NULL_ALLBINARY_LAYER))
            jflow <- 1
        jret


