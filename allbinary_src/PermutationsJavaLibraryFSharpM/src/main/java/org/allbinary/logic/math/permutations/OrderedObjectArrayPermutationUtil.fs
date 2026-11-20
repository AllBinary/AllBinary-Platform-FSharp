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
type OrderedObjectArrayPermutationUtil =
    [<DefaultValue(false)>] val mutable TOTAL_ITERATIONS_TABLE : string
    [<DefaultValue(false)>] val mutable FINISHED : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : OrderedObjectArrayPermutationUtil
    static member instance with get() : OrderedObjectArrayPermutationUtil = (OrderedObjectArrayPermutationUtil.jclinit(); OrderedObjectArrayPermutationUtil.jcell_instance) and set (jvalue: OrderedObjectArrayPermutationUtil) = (OrderedObjectArrayPermutationUtil.jclinit(); OrderedObjectArrayPermutationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OrderedObjectArrayPermutationUtil.jclinitDone then
            OrderedObjectArrayPermutationUtil.jclinitDone <- true
            OrderedObjectArrayPermutationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OrderedObjectArrayPermutationUtil.jcell_instance <- (new OrderedObjectArrayPermutationUtil())
        ()
    member this.jfields_OrderedObjectArrayPermutationUtil() : unit =
        this.TOTAL_ITERATIONS_TABLE <- "Total Iterations: "
        this.FINISHED <- "\nFINISHED"
        ()
    
    static member getInstance() : OrderedObjectArrayPermutationUtil =
        OrderedObjectArrayPermutationUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_OrderedObjectArrayPermutationUtil()
    
    abstract getNext : data: obj[] -> unit
    default this.getNext(data: obj[]) : unit =
        let mutable length : int = data.Length
        let mutable i : int = length - 1
        let mutable tsUtil : TsUtil = TsUtil.getInstance()
        while tsUtil.hashCode(data.[i - 1]) >= tsUtil.hashCode(data.[i]) do
            i <- i - 1
        let mutable j : int = length
        while tsUtil.hashCode(data.[j - 1]) <= tsUtil.hashCode(data.[i - 1]) do
            j <- j - 1
        this.swap(data, (i - 1), (j - 1))
        i <- i + 1
        j <- length
        while i < j do
            this.swap(data, (i - 1), (j - 1))
            i <- i + 1
            j <- j - 1
    
    abstract swap : data: obj[] * a: int * b: int -> unit
    default this.swap(data: obj[], a: int, b: int) : unit =
        let mutable temp : obj = data.[a]
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
    
    abstract generate : data: obj[] * visitor: Visitor -> unit
    default this.generate(data: obj[], visitor: Visitor) : unit =
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
        let mutable TOTAL : int = 7
        let mutable data : obj[] = (Array.zeroCreate<obj> (TOTAL))
        let mutable i : int = 0
        while i < TOTAL do
            data.[i] <- (new ComparableObject())
            i <- i + 1
        ignore (Arrays.sort(data))
        let mutable permutationVisitor : ObjectPermutationVisitor = (new ObjectPermutationVisitor(data))
        let mutable ORIGINAL_DATA_LABEL : string = "Original Data: "
        JSystem.out.print(ORIGINAL_DATA_LABEL)
        ignore (permutationVisitor.visit(data))
        OrderedObjectArrayPermutationUtil.getInstance().generate(data, permutationVisitor)


