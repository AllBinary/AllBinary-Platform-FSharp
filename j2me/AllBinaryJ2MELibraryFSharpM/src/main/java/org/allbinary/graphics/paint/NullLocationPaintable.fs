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
type NullLocationPaintable =
    inherit LocationPaintable
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : NullLocationPaintable
    static member instanceC with get() : NullLocationPaintable = (NullLocationPaintable.jclinit(); NullLocationPaintable.jcell_instanceC) and set (jvalue: NullLocationPaintable) = (NullLocationPaintable.jclinit(); NullLocationPaintable.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullLocationPaintable.jclinitDone then
            NullLocationPaintable.jclinitDone <- true
            NullLocationPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        NullLocationPaintable.jcell_instanceC <- (new NullLocationPaintable())
        ()
    new () =
        { inherit LocationPaintable() }
    
    static member getInstance() : NullLocationPaintable =
        NullLocationPaintable.instanceC


