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
type CpuInterface =
    abstract getProcessor : unit -> string
    abstract getVendorId : unit -> string
    abstract getCpuFamily : unit -> string
    abstract getModel : unit -> string
    abstract getModelName : unit -> string
    abstract getStepping : unit -> string
    abstract getCpuSpeed : unit -> string
    abstract getCacheSize : unit -> string
    abstract compareTo : cpuInterface: CpuInterface -> bool


