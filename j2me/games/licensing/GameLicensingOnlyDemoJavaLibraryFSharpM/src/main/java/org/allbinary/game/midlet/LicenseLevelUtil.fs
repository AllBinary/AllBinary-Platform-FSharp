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
type LicenseLevelUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LicenseLevelUtil
    static member instance with get() : LicenseLevelUtil = (LicenseLevelUtil.jclinit(); LicenseLevelUtil.jcell_instance) and set (jvalue: LicenseLevelUtil) = (LicenseLevelUtil.jclinit(); LicenseLevelUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseLevelUtil.jclinitDone then
            LicenseLevelUtil.jclinitDone <- true
            LicenseLevelUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseLevelUtil.jcell_instance <- (new LicenseLevelUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : LicenseLevelUtil =
        LicenseLevelUtil.instance
    
    abstract getMaxLevel : maxLevel: int * demoLevel: int -> int
    default this.getMaxLevel(maxLevel: int, demoLevel: int) : int =
        demoLevel


