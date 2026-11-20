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
type AllBinaryRenderer =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AllBinaryRenderer
    static member instance with get() : AllBinaryRenderer = (AllBinaryRenderer.jclinit(); AllBinaryRenderer.jcell_instance) and set (jvalue: AllBinaryRenderer) = (AllBinaryRenderer.jclinit(); AllBinaryRenderer.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryRenderer.jclinitDone then
            AllBinaryRenderer.jclinitDone <- true
            AllBinaryRenderer.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryRenderer.jcell_instance <- (new AllBinaryRenderer())
        ()
    new () =
        {  }
    
    static member getInstance() : AllBinaryRenderer =
        AllBinaryRenderer.instance
    
    abstract setRunnable : runnable: Runnable -> unit
    default this.setRunnable(runnable: Runnable) : unit =
        ()
    
    abstract clearRunnable : unit -> unit
    default this.clearRunnable() : unit =
        ()


