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
type CustomItemUtil =
    [<DefaultValue(false)>] val mutable CUSTOM_ITEM_ARRAY : ABCustomItem[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : CustomItemUtil
    static member instance with get() : CustomItemUtil = (CustomItemUtil.jclinit(); CustomItemUtil.jcell_instance) and set (jvalue: CustomItemUtil) = (CustomItemUtil.jclinit(); CustomItemUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomItemUtil.jclinitDone then
            CustomItemUtil.jclinitDone <- true
            CustomItemUtil.jclinitBody()
    static member private jclinitBody() : unit =
        CustomItemUtil.jcell_instance <- (new CustomItemUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_CustomItemUtil()
    member this.jfields_CustomItemUtil() : unit =
        this.CUSTOM_ITEM_ARRAY <- (Array.zeroCreate<ABCustomItem> (0))
        ()
    
    static member getInstance() : CustomItemUtil =
        CustomItemUtil.instance


