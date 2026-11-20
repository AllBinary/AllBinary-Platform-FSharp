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
type AllBinaryLayerCircularPool =
    inherit BaseCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryLayerCircularPool.jclinitDone then
            AllBinaryLayerCircularPool.jclinitDone <- true
            AllBinaryLayerCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit BaseCircularPool() }
    
    abstract initAllBinaryLayerCircularPool : allbinaryLayerFactoryInterface: AllBinaryLayerFactoryInterface * total: int -> unit
    default this.initAllBinaryLayerCircularPool(allbinaryLayerFactoryInterface: AllBinaryLayerFactoryInterface, total: int) : unit =
        this.circularIndexUtil <- CircularIndexUtil.createInstance(total)
        this.OBJECT_ARRAY <- (Array.zeroCreate<obj> (total))
        let mutable localIndex : int = 0
        while localIndex < total do
            this.OBJECT_ARRAY.[localIndex] <- allbinaryLayerFactoryInterface.getInstance()
            localIndex <- localIndex + 1


