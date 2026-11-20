namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type VectorUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : VectorUtil
    static member instance with get() : VectorUtil = (VectorUtil.jclinit(); VectorUtil.jcell_instance) and set (jvalue: VectorUtil) = (VectorUtil.jclinit(); VectorUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorUtil.jclinitDone then
            VectorUtil.jclinitDone <- true
            VectorUtil.jclinitBody()
    static member private jclinitBody() : unit =
        VectorUtil.jcell_instance <- (new VectorUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : VectorUtil =
        VectorUtil.instance
    
    abstract getSize : anyType: obj -> int
    default this.getSize(anyType: obj) : int =
        let mutable vector : Vector = (box (anyType) :?> Vector)
        vector.size()
    
    abstract elementAt : anyType: obj * index: int -> obj
    default this.elementAt(anyType: obj, index: int) : obj =
        let mutable vector : Vector = (box (anyType) :?> Vector)
        vector.elementAt(index)


