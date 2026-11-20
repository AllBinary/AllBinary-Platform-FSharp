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
type OpenGLFeatureUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLFeatureUtil
    static member instance with get() : OpenGLFeatureUtil = (OpenGLFeatureUtil.jclinit(); OpenGLFeatureUtil.jcell_instance) and set (jvalue: OpenGLFeatureUtil) = (OpenGLFeatureUtil.jclinit(); OpenGLFeatureUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLFeatureUtil.jclinitDone then
            OpenGLFeatureUtil.jclinitDone <- true
            OpenGLFeatureUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLFeatureUtil.jcell_instance <- (new OpenGLFeatureUtil())
        ()
    
    static member getInstance() : OpenGLFeatureUtil =
        OpenGLFeatureUtil.instance
    
    new () =
        {  }
    
    abstract isAnyThreed : unit -> bool
    default this.isAnyThreed() : bool =
        false


