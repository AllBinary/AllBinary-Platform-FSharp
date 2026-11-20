namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2023 AllBinary
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
type ImageJ2MEScaleUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageJ2MEScaleUtil
    static member instance with get() : ImageJ2MEScaleUtil = (ImageJ2MEScaleUtil.jclinit(); ImageJ2MEScaleUtil.jcell_instance) and set (jvalue: ImageJ2MEScaleUtil) = (ImageJ2MEScaleUtil.jclinit(); ImageJ2MEScaleUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageJ2MEScaleUtil.jclinitDone then
            ImageJ2MEScaleUtil.jclinitDone <- true
            ImageJ2MEScaleUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageJ2MEScaleUtil.jcell_instance <- (new ImageJ2MEScaleUtil())
        ()
    
    static member getInstance() : ImageJ2MEScaleUtil =
        ImageJ2MEScaleUtil.instance
    
    new () =
        {  }
    
    abstract scaleArray : images: Image[] * width: int * height: int -> Image[]
    default this.scaleArray(images: Image[], width: int, height: int) : Image[] =
        let mutable scaledImages : Image[] = (Array.zeroCreate<Image> (images.Length))
        let mutable index : int = images.Length
        while ((index <- index - 1; index)) >= 0 do
            scaledImages.[index] <- this.scale(images.[index], width, height)
        scaledImages
    
    abstract scale : image: Image * width: int * height: int -> Image
    default this.scale(image: Image, width: int, height: int) : Image =
        let mutable sourceWidth : int = image.getWidth()
        let mutable sourceHeight : int = image.getHeight()
        let mutable originalData : int[] = (Array.zeroCreate<int> (image.getWidth() * image.getHeight()))
        image.getRGB(originalData, 0, image.getWidth(), 0, 0, image.getWidth(), image.getHeight())
        let mutable scaledData : int[] = (Array.zeroCreate<int> (width * height))
        let mutable heightRatioFactor : int = (8 * sourceHeight) / height
        let mutable widthRatioFactor : int = (8 * sourceWidth) / width
        let mutable scaledIndex : int = scaledData.Length - 1
        let mutable dx : int = 0
        let mutable dy : int = 0
        let mutable index : int = height
        while ((index <- index - 1; index)) >= 0 do
            dy <- (index * heightRatioFactor) >>> 3
            let mutable index2 : int = width
            while ((index2 <- index2 - 1; index2)) >= 0 do
                dx <- (index2 * widthRatioFactor) >>> 3
                scaledData.[(let jt = scaledIndex in scaledIndex <- scaledIndex - 1; jt)] <- originalData.[(sourceWidth * dy) + dx]
        let mutable scaledImage : Image = Image.createRGBImage(scaledData, width, height, true)
        scaledImage


