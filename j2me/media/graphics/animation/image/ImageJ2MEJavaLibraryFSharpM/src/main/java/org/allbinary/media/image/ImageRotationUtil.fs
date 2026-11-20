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
type ImageRotationUtil =
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageRotationUtil
    static member instance with get() : ImageRotationUtil = (ImageRotationUtil.jclinit(); ImageRotationUtil.jcell_instance) and set (jvalue: ImageRotationUtil) = (ImageRotationUtil.jclinit(); ImageRotationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageRotationUtil.jclinitDone then
            ImageRotationUtil.jclinitDone <- true
            ImageRotationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageRotationUtil.jcell_instance <- (new ImageRotationUtil())
        ()
    member this.jfields_ImageRotationUtil() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    static member getInstance() : ImageRotationUtil =
        ImageRotationUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_ImageRotationUtil()
    
    abstract createRotatedImage : originalImage: Image * rotationInDegrees: int -> Image
    default this.createRotatedImage(originalImage: Image, rotationInDegrees: int) : Image =
        originalImage


