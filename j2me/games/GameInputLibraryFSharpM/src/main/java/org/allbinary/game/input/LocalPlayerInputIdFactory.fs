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
type LocalPlayerInputIdFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable MAX_NUMBER_OF_PLAYERS : int
    [<DefaultValue(false)>] val mutable MAX_FAST_DEVICEID : int
    [<DefaultValue(false)>] val mutable deviceIdToplayerId : int[]
    [<DefaultValue(false)>] val mutable playerIdToDeviceId : int[]
    [<DefaultValue(false)>] val mutable playersInPlay : bool[]
    [<DefaultValue(false)>] val mutable totalDevicesMapped : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : LocalPlayerInputIdFactory
    static member instance with get() : LocalPlayerInputIdFactory = (LocalPlayerInputIdFactory.jclinit(); LocalPlayerInputIdFactory.jcell_instance) and set (jvalue: LocalPlayerInputIdFactory) = (LocalPlayerInputIdFactory.jclinit(); LocalPlayerInputIdFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LocalPlayerInputIdFactory.jclinitDone then
            LocalPlayerInputIdFactory.jclinitDone <- true
            LocalPlayerInputIdFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LocalPlayerInputIdFactory.jcell_instance <- (new LocalPlayerInputIdFactory())
        ()
    member this.jfields_LocalPlayerInputIdFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.MAX_NUMBER_OF_PLAYERS <- 6
        this.MAX_FAST_DEVICEID <- 65
        this.deviceIdToplayerId <- (Array.zeroCreate<int> (this.MAX_FAST_DEVICEID))
        this.playerIdToDeviceId <- (Array.zeroCreate<int> (this.MAX_NUMBER_OF_PLAYERS))
        this.playersInPlay <- (Array.zeroCreate<bool> (this.MAX_NUMBER_OF_PLAYERS))
        this.totalDevicesMapped <- 0
        ()
    
    new () as this =
        {  }
        then
            this.jfields_LocalPlayerInputIdFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable index : int = this.deviceIdToplayerId.Length - 1
        while index >= 0 do
            this.deviceIdToplayerId.[index] <- -1
            index <- index - 1
        ()
    
    static member getInstance() : LocalPlayerInputIdFactory =
        LocalPlayerInputIdFactory.instance
    
    abstract getDeviceId : playerInputId: int -> int
    default this.getDeviceId(playerInputId: int) : int =
        this.playerIdToDeviceId.[playerInputId]
    
    abstract getPlayerForDevice : deviceId: int -> int
    default this.getPlayerForDevice(deviceId: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable index : int = 0
        if deviceId < this.MAX_FAST_DEVICEID then
            let mutable playerInputId : int = this.deviceIdToplayerId.[deviceId]
            if playerInputId <> (-1) then
                jret <- playerInputId
                jflow <- 1
        else
            index <- this.totalDevicesMapped - 1
            while jflow = 0 && (index >= 0) do
                if this.playerIdToDeviceId.[index] = deviceId then
                    jret <- index
                    jflow <- 1
                if jflow = 200002 then jflow <- 0
                if jflow = 0 then index <- index - 1
            if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            index <- this.totalDevicesMapped
            if deviceId < this.MAX_FAST_DEVICEID then
                this.deviceIdToplayerId.[deviceId] <- index
            else
                this.logUtil.putF((new StringMaker()).append("Added DeviceId: ").appendint(deviceId).append(" beyond fast Id list").ToString(), this, "getPlayerForDevice")
            this.playerIdToDeviceId.[index] <- deviceId
            AnalogLocationInputFactory.getInstance().addPlayer(this.totalDevicesMapped)
            this.totalDevicesMapped <- this.totalDevicesMapped + 1
            this.logUtil.putF((new StringMaker()).append("Added DeviceId: ").appendint(deviceId).append(" at: ").appendint(index).append(" Total: ").appendint(this.totalDevicesMapped).ToString(), this, "getPlayerForDevice")
            jret <- index
            jflow <- 1
        jret
    
    abstract getTotalDevicesInPlay : unit -> int
    default this.getTotalDevicesInPlay() : int =
        let mutable total : int = 0
        let mutable index : int = this.totalDevicesMapped - 1
        while index >= 0 do
            if this.playersInPlay.[index] = true then
                total <- total + 1
            index <- index - 1
        total
    
    abstract isPlayerInPlay : playerInputId: int -> bool
    default this.isPlayerInPlay(playerInputId: int) : bool =
        this.playersInPlay.[playerInputId]
    
    abstract setPlayerInPlay : playerInputId: int -> unit
    default this.setPlayerInPlay(playerInputId: int) : unit =
        this.logUtil.putF((new StringMaker()).append("Setting PlayerInPlay with playerInputId: ").appendint(playerInputId).ToString(), this, "setPlayerInPlay")
        this.playersInPlay.[playerInputId] <- true
    
    abstract setPlayerOutOfPlay : playerInputId: int -> unit
    default this.setPlayerOutOfPlay(playerInputId: int) : unit =
        this.logUtil.putF((new StringMaker()).append("Setting PlayerOutOfPlay with playerInputId: ").appendint(playerInputId).ToString(), this, "setPlayerOutOfPlay")
        this.playersInPlay.[playerInputId] <- false
    
    abstract getPlayersInPlay : unit -> bool[]
    default this.getPlayersInPlay() : bool[] =
        this.playersInPlay


