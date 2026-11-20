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
type OpenGLCapabilities =
    [<DefaultValue(false)>] val mutable CUSTOM_GL_SURFACE_VIEW : bool
    [<DefaultValue(false)>] val mutable VERSION_1_0 : string
    [<DefaultValue(false)>] val mutable VERSION_1_1 : string
    [<DefaultValue(false)>] val mutable VERSION_2_0 : string
    [<DefaultValue(false)>] val mutable VERSION_3_0 : string
    [<DefaultValue(false)>] val mutable VERSION_3_1 : string
    [<DefaultValue(false)>] val mutable VERSION_3_2 : string
    [<DefaultValue(false)>] val mutable VERSION_HIGHER_THAN_EXISTS : string
    [<DefaultValue(false)>] val mutable glVersion : string
    [<DefaultValue(false)>] val mutable shaderVersion : int
    [<DefaultValue(false)>] val mutable glInstanceVersion : string
    [<DefaultValue(false)>] val mutable maxTextureSize : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLCapabilities
    static member instance with get() : OpenGLCapabilities = (OpenGLCapabilities.jclinit(); OpenGLCapabilities.jcell_instance) and set (jvalue: OpenGLCapabilities) = (OpenGLCapabilities.jclinit(); OpenGLCapabilities.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLCapabilities.jclinitDone then
            OpenGLCapabilities.jclinitDone <- true
            OpenGLCapabilities.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLCapabilities.jcell_instance <- (new OpenGLCapabilities())
        ()
    member this.jfields_OpenGLCapabilities() : unit =
        this.CUSTOM_GL_SURFACE_VIEW <- true
        this.VERSION_1_0 <- "1.0"
        this.VERSION_1_1 <- "1.1"
        this.VERSION_2_0 <- "2.0"
        this.VERSION_3_0 <- "3.0"
        this.VERSION_3_1 <- "3.1"
        this.VERSION_3_2 <- "3.2"
        this.VERSION_HIGHER_THAN_EXISTS <- "999.999"
        this.glVersion <- StringUtil.getInstance().EMPTY_STRING
        this.shaderVersion <- 0
        this.glInstanceVersion <- StringUtil.getInstance().EMPTY_STRING
        this.maxTextureSize <- 64
        ()
    
    static member getInstance() : OpenGLCapabilities =
        OpenGLCapabilities.instance
    
    new () as this =
        {  }
        then
            this.jfields_OpenGLCapabilities()
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        true
    
    abstract initCapabilities : gl: obj -> unit
    default this.initCapabilities(gl: obj) : unit =
        ()
    
    abstract isGlExtensionDrawTexture : unit -> bool
    default this.isGlExtensionDrawTexture() : bool =
        false
    
    abstract getGlVersion : unit -> string
    default this.getGlVersion() : string =
        this.glVersion
    
    abstract isVertexBufferObjectSupport : unit -> bool
    default this.isVertexBufferObjectSupport() : bool =
        false
    
    abstract isTextureSizeValid : widthAndHeight: int -> bool
    default this.isTextureSizeValid(widthAndHeight: int) : bool =
        true


