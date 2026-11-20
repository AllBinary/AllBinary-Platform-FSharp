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
type BoundsChangeEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : BasicEventHandler
    static member SINGLETON with get() : BasicEventHandler = (BoundsChangeEventHandler.jclinit(); BoundsChangeEventHandler.jcell_SINGLETON) and set (jvalue: BasicEventHandler) = (BoundsChangeEventHandler.jclinit(); BoundsChangeEventHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BoundsChangeEventHandler.jclinitDone then
            BoundsChangeEventHandler.jclinitDone <- true
            BoundsChangeEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        BoundsChangeEventHandler.jcell_SINGLETON <- (new BoundsChangeEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : BasicEventHandler =
        BoundsChangeEventHandler.SINGLETON
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable boundsChangeEventListener : BoundsChangeEventListener = (box (eventListenerInterface) :?> BoundsChangeEventListener)
        boundsChangeEventListener.onBoundsChangeEvent((box (eventObject) :?> BoundsChangeEvent))


