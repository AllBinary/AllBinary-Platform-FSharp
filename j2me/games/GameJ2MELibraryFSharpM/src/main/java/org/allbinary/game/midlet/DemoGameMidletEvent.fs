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
type DemoGameMidletEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable demoGameMidletState : DemoGameMidletState
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameMidletEvent.jclinitDone then
            DemoGameMidletEvent.jclinitDone <- true
            DemoGameMidletEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (anyType: obj, demoGameMidletState: DemoGameMidletState) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jctor1(anyType, demoGameMidletState)
    member this.jctor1(anyType: obj, demoGameMidletState: DemoGameMidletState) : unit =
        ()
        this.demoGameMidletState <- demoGameMidletState
        ()
    
    abstract init : anyType: obj -> unit
    default this.init(anyType: obj) : unit =
        this.setSource(anyType)
    
    abstract setDemoGameMidletState : demoGameMidletState: DemoGameMidletState -> unit
    default this.setDemoGameMidletState(demoGameMidletState: DemoGameMidletState) : unit =
        this.demoGameMidletState <- demoGameMidletState
    
    abstract getDemoGameMidletState : unit -> DemoGameMidletState
    default this.getDemoGameMidletState() : DemoGameMidletState =
        this.demoGameMidletState


