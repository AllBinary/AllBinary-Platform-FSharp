namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type PropertyInitUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : PropertyInitUtil
    static member instance with get() : PropertyInitUtil = (PropertyInitUtil.jclinit(); PropertyInitUtil.jcell_instance) and set (jvalue: PropertyInitUtil) = (PropertyInitUtil.jclinit(); PropertyInitUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PropertyInitUtil.jclinitDone then
            PropertyInitUtil.jclinitDone <- true
            PropertyInitUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PropertyInitUtil.jcell_instance <- (new PropertyInitUtil())
        ()
    new () =
        {  }
    
    static member getInstance(value: int) : PropertyInitUtil =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        logUtil.putF((new StringMaker()).append("PropertyInitUtil: ").appendint(value).ToString(), logUtil, commonStrings.CONSTRUCTOR)
        PropertyInitUtil.instance


