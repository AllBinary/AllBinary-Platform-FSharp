namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type OpenGLESImageExclusionUtil =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLESImageExclusionUtil
    static member instance with get() : OpenGLESImageExclusionUtil = (OpenGLESImageExclusionUtil.jclinit(); OpenGLESImageExclusionUtil.jcell_instance) and set (jvalue: OpenGLESImageExclusionUtil) = (OpenGLESImageExclusionUtil.jclinit(); OpenGLESImageExclusionUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESImageExclusionUtil.jclinitDone then
            OpenGLESImageExclusionUtil.jclinitDone <- true
            OpenGLESImageExclusionUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESImageExclusionUtil.jcell_instance <- (new OpenGLESImageExclusionUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLESImageExclusionUtil()
    member this.jfields_OpenGLESImageExclusionUtil() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : OpenGLESImageExclusionUtil =
        OpenGLESImageExclusionUtil.instance
    
    abstract isCustomScaling : image: Image -> bool
    default this.isCustomScaling(image: Image) : bool =
        false


