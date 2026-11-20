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
type ImageModifierUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageModifierUtil
    static member instance with get() : ImageModifierUtil = (ImageModifierUtil.jclinit(); ImageModifierUtil.jcell_instance) and set (jvalue: ImageModifierUtil) = (ImageModifierUtil.jclinit(); ImageModifierUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageModifierUtil.jclinitDone then
            ImageModifierUtil.jclinitDone <- true
            ImageModifierUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageModifierUtil.jcell_instance <- (new ImageModifierUtil())
        ()
    new () =
        {  }
    
    static member getInstanceOrCreate() : ImageModifierUtil =
        ImageModifierUtil.instance
    
    abstract setColor : unusedOriginalImage: Image * image: Image * imageIndex: int * basicColor: BasicColor -> unit
    default this.setColor(unusedOriginalImage: Image, image: Image, imageIndex: int, basicColor: BasicColor) : unit =
        ()
    
    abstract changeColor : unusedOriginalImage: Image * image: Image * imageIndex: int * basicColor: BasicColor -> unit
    default this.changeColor(unusedOriginalImage: Image, image: Image, imageIndex: int, basicColor: BasicColor) : unit =
        ()
    
    abstract setAlpha : originalImage: Image * image: Image * imageIndex: int * alphaInt: int -> unit
    default this.setAlpha(originalImage: Image, image: Image, imageIndex: int, alphaInt: int) : unit =
        ()
    
    abstract getImageArray : originalImageArray: Image[] -> Image[]
    default this.getImageArray(originalImageArray: Image[]) : Image[] =
        originalImageArray
    
    abstract handleImage : imageArray: Image[] * index: int * image: Image -> unit
    default this.handleImage(imageArray: Image[], index: int, image: Image) : unit =
        ()
    
    abstract reset : unit -> unit
    default this.reset() : unit =
        ()


