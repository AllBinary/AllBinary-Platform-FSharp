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
type ScreenEmptyListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenEmptyListener.jclinitDone then
            ScreenEmptyListener.jclinitDone <- true
            ScreenEmptyListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onFullScreen : isFullScreen: bool -> unit
    default this.onFullScreen(isFullScreen: bool) : unit =
        ()
    
    abstract onFullScreenDisplay : unit -> unit
    default this.onFullScreenDisplay() : unit =
        ()
    interface ScreenListenerInterface with
        member this.onFullScreen(jp0: bool) : unit = this.onFullScreen(jp0)
        member this.onFullScreenDisplay() : unit = this.onFullScreenDisplay()


