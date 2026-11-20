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
type CamelCaseUtil =
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] static val mutable private jcell_instance : CamelCaseUtil
    static member instance with get() : CamelCaseUtil = (CamelCaseUtil.jclinit(); CamelCaseUtil.jcell_instance) and set (jvalue: CamelCaseUtil) = (CamelCaseUtil.jclinit(); CamelCaseUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CamelCaseUtil.jclinitDone then
            CamelCaseUtil.jclinitDone <- true
            CamelCaseUtil.jclinitBody()
    static member private jclinitBody() : unit =
        CamelCaseUtil.jcell_instance <- (new CamelCaseUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_CamelCaseUtil()
    member this.jfields_CamelCaseUtil() : unit =
        this.commonSeps <- CommonSeps.getInstance()
        ()
    
    static member getInstance() : CamelCaseUtil =
        CamelCaseUtil.instance
    
    abstract getAsCamelCase : string_: string * stringBuilder: StringMaker -> string
    default this.getAsCamelCase(string_: string, stringBuilder: StringMaker) : string =
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        ignore (stringBuilder.delete(0, stringBuilder.length()))
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable tokenizer : Tokenizer = (new Tokenizer(this.commonSeps.UNDERSCORE))
        ignore (tokenizer.getTokensFromString(string_, list_))
        let mutable size : int = list_.size()
        let mutable word : string = null
        let mutable i : int = 0
        while i < size do
            word <- (box (list_.get(i)) :?> string)
            word <- (if stringValidationUtil.isEmpty(word) then word else (new StringMaker()).appendchar(Character.toUpperCase(JString.charAt(word, 0))).append(JString.toLowerCase(JString.substring(word, 1))).ToString())
            ignore (stringBuilder.append(word))
            i <- i + 1
        stringBuilder.ToString()


