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
type LastKeyAIVisitor =
    inherit Visitor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable TRUE : Boolean
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LastKeyAIVisitor.jclinitDone then
            LastKeyAIVisitor.jclinitDone <- true
            LastKeyAIVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LastKeyAIVisitor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.TRUE <- BooleanFactory.getInstance().TRUE
        ()
    
    new () as this =
        { inherit Visitor() }
        then
            this.jfields_LastKeyAIVisitor()
    
    override this.visit(anyType: obj) : obj =
        try
            let mutable basicAI : BasicAI = (box (anyType) :?> BasicAI)
            let mutable key : int = basicAI.getLastKey()
            if key <> (-1) then
                basicAI.processKeyAI(key)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.VISIT, e)
            | _ -> reraise ()
        this.TRUE


