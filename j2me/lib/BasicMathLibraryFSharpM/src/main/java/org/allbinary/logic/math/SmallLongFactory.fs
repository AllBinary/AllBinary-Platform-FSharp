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
type SmallLongFactory =
    [<DefaultValue(false)>] val mutable NEGATIVE_MAX : int
    [<DefaultValue(false)>] val mutable POSITIVE_MAX : int
    [<DefaultValue(false)>] val mutable INTEGER_ARRAY : Long[]
    [<DefaultValue(false)>] val mutable STRING_ARRAY : string[]
    [<DefaultValue(false)>] val mutable MIN : int
    [<DefaultValue(false)>] val mutable lastMin : int
    [<DefaultValue(false)>] val mutable lastNegativeMin : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : SmallLongFactory
    static member instance with get() : SmallLongFactory = (SmallLongFactory.jclinit(); SmallLongFactory.jcell_instance) and set (jvalue: SmallLongFactory) = (SmallLongFactory.jclinit(); SmallLongFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SmallLongFactory.jclinitDone then
            SmallLongFactory.jclinitDone <- true
            SmallLongFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SmallLongFactory.jcell_instance <- (new SmallLongFactory())
        ()
    member this.jfields_SmallLongFactory() : unit =
        this.NEGATIVE_MAX <- 500
        this.POSITIVE_MAX <- 0x2D1
        this.INTEGER_ARRAY <- (Array.zeroCreate<Long> (this.NEGATIVE_MAX + this.POSITIVE_MAX))
        this.STRING_ARRAY <- (Array.zeroCreate<string> (this.NEGATIVE_MAX + this.POSITIVE_MAX))
        this.MIN <- 0
        this.lastMin <- 0
        this.lastNegativeMin <- 0
        ()
    
    static member getInstance() : SmallLongFactory =
        SmallLongFactory.instance
    
    abstract initWithRange : value: int * negativeValue: int -> unit
    default this.initWithRange(value: int, negativeValue: int) : unit =
        let mutable index : int = value - 1
        while index >= this.lastMin do
            this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX] <- (new Long(index))
            index <- index - 1
        let mutable index : int = negativeValue - 1
        while index >= this.lastNegativeMin do
            this.INTEGER_ARRAY.[index] <- (new Long(-(index)))
            index <- index - 1
        if this.lastMin < value then
            this.lastMin <- value
            this.MIN <- value
        if this.lastNegativeMin < negativeValue then
            this.lastNegativeMin <- negativeValue
    
    abstract init : unit -> unit
    default this.init() : unit =
        if (JR.same(this.INTEGER_ARRAY.[0], null)) then
            if (this.lastMin < this.POSITIVE_MAX) || (this.lastNegativeMin < this.NEGATIVE_MAX) then
                let mutable index : int = this.POSITIVE_MAX - 1
                while index >= this.lastMin do
                    this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX] <- (new Long(index))
                    index <- index - 1
                let mutable index : int = this.NEGATIVE_MAX - 1
                while index >= this.lastNegativeMin do
                    this.INTEGER_ARRAY.[index] <- (new Long(-(index)))
                    index <- index - 1
                this.lastMin <- this.POSITIVE_MAX
                this.lastNegativeMin <- this.NEGATIVE_MAX
    
    new () as this =
        {  }
        then
            this.jfields_SmallLongFactory()
    
    abstract getInstanceNoThrow : index: int64 -> Long
    default this.getInstanceNoThrow(index: int64) : Long =
        let mutable jflow = 0
        let mutable jret : Long = Unchecked.defaultof<Long>
        if (index + int64 (this.NEGATIVE_MAX)) > (int64 (this.INTEGER_ARRAY.Length - 1)) then
            jret <- this.INTEGER_ARRAY.[(-1) + this.NEGATIVE_MAX]
            jflow <- 1
        if jflow = 0 then
            jret <- this.INTEGER_ARRAY.[(int (index)) + this.NEGATIVE_MAX]
            jflow <- 1
        jret
    
    abstract getString : index: int -> string
    default this.getString(index: int) : string =
        let mutable i : int = index + this.NEGATIVE_MAX
        if (JR.same(this.STRING_ARRAY.[i], null)) then
            this.STRING_ARRAY.[i] <- this.INTEGER_ARRAY.[i].ToString()
        this.STRING_ARRAY.[i]


