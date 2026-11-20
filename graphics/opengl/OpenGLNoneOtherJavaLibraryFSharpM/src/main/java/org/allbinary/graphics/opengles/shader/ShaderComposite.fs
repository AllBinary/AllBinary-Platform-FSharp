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
type ShaderComposite =
    [<DefaultValue(false)>] val mutable disableProgramShaderOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable requiresOpenGLVersion : string
    [<DefaultValue(false)>] val mutable shaderArray : Shader[]
    [<DefaultValue(false)>] val mutable shaderInitializer : ShaderInitializer
    [<DefaultValue(false)>] val mutable compositeShaderUpdater : CompositeShaderUpdater
    [<DefaultValue(false)>] val mutable modelViewProjection : ModelViewProjection
    [<DefaultValue(false)>] val mutable colorOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable vertexOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable useProgramShaderOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable shaderMatrixOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable colorEnableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable normalEnableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable vertexEnableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable textureEnableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable colorDisableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable normalDisableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable vertexDisableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable textureDisableVertexAttribArrayOpenGLProcessor : OpenGLProcessor
    [<DefaultValue(false)>] val mutable uniformLightPositionOpenGLProcessor : OpenGLObject3dProcessor
    [<DefaultValue(false)>] val mutable uniformLightColorOpenGLProcessor : OpenGLObject3dProcessor
    [<DefaultValue(false)>] val mutable uniformCameraPositionOpenGLProcessor : OpenGLObject3dProcessor
    [<DefaultValue(false)>] val mutable uniformTextureUnitOpenGLProcessor : OpenGLObject3dProcessor
    [<DefaultValue(false)>] val mutable programHandle : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderComposite.jclinitDone then
            ShaderComposite.jclinitDone <- true
            ShaderComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ShaderComposite() : unit =
        this.useProgramShaderOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.shaderMatrixOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.colorEnableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.normalEnableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.vertexEnableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.textureEnableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.colorDisableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.normalDisableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.vertexDisableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.textureDisableVertexAttribArrayOpenGLProcessor <- NullOpenGLProcessorFactory.getInstance()
        this.uniformLightPositionOpenGLProcessor <- NullOpenGLTextureProcessor.getInstance()
        this.uniformLightColorOpenGLProcessor <- NullOpenGLTextureProcessor.getInstance()
        this.uniformCameraPositionOpenGLProcessor <- NullOpenGLTextureProcessor.getInstance()
        this.uniformTextureUnitOpenGLProcessor <- NullOpenGLTextureProcessor.getInstance()
        ()
    
    new (requiresOpenGLVersion: string, shaderArray: Shader[], compositeShaderUpdater: CompositeShaderUpdater, shaderInitializer: ShaderInitializer, modelViewProjection: ModelViewProjection, colorOpenGLProcessor: OpenGLProcessor, vertexOpenGLProcessor: OpenGLProcessor, disableProgramShaderOpenGLProcessor: OpenGLProcessor) as this =
        {  }
        then
            this.jfields_ShaderComposite()
            this.jctor1(requiresOpenGLVersion, shaderArray, compositeShaderUpdater, shaderInitializer, modelViewProjection, colorOpenGLProcessor, vertexOpenGLProcessor, disableProgramShaderOpenGLProcessor)
    member this.jctor1(requiresOpenGLVersion: string, shaderArray: Shader[], compositeShaderUpdater: CompositeShaderUpdater, shaderInitializer: ShaderInitializer, modelViewProjection: ModelViewProjection, colorOpenGLProcessor: OpenGLProcessor, vertexOpenGLProcessor: OpenGLProcessor, disableProgramShaderOpenGLProcessor: OpenGLProcessor) : unit =
        this.requiresOpenGLVersion <- requiresOpenGLVersion
        this.shaderArray <- shaderArray
        this.shaderInitializer <- shaderInitializer
        this.compositeShaderUpdater <- compositeShaderUpdater
        this.modelViewProjection <- modelViewProjection
        this.colorOpenGLProcessor <- colorOpenGLProcessor
        this.vertexOpenGLProcessor <- vertexOpenGLProcessor
        this.disableProgramShaderOpenGLProcessor <- disableProgramShaderOpenGLProcessor
        ()
    
    abstract init : gl: GL10 -> unit
    default this.init(gl: GL10) : unit =
        this.programHandle <- this.shaderInitializer.init(gl, this.shaderArray, StringUtil.getInstance().getArrayInstance())


