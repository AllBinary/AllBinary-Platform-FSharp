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
type LicenseInitInfo =
    [<DefaultValue(false)>] val mutable id : string
    [<DefaultValue(false)>] val mutable serverList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseInitInfo.jclinitDone then
            LicenseInitInfo.jclinitDone <- true
            LicenseInitInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LicenseInitInfo() : unit =
        this.id <- StringUtil.getInstance().EMPTY_STRING
        this.serverList <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_LicenseInitInfo()
    
    abstract getLicenseId : unit -> string
    default this.getLicenseId() : string =
        this.id
    
    abstract getServer : index: int -> string
    default this.getServer(index: int) : string =
        (box (this.serverList.get(index)) :?> string)
    
    abstract getNumberOfServers : unit -> int
    default this.getNumberOfServers() : int =
        this.serverList.size()
    
    abstract setLicenseId : value: string -> unit
    default this.setLicenseId(value: string) : unit =
        this.id <- value
    
    abstract clearServers : unit -> unit
    default this.clearServers() : unit =
        this.serverList.clear()
    
    abstract setServer : value: string * index: int -> unit
    default this.setServer(value: string, index: int) : unit =
        this.serverList.addAt(index, value)
    
    abstract addServer : value: string -> unit
    default this.addServer(value: string) : unit =
        ignore (this.serverList.add(value))
    
    abstract getServerList : unit -> BasicArrayList
    default this.getServerList() : BasicArrayList =
        this.serverList
    
    abstract setServerList : servers: BasicArrayList -> unit
    default this.setServerList(servers: BasicArrayList) : unit =
        if DebugFactory.getInstance() = NoDebug.getInstance() then
            this.serverList <- servers


