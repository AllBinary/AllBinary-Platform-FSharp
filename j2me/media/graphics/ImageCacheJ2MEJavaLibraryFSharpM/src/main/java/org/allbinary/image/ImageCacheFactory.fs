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
type ImageCacheFactory =
    [<DefaultValue(false)>] static val mutable private jcell_IMAGE_CACHE : ImageCache
    static member IMAGE_CACHE with get() : ImageCache = (ImageCacheFactory.jclinit(); ImageCacheFactory.jcell_IMAGE_CACHE) and set (jvalue: ImageCache) = (ImageCacheFactory.jclinit(); ImageCacheFactory.jcell_IMAGE_CACHE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCacheFactory.jclinitDone then
            ImageCacheFactory.jclinitDone <- true
            ImageCacheFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ImageCacheFactory.jcell_IMAGE_CACHE <- (new ImageCache())
        ()
    new () =
        {  }
    
    static member getInstance() : ImageCache =
        ImageCacheFactory.IMAGE_CACHE
    
    static member init() : unit =
        ()


