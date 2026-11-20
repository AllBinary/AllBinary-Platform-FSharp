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
type SimpleShaderInitializer =
    inherit ShaderInitializer
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : SimpleShaderInitializer
    static member instanceC with get() : SimpleShaderInitializer = (SimpleShaderInitializer.jclinit(); SimpleShaderInitializer.jcell_instanceC) and set (jvalue: SimpleShaderInitializer) = (SimpleShaderInitializer.jclinit(); SimpleShaderInitializer.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleShaderInitializer.jclinitDone then
            SimpleShaderInitializer.jclinitDone <- true
            SimpleShaderInitializer.jclinitBody()
    static member private jclinitBody() : unit =
        SimpleShaderInitializer.jcell_instanceC <- (new SimpleShaderInitializer())
        ()
    new () =
        { inherit ShaderInitializer() }
    
    static member getInstance() : SimpleShaderInitializer =
        SimpleShaderInitializer.instanceC


