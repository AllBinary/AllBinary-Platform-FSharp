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
type UpGameKeyEventHandler =
    inherit UpGameKeyEventHandlerBase
    [<DefaultValue(false)>] val mutable playerInputIdFactory : LocalPlayerInputIdFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : UpGameKeyEventHandler
    static member instance with get() : UpGameKeyEventHandler = (UpGameKeyEventHandler.jclinit(); UpGameKeyEventHandler.jcell_instance) and set (jvalue: UpGameKeyEventHandler) = (UpGameKeyEventHandler.jclinit(); UpGameKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_instanceArray : UpGameKeyEventHandlerBase[]
    static member instanceArray with get() : UpGameKeyEventHandlerBase[] = (UpGameKeyEventHandler.jclinit(); UpGameKeyEventHandler.jcell_instanceArray) and set (jvalue: UpGameKeyEventHandlerBase[]) = (UpGameKeyEventHandler.jclinit(); UpGameKeyEventHandler.jcell_instanceArray <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpGameKeyEventHandler.jclinitDone then
            UpGameKeyEventHandler.jclinitDone <- true
            UpGameKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        UpGameKeyEventHandler.jcell_instance <- (new UpGameKeyEventHandler())
        UpGameKeyEventHandler.jcell_instanceArray <- ([| (new UpGameKeyEventHandlerBase()); (new UpGameKeyEventHandlerBase()); (new UpGameKeyEventHandlerBase()); (new UpGameKeyEventHandlerBase()); (new UpGameKeyEventHandlerBase()); (new UpGameKeyEventHandlerBase()) |] : UpGameKeyEventHandlerBase[])
        ()
    member this.jfields_UpGameKeyEventHandler() : unit =
        this.playerInputIdFactory <- LocalPlayerInputIdFactory.getInstance()
        ()
    
    static member getInstance() : UpGameKeyEventHandler =
        UpGameKeyEventHandler.instance
    
    abstract getInstanceForDevice : deviceId: int -> UpGameKeyEventHandlerBase
    default this.getInstanceForDevice(deviceId: int) : UpGameKeyEventHandlerBase =
        let mutable playerInputId : int = this.playerInputIdFactory.getPlayerForDevice(deviceId)
        UpGameKeyEventHandler.instanceArray.[playerInputId]
    
    abstract getInstanceForPlayer : playerInputId: int -> UpGameKeyEventHandlerBase
    default this.getInstanceForPlayer(playerInputId: int) : UpGameKeyEventHandlerBase =
        UpGameKeyEventHandler.instanceArray.[playerInputId]
    
    new () as this =
        { inherit UpGameKeyEventHandlerBase() }
        then
            this.jfields_UpGameKeyEventHandler()
    
    override this.removeAllListeners() : unit =
        base.removeAllListeners()
        let mutable index : int = UpGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpGameKeyEventHandler.instanceArray.[index].removeAllListeners()
            index <- index - 1
    
    override this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListenerSingleThreaded(eventListenerInterface)
        let mutable index : int = UpGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpGameKeyEventHandler.instanceArray.[index].removeListenerSingleThreaded(eventListenerInterface)
            index <- index - 1
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        base.removeListener(eventListenerInterface)
        let mutable index : int = UpGameKeyEventHandler.instanceArray.Length - 1
        while index >= 0 do
            UpGameKeyEventHandler.instanceArray.[index].removeListener(eventListenerInterface)
            index <- index - 1


