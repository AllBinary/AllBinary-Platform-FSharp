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
type GPointCircularPool =
    inherit BaseCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GPointCircularPool.jclinitDone then
            GPointCircularPool.jclinitDone <- true
            GPointCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (size: int) as this =
        { inherit BaseCircularPool() }
        then
            this.jctor1(size)
    member this.jctor1(size: int) : unit =
        this.circularIndexUtil <- CircularIndexUtil.createInstance(size)
        this.OBJECT_ARRAY <- (Array.zeroCreate<obj> (size))
        let mutable index : int = size - 1
        while index >= 0 do
            this.OBJECT_ARRAY.[index] <- CustomGPoint.getInstance3(0, 0)
            index <- index - 1
        ()


