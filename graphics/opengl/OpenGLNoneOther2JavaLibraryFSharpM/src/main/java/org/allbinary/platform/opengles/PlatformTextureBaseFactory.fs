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
type PlatformTextureBaseFactory =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PLATFORM_TEXTURE_BASE_FACTORY : PlatformTextureBaseFactory
    static member NULL_PLATFORM_TEXTURE_BASE_FACTORY with get() : PlatformTextureBaseFactory = (PlatformTextureBaseFactory.jclinit(); PlatformTextureBaseFactory.jcell_NULL_PLATFORM_TEXTURE_BASE_FACTORY) and set (jvalue: PlatformTextureBaseFactory) = (PlatformTextureBaseFactory.jclinit(); PlatformTextureBaseFactory.jcell_NULL_PLATFORM_TEXTURE_BASE_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformTextureBaseFactory.jclinitDone then
            PlatformTextureBaseFactory.jclinitDone <- true
            PlatformTextureBaseFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformTextureBaseFactory.jcell_NULL_PLATFORM_TEXTURE_BASE_FACTORY <- (new PlatformTextureBaseFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlatformTextureBaseFactory()
    member this.jfields_PlatformTextureBaseFactory() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    abstract load : gl: GL10 * target: int * level: int * image: Image * border: int * flip: bool -> unit
    default this.load(gl: GL10, target: int, level: int, image: Image, border: int, flip: bool) : unit =
        ()


