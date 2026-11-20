namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ObjectPermutationVisitor =
    inherit Visitor
    [<DefaultValue(false)>] val mutable data : obj[]
    [<DefaultValue(false)>] val mutable stringBuilder : StringMaker
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ObjectPermutationVisitor.jclinitDone then
            ObjectPermutationVisitor.jclinitDone <- true
            ObjectPermutationVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ObjectPermutationVisitor() : unit =
        this.stringBuilder <- (new StringMaker())
        ()
    
    new (data: obj[]) as this =
        { inherit Visitor() }
        then
            this.jfields_ObjectPermutationVisitor()
            this.jctor1(data)
    member this.jctor1(data: obj[]) : unit =
        this.data <- data
        ()
    
    override this.visit(anyType: obj) : obj =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        this.print(this.data, this.stringBuilder)
        NullUtil.getInstance().NULL_OBJECT
    
    abstract print : data: obj[] -> unit
    default this.print(data: obj[]) : unit =
        let mutable stringBuilder : StringMaker = (new StringMaker())
        this.print(data, stringBuilder)
    
    abstract print : data: obj[] * stringBuilder: StringMaker -> unit
    default this.print(data: obj[], stringBuilder: StringMaker) : unit =
        let mutable tsUtil : TsUtil = TsUtil.getInstance()
        let mutable size : int = data.Length
        let mutable i : int = 0
        while i < size do
            ignore (stringBuilder.appendint(tsUtil.hashCode(data.[i])))
            ignore (stringBuilder.append(CommonSeps.getInstance().SPACE))
            i <- i + 1
        JSystem.out.println(stringBuilder.ToString())


