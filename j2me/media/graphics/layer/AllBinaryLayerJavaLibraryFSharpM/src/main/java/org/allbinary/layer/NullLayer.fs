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
type NullLayer =
    inherit Layer
    [<DefaultValue(false)>] static val mutable private jcell_instance : NullLayer
    static member instance with get() : NullLayer = (NullLayer.jclinit(); NullLayer.jcell_instance) and set (jvalue: NullLayer) = (NullLayer.jclinit(); NullLayer.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullLayer.jclinitDone then
            NullLayer.jclinitDone <- true
            NullLayer.jclinitBody()
    static member private jclinitBody() : unit =
        NullLayer.jcell_instance <- (new NullLayer())
        ()
    
    static member getInstance() : NullLayer =
        NullLayer.instance
    
    new () =
        { inherit Layer(0, 0) }
    
    override this.paint(graphics: Graphics) : unit =
        ()


