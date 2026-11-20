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
type ImageCreationUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageCreationUtil
    static member instance with get() : ImageCreationUtil = (ImageCreationUtil.jclinit(); ImageCreationUtil.jcell_instance) and set (jvalue: ImageCreationUtil) = (ImageCreationUtil.jclinit(); ImageCreationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCreationUtil.jclinitDone then
            ImageCreationUtil.jclinitDone <- true
            ImageCreationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageCreationUtil.jcell_instance <- (new ImageCreationUtil())
        ()
    
    static member getInstance() : ImageCreationUtil =
        ImageCreationUtil.instance
    
    new () =
        {  }
    
    abstract createImageWH : width: int * height: int -> Image
    default this.createImageWH(width: int, height: int) : Image =
        let mutable image : Image = GameFeatureImageCacheFactory.getInstance().get(JR.getClass(this), width, height)
        image
    
    abstract createImage : width: int * height: int * maxScaleX: float32 * maxScaleY: float32 -> Image
    default this.createImage(width: int, height: int, maxScaleX: float32, maxScaleY: float32) : Image =
        let mutable image : Image = GameFeatureImageCacheFactory.getInstance().get(JR.getClass(this), (JR.d2i(float ((float32 (width) * maxScaleX))) + 1), (JR.d2i(float ((float32 (height) * maxScaleY))) + 1))
        image


