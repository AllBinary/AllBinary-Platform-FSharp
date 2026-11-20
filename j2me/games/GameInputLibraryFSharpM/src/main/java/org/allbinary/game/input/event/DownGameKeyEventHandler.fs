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
type DownGameKeyEventHandler =
    inherit DownGameKeyEventHandlerBase
    [<DefaultValue(false)>] val mutable playerInputIdFactory : LocalPlayerInputIdFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : DownGameKeyEventHandler
    static member instance with get() : DownGameKeyEventHandler = (DownGameKeyEventHandler.jclinit(); DownGameKeyEventHandler.jcell_instance) and set (jvalue: DownGameKeyEventHandler) = (DownGameKeyEventHandler.jclinit(); DownGameKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_instanceArray : DownGameKeyEventHandlerBase[]
    static member instanceArray with get() : DownGameKeyEventHandlerBase[] = (DownGameKeyEventHandler.jclinit(); DownGameKeyEventHandler.jcell_instanceArray) and set (jvalue: DownGameKeyEventHandlerBase[]) = (DownGameKeyEventHandler.jclinit(); DownGameKeyEventHandler.jcell_instanceArray <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DownGameKeyEventHandler.jclinitDone then
            DownGameKeyEventHandler.jclinitDone <- true
            DownGameKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        DownGameKeyEventHandler.jcell_instance <- (new DownGameKeyEventHandler())
        DownGameKeyEventHandler.jcell_instanceArray <- ([| (new DownGameKeyEventHandlerBase()); (new DownGameKeyEventHandlerBase()); (new DownGameKeyEventHandlerBase()); (new DownGameKeyEventHandlerBase()); (new DownGameKeyEventHandlerBase()); (new DownGameKeyEventHandlerBase()) |] : DownGameKeyEventHandlerBase[])
        ()
    member this.jfields_DownGameKeyEventHandler() : unit =
        this.playerInputIdFactory <- LocalPlayerInputIdFactory.getInstance()
        ()
    
    static member getInstance() : DownGameKeyEventHandler =
        DownGameKeyEventHandler.instance
    
    abstract getInstanceForDevice : deviceId: int -> DownGameKeyEventHandlerBase
    default this.getInstanceForDevice(deviceId: int) : DownGameKeyEventHandlerBase =
        let mutable playerInputId : int = this.playerInputIdFactory.getPlayerForDevice(deviceId)
        DownGameKeyEventHandler.instanceArray.[playerInputId]
    
    abstract getInstanceForPlayer : playerInputId: int -> DownGameKeyEventHandlerBase
    default this.getInstanceForPlayer(playerInputId: int) : DownGameKeyEventHandlerBase =
        DownGameKeyEventHandler.instanceArray.[playerInputId]
    
    new () as this =
        { inherit DownGameKeyEventHandlerBase() }
        then
            this.jfields_DownGameKeyEventHandler()
    
    override this.removeAllListeners() : unit =
        base.removeAllListeners()
        let mutable index : int = DownGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownGameKeyEventHandler.instanceArray.[index].removeAllListeners()
            index <- index - 1
    
    override this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListenerSingleThreaded(eventListenerInterface)
        let mutable index : int = DownGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownGameKeyEventHandler.instanceArray.[index].removeListenerSingleThreaded(eventListenerInterface)
            index <- index - 1
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListener(eventListenerInterface)
        let mutable index : int = DownGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            DownGameKeyEventHandler.instanceArray.[index].removeListener(eventListenerInterface)
            index <- index - 1


