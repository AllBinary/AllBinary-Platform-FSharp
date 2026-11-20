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
type CompositeShaderUpdater =
    inherit ShaderUpdater
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : CompositeShaderUpdater
    static member instanceC with get() : CompositeShaderUpdater = (CompositeShaderUpdater.jclinit(); CompositeShaderUpdater.jcell_instanceC) and set (jvalue: CompositeShaderUpdater) = (CompositeShaderUpdater.jclinit(); CompositeShaderUpdater.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompositeShaderUpdater.jclinitDone then
            CompositeShaderUpdater.jclinitDone <- true
            CompositeShaderUpdater.jclinitBody()
    static member private jclinitBody() : unit =
        CompositeShaderUpdater.jcell_instanceC <- (new CompositeShaderUpdater(StringUtil.getInstance().getArrayInstance(), StringUtil.getInstance().getArrayInstance(), StringUtil.getInstance().getArrayInstance(), NullUtil.getInstance().NULL_INT_ARRAY))
        ()
    member this.jfields_CompositeShaderUpdater() : unit =
        this.commonSeps <- CommonSeps.getInstance()
        ()
    
    static member getInstance() : CompositeShaderUpdater =
        CompositeShaderUpdater.instanceC
    
    new (uniformBlockArray: string[], uniformArray: string[], attributeArray: string[], attributeHandleArray: int[]) as this =
        { inherit ShaderUpdater() }
        then
            this.jfields_CompositeShaderUpdater()
    
    abstract onSurfaceCreated : gl: GL10 * eglConfig: EGLConfig * programHandle: int -> unit
    default this.onSurfaceCreated(gl: GL10, eglConfig: EGLConfig, programHandle: int) : unit =
        ()
    
    abstract onSurfaceDestroyed : gl: GL10 -> unit
    default this.onSurfaceDestroyed(gl: GL10) : unit =
        ()


