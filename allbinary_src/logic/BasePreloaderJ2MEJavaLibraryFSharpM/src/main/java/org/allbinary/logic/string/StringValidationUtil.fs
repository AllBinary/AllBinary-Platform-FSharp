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
type StringValidationUtil =
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : StringValidationUtil
    static member instance with get() : StringValidationUtil = (StringValidationUtil.jclinit(); StringValidationUtil.jcell_instance) and set (jvalue: StringValidationUtil) = (StringValidationUtil.jclinit(); StringValidationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StringValidationUtil.jclinitDone then
            StringValidationUtil.jclinitDone <- true
            StringValidationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        StringValidationUtil.jcell_instance <- (new StringValidationUtil())
        ()
    member this.jfields_StringValidationUtil() : unit =
        this.stringUtil <- StringUtil.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        ()
    
    static member getInstance() : StringValidationUtil =
        StringValidationUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_StringValidationUtil()
    
    abstract containsSpaces : value: string -> bool
    default this.containsSpaces(value: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if JString.indexOf(value, ' ') >= 0 then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isNumber : value: string -> bool
    default this.isNumber(value: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable numberOfDecimalPoints : int = 0
        let mutable index : int = 0
        while jflow = 0 && (index < JString.length(value)) do
            let mutable digit : char = JString.charAt(value, index)
            if (not (this.isNumberFromChar(digit))) && (digit <> '.') then
                jret <- false
                jflow <- 1
            if jflow = 0 then
                if digit = '.' then
                    numberOfDecimalPoints <- numberOfDecimalPoints + 1
                    if numberOfDecimalPoints > 1 then
                        jret <- false
                        jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract isNumberFromChar : digit: char -> bool
    default this.isNumberFromChar(digit: char) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((((((((digit <> '0') && (digit <> '1')) && (digit <> '2')) && (digit <> '3')) && (digit <> '4')) && (digit <> '5')) && (digit <> '6')) && (digit <> '7')) && (digit <> '8')) && (digit <> '9') then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract isValidRequired : value: string * min_: int * max_: int -> bool
    default this.isValidRequired(value: string, min_: int, max_: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JString.length(value) < min_) || (JString.length(value) > max_) then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract isValidRequiredNumber : value: string * min_: int * max_: int -> bool
    default this.isValidRequiredNumber(value: string, min_: int, max_: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (this.isEmpty(value) || (JString.length(value) < min_)) || (JString.length(value) > max_) then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            if not (this.isNumber(value)) then
                jret <- false
                jflow <- 1
            if jflow = 0 then
                jret <- true
                jflow <- 1
        jret
    
    abstract isValidNotRequired : value: string * min_: int * max_: int -> bool
    default this.isValidNotRequired(value: string, min_: int, max_: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if JString.length(value) > 0 then
            if (JString.length(value) < min_) || (JString.length(value) > max_) then
                jret <- false
                jflow <- 1
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract isValidNotRequiredNumber : value: string * min_: int * max_: int -> bool
    default this.isValidNotRequiredNumber(value: string, min_: int, max_: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if JString.length(value) > 0 then
            if ((this.tsUtil.compareTo(value, this.stringUtil.NULL_STRING) = 0) || (JString.length(value) < min_)) || (JString.length(value) > max_) then
                jret <- false
                jflow <- 1
            if jflow = 0 then
                if not (this.isNumber(value)) then
                    jret <- false
                    jflow <- 1
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract isEmpty : string_: string -> bool
    default this.isEmpty(string_: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (this.tsUtil.compareTo(string_, this.stringUtil.NULL_STRING) <> 0) && (this.tsUtil.compareTo(string_, this.stringUtil.EMPTY_STRING) <> 0) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret


