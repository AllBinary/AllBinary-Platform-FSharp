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
type ShaderInitializer =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jcell_instance : ShaderInitializer
    static member instance with get() : ShaderInitializer = (ShaderInitializer.jclinit(); ShaderInitializer.jcell_instance) and set (jvalue: ShaderInitializer) = (ShaderInitializer.jclinit(); ShaderInitializer.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderInitializer.jclinitDone then
            ShaderInitializer.jclinitDone <- true
            ShaderInitializer.jclinitBody()
    static member private jclinitBody() : unit =
        ShaderInitializer.jcell_instance <- (new ShaderInitializer())
        ()
    new () as this =
        {  }
        then
            this.jfields_ShaderInitializer()
    member this.jfields_ShaderInitializer() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    static member getInstance() : ShaderInitializer =
        ShaderInitializer.instance
    
    abstract init : gl: GL10 * shader: Shader[] * attributeArray: string[] -> int
    default this.init(gl: GL10, shader: Shader[], attributeArray: string[]) : int =
        -1


