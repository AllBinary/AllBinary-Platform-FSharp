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
type AnimationEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_eventHandler : AnimationEventHandler
    static member eventHandler with get() : AnimationEventHandler = (AnimationEventHandler.jclinit(); AnimationEventHandler.jcell_eventHandler) and set (jvalue: AnimationEventHandler) = (AnimationEventHandler.jclinit(); AnimationEventHandler.jcell_eventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationEventHandler.jclinitDone then
            AnimationEventHandler.jclinitDone <- true
            AnimationEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationEventHandler.jcell_eventHandler <- (new AnimationEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : AnimationEventHandler =
        AnimationEventHandler.eventHandler


