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
type StringValidationJSEUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StringValidationJSEUtil.jclinitDone then
            StringValidationJSEUtil.jclinitDone <- true
            StringValidationJSEUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member isBlank(string_: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable len : int = JString.length(string_)
        let mutable i : int = 0
        while jflow = 0 && (i < len) do
            let mutable c : char = JString.charAt(string_, i)
            if Character.isWhitespace(c) = false then
                jret <- false
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then i <- i + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret


