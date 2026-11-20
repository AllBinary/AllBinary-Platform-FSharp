namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type MathUtil =
    [<DefaultValue(false)>] val mutable ACCURACY : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : MathUtil
    static member instance with get() : MathUtil = (MathUtil.jclinit(); MathUtil.jcell_instance) and set (jvalue: MathUtil) = (MathUtil.jclinit(); MathUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MathUtil.jclinitDone then
            MathUtil.jclinitDone <- true
            MathUtil.jclinitBody()
    static member private jclinitBody() : unit =
        MathUtil.jcell_instance <- (new MathUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_MathUtil()
    member this.jfields_MathUtil() : unit =
        this.ACCURACY <- 100
        ()
    
    static member getInstance() : MathUtil =
        MathUtil.instance
    
    abstract getTotalDigits : digits: int -> int
    default this.getTotalDigits(digits: int) : int =
        let mutable digits = digits
        let mutable total : int = 0
        while digits > 0 do
            digits <- digits / 10
            total <- total + 1
        total
    
    abstract sqrt : value: int -> int
    default this.sqrt(value: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if value <= 1 then
            jret <- value
            jflow <- 1
        if jflow = 0 then
            let mutable accumulated : int = value >>> 1
            let mutable result : int = (accumulated + (value / accumulated)) >>> 1
            let mutable jfirst2 = true
            while jfirst2 || (accumulated > result) do
                jfirst2 <- false
                accumulated <- result
                result <- (accumulated + (value / accumulated)) >>> 1
            jret <- accumulated
            jflow <- 1
        jret
    
    abstract sqrtd : x: int -> float
    default this.sqrtd(x: int) : float =
        let mutable jflow = 0
        let mutable jret : float = Unchecked.defaultof<float>
        if x = 0 then
            jret <- float (0.0f)
            jflow <- 1
        if jflow = 0 then
            if x < 0 then
                jret <- float (-1.0f)
                jflow <- 1
            if jflow = 0 then
                let mutable result : float = float (x)
                let mutable index : int = 0
                while index < this.ACCURACY do
                    result <- (result + (float (x) / result)) / 2.0
                    index <- index + 1
                jret <- result
                jflow <- 1
        jret
    
    abstract abs : value: int -> int
    default this.abs(value: int) : int =
        (if (value < 0) then -(value) else value)
    
    abstract abslong : value: int64 -> int64
    default this.abslong(value: int64) : int64 =
        (if (value < 0L) then -(value) else value)
    
    abstract min : value: int * value2: int -> int
    default this.min(value: int, value2: int) : int =
        (if (value <= value2) then value else value2)
    
    abstract max : value: int * value2: int -> int
    default this.max(value: int, value2: int) : int =
        (if (value >= value2) then value else value2)


