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
type PlatformAssetManager =
    [<DefaultValue(false)>] static val mutable private jcell_instance : PlatformAssetManager
    static member instance with get() : PlatformAssetManager = (PlatformAssetManager.jclinit(); PlatformAssetManager.jcell_instance) and set (jvalue: PlatformAssetManager) = (PlatformAssetManager.jclinit(); PlatformAssetManager.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformAssetManager.jclinitDone then
            PlatformAssetManager.jclinitDone <- true
            PlatformAssetManager.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformAssetManager.jcell_instance <- (new PlatformAssetManager())
        ()
    new () =
        {  }
    
    static member getInstance() : PlatformAssetManager =
        PlatformAssetManager.instance
    
    abstract getResourceAsStream : resource: string -> InputStream
    default this.getResourceAsStream(resource: string) : InputStream =
        let mutable resourceUtil : ResourceUtil = ResourceUtil.getInstance()
        let mutable inputStream : InputStream = resourceUtil.getResourceAsStream(resource)
        inputStream


