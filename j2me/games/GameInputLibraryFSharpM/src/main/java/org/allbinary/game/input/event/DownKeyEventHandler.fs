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
type DownKeyEventHandler =
    inherit DownKeyEventHandlerBase
    [<DefaultValue(false)>] val mutable playerInputIdFactory : LocalPlayerInputIdFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : DownKeyEventHandler
    static member instance with get() : DownKeyEventHandler = (DownKeyEventHandler.jclinit(); DownKeyEventHandler.jcell_instance) and set (jvalue: DownKeyEventHandler) = (DownKeyEventHandler.jclinit(); DownKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_instanceArray : DownKeyEventHandlerBase[]
    static member instanceArray with get() : DownKeyEventHandlerBase[] = (DownKeyEventHandler.jclinit(); DownKeyEventHandler.jcell_instanceArray) and set (jvalue: DownKeyEventHandlerBase[]) = (DownKeyEventHandler.jclinit(); DownKeyEventHandler.jcell_instanceArray <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DownKeyEventHandler.jclinitDone then
            DownKeyEventHandler.jclinitDone <- true
            DownKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        DownKeyEventHandler.jcell_instance <- (new DownKeyEventHandler())
        DownKeyEventHandler.jcell_instanceArray <- ([| (new DownKeyEventHandlerBase()); (new DownKeyEventHandlerBase()); (new DownKeyEventHandlerBase()); (new DownKeyEventHandlerBase()); (new DownKeyEventHandlerBase()); (new DownKeyEventHandlerBase()) |] : DownKeyEventHandlerBase[])
        ()
    member this.jfields_DownKeyEventHandler() : unit =
        this.playerInputIdFactory <- LocalPlayerInputIdFactory.getInstance()
        ()
    
    static member getInstance() : DownKeyEventHandler =
        DownKeyEventHandler.instance
    
    abstract getInstanceForDevice : deviceId: int -> DownKeyEventHandlerBase
    default this.getInstanceForDevice(deviceId: int) : DownKeyEventHandlerBase =
        let mutable playerInputId : int = this.playerInputIdFactory.getPlayerForDevice(deviceId)
        DownKeyEventHandler.instanceArray.[playerInputId]
    
    abstract getInstanceForPlayer : playerInputId: int -> DownKeyEventHandlerBase
    default this.getInstanceForPlayer(playerInputId: int) : DownKeyEventHandlerBase =
        DownKeyEventHandler.instanceArray.[playerInputId]
    
    new () as this =
        { inherit DownKeyEventHandlerBase() }
        then
            this.jfields_DownKeyEventHandler()
    
    override this.removeAllListeners() : unit =
        base.removeAllListeners()
        let mutable index : int = DownKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownKeyEventHandler.instanceArray.[index].removeAllListeners()
            index <- index - 1
    
    override this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListenerSingleThreaded(eventListenerInterface)
        let mutable index : int = DownKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownKeyEventHandler.instanceArray.[index].removeListenerSingleThreaded(eventListenerInterface)
            index <- index - 1
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListener(eventListenerInterface)
        let mutable index : int = DownKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownKeyEventHandler.instanceArray.[index].removeListener(eventListenerInterface)
            index <- index - 1


