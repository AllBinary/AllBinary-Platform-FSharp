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
type AllBinaryEventCircularPool =
    inherit BaseCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryEventCircularPool.jclinitDone then
            AllBinaryEventCircularPool.jclinitDone <- true
            AllBinaryEventCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (max_: int) as this =
        { inherit BaseCircularPool() }
        then
            this.jctor1(max_)
    member this.jctor1(max_: int) : unit =
        this.OBJECT_ARRAY <- (Array.zeroCreate<obj> (max_))
        this.circularIndexUtil <- CircularIndexUtil.createInstance(max_)
        ()
    
    abstract initAllBinaryEventCircularPool : allBinaryEventObjectFactoryInterface: AllBinaryEventObjectFactoryInterface -> unit
    default this.initAllBinaryEventCircularPool(allBinaryEventObjectFactoryInterface: AllBinaryEventObjectFactoryInterface) : unit =
        this.circularIndexUtil.setIndex(0)
        let mutable size : int = this.circularIndexUtil.getSize()
        let mutable index : int = 0
        while index < size do
            this.OBJECT_ARRAY.[index] <- allBinaryEventObjectFactoryInterface.getInstance()
            index <- index + 1


