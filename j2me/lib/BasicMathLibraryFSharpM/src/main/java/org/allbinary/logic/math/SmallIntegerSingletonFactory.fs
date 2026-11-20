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
type SmallIntegerSingletonFactory =
    [<DefaultValue(false)>] val mutable NEGATIVE_MAX : int
    [<DefaultValue(false)>] val mutable POSITIVE_MAX : int
    [<DefaultValue(false)>] val mutable INTEGER_ARRAY : Integer[]
    [<DefaultValue(false)>] val mutable STRING_ARRAY : string[]
    [<DefaultValue(false)>] val mutable MIN : int
    [<DefaultValue(false)>] val mutable lastMin : int
    [<DefaultValue(false)>] val mutable lastNegativeMin : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : SmallIntegerSingletonFactory
    static member instance with get() : SmallIntegerSingletonFactory = (SmallIntegerSingletonFactory.jclinit(); SmallIntegerSingletonFactory.jcell_instance) and set (jvalue: SmallIntegerSingletonFactory) = (SmallIntegerSingletonFactory.jclinit(); SmallIntegerSingletonFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SmallIntegerSingletonFactory.jclinitDone then
            SmallIntegerSingletonFactory.jclinitDone <- true
            SmallIntegerSingletonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SmallIntegerSingletonFactory.jcell_instance <- (new SmallIntegerSingletonFactory())
        ()
    member this.jfields_SmallIntegerSingletonFactory() : unit =
        this.NEGATIVE_MAX <- 500
        this.POSITIVE_MAX <- 0x2D1
        this.INTEGER_ARRAY <- (Array.zeroCreate<Integer> (this.NEGATIVE_MAX + this.POSITIVE_MAX))
        this.STRING_ARRAY <- (Array.zeroCreate<string> (this.NEGATIVE_MAX + this.POSITIVE_MAX))
        this.MIN <- 0
        this.lastMin <- 0
        this.lastNegativeMin <- 0
        ()
    
    static member getInstance() : SmallIntegerSingletonFactory =
        SmallIntegerSingletonFactory.instance
    
    abstract getMin : unit -> int
    default this.getMin() : int =
        let mutable minAllowed : int = this.getMinAllowed()
        if this.MIN <= minAllowed then
            if J2MEUtil.isJ2ME() then
                ()
            elif AndroidUtil.isAndroid() then
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                logUtil.putF((new StringMaker()).append("Android InputFactory was initialized before GameMidlet: ").appendint(this.MIN).ToString(), this, "getMin")
                this.initWithRange(0x291, 6)
            else
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                logUtil.putF((new StringMaker()).append("InputFactory was initialized before GameMidlet or KeyFactoryInitializer - Currently this is occurs on JS build by TouchMotionGestureFactory constructor: ").appendint(this.MIN).ToString(), this, "getMin")
                this.initWithRange(0x2D0, 6)
        if this.MIN <= minAllowed then
            let mutable logUtil : LogUtil = LogUtil.getInstance()
            logUtil.put("This means you loaded the InputFactory before determining the platform input size requirements.", this, "getMin", (new JException()))
        this.MIN
    
    member this.getMinAllowed() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if J2MEUtil.isJ2ME() then
            jret <- 0
            jflow <- 1
        else
            if AndroidUtil.isAndroid() then
                jret <- 0x101
                jflow <- 1
            else
                jret <- 23
                jflow <- 1
        jret
    
    abstract initWithRange : value: int * negativeValue: int -> unit
    default this.initWithRange(value: int, negativeValue: int) : unit =
        let mutable index : int = value - 1
        while index >= this.lastMin do
            this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX] <- (new Integer(index))
            index <- index - 1
        let mutable index : int = negativeValue - 1
        while index >= this.lastNegativeMin do
            this.INTEGER_ARRAY.[index] <- (new Integer(-(index)))
            index <- index - 1
        if this.lastMin < value then
            this.lastMin <- value
            this.MIN <- value
        if this.lastNegativeMin < negativeValue then
            this.lastNegativeMin <- negativeValue
    
    abstract init : unit -> unit
    default this.init() : unit =
        if (this.lastMin < this.POSITIVE_MAX) || (this.lastNegativeMin < this.NEGATIVE_MAX) then
            let mutable index : int = this.POSITIVE_MAX - 1
            while index >= this.lastMin do
                this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX] <- (new Integer(index))
                index <- index - 1
            let mutable index : int = this.NEGATIVE_MAX - 1
            while index >= this.lastNegativeMin do
                this.INTEGER_ARRAY.[index] <- (new Integer(-(index)))
                index <- index - 1
            this.lastMin <- this.POSITIVE_MAX
            this.MIN <- this.lastMin
            this.lastNegativeMin <- this.NEGATIVE_MAX
    
    new () as this =
        {  }
        then
            this.jfields_SmallIntegerSingletonFactory()
            this.jctor1()
    member this.jctor1() : unit =
        this.initWithRange(23, 0)
        ()
    
    abstract getAt : index: int -> Integer
    default this.getAt(index: int) : Integer =
        this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX]
    
    abstract getAtNoThrow : index: int -> Integer
    default this.getAtNoThrow(index: int) : Integer =
        let mutable jflow = 0
        let mutable jret : Integer = Unchecked.defaultof<Integer>
        if (index + this.NEGATIVE_MAX) > (this.INTEGER_ARRAY.Length - 1) then
            jret <- this.INTEGER_ARRAY.[(-1) + this.NEGATIVE_MAX]
            jflow <- 1
        if jflow = 0 then
            jret <- this.INTEGER_ARRAY.[index + this.NEGATIVE_MAX]
            jflow <- 1
        jret
    
    abstract createInstance : index: int -> Integer
    default this.createInstance(index: int) : Integer =
        let mutable integer : Integer = this.getAt(index)
        if (JR.same(integer, null)) then
            integer <- (new Integer(index))
        integer
    
    abstract getString : index: int -> string
    default this.getString(index: int) : string =
        let mutable i : int = index + this.NEGATIVE_MAX
        if (JR.same(this.STRING_ARRAY.[i], null)) then
            this.STRING_ARRAY.[i] <- this.INTEGER_ARRAY.[i].ToString()
        this.STRING_ARRAY.[i]


