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
type ProcessPaintableSingletonFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : ProcessPaintable
    static member SINGLETON with get() : ProcessPaintable = (ProcessPaintableSingletonFactory.jclinit(); ProcessPaintableSingletonFactory.jcell_SINGLETON) and set (jvalue: ProcessPaintable) = (ProcessPaintableSingletonFactory.jclinit(); ProcessPaintableSingletonFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ProcessPaintableSingletonFactory.jclinitDone then
            ProcessPaintableSingletonFactory.jclinitDone <- true
            ProcessPaintableSingletonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ProcessPaintableSingletonFactory.jcell_SINGLETON <- (new ProcessPaintable())
        ()
    
    new () =
        {  }
    
    static member getInstance() : ProcessPaintable =
        ProcessPaintableSingletonFactory.SINGLETON


