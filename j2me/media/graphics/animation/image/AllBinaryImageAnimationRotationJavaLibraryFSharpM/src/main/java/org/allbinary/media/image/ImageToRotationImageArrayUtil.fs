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
type ImageToRotationImageArrayUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageToRotationImageArrayUtil
    static member instance with get() : ImageToRotationImageArrayUtil = (ImageToRotationImageArrayUtil.jclinit(); ImageToRotationImageArrayUtil.jcell_instance) and set (jvalue: ImageToRotationImageArrayUtil) = (ImageToRotationImageArrayUtil.jclinit(); ImageToRotationImageArrayUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageToRotationImageArrayUtil.jclinitDone then
            ImageToRotationImageArrayUtil.jclinitDone <- true
            ImageToRotationImageArrayUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageToRotationImageArrayUtil.jcell_instance <- (new ImageToRotationImageArrayUtil())
        ()
    
    static member getInstance() : ImageToRotationImageArrayUtil =
        ImageToRotationImageArrayUtil.instance
    
    new () =
        {  }
    
    abstract generate : image: Image * angleIncrement: int * totalAngle: int -> Image[]
    default this.generate(image: Image, angleIncrement: int, totalAngle: int) : Image[] =
        let mutable imageRotationUtil : ImageRotationUtil = ImageRotationUtil.getInstance()
        let mutable totalFrames : int = totalAngle / angleIncrement
        let mutable imageArray : Image[] = (Array.zeroCreate<Image> (totalFrames))
        imageArray.[0] <- image
        let mutable index : int = 1
        while index < totalFrames do
            imageArray.[index] <- imageRotationUtil.createRotatedImage(image, (index * angleIncrement))
            index <- index + 1
        imageArray


