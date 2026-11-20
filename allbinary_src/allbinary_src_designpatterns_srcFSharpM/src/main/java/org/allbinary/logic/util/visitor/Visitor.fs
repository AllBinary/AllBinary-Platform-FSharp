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
type Visitor =
    [<DefaultValue(false)>] val mutable nullUtil : NullUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : Visitor
    static member instance with get() : Visitor = (Visitor.jclinit(); Visitor.jcell_instance) and set (jvalue: Visitor) = (Visitor.jclinit(); Visitor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Visitor.jclinitDone then
            Visitor.jclinitDone <- true
            Visitor.jclinitBody()
    static member private jclinitBody() : unit =
        Visitor.jcell_instance <- (new Visitor())
        ()
    new () as this =
        {  }
        then
            this.jfields_Visitor()
    member this.jfields_Visitor() : unit =
        this.nullUtil <- NullUtil.getInstance()
        ()
    
    abstract visit : anyType: obj -> obj
    default this.visit(anyType: obj) : obj =
        this.nullUtil.NULL_OBJECT
    
    static member getInstance() : Visitor =
        Visitor.instance
    interface VisitorInterface with
        member this.visit(jp0: obj) : obj = this.visit(jp0)


