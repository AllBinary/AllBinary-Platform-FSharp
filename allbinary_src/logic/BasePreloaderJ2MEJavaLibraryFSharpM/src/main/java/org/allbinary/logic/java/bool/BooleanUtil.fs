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
type BooleanUtil =
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : BooleanUtil
    static member instance with get() : BooleanUtil = (BooleanUtil.jclinit(); BooleanUtil.jcell_instance) and set (jvalue: BooleanUtil) = (BooleanUtil.jclinit(); BooleanUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BooleanUtil.jclinitDone then
            BooleanUtil.jclinitDone <- true
            BooleanUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BooleanUtil.jcell_instance <- (new BooleanUtil())
        ()
    member this.jfields_BooleanUtil() : unit =
        this.tsUtil <- TsUtil.getInstance()
        ()
    
    static member getInstance() : BooleanUtil =
        BooleanUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_BooleanUtil()
    
    abstract getFromString : booleanString: string -> bool
    default this.getFromString(booleanString: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        let mutable booleanFactory : BooleanFactory = BooleanFactory.getInstance()
        if stringValidationUtil.isEmpty(booleanString) then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            let mutable booleanStringLowerCase : string = JString.toLowerCase(booleanString)
            if this.tsUtil.compareTo(booleanStringLowerCase, booleanFactory.TRUE_STRING) = 0 then
                jret <- true
                jflow <- 1
            elif this.tsUtil.compareTo(booleanStringLowerCase, booleanFactory.FALSE_STRING) = 0 then
                jret <- false
                jflow <- 1
            else
                raise ((new JException("Invalid booleanString - Must be true or false")))
        jret
    
    abstract isStringBoolean : booleanString: string -> bool
    default this.isStringBoolean(booleanString: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable booleanFactory : BooleanFactory = BooleanFactory.getInstance()
        let mutable booleanStringLowerCase : string = JString.toLowerCase(booleanString)
        if (JString.compareTo(booleanStringLowerCase, booleanFactory.TRUE_STRING) = 0) || (JString.compareTo(booleanStringLowerCase, booleanFactory.FALSE_STRING) = 0) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract toStringFromBooleanArray : booleanArray: bool[] -> string
    default this.toStringFromBooleanArray(booleanArray: bool[]) : string =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable size : int = booleanArray.Length
        let mutable index : int = 0
        while index < size do
            ignore (stringMaker.appendboolean(booleanArray.[index]))
            index <- index + 1
        stringMaker.ToString()


