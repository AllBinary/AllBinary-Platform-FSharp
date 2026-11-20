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
type CircularIndexUtil =
    [<DefaultValue(false)>] val mutable index : int
    [<DefaultValue(false)>] val mutable lastIndex : int
    [<DefaultValue(false)>] val mutable size : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CIRCULAR_INDEX_UTIL : CircularIndexUtil
    static member NULL_CIRCULAR_INDEX_UTIL with get() : CircularIndexUtil = (CircularIndexUtil.jclinit(); CircularIndexUtil.jcell_NULL_CIRCULAR_INDEX_UTIL) and set (jvalue: CircularIndexUtil) = (CircularIndexUtil.jclinit(); CircularIndexUtil.jcell_NULL_CIRCULAR_INDEX_UTIL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CircularIndexUtil.jclinitDone then
            CircularIndexUtil.jclinitDone <- true
            CircularIndexUtil.jclinitBody()
    static member private jclinitBody() : unit =
        CircularIndexUtil.jcell_NULL_CIRCULAR_INDEX_UTIL <- (new CircularIndexUtil(0, 0))
        ()
    member this.jfields_CircularIndexUtil() : unit =
        this.index <- 0
        this.lastIndex <- 0
        this.size <- 0
        ()
    
    new (index: int, size: int) as this =
        {  }
        then
            this.jfields_CircularIndexUtil()
            this.jctor1(index, size)
    member this.jctor1(index: int, size: int) : unit =
        this.setSize(size)
        this.setIndex(index)
        ()
    
    abstract next : unit -> int
    default this.next() : int =
        if this.index >= this.lastIndex then
            this.index <- 0
        else
            this.index <- this.index + 1
        this.index
    
    abstract previous : unit -> int
    default this.previous() : int =
        if this.index < 1 then
            this.index <- this.lastIndex
        else
            this.index <- this.index - 1
        this.index
    
    abstract setIndex : index: int -> unit
    default this.setIndex(index: int) : unit =
        let mutable jflow = 0
        if index > this.lastIndex then
            jflow <- 1
        if jflow = 0 then
            this.index <- index
    
    abstract getIndex : unit -> int
    default this.getIndex() : int =
        this.index
    
    static member createInstance(max_: int) : CircularIndexUtil =
        (new CircularIndexUtil(0, max_))
    
    static member createInstanceAt(index: int, max_: int) : CircularIndexUtil =
        (new CircularIndexUtil(index, max_))
    
    abstract setSize : size: int -> unit
    default this.setSize(size: int) : unit =
        this.size <- size
        this.lastIndex <- size - 1
        this.index <- 0
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        this.size
    
    override this.ToString() : string =
        (new StringMaker()).append(CommonLabels.getInstance().INDEX_LABEL).appendint(this.index).append("lastIndex: ").appendint(this.lastIndex).append("size: ").appendint(this.size).ToString()


