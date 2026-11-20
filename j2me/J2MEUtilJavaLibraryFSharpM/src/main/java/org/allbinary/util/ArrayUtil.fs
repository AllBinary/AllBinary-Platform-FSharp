namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ArrayUtil =
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : ArrayUtil
    static member instance with get() : ArrayUtil = (ArrayUtil.jclinit(); ArrayUtil.jcell_instance) and set (jvalue: ArrayUtil) = (ArrayUtil.jclinit(); ArrayUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArrayUtil.jclinitDone then
            ArrayUtil.jclinitDone <- true
            ArrayUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ArrayUtil.jcell_instance <- (new ArrayUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ArrayUtil()
    member this.jfields_ArrayUtil() : unit =
        this.mathUtil <- MathUtil.getInstance()
        ()
    
    static member getInstance() : ArrayUtil =
        ArrayUtil.instance
    
    abstract copyOf : original: obj[] * newLength: int -> obj[]
    default this.copyOf(original: obj[], newLength: int) : obj[] =
        this.copyOfType(original, newLength, JR.getClass(original))
    
    abstract copyOfType : original: obj[] * newLength: int * newType: string -> obj[]
    default this.copyOfType(original: obj[], newLength: int, newType: string) : obj[] =
        let mutable copy : obj[] = (Array.zeroCreate<obj> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfbyte : original: sbyte[] * newLength: int -> sbyte[]
    default this.copyOfbyte(original: sbyte[], newLength: int) : sbyte[] =
        let mutable copy : sbyte[] = (Array.zeroCreate<sbyte> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfshort : original: int16[] * newLength: int -> int16[]
    default this.copyOfshort(original: int16[], newLength: int) : int16[] =
        let mutable copy : int16[] = (Array.zeroCreate<int16> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfint : original: int[] * newLength: int -> int[]
    default this.copyOfint(original: int[], newLength: int) : int[] =
        let mutable copy : int[] = (Array.zeroCreate<int> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOflong : original: int64[] * newLength: int -> int64[]
    default this.copyOflong(original: int64[], newLength: int) : int64[] =
        let mutable copy : int64[] = (Array.zeroCreate<int64> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfchar : original: char[] * newLength: int -> char[]
    default this.copyOfchar(original: char[], newLength: int) : char[] =
        let mutable copy : char[] = (Array.zeroCreate<char> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOffloat : original: float32[] * newLength: int -> float32[]
    default this.copyOffloat(original: float32[], newLength: int) : float32[] =
        let mutable copy : float32[] = (Array.zeroCreate<float32> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfdouble : original: float[] * newLength: int -> float[]
    default this.copyOfdouble(original: float[], newLength: int) : float[] =
        let mutable copy : float[] = (Array.zeroCreate<float> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract copyOfboolean : original: bool[] * newLength: int -> bool[]
    default this.copyOfboolean(original: bool[], newLength: int) : bool[] =
        let mutable copy : bool[] = (Array.zeroCreate<bool> (newLength))
        ignore (JSystem.arraycopy(original, 0, copy, 0, this.mathUtil.min(original.Length, newLength)))
        copy
    
    abstract reverse : intArray: int[] -> unit
    default this.reverse(intArray: int[]) : unit =
        let mutable length : int = intArray.Length - 1
        let mutable temp : int = 0
        let mutable size : int = length / 2
        let mutable index : int = 0
        while index <= size do
            temp <- intArray.[index]
            intArray.[index] <- intArray.[length - index]
            intArray.[length - index] <- temp
            index <- index + 1
    
    abstract flip : intArray: int[] * width: int * height: int -> unit
    default this.flip(intArray: int[], width: int, height: int) : unit =
        let mutable length : int = height - 1
        let mutable temp : int = 0
        let mutable index : int = 0
        let mutable rowIndex : int = 0
        let mutable y : int = 0
        while y <= (length / 2) do
            let mutable x : int = 0
            while x < width do
                rowIndex <- ((length - y) * width)
                index <- x + (y * width)
                temp <- intArray.[index]
                intArray.[index] <- intArray.[rowIndex + x]
                intArray.[rowIndex + x] <- temp
                x <- x + 1
            y <- y + 1
    
    abstract toStringFromTwoDimensionaArray : twoDimensionalIntArray: int[][] -> string
    default this.toStringFromTwoDimensionaArray(twoDimensionalIntArray: int[][]) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable endIndex : int = twoDimensionalIntArray.Length
        let mutable endIndex2 : int = twoDimensionalIntArray.[0].Length
        let mutable index : int = 0
        while index < endIndex do
            ignore (stringBuffer.append(commonSeps.BRACE_OPEN))
            let mutable index2 : int = 0
            while index2 < endIndex2 do
                ignore (stringBuffer.appendint(int (twoDimensionalIntArray.[index].[index2])))
                ignore (stringBuffer.append(commonSeps.COMMA_SEP))
                index2 <- index2 + 1
            ignore (stringBuffer.append(commonSeps.BRACE_CLOSE))
            ignore (stringBuffer.append(commonSeps.NEW_LINE))
            index <- index + 1
        stringBuffer.ToString()
    
    abstract toStringFromObjectArray : objectArray: obj[] -> string
    default this.toStringFromObjectArray(objectArray: obj[]) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable index : int = 0
        while index < objectArray.Length do
            ignore (stringBuffer.append(StringUtil.getInstance().toString(objectArray.[index])))
            ignore (stringBuffer.append(commonSeps.COMMA_SEP))
            index <- index + 1
        stringBuffer.ToString()
    
    abstract toStringFromByteArray : byteArray: sbyte[] -> string
    default this.toStringFromByteArray(byteArray: sbyte[]) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable index : int = 0
        while index < byteArray.Length do
            ignore (stringBuffer.appendbyte(byteArray.[index]))
            ignore (stringBuffer.append(commonSeps.COMMA_SEP))
            index <- index + 1
        stringBuffer.ToString()


