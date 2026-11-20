namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullEmulatorView =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_EMULATOR_VIEW : NullEmulatorView
    static member NULL_EMULATOR_VIEW with get() : NullEmulatorView = (NullEmulatorView.jclinit(); NullEmulatorView.jcell_NULL_EMULATOR_VIEW) and set (jvalue: NullEmulatorView) = (NullEmulatorView.jclinit(); NullEmulatorView.jcell_NULL_EMULATOR_VIEW <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullEmulatorView.jclinitDone then
            NullEmulatorView.jclinitDone <- true
            NullEmulatorView.jclinitBody()
    static member private jclinitBody() : unit =
        NullEmulatorView.jcell_NULL_EMULATOR_VIEW <- (new NullEmulatorView())
        ()
    new () =
        {  }
    
    abstract setMidlet : midlet: MIDlet -> unit
    default this.setMidlet(midlet: MIDlet) : unit =
        ()
    
    abstract onEmulatorInitComplete : midletActivity: obj -> unit
    default this.onEmulatorInitComplete(midletActivity: obj) : unit =
        ()
    
    abstract onSetDisplayable : displayable: Displayable -> unit
    default this.onSetDisplayable(displayable: Displayable) : unit =
        ()
    interface EmulatorViewInterface with
        member this.setMidlet(jp0: MIDlet) : unit = this.setMidlet(jp0)
        member this.onEmulatorInitComplete(jp0: obj) : unit = this.onEmulatorInitComplete(jp0)
        member this.onSetDisplayable(jp0: Displayable) : unit = this.onSetDisplayable(jp0)


