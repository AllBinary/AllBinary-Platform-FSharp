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
type LockedUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LockedUtil
    static member instance with get() : LockedUtil = (LockedUtil.jclinit(); LockedUtil.jcell_instance) and set (jvalue: LockedUtil) = (LockedUtil.jclinit(); LockedUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockedUtil.jclinitDone then
            LockedUtil.jclinitDone <- true
            LockedUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LockedUtil.jcell_instance <- (new LockedUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : LockedUtil =
        LockedUtil.instance
    
    abstract isLocked : unit -> bool
    default this.isLocked() : bool =
        true
    
    abstract isLockedFeature : lockableFeatrue: LockableFeature -> bool
    default this.isLockedFeature(lockableFeatrue: LockableFeature) : bool =
        true
    interface LockedUtilInterface with
        member this.isLocked() : bool = this.isLocked()
        member this.isLockedFeature(jp0: LockableFeature) : bool = this.isLockedFeature(jp0)


