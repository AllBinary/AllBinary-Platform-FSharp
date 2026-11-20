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
type ShaderUpdater =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable rendererStrings : RendererStrings
    [<DefaultValue(false)>] static val mutable private jcell_instance : ShaderUpdater
    static member instance with get() : ShaderUpdater = (ShaderUpdater.jclinit(); ShaderUpdater.jcell_instance) and set (jvalue: ShaderUpdater) = (ShaderUpdater.jclinit(); ShaderUpdater.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderUpdater.jclinitDone then
            ShaderUpdater.jclinitDone <- true
            ShaderUpdater.jclinitBody()
    static member private jclinitBody() : unit =
        ShaderUpdater.jcell_instance <- (new ShaderUpdater())
        ()
    new () as this =
        {  }
        then
            this.jfields_ShaderUpdater()
    member this.jfields_ShaderUpdater() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.rendererStrings <- RendererStrings.getInstance()
        ()
    
    static member getInstance() : ShaderUpdater =
        ShaderUpdater.instance
    
    abstract onSurfaceCreated : gl: GL10 * eglConfig: EGLConfig -> unit
    default this.onSurfaceCreated(gl: GL10, eglConfig: EGLConfig) : unit =
        ()


