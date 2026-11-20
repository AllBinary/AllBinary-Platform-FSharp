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
type TextItemNumberVisitor =
    inherit Visitor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextItemNumberVisitor.jclinitDone then
            TextItemNumberVisitor.jclinitDone <- true
            TextItemNumberVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TextItemNumberVisitor() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        { inherit Visitor() }
        then
            this.jfields_TextItemNumberVisitor()
    
    override this.visit(anyType: obj) : obj =
        let mutable jflow = 0
        let mutable jret : obj = Unchecked.defaultof<obj>
        let mutable value : string = (box (anyType) :?> string)
        if JString.length(value) < 2 then
            let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
            if stringValidationUtil.isNumber(value) then
                jret <- BooleanFactory.getInstance().TRUE
                jflow <- 1
            else
                try
                    TextNotificationUtil.getInstance().fireError("Numbers Only")
                with jex ->
                    match JR.throwable(jex) with
                    | :? JException as e ->
                        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                        this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.VISIT, e)
                    | _ -> reraise ()
                jret <- BooleanFactory.getInstance().FALSE
                jflow <- 1
        else
            jret <- BooleanFactory.getInstance().FALSE
            jflow <- 1
        jret


