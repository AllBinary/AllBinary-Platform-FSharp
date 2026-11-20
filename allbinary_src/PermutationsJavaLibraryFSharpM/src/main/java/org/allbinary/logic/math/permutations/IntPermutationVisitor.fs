namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type IntPermutationVisitor =
    inherit Visitor
    [<DefaultValue(false)>] val mutable data : int[]
    [<DefaultValue(false)>] val mutable stringBuilder : StringMaker
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IntPermutationVisitor.jclinitDone then
            IntPermutationVisitor.jclinitDone <- true
            IntPermutationVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_IntPermutationVisitor() : unit =
        this.stringBuilder <- (new StringMaker())
        ()
    
    new (data: int[]) as this =
        { inherit Visitor() }
        then
            this.jfields_IntPermutationVisitor()
            this.jctor1(data)
    member this.jctor1(data: int[]) : unit =
        this.data <- data
        ()
    
    override this.visit(anyType: obj) : obj =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        this.print(this.data, this.stringBuilder)
        NullUtil.getInstance().NULL_OBJECT
    
    abstract print : data: int[] -> unit
    default this.print(data: int[]) : unit =
        let mutable stringBuilder : StringMaker = (new StringMaker())
        this.print(data, stringBuilder)
    
    abstract print : data: int[] * stringBuilder: StringMaker -> unit
    default this.print(data: int[], stringBuilder: StringMaker) : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable size : int = data.Length
        let mutable i : int = 0
        while i < size do
            ignore (stringBuilder.appendint(data.[i]))
            ignore (stringBuilder.append(commonSeps.SPACE))
            i <- i + 1
        JSystem.out.println(stringBuilder.ToString())


