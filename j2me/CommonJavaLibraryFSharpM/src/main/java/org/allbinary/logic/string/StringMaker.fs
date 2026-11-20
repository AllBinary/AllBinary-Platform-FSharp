namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type StringMaker =
    [<DefaultValue(false)>] val mutable charArray : char[]
    [<DefaultValue(false)>] val mutable currentLength : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StringMaker.jclinitDone then
            StringMaker.jclinitDone <- true
            StringMaker.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.charArray <- (Array.zeroCreate<char> (20))
        ()
    
    abstract append : string_: string -> StringMaker
    default this.append(string_: string) : StringMaker =
        let mutable stringLength : int = JString.length(string_)
        this.ensureCapacity((this.currentLength + stringLength))
        ignore (JString.getChars(string_, 0, stringLength, this.charArray, this.currentLength))
        this.currentLength <- this.currentLength + stringLength
        this
    
    abstract appendchar : c: char -> StringMaker
    default this.appendchar(c: char) : StringMaker =
        this.ensureCapacity((this.currentLength + 1))
        this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- c
        this
    
    abstract appendCharArray : charArray: char[] * start: int * end_: int -> StringMaker
    default this.appendCharArray(charArray: char[], start: int, end_: int) : StringMaker =
        this.ensureCapacity((this.currentLength + (end_ - start)))
        let mutable index : int = start
        while index < end_ do
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- charArray.[index]
            index <- index + 1
        this
    
    abstract appendbyte : b: sbyte -> StringMaker
    default this.appendbyte(b: sbyte) : StringMaker =
        ignore (this.append(Integer.toString(b)))
        this
    
    abstract appendshort : b: int16 -> StringMaker
    default this.appendshort(b: int16) : StringMaker =
        ignore (this.append(Integer.toString(b)))
        this
    
    abstract appendint : i: int -> StringMaker
    default this.appendint(i: int) : StringMaker =
        ignore (this.append(Integer.toString(i)))
        this
    
    abstract appendlong : l: int64 -> StringMaker
    default this.appendlong(l: int64) : StringMaker =
        ignore (this.append(Long.toString(l)))
        this
    
    abstract appendfloat : f: float32 -> StringMaker
    default this.appendfloat(f: float32) : StringMaker =
        ignore (this.append(Float.toString(f)))
        this
    
    abstract appendboolean : bool: bool -> StringMaker
    default this.appendboolean(bool: bool) : StringMaker =
        if bool then
            this.ensureCapacity((this.currentLength + 4))
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 't'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'r'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'u'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'e'
        else
            this.ensureCapacity((this.currentLength + 5))
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'f'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'a'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'l'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 's'
            this.charArray.[(let jt = this.currentLength in this.currentLength <- this.currentLength + 1; jt)] <- 'e'
        this
    
    abstract ensureCapacity : minSize: int -> unit
    default this.ensureCapacity(minSize: int) : unit =
        let mutable oldCapacity : int = this.charArray.Length
        if minSize > oldCapacity then
            let mutable newCapacity : int = oldCapacity * 3
            if newCapacity < minSize then
                newCapacity <- minSize
            let mutable copy : char[] = (Array.zeroCreate<char> (newCapacity))
            let mutable min_ : int = this.min(this.charArray.Length, newCapacity)
            ignore (JSystem.arraycopy(this.charArray, 0, copy, 0, min_))
            this.charArray <- copy
    
    abstract min : value: int * value2: int -> int
    default this.min(value: int, value2: int) : int =
        (if (value <= value2) then value else value2)
    
    abstract delete : start: int * end_: int -> StringMaker
    default this.delete(start: int, end_: int) : StringMaker =
        this.currentLength <- this.currentLength - (end_ - start)
        this
    
    abstract length : unit -> int
    default this.length() : int =
        this.currentLength
    
    override this.ToString() : string =
        JString.newString(this.charArray, 0, this.currentLength)


