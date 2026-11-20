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
type OrderedIntArrayPermutationUtil =
    [<DefaultValue(false)>] val mutable TOTAL_ITERATIONS_TABLE : string
    [<DefaultValue(false)>] val mutable FINISHED : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : OrderedIntArrayPermutationUtil
    static member instance with get() : OrderedIntArrayPermutationUtil = (OrderedIntArrayPermutationUtil.jclinit(); OrderedIntArrayPermutationUtil.jcell_instance) and set (jvalue: OrderedIntArrayPermutationUtil) = (OrderedIntArrayPermutationUtil.jclinit(); OrderedIntArrayPermutationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OrderedIntArrayPermutationUtil.jclinitDone then
            OrderedIntArrayPermutationUtil.jclinitDone <- true
            OrderedIntArrayPermutationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OrderedIntArrayPermutationUtil.jcell_instance <- (new OrderedIntArrayPermutationUtil())
        ()
    member this.jfields_OrderedIntArrayPermutationUtil() : unit =
        this.TOTAL_ITERATIONS_TABLE <- "Total Iterations: "
        this.FINISHED <- "\nFINISHED"
        ()
    
    static member getInstance() : OrderedIntArrayPermutationUtil =
        OrderedIntArrayPermutationUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_OrderedIntArrayPermutationUtil()
    
    abstract getNext : data: int[] -> unit
    default this.getNext(data: int[]) : unit =
        let mutable length : int = data.Length
        let mutable i : int = length - 1
        while data.[i - 1] >= data.[i] do
            i <- i - 1
        let mutable j : int = length
        while data.[j - 1] <= data.[i - 1] do
            j <- j - 1
        this.swap(data, (i - 1), (j - 1))
        i <- i + 1
        j <- length
        while i < j do
            this.swap(data, (i - 1), (j - 1))
            i <- i + 1
            j <- j - 1
    
    abstract swap : data: int[] * a: int * b: int -> unit
    default this.swap(data: int[], a: int, b: int) : unit =
        let mutable temp : int = data.[a]
        data.[a] <- data.[b]
        data.[b] <- temp
    
    abstract factorial : dataLength: int -> int64
    default this.factorial(dataLength: int) : int64 =
        let mutable temp : int64 = 1L
        if dataLength > 1 then
            let mutable i : int = 1
            while i <= dataLength do
                temp <- temp * int64 (i)
                i <- i + 1
        temp
    
    abstract generate : data: int[] * visitor: Visitor -> unit
    default this.generate(data: int[], visitor: Visitor) : unit =
        let mutable iterations : int64 = this.factorial(data.Length)
        JSystem.out.print(this.TOTAL_ITERATIONS_TABLE)
        JSystem.out.println(iterations)
        let mutable count : int64 = 0L
        while count < (iterations - 1L) do
            this.getNext(data)
            ignore (visitor.visit(this))
            count <- count + 1L
        JSystem.out.println(this.FINISHED)
    
    static member main(args: string[]) : unit =
        let mutable TOTAL : int = 3
        let mutable data : int[] = (Array.zeroCreate<int> (TOTAL))
        let mutable i : int = 0
        while i < TOTAL do
            data.[i] <- i
            i <- i + 1
        let mutable permutationVisitor : IntPermutationVisitor = (new IntPermutationVisitor(data))
        let mutable ORIGINAL_DATA_LABEL : string = "Original Data: "
        JSystem.out.print(ORIGINAL_DATA_LABEL)
        permutationVisitor.print(data, (new StringMaker()))
        OrderedIntArrayPermutationUtil.getInstance().generate(data, permutationVisitor)


