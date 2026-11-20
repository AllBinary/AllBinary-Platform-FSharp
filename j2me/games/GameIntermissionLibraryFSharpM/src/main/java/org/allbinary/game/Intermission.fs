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
type Intermission =
    [<DefaultValue(false)>] val mutable enabled : bool
    [<DefaultValue(false)>] val mutable timeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable intermissionEnableListener : IntermissionEnableListenerInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Intermission.jclinitDone then
            Intermission.jclinitDone <- true
            Intermission.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Intermission() : unit =
        this.timeElapsedHelper <- (new TimeDelayHelper(0))
        this.intermissionEnableListener <- NullIntermissionEnableListener.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_Intermission()
    
    abstract setListener : enableListener: IntermissionEnableListenerInterface -> unit
    default this.setListener(enableListener: IntermissionEnableListenerInterface) : unit =
        this.intermissionEnableListener <- enableListener
    
    abstract getTimeDelayHelper : unit -> TimeDelayHelper
    default this.getTimeDelayHelper() : TimeDelayHelper =
        this.timeElapsedHelper
    
    abstract setEnabled : enabled: bool -> unit
    default this.setEnabled(enabled: bool) : unit =
        this.enabled <- enabled
        if this.isEnabled() then
            this.getTimeDelayHelper().setStartTimeTNT()
        this.intermissionEnableListener.notifyIntermission(enabled)
    
    abstract isEnabled : unit -> bool
    default this.isEnabled() : bool =
        this.enabled
    interface IntermissionInterface with
        member this.getTimeDelayHelper() : TimeDelayHelper = this.getTimeDelayHelper()
        member this.isEnabled() : bool = this.isEnabled()
        member this.setEnabled(jp0: bool) : unit = this.setEnabled(jp0)
        member this.setListener(jp0: IntermissionEnableListenerInterface) : unit = this.setListener(jp0)


