namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type DisplayPointScalar =
    [<DefaultValue(false)>] static val mutable private jcell_instance : DisplayPointScalar
    static member instance with get() : DisplayPointScalar = (DisplayPointScalar.jclinit(); DisplayPointScalar.jcell_instance) and set (jvalue: DisplayPointScalar) = (DisplayPointScalar.jclinit(); DisplayPointScalar.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DisplayPointScalar.jclinitDone then
            DisplayPointScalar.jclinitDone <- true
            DisplayPointScalar.jclinitBody()
    static member private jclinitBody() : unit =
        DisplayPointScalar.jcell_instance <- (new DisplayPointScalar())
        ()
    
    static member getInstance() : DisplayPointScalar =
        DisplayPointScalar.instance
    
    new () =
        {  }
    
    abstract processX : value: int -> int
    default this.processX(value: int) : int =
        value
    
    abstract processY : value: int -> int
    default this.processY(value: int) : int =
        value
    
    abstract process_ : point: GPoint -> GPoint
    default this.process_(point: GPoint) : GPoint =
        point


