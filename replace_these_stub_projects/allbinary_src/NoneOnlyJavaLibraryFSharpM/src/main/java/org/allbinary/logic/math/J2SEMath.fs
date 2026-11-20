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
type J2SEMath =
    [<DefaultValue(false)>] static val mutable private jcell_instance : J2SEMath
    static member instance with get() : J2SEMath = (J2SEMath.jclinit(); J2SEMath.jcell_instance) and set (jvalue: J2SEMath) = (J2SEMath.jclinit(); J2SEMath.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not J2SEMath.jclinitDone then
            J2SEMath.jclinitDone <- true
            J2SEMath.jclinitBody()
    static member private jclinitBody() : unit =
        J2SEMath.jcell_instance <- (new J2SEMath())
        ()
    new () =
        {  }
    
    static member getInstance() : J2SEMath =
        J2SEMath.instance
    
    abstract round : value: float32 -> int
    default this.round(value: float32) : int =
        JMath.round(value)
    
    abstract abs : value: float32 -> float32
    default this.abs(value: float32) : float32 =
        (if (value < 0.0f) then -(value) else value)
    
    abstract absdouble : value: float -> float
    default this.absdouble(value: float) : float =
        (if (value < 0.0) then -(value) else value)


