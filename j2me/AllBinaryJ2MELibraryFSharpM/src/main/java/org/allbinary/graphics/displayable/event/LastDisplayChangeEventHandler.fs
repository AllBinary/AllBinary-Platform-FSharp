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
type LastDisplayChangeEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : LastDisplayChangeEventHandler
    static member SINGLETON with get() : LastDisplayChangeEventHandler = (LastDisplayChangeEventHandler.jclinit(); LastDisplayChangeEventHandler.jcell_SINGLETON) and set (jvalue: LastDisplayChangeEventHandler) = (LastDisplayChangeEventHandler.jclinit(); LastDisplayChangeEventHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LastDisplayChangeEventHandler.jclinitDone then
            LastDisplayChangeEventHandler.jclinitDone <- true
            LastDisplayChangeEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        LastDisplayChangeEventHandler.jcell_SINGLETON <- (new LastDisplayChangeEventHandler())
        ()
    
    static member getInstance() : LastDisplayChangeEventHandler =
        LastDisplayChangeEventHandler.SINGLETON
    
    new () =
        { inherit BasicEventHandler() }
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable displayChangeEventListener : DisplayChangeEventListener = ((box (eventListenerInterface) :?> DisplayChangeEventListener))
        displayChangeEventListener.onDisplayChangeEvent((box (eventObject) :?> DisplayChangeEvent))


