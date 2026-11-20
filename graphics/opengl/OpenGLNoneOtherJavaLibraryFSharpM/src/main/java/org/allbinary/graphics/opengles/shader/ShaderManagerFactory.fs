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
type ShaderManagerFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ShaderManagerFactory
    static member instance with get() : ShaderManagerFactory = (ShaderManagerFactory.jclinit(); ShaderManagerFactory.jcell_instance) and set (jvalue: ShaderManagerFactory) = (ShaderManagerFactory.jclinit(); ShaderManagerFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderManagerFactory.jclinitDone then
            ShaderManagerFactory.jclinitDone <- true
            ShaderManagerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ShaderManagerFactory.jcell_instance <- (new ShaderManagerFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : ShaderManagerFactory =
        ShaderManagerFactory.instance
    
    abstract create : unit -> ShaderManager
    default this.create() : ShaderManager =
        ShaderManager.getInstance()


