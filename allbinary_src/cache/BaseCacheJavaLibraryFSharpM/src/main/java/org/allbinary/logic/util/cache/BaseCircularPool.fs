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
type BaseCircularPool =
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable OBJECT_ARRAY : obj[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseCircularPool.jclinitDone then
            BaseCircularPool.jclinitDone <- true
            BaseCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_BaseCircularPool()
    member this.jfields_BaseCircularPool() : unit =
        this.circularIndexUtil <- CircularIndexUtil.NULL_CIRCULAR_INDEX_UTIL
        this.OBJECT_ARRAY <- NullUtil.getInstance().NULL_OBJECT_ARRAY
        ()
    
    abstract getNextInstance : unit -> obj
    default this.getNextInstance() : obj =
        let mutable anyType : obj = this.OBJECT_ARRAY.[this.circularIndexUtil.getIndex()]
        ignore (this.circularIndexUtil.next())
        anyType
    
    abstract init : allBinaryObjectFactoryInterface: AllBinaryObjectFactoryInterface -> unit
    default this.init(allBinaryObjectFactoryInterface: AllBinaryObjectFactoryInterface) : unit =
        this.circularIndexUtil.setIndex(0)
        let mutable size : int = this.circularIndexUtil.getSize()
        let mutable index : int = 0
        while index < size do
            this.OBJECT_ARRAY.[index] <- allBinaryObjectFactoryInterface.getInstance()
            index <- index + 1
    
    abstract getInstance : index: int -> obj
    default this.getInstance(index: int) : obj =
        this.OBJECT_ARRAY.[index]


