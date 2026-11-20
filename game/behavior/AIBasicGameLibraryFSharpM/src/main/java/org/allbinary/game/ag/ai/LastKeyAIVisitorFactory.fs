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
type LastKeyAIVisitorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LastKeyAIVisitor
    static member instance with get() : LastKeyAIVisitor = (LastKeyAIVisitorFactory.jclinit(); LastKeyAIVisitorFactory.jcell_instance) and set (jvalue: LastKeyAIVisitor) = (LastKeyAIVisitorFactory.jclinit(); LastKeyAIVisitorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LastKeyAIVisitorFactory.jclinitDone then
            LastKeyAIVisitorFactory.jclinitDone <- true
            LastKeyAIVisitorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LastKeyAIVisitorFactory.jcell_instance <- (new LastKeyAIVisitor())
        ()
    new () =
        {  }
    
    static member getInstance() : LastKeyAIVisitor =
        LastKeyAIVisitorFactory.instance


