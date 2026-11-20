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
type NullPaintable =
    inherit Paintable
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NullPaintable
    static member SINGLETON with get() : NullPaintable = (NullPaintable.jclinit(); NullPaintable.jcell_SINGLETON) and set (jvalue: NullPaintable) = (NullPaintable.jclinit(); NullPaintable.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullPaintable.jclinitDone then
            NullPaintable.jclinitDone <- true
            NullPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        NullPaintable.jcell_SINGLETON <- (new NullPaintable())
        ()
    
    new () =
        { inherit Paintable() }
    
    static member getInstance() : Paintable =
        NullPaintable.SINGLETON


