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
type Anchor =
    [<DefaultValue(false)>] static val mutable private jcell_TOP_LEFT : int
    static member TOP_LEFT with get() : int = (Anchor.jclinit(); Anchor.jcell_TOP_LEFT) and set (jvalue: int) = (Anchor.jclinit(); Anchor.jcell_TOP_LEFT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Anchor.jclinitDone then
            Anchor.jclinitDone <- true
            Anchor.jclinitBody()
    static member private jclinitBody() : unit =
        Anchor.jcell_TOP_LEFT <- Graphics.TOP &&& Graphics.LEFT
        ()
    new () =
        {  }


