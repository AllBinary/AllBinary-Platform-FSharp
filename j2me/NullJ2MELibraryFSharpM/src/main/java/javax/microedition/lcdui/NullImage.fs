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
type NullImage =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_IMAGE_ARRAY : Image[]
    static member NULL_IMAGE_ARRAY with get() : Image[] = (NullImage.jclinit(); NullImage.jcell_NULL_IMAGE_ARRAY) and set (jvalue: Image[]) = (NullImage.jclinit(); NullImage.jcell_NULL_IMAGE_ARRAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_NULL_IMAGE : Image
    static member NULL_IMAGE with get() : Image = (NullImage.jclinit(); NullImage.jcell_NULL_IMAGE) and set (jvalue: Image) = (NullImage.jclinit(); NullImage.jcell_NULL_IMAGE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullImage.jclinitDone then
            NullImage.jclinitDone <- true
            NullImage.jclinitBody()
    static member private jclinitBody() : unit =
        NullImage.jcell_NULL_IMAGE_ARRAY <- (Array.zeroCreate<Image> (0))
        NullImage.jcell_NULL_IMAGE <- (new Image())
        ()
    new () =
        {  }


