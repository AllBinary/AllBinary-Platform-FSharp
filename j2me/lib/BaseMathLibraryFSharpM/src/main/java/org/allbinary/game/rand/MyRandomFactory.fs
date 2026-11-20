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
type MyRandomFactory =
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] val mutable rand : Random
    [<DefaultValue(false)>] static val mutable private jcell_instance : MyRandomFactory
    static member instance with get() : MyRandomFactory = (MyRandomFactory.jclinit(); MyRandomFactory.jcell_instance) and set (jvalue: MyRandomFactory) = (MyRandomFactory.jclinit(); MyRandomFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MyRandomFactory.jclinitDone then
            MyRandomFactory.jclinitDone <- true
            MyRandomFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MyRandomFactory.jcell_instance <- (new MyRandomFactory())
        ()
    member this.jfields_MyRandomFactory() : unit =
        this.mathUtil <- MathUtil.getInstance()
        ()
    
    static member getInstance() : MyRandomFactory =
        MyRandomFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_MyRandomFactory()
            this.jctor1()
    member this.jctor1() : unit =
        this.rand <- (new Random(JSystem.currentTimeMillis()))
        ()
    
    abstract setSeed : seed: int64 -> unit
    default this.setSeed(seed: int64) : unit =
        this.rand <- (new Random(seed))
    
    abstract getNextInt : range: int -> int
    default this.getNextInt(range: int) : int =
        let mutable div : int = (Integer.MAX_VALUE / range) + 1
        (this.rand.nextInt() / div)
    
    abstract getAbsoluteNextInt : range: int -> int
    default this.getAbsoluteNextInt(range: int) : int =
        this.mathUtil.abs(this.getNextInt(range))
    
    abstract getAbsoluteNextIntAllowZero : range: int -> int
    default this.getAbsoluteNextIntAllowZero(range: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if range = 0 then
            jret <- 0
            jflow <- 1
        else
            jret <- this.mathUtil.abs(this.getNextInt(range))
            jflow <- 1
        jret
    
    abstract shuffle : intArray: int[] -> unit
    default this.shuffle(intArray: int[]) : unit =
        this.shuffleTotal(intArray, (intArray.Length * 7))
    
    abstract shuffleTotal : intArray: int[] * shuffleTotal: int -> unit
    default this.shuffleTotal(intArray: int[], shuffleTotal: int) : unit =
        let mutable size : int = intArray.Length
        let mutable randomIndex : int = 0
        let mutable randomIndex2 : int = 0
        let mutable value : int = 0
        let mutable index : int = 0
        while index < shuffleTotal do
            randomIndex <- this.getAbsoluteNextIntAllowZero(size)
            randomIndex2 <- this.getAbsoluteNextIntAllowZero(size)
            value <- intArray.[randomIndex]
            intArray.[randomIndex] <- intArray.[randomIndex2]
            intArray.[randomIndex2] <- value
            index <- index + 1
    
    abstract shuffle2 : intArray: int[] * intArray2: int[] -> unit
    default this.shuffle2(intArray: int[], intArray2: int[]) : unit =
        this.shuffle2Total(intArray, intArray2, (intArray.Length * 7))
    
    abstract shuffle2Total : intArray: int[] * intArray2: int[] * shuffleTotal: int -> unit
    default this.shuffle2Total(intArray: int[], intArray2: int[], shuffleTotal: int) : unit =
        let mutable size : int = intArray.Length
        let mutable randomIndex : int = 0
        let mutable randomIndex2 : int = 0
        let mutable value : int = 0
        let mutable value2 : int = 0
        let mutable index : int = 0
        while index < shuffleTotal do
            randomIndex <- this.getAbsoluteNextIntAllowZero(size)
            randomIndex2 <- this.getAbsoluteNextIntAllowZero(size)
            value <- intArray.[randomIndex]
            value2 <- intArray2.[randomIndex]
            intArray.[randomIndex] <- intArray.[randomIndex2]
            intArray.[randomIndex2] <- value
            intArray2.[randomIndex] <- intArray2.[randomIndex2]
            intArray2.[randomIndex2] <- value2
            index <- index + 1
    
    static member main(args: string[]) : unit =
        let mutable randomFactory : MyRandomFactory = MyRandomFactory.getInstance()
        let mutable stringBuilder : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable size2 : int = 100
        let mutable index : int = 0
        while index < size2 do
            ignore (stringBuilder.appendint(randomFactory.getAbsoluteNextInt(3)).append(commonSeps.COMMA))
            index <- index + 1
        JSystem.out.println(stringBuilder.ToString())
        ignore (stringBuilder.delete(0, stringBuilder.length()))
        let mutable intArray : int[] = (Array.zeroCreate<int> (52))
        let mutable intArray2 : int[] = (Array.zeroCreate<int> (52))
        let mutable size : int = intArray.Length
        let mutable index : int = 0
        while index < size do
            intArray.[index] <- index
            intArray2.[index] <- index
            index <- index + 1
        randomFactory.shuffle2(intArray, intArray2)
        let mutable index : int = 0
        while index < size do
            ignore (stringBuilder.appendint(intArray.[index]).append(commonSeps.COMMA))
            index <- index + 1
        JSystem.out.println(stringBuilder.ToString())
        ignore (stringBuilder.delete(0, stringBuilder.length()))
        let mutable index : int = 0
        while index < size do
            ignore (stringBuilder.appendint(intArray2.[index]).append(commonSeps.COMMA))
            index <- index + 1
        JSystem.out.println(stringBuilder.ToString())
        let mutable found : bool = false
        let mutable index : int = 0
        while index < size do
            found <- false
            let mutable index2 : int = 0
            while index2 < size do
                if intArray.[index2] = index then
                    found <- true
                index2 <- index2 + 1
            if not (found) then
                raise ((new JRuntimeException()))
            index <- index + 1


