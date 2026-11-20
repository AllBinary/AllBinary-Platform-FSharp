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
type NullInitUpdatePaintable =
    inherit InitUpdatePaintable
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NullInitUpdatePaintable
    static member SINGLETON with get() : NullInitUpdatePaintable = (NullInitUpdatePaintable.jclinit(); NullInitUpdatePaintable.jcell_SINGLETON) and set (jvalue: NullInitUpdatePaintable) = (NullInitUpdatePaintable.jclinit(); NullInitUpdatePaintable.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullInitUpdatePaintable.jclinitDone then
            NullInitUpdatePaintable.jclinitDone <- true
            NullInitUpdatePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        NullInitUpdatePaintable.jcell_SINGLETON <- (new NullInitUpdatePaintable())
        ()
    
    new () =
        { inherit InitUpdatePaintable() }
    
    static member getInstance() : InitUpdatePaintable =
        NullInitUpdatePaintable.SINGLETON


