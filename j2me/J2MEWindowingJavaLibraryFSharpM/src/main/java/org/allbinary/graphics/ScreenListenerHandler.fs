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
type ScreenListenerHandler =
    [<DefaultValue(false)>] val mutable screenListenerInterface : ScreenListenerInterface
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScreenListenerHandler
    static member instance with get() : ScreenListenerHandler = (ScreenListenerHandler.jclinit(); ScreenListenerHandler.jcell_instance) and set (jvalue: ScreenListenerHandler) = (ScreenListenerHandler.jclinit(); ScreenListenerHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenListenerHandler.jclinitDone then
            ScreenListenerHandler.jclinitDone <- true
            ScreenListenerHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ScreenListenerHandler.jcell_instance <- (new ScreenListenerHandler())
        ()
    new () as this =
        {  }
        then
            this.jfields_ScreenListenerHandler()
    member this.jfields_ScreenListenerHandler() : unit =
        this.screenListenerInterface <- (new ScreenEmptyListener())
        ()
    
    static member getInstance() : ScreenListenerHandler =
        ScreenListenerHandler.instance
    
    abstract setListener : screenListenerInterface: ScreenListenerInterface -> unit
    default this.setListener(screenListenerInterface: ScreenListenerInterface) : unit =
        this.screenListenerInterface <- screenListenerInterface
    
    abstract fireWithState : isFullScreen: bool -> unit
    default this.fireWithState(isFullScreen: bool) : unit =
        this.screenListenerInterface.onFullScreen(isFullScreen)
    
    abstract fire : unit -> unit
    default this.fire() : unit =
        this.screenListenerInterface.onFullScreenDisplay()


