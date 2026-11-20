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
type AbeClientInformationInterface =
    abstract init : unit -> unit
    abstract getOperatingSystemInterface : unit -> GenericOperatingSystem
    abstract getName : unit -> string
    abstract getSpecialName : unit -> string
    abstract getVersion : unit -> string
    abstract getLicenseId : unit -> string
    abstract getLicenseServers : unit -> BasicArrayList
    abstract getLicenseServer : index: int -> string
    abstract getNumberOfLicenseServers : unit -> int
    abstract toHashtable : unit -> ABHashtable
    abstract isSameId : alicenseId: string -> bool
    abstract isLargerOrDifferentServerList : vector: BasicArrayList -> bool
    abstract isHardSale : unit -> bool
    abstract toShortString : unit -> string


