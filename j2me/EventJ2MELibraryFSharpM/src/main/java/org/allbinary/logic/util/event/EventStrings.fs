namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type EventStrings =
    [<DefaultValue(false)>] val mutable PERFORMANCE_MESSAGE : string
    [<DefaultValue(false)>] val mutable TOTAL_LISTENERS : string
    [<DefaultValue(false)>] val mutable LISTENER_LABEL : string
    [<DefaultValue(false)>] val mutable FIRE_EVENT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : EventStrings
    static member instance with get() : EventStrings = (EventStrings.jclinit(); EventStrings.jcell_instance) and set (jvalue: EventStrings) = (EventStrings.jclinit(); EventStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EventStrings.jclinitDone then
            EventStrings.jclinitDone <- true
            EventStrings.jclinitBody()
    static member private jclinitBody() : unit =
        EventStrings.jcell_instance <- (new EventStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_EventStrings()
    member this.jfields_EventStrings() : unit =
        this.PERFORMANCE_MESSAGE <- "Use Custom onEvent Methods for needed optimization"
        this.TOTAL_LISTENERS <- "Total Listeners: "
        this.LISTENER_LABEL <- " Listener: "
        this.FIRE_EVENT <- "fireEvent"
        ()
    
    static member getInstance() : EventStrings =
        EventStrings.instance


