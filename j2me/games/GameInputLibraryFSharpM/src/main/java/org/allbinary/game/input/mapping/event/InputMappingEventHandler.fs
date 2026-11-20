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
type InputMappingEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : InputMappingEventHandler
    static member gameKeyEventHandler with get() : InputMappingEventHandler = (InputMappingEventHandler.jclinit(); InputMappingEventHandler.jcell_gameKeyEventHandler) and set (jvalue: InputMappingEventHandler) = (InputMappingEventHandler.jclinit(); InputMappingEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputMappingEventHandler.jclinitDone then
            InputMappingEventHandler.jclinitDone <- true
            InputMappingEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        InputMappingEventHandler.jcell_gameKeyEventHandler <- (new InputMappingEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : InputMappingEventHandler =
        InputMappingEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable inputMappingEventListenerInterface : InputMappingEventListenerInterface = (box (eventListenerInterface) :?> InputMappingEventListenerInterface)
        inputMappingEventListenerInterface.onInputMappingEvent((box (eventObject) :?> InputMappingEvent))


