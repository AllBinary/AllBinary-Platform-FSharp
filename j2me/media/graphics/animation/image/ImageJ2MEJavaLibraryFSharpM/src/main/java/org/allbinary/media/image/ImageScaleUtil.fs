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
type ImageScaleUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageScaleUtil
    static member instance with get() : ImageScaleUtil = (ImageScaleUtil.jclinit(); ImageScaleUtil.jcell_instance) and set (jvalue: ImageScaleUtil) = (ImageScaleUtil.jclinit(); ImageScaleUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageScaleUtil.jclinitDone then
            ImageScaleUtil.jclinitDone <- true
            ImageScaleUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageScaleUtil.jcell_instance <- (new ImageScaleUtil())
        ()
    
    static member getInstance() : ImageScaleUtil =
        ImageScaleUtil.instance
    
    new () =
        {  }
    
    abstract createImage2 : imageCache: ImageCache * originalImage: Image * scaleNominatorX: float32 * scaleDenominatorX: float32 * scaleNominatorY: float32 * scaleDenominatorY: float32 * cached: bool -> Image
    default this.createImage2(imageCache: ImageCache, originalImage: Image, scaleNominatorX: float32, scaleDenominatorX: float32, scaleNominatorY: float32, scaleDenominatorY: float32, cached: bool) : Image =
        this.createImage3(imageCache, originalImage, scaleNominatorX, scaleDenominatorX, scaleNominatorY, scaleDenominatorY, cached, true)
    
    abstract createImage3 : imageCache: ImageCache * originalImage: Image * scaleNominatorX: float32 * scaleDenominatorX: float32 * scaleNominatorY: float32 * scaleDenominatorY: float32 * cached: bool * mutable_: bool -> Image
    default this.createImage3(imageCache: ImageCache, originalImage: Image, scaleNominatorX: float32, scaleDenominatorX: float32, scaleNominatorY: float32, scaleDenominatorY: float32, cached: bool, mutable_: bool) : Image =
        originalImage


