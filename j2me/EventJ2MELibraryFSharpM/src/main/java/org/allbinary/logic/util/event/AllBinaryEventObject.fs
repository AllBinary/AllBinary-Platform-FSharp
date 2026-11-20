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
type AllBinaryEventObject =
    [<DefaultValue(false)>] val mutable source : obj
    [<DefaultValue(false)>] static val mutable private jcell_NULL_EVENT : AllBinaryEventObject
    static member NULL_EVENT with get() : AllBinaryEventObject = (AllBinaryEventObject.jclinit(); AllBinaryEventObject.jcell_NULL_EVENT) and set (jvalue: AllBinaryEventObject) = (AllBinaryEventObject.jclinit(); AllBinaryEventObject.jcell_NULL_EVENT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryEventObject.jclinitDone then
            AllBinaryEventObject.jclinitDone <- true
            AllBinaryEventObject.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryEventObject.jcell_NULL_EVENT <- (new AllBinaryEventObject(NullUtil.getInstance().NULL_OBJECT))
        ()
    
    new (anyType: obj) as this =
        {  }
        then
            this.jctor1(anyType)
    member this.jctor1(anyType: obj) : unit =
        this.source <- anyType
        ()
    
    abstract getSource : unit -> obj
    default this.getSource() : obj =
        this.source
    
    abstract setSource : source: obj -> unit
    default this.setSource(source: obj) : unit =
        this.source <- source


