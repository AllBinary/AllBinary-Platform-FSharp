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
type CommonSeps =
    [<DefaultValue(false)>] val mutable NEW_LINE : string
    [<DefaultValue(false)>] val mutable SEMICOLON : string
    [<DefaultValue(false)>] val mutable EQUALS : string
    [<DefaultValue(false)>] val mutable SPACE : string
    [<DefaultValue(false)>] val mutable COMMA : string
    [<DefaultValue(false)>] val mutable COLON : string
    [<DefaultValue(false)>] val mutable PERIOD : string
    [<DefaultValue(false)>] val mutable UNDERSCORE : string
    [<DefaultValue(false)>] val mutable COLON_SEP : string
    [<DefaultValue(false)>] val mutable COMMA_SEP : string
    [<DefaultValue(false)>] val mutable PARENTHESIS_OPEN : string
    [<DefaultValue(false)>] val mutable PARENTHESIS_CLOSE : string
    [<DefaultValue(false)>] val mutable BRACE_OPEN : string
    [<DefaultValue(false)>] val mutable BRACE_CLOSE : string
    [<DefaultValue(false)>] val mutable BRACKET_OPEN : string
    [<DefaultValue(false)>] val mutable BRACKET_CLOSE : string
    [<DefaultValue(false)>] val mutable DASH : string
    [<DefaultValue(false)>] val mutable PERCENT : string
    [<DefaultValue(false)>] val mutable AMPERSAND : string
    [<DefaultValue(false)>] val mutable FORWARD_SLASH : string
    [<DefaultValue(false)>] val mutable BACK_SLASH : string
    [<DefaultValue(false)>] val mutable QUESTION : string
    [<DefaultValue(false)>] val mutable QUOTE : string
    [<DefaultValue(false)>] val mutable QUOTE_END : string
    [<DefaultValue(false)>] val mutable COMMENT : string
    [<DefaultValue(false)>] val mutable INDENT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonSeps
    static member instance with get() : CommonSeps = (CommonSeps.jclinit(); CommonSeps.jcell_instance) and set (jvalue: CommonSeps) = (CommonSeps.jclinit(); CommonSeps.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonSeps.jclinitDone then
            CommonSeps.jclinitDone <- true
            CommonSeps.jclinitBody()
    static member private jclinitBody() : unit =
        CommonSeps.jcell_instance <- (new CommonSeps())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommonSeps()
    member this.jfields_CommonSeps() : unit =
        this.NEW_LINE <- "\n"
        this.SEMICOLON <- ";"
        this.EQUALS <- "="
        this.SPACE <- " "
        this.COMMA <- ","
        this.COLON <- ":"
        this.PERIOD <- "."
        this.UNDERSCORE <- "_"
        this.COLON_SEP <- (new StringMaker()).append(this.COLON).append(this.SPACE).ToString()
        this.COMMA_SEP <- (new StringMaker()).append(this.COMMA).append(this.SPACE).ToString()
        this.PARENTHESIS_OPEN <- "("
        this.PARENTHESIS_CLOSE <- ")"
        this.BRACE_OPEN <- "{"
        this.BRACE_CLOSE <- "}"
        this.BRACKET_OPEN <- "["
        this.BRACKET_CLOSE <- "]"
        this.DASH <- "-"
        this.PERCENT <- "%"
        this.AMPERSAND <- "&"
        this.FORWARD_SLASH <- "/"
        this.BACK_SLASH <- "\\"
        this.QUESTION <- "?"
        this.QUOTE <- "\""
        this.QUOTE_END <- "\","
        this.COMMENT <- "//"
        this.INDENT <- "    "
        ()
    
    static member getInstance() : CommonSeps =
        CommonSeps.instance


