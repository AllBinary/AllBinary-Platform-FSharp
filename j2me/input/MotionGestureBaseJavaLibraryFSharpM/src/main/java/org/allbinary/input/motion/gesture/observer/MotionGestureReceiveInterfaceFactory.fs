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
type MotionGestureReceiveInterfaceFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureReceiveInterfaceFactory.jclinitDone then
            MotionGestureReceiveInterfaceFactory.jclinitDone <- true
            MotionGestureReceiveInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstance() : CompleteMotionGestureListenerInterface =
        let mutable jflow = 0
        let mutable jret : CompleteMotionGestureListenerInterface = Unchecked.defaultof<CompleteMotionGestureListenerInterface>
        let mutable configuration : MotionGestureConfiguration = MotionGestureConfigurationFactory.getInstance()
        if not (configuration.isExecutingActionsAllowed()) then
            jret <- (new NullCompleteMotionGestureReceiver())
            jflow <- 1
        else
            jret <- (new ResolveCompleteMotionGestureListener())
            jflow <- 1
        jret


