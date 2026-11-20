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
type PlatformBitmapBaseFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PLATFORM_BITMAP_BASE_FACTORY : PlatformBitmapBaseFactory
    static member NULL_PLATFORM_BITMAP_BASE_FACTORY with get() : PlatformBitmapBaseFactory = (PlatformBitmapBaseFactory.jclinit(); PlatformBitmapBaseFactory.jcell_NULL_PLATFORM_BITMAP_BASE_FACTORY) and set (jvalue: PlatformBitmapBaseFactory) = (PlatformBitmapBaseFactory.jclinit(); PlatformBitmapBaseFactory.jcell_NULL_PLATFORM_BITMAP_BASE_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformBitmapBaseFactory.jclinitDone then
            PlatformBitmapBaseFactory.jclinitDone <- true
            PlatformBitmapBaseFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformBitmapBaseFactory.jcell_NULL_PLATFORM_BITMAP_BASE_FACTORY <- (new PlatformBitmapBaseFactory())
        ()
    new () =
        {  }
    
    abstract createBitmap : image: Image -> PlatformBitmapBase
    default this.createBitmap(image: Image) : PlatformBitmapBase =
        raise ((new JRuntimeException()))


