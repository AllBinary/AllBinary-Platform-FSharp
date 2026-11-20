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
type TextItemVisitor =
    inherit Visitor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextItemVisitor.jclinitDone then
            TextItemVisitor.jclinitDone <- true
            TextItemVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit Visitor() }
    
    override this.visit(anyType: obj) : obj =
        let mutable jflow = 0
        let mutable jret : obj = Unchecked.defaultof<obj>
        let mutable value : string = (box (anyType) :?> string)
        if JString.length(value) < 2 then
            jret <- BooleanFactory.getInstance().TRUE
            jflow <- 1
        else
            jret <- BooleanFactory.getInstance().FALSE
            jflow <- 1
        jret


