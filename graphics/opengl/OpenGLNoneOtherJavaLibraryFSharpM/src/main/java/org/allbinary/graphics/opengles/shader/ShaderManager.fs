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
type ShaderManager =
    [<DefaultValue(false)>] val mutable LOAD_SHADER : string
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable GL_VERTEX_SHADER : int
    [<DefaultValue(false)>] val mutable GL_FRAGMENT_SHADER : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ShaderManager
    static member instance with get() : ShaderManager = (ShaderManager.jclinit(); ShaderManager.jcell_instance) and set (jvalue: ShaderManager) = (ShaderManager.jclinit(); ShaderManager.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderManager.jclinitDone then
            ShaderManager.jclinitDone <- true
            ShaderManager.jclinitBody()
    static member private jclinitBody() : unit =
        ShaderManager.jcell_instance <- (new ShaderManager(-1, -1))
        ()
    member this.jfields_ShaderManager() : unit =
        this.LOAD_SHADER <- "loadShader"
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    static member getInstance() : ShaderManager =
        ShaderManager.instance
    
    new (GL_VERTEX_SHADER: int, GL_FRAGMENT_SHADER: int) as this =
        {  }
        then
            this.jfields_ShaderManager()
            this.jctor1(GL_VERTEX_SHADER, GL_FRAGMENT_SHADER)
    member this.jctor1(GL_VERTEX_SHADER: int, GL_FRAGMENT_SHADER: int) : unit =
        this.GL_VERTEX_SHADER <- GL_VERTEX_SHADER
        this.GL_FRAGMENT_SHADER <- GL_FRAGMENT_SHADER
        ()
    
    abstract load : gl: GL10 * resource: string * shaderAsStringArray: string[] * shaderType: int -> int
    default this.load(gl: GL10, resource: string, shaderAsStringArray: string[], shaderType: int) : int =
        -1
    
    abstract loadShader : gl: GL10 * resource: string * stringList: BasicArrayList * shaderType: int -> int
    default this.loadShader(gl: GL10, resource: string, stringList: BasicArrayList, shaderType: int) : int =
        -1


