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
type UpKeyEventHandler =
    inherit UpKeyEventHandlerBase
    [<DefaultValue(false)>] val mutable playerInputIdFactory : LocalPlayerInputIdFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : UpKeyEventHandler
    static member instance with get() : UpKeyEventHandler = (UpKeyEventHandler.jclinit(); UpKeyEventHandler.jcell_instance) and set (jvalue: UpKeyEventHandler) = (UpKeyEventHandler.jclinit(); UpKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_instanceArray : UpKeyEventHandlerBase[]
    static member instanceArray with get() : UpKeyEventHandlerBase[] = (UpKeyEventHandler.jclinit(); UpKeyEventHandler.jcell_instanceArray) and set (jvalue: UpKeyEventHandlerBase[]) = (UpKeyEventHandler.jclinit(); UpKeyEventHandler.jcell_instanceArray <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpKeyEventHandler.jclinitDone then
            UpKeyEventHandler.jclinitDone <- true
            UpKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        UpKeyEventHandler.jcell_instance <- (new UpKeyEventHandler())
        UpKeyEventHandler.jcell_instanceArray <- ([| (new UpKeyEventHandlerBase()); (new UpKeyEventHandlerBase()); (new UpKeyEventHandlerBase()); (new UpKeyEventHandlerBase()); (new UpKeyEventHandlerBase()); (new UpKeyEventHandlerBase()) |] : UpKeyEventHandlerBase[])
        ()
    member this.jfields_UpKeyEventHandler() : unit =
        this.playerInputIdFactory <- LocalPlayerInputIdFactory.getInstance()
        ()
    
    static member getInstance() : UpKeyEventHandler =
        UpKeyEventHandler.instance
    
    abstract getInstanceForDevice : deviceId: int -> UpKeyEventHandlerBase
    default this.getInstanceForDevice(deviceId: int) : UpKeyEventHandlerBase =
        let mutable playerInputId : int = this.playerInputIdFactory.getPlayerForDevice(deviceId)
        UpKeyEventHandler.instanceArray.[playerInputId]
    
    abstract getInstanceForPlayer : playerInputId: int -> UpKeyEventHandlerBase
    default this.getInstanceForPlayer(playerInputId: int) : UpKeyEventHandlerBase =
        UpKeyEventHandler.instanceArray.[playerInputId]
    
    new () as this =
        { inherit UpKeyEventHandlerBase() }
        then
            this.jfields_UpKeyEventHandler()
    
    override this.removeAllListeners() : unit =
        base.removeAllListeners()
        let mutable index : int = UpKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpKeyEventHandler.instanceArray.[index].removeAllListeners()
            index <- index - 1
    
    override this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListenerSingleThreaded(eventListenerInterface)
        let mutable index : int = UpKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpKeyEventHandler.instanceArray.[index].removeListenerSingleThreaded(eventListenerInterface)
            index <- index - 1
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListener(eventListenerInterface)
        let mutable index : int = UpKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpKeyEventHandler.instanceArray.[index].removeListener(eventListenerInterface)
            index <- index - 1


