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
type StringUtil =
    [<DefaultValue(false)>] val mutable INIT_STRING : string
    [<DefaultValue(false)>] val mutable NULL_STRING : string
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable ONE_EMPTY_STRING_ARRAY : string[]
    [<DefaultValue(false)>] val mutable ONE_EMPTY_STRING_ARRAY_OF_ARRAYS : string[][]
    [<DefaultValue(false)>] val mutable stringArray : string[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : StringUtil
    static member instance with get() : StringUtil = (StringUtil.jclinit(); StringUtil.jcell_instance) and set (jvalue: StringUtil) = (StringUtil.jclinit(); StringUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StringUtil.jclinitDone then
            StringUtil.jclinitDone <- true
            StringUtil.jclinitBody()
    static member private jclinitBody() : unit =
        StringUtil.jcell_instance <- (new StringUtil())
        ()
    member this.jfields_StringUtil() : unit =
        this.INIT_STRING <- JString.newString("")
        this.NULL_STRING <- "null"
        this.EMPTY_STRING <- ""
        this.ONE_EMPTY_STRING_ARRAY <- ([| this.EMPTY_STRING |] : string[])
        this.ONE_EMPTY_STRING_ARRAY_OF_ARRAYS <- (JR.newArray2<string>(0, 0))
        this.stringArray <- (Array.zeroCreate<string> (0))
        ()
    
    static member getInstance() : StringUtil =
        StringUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_StringUtil()
    
    abstract getNonNull : string_: string -> string
    default this.getNonNull(string_: string) : string =
        string_
    
    abstract getArrayInstance : unit -> string[]
    default this.getArrayInstance() : string[] =
        this.stringArray
    
    abstract count : string_: string * aChar: char -> int
    default this.count(string_: string, aChar: char) : int =
        let mutable count : int = 0
        let mutable size : int = JString.length(string_)
        let mutable index : int = 0
        while index < size do
            if JString.charAt(string_, index) = aChar then
                count <- count + 1
            index <- index + 1
        count
    
    abstract toString : anyType: obj -> string
    default this.toString(anyType: obj) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if not (JR.same(anyType, null)) then
            jret <- anyType.ToString()
            jflow <- 1
        else
            jret <- this.NULL_STRING
            jflow <- 1
        jret


