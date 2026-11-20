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
type GenericTrackingLayerCircularStaticPool =
    inherit AllBinaryLayerCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : GenericTrackingLayerCircularStaticPool
    static member SINGLETON with get() : GenericTrackingLayerCircularStaticPool = (GenericTrackingLayerCircularStaticPool.jclinit(); GenericTrackingLayerCircularStaticPool.jcell_SINGLETON) and set (jvalue: GenericTrackingLayerCircularStaticPool) = (GenericTrackingLayerCircularStaticPool.jclinit(); GenericTrackingLayerCircularStaticPool.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GenericTrackingLayerCircularStaticPool.jclinitDone then
            GenericTrackingLayerCircularStaticPool.jclinitDone <- true
            GenericTrackingLayerCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        GenericTrackingLayerCircularStaticPool.jcell_SINGLETON <- (new GenericTrackingLayerCircularStaticPool())
        ()
    
    new () =
        { inherit AllBinaryLayerCircularPool() }
    
    static member getInstance() : GenericTrackingLayerCircularStaticPool =
        GenericTrackingLayerCircularStaticPool.SINGLETON


