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
type ThrustAIVisitorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThrustAIVisitor
    static member instance with get() : ThrustAIVisitor = (ThrustAIVisitorFactory.jclinit(); ThrustAIVisitorFactory.jcell_instance) and set (jvalue: ThrustAIVisitor) = (ThrustAIVisitorFactory.jclinit(); ThrustAIVisitorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThrustAIVisitorFactory.jclinitDone then
            ThrustAIVisitorFactory.jclinitDone <- true
            ThrustAIVisitorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ThrustAIVisitorFactory.jcell_instance <- (new ThrustAIVisitor())
        ()
    new () =
        {  }
    
    static member getInstance() : ThrustAIVisitor =
        ThrustAIVisitorFactory.instance


