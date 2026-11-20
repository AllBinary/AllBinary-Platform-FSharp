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
type PreLoadPlatformImage =
    inherit PlatformImage
    [<DefaultValue(false)>] static val mutable private jcell_instance : PreLoadPlatformImage
    static member instance with get() : PreLoadPlatformImage = (PreLoadPlatformImage.jclinit(); PreLoadPlatformImage.jcell_instance) and set (jvalue: PreLoadPlatformImage) = (PreLoadPlatformImage.jclinit(); PreLoadPlatformImage.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PreLoadPlatformImage.jclinitDone then
            PreLoadPlatformImage.jclinitDone <- true
            PreLoadPlatformImage.jclinitBody()
    static member private jclinitBody() : unit =
        PreLoadPlatformImage.jcell_instance <- (new PreLoadPlatformImage())
        ()
    new () =
        { inherit PlatformImage() }
    
    static member getInstance() : PreLoadPlatformImage =
        PreLoadPlatformImage.instance


