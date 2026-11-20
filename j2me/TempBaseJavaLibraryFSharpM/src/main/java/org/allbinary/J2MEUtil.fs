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
type J2MEUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not J2MEUtil.jclinitDone then
            J2MEUtil.jclinitDone <- true
            J2MEUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member isJ2ME() : bool =
        false
    
    static member isJ2SE() : bool =
        false
    
    static member isHTML() : bool =
        false


