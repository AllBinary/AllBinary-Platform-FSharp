namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type AbPathUtil =
    [<DefaultValue(false)>] val mutable NO_ABPATH : AbPath
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbPathUtil
    static member instance with get() : AbPathUtil = (AbPathUtil.jclinit(); AbPathUtil.jcell_instance) and set (jvalue: AbPathUtil) = (AbPathUtil.jclinit(); AbPathUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbPathUtil.jclinitDone then
            AbPathUtil.jclinitDone <- true
            AbPathUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AbPathUtil.jcell_instance <- (new AbPathUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_AbPathUtil()
    member this.jfields_AbPathUtil() : unit =
        this.NO_ABPATH <- AbPath.createAbPath()
        ()
    
    static member getInstance() : AbPathUtil =
        AbPathUtil.instance


