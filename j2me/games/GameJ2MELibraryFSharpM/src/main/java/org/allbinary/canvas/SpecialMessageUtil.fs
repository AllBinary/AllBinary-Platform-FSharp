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
type SpecialMessageUtil =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : SpecialMessageUtil
    static member SINGLETON with get() : SpecialMessageUtil = (SpecialMessageUtil.jclinit(); SpecialMessageUtil.jcell_SINGLETON) and set (jvalue: SpecialMessageUtil) = (SpecialMessageUtil.jclinit(); SpecialMessageUtil.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialMessageUtil.jclinitDone then
            SpecialMessageUtil.jclinitDone <- true
            SpecialMessageUtil.jclinitBody()
    static member private jclinitBody() : unit =
        SpecialMessageUtil.jcell_SINGLETON <- (new SpecialMessageUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : SpecialMessageUtil =
        SpecialMessageUtil.SINGLETON
    
    abstract get : unit -> string
    default this.get() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(Memory.getInfo()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(GameStatisticsFactory.getInstance().ToString()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(" Option: "))
        if Features.getInstance().isDefault(OpenGLFeatureFactory.getInstance().OPENGL_AUTO_SELECT) then
            ignore (stringBuffer.append(OpenGLFeatureFactory.getInstance().OPENGL_AUTO_SELECT.getName()))
        else
            ignore (stringBuffer.append(OpenGLFeatureFactory.getInstance().OPENGL_MINIMUM.getName()))
        stringBuffer.ToString()


