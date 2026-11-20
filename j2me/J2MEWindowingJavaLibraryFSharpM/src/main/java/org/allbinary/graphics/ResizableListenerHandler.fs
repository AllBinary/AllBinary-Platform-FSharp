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
type ResizableListenerHandler =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ResizableListenerHandler
    static member instance with get() : ResizableListenerHandler = (ResizableListenerHandler.jclinit(); ResizableListenerHandler.jcell_instance) and set (jvalue: ResizableListenerHandler) = (ResizableListenerHandler.jclinit(); ResizableListenerHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResizableListenerHandler.jclinitDone then
            ResizableListenerHandler.jclinitDone <- true
            ResizableListenerHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ResizableListenerHandler.jcell_instance <- (new ResizableListenerHandler())
        ()
    new () =
        {  }
    
    static member getInstance() : ResizableListenerHandler =
        ResizableListenerHandler.instance
    
    abstract setListener : resizableListenerInterface: ResizableListenerInterface -> unit
    default this.setListener(resizableListenerInterface: ResizableListenerInterface) : unit =
        ()
    
    abstract fire : isFullScreen: bool -> unit
    default this.fire(isFullScreen: bool) : unit =
        ()
    
    abstract fireEvent : value: bool -> unit
    default this.fireEvent(value: bool) : unit =
        ()


