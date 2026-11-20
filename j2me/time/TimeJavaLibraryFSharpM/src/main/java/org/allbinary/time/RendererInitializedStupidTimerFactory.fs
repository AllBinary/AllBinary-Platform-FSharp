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
type RendererInitializedStupidTimerFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : StupidTimer
    static member instance with get() : StupidTimer = (RendererInitializedStupidTimerFactory.jclinit(); RendererInitializedStupidTimerFactory.jcell_instance) and set (jvalue: StupidTimer) = (RendererInitializedStupidTimerFactory.jclinit(); RendererInitializedStupidTimerFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RendererInitializedStupidTimerFactory.jclinitDone then
            RendererInitializedStupidTimerFactory.jclinitDone <- true
            RendererInitializedStupidTimerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        RendererInitializedStupidTimerFactory.jcell_instance <- (new StupidTimer())
        ()
    new () =
        {  }
    
    static member getInstance() : StupidTimer =
        RendererInitializedStupidTimerFactory.instance


