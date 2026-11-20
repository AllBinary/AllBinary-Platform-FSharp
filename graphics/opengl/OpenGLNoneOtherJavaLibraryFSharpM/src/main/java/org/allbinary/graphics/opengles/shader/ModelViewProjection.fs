namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type ModelViewProjection =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ModelViewProjection
    static member instance with get() : ModelViewProjection = (ModelViewProjection.jclinit(); ModelViewProjection.jcell_instance) and set (jvalue: ModelViewProjection) = (ModelViewProjection.jclinit(); ModelViewProjection.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ModelViewProjection.jclinitDone then
            ModelViewProjection.jclinitDone <- true
            ModelViewProjection.jclinitBody()
    static member private jclinitBody() : unit =
        ModelViewProjection.jcell_instance <- (new ModelViewProjection())
        ()
    new () =
        {  }
    
    static member getInstance() : ModelViewProjection =
        ModelViewProjection.instance
    
    abstract get : unit -> float32[]
    default this.get() : float32[] =
        NullUtil.getInstance().NULL_FLOAT_ARRAY


