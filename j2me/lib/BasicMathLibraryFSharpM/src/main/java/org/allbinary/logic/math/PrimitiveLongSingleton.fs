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
type PrimitiveLongSingleton =
    [<DefaultValue(false)>] val mutable UNK : char[]
    [<DefaultValue(false)>] val mutable NUMBER_ARRAY : sbyte[]
    [<DefaultValue(false)>] val mutable NUMBER_CHAR_ARRAY : char[]
    [<DefaultValue(false)>] val mutable NUMBER_CHAR_ARRAYS : char[][]
    [<DefaultValue(false)>] val mutable ZERO : char[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : PrimitiveLongSingleton
    static member instance with get() : PrimitiveLongSingleton = (PrimitiveLongSingleton.jclinit(); PrimitiveLongSingleton.jcell_instance) and set (jvalue: PrimitiveLongSingleton) = (PrimitiveLongSingleton.jclinit(); PrimitiveLongSingleton.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PrimitiveLongSingleton.jclinitDone then
            PrimitiveLongSingleton.jclinitDone <- true
            PrimitiveLongSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        PrimitiveLongSingleton.jcell_instance <- (new PrimitiveLongSingleton())
        ()
    new () as this =
        {  }
        then
            this.jfields_PrimitiveLongSingleton()
    member this.jfields_PrimitiveLongSingleton() : unit =
        this.UNK <- ([| 'U'; 'n'; 'k' |] : char[])
        this.NUMBER_ARRAY <- ([| (0y); (1y); (2y); (3y); (4y); (5y); (6y); (7y); (8y); (9y) |] : sbyte[])
        this.NUMBER_CHAR_ARRAY <- ([| '0'; '1'; '2'; '3'; '4'; '5'; '6'; '7'; '8'; '9' |] : char[])
        this.NUMBER_CHAR_ARRAYS <- ([| ([| '0' |] : char[]); ([| '1' |] : char[]); ([| '2' |] : char[]); ([| '3' |] : char[]); ([| '4' |] : char[]); ([| '5' |] : char[]); ([| '6' |] : char[]); ([| '7' |] : char[]); ([| '8' |] : char[]); ([| '9' |] : char[]) |] : char[][])
        this.ZERO <- ([| this.NUMBER_CHAR_ARRAY.[0] |] : char[])
        ()
    
    static member getInstance() : PrimitiveLongSingleton =
        PrimitiveLongSingleton.instance
    
    abstract getNumberFromChar : numberAsChar: char -> sbyte
    default this.getNumberFromChar(numberAsChar: char) : sbyte =
        let mutable jflow = 0
        let mutable jret : sbyte = Unchecked.defaultof<sbyte>
        let mutable size : int = this.NUMBER_CHAR_ARRAY.Length
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            if this.NUMBER_CHAR_ARRAY.[index] = numberAsChar then
                jret <- this.NUMBER_ARRAY.[index]
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            raise ((new JException((new StringMaker()).append("numberAsChar was not in array: ").appendchar(numberAsChar).ToString())))
        jret


