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
type GameAdState =
    inherit GameAdStateBase
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameAdState.jclinitDone then
            GameAdState.jclinitDone <- true
            GameAdState.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (adConfiguration: AdConfiguration) as this =
        { inherit GameAdStateBase(adConfiguration) }
        then
            this.jctor1(adConfiguration)
    member this.jctor1(adConfiguration: AdConfiguration) : unit =
        ()
        VirtualKeyboardEventHandler.getInstance().addListenerInterface(this)
        ()
    
    abstract onVirtualKeyboardEvent : virtualKeyboardEvent: VirtualKeyboardEvent -> unit
    default this.onVirtualKeyboardEvent(virtualKeyboardEvent: VirtualKeyboardEvent) : unit =
        ()
    
    override this.onEvent(eventObject: AllBinaryEventObject) : unit =
        base.onEvent(eventObject)
    interface VirtualKeyboardEventListenerInterface with
        member this.onVirtualKeyboardEvent(jp0: VirtualKeyboardEvent) : unit = this.onVirtualKeyboardEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


