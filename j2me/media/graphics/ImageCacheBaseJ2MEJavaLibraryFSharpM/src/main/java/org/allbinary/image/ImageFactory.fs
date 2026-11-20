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
type ImageFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageFactory
    static member instance with get() : ImageFactory = (ImageFactory.jclinit(); ImageFactory.jcell_instance) and set (jvalue: ImageFactory) = (ImageFactory.jclinit(); ImageFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageFactory.jclinitDone then
            ImageFactory.jclinitDone <- true
            ImageFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ImageFactory.jcell_instance <- (new ImageFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : ImageFactory =
        ImageFactory.instance
    
    abstract createImageUrl : url: string -> Image
    default this.createImageUrl(url: string) : Image =
        Image.createImage(url)
    
    abstract createImage : caller: string * width: int * height: int -> Image
    default this.createImage(caller: string, width: int, height: int) : Image =
        MIDPUtil.getInstance().createImageWH(width, height)
    
    abstract createImageFromInputStream : key: obj * inputStream: InputStream -> Image
    default this.createImageFromInputStream(key: obj, inputStream: InputStream) : Image =
        let mutable image : Image = MIDPUtil.getInstance().createImageFromInputStream(inputStream)
        image
    
    abstract createImageFromInputStream : inputStream: InputStream -> Image
    default this.createImageFromInputStream(inputStream: InputStream) : Image =
        MIDPUtil.getInstance().createImageFromInputStream(inputStream)


