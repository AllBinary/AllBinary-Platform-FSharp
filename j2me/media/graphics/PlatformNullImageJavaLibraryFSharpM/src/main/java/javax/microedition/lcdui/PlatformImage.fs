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
type PlatformImage =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformImage.jclinitDone then
            PlatformImage.jclinitDone <- true
            PlatformImage.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getImage : graphicsSurface2: obj -> obj
    default this.getImage(graphicsSurface2: obj) : obj =
        NullImage.NULL_IMAGE
    
    abstract getSurfaceWidth : graphicsSurface2: obj * width: int -> int
    default this.getSurfaceWidth(graphicsSurface2: obj, width: int) : int =
        width
    
    abstract getSurfaceHeight : graphicsSurface2: obj * height: int -> int
    default this.getSurfaceHeight(graphicsSurface2: obj, height: int) : int =
        height
    
    abstract getWidth : image: Image * width: int -> int
    default this.getWidth(image: Image, width: int) : int =
        width
    
    abstract getHeight : image: Image * height: int -> int
    default this.getHeight(image: Image, height: int) : int =
        height
    
    abstract getGraphics : graphicsSurface: obj * width: int * height: int * image: Image -> Graphics
    default this.getGraphics(graphicsSurface: obj, width: int, height: int, image: Image) : Graphics =
        raise ((new JRuntimeException()))
    
    abstract drawImage : image: Image * x: int * y: int * anchor: int * g2: Graphics * g: obj -> unit
    default this.drawImage(image: Image, x: int, y: int, anchor: int, g2: Graphics, g: obj) : unit =
        ()
    
    abstract drawRegion : image: Image * x_src: int * y_src: int * width: int * height: int * transform: int * x_dst: int * y_dst: int * anchor: int * g: Graphics -> unit
    default this.drawRegion(image: Image, x_src: int, y_src: int, width: int, height: int, transform: int, x_dst: int, y_dst: int, anchor: int, g: Graphics) : unit =
        ()
    
    abstract getRGB : argb: int[] * offset: int * scanlength: int * x: int * y: int * width: int * height: int * image: Image -> unit
    default this.getRGB(argb: int[], offset: int, scanlength: int, x: int, y: int, width: int, height: int, image: Image) : unit =
        ()
    
    abstract setRGB : argb: int[] * offset: int * scanlength: int * x: int * y: int * width: int * height: int * image: Image -> unit
    default this.setRGB(argb: int[], offset: int, scanlength: int, x: int, y: int, width: int, height: int, image: Image) : unit =
        ()
    
    abstract getData : image: Image -> int[]
    default this.getData(image: Image) : int[] =
        NullUtil.getInstance().NULL_INT_ARRAY


