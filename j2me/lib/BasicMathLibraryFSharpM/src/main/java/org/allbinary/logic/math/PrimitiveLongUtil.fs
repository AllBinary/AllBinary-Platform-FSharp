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
type PrimitiveLongUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable powerOfTen : int
    [<DefaultValue(false)>] val mutable maxValue : int
    [<DefaultValue(false)>] val mutable maxDigits : int
    [<DefaultValue(false)>] val mutable charArray : char[]
    [<DefaultValue(false)>] val mutable currentTotalDigits : int
    [<DefaultValue(false)>] val mutable primitiveLongSingleton : PrimitiveLongSingleton
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PrimitiveLongUtil.jclinitDone then
            PrimitiveLongUtil.jclinitDone <- true
            PrimitiveLongUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PrimitiveLongUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.primitiveLongSingleton <- PrimitiveLongSingleton.getInstance()
        ()
    
    static member createPowerOfTen(powerOfTen: int) : PrimitiveLongUtil =
        let mutable primitiveLongUtil : PrimitiveLongUtil = (new PrimitiveLongUtil(powerOfTen, NullUtil.getInstance().NULL_OBJECT))
        if (powerOfTen % 10) <> 0 then
            let mutable logUtil : LogUtil = LogUtil.getInstance()
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            logUtil.put(commonStrings.EXCEPTION, primitiveLongUtil, commonStrings.CONSTRUCTOR, (new JException("Max must be power of 10")))
        primitiveLongUtil
    
    new (powerOfTen: int, unused: obj) as this =
        {  }
        then
            this.jfields_PrimitiveLongUtil()
            this.jctor1(powerOfTen, unused)
    member this.jctor1(powerOfTen: int, unused: obj) : unit =
        this.maxDigits <- MathUtil.getInstance().getTotalDigits(powerOfTen)
        this.powerOfTen <- powerOfTen
        this.maxValue <- (powerOfTen * 10) - 1
        this.charArray <- (Array.zeroCreate<char> (this.maxDigits))
        ()
    
    abstract getCharArray : value: int -> char[]
    default this.getCharArray(value: int) : char[] =
        let mutable jflow = 0
        let mutable jret : char[] = Unchecked.defaultof<char[]>
        if value < 10 then
            this.setCurrentTotalDigits(1)
            jret <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAYS.[value]
            jflow <- 1
        if jflow = 0 then
            if value > this.maxValue then
                this.setCurrentTotalDigits(3)
                jret <- this.primitiveLongSingleton.UNK
                jflow <- 1
            if jflow = 0 then
                let mutable index : int = 0
                let mutable div : int = this.powerOfTen
                let mutable lastValue : int = 0
                while div >= 1 do
                    let mutable digit : int = (value - lastValue) / div
                    if (digit >= 0) && (digit < 10) then
                        if (digit = 0) && (index = 0) then
                            ()
                        else
                            this.charArray.[(let jt = index in index <- index + 1; jt)] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[digit]
                        lastValue <- lastValue + (digit * div)
                    div <- div / 10
                this.setCurrentTotalDigits(index)
                jret <- this.charArray
                jflow <- 1
        jret
    
    member this.setCurrentTotalDigits(currentTotalDigits: int) : unit =
        this.currentTotalDigits <- currentTotalDigits
    
    abstract getCurrentTotalDigits : unit -> int
    default this.getCurrentTotalDigits() : int =
        this.currentTotalDigits
    
    abstract getMaxDigits : unit -> int
    default this.getMaxDigits() : int =
        this.maxDigits


