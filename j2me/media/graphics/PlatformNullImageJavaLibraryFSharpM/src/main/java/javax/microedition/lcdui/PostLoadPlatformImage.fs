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
type PostLoadPlatformImage =
    inherit PlatformImage
    [<DefaultValue(false)>] static val mutable private jcell_instance : PostLoadPlatformImage
    static member instance with get() : PostLoadPlatformImage = (PostLoadPlatformImage.jclinit(); PostLoadPlatformImage.jcell_instance) and set (jvalue: PostLoadPlatformImage) = (PostLoadPlatformImage.jclinit(); PostLoadPlatformImage.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PostLoadPlatformImage.jclinitDone then
            PostLoadPlatformImage.jclinitDone <- true
            PostLoadPlatformImage.jclinitBody()
    static member private jclinitBody() : unit =
        PostLoadPlatformImage.jcell_instance <- (new PostLoadPlatformImage())
        ()
    new () =
        { inherit PlatformImage() }
    
    static member getInstance() : PostLoadPlatformImage =
        PostLoadPlatformImage.instance


