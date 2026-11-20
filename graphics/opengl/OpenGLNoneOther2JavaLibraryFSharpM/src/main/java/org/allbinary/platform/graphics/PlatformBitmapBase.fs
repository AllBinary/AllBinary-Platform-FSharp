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
type PlatformBitmapBase =
    [<DefaultValue(false)>] val mutable alpha : int
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PLATFORM_BITMAP_BASE : PlatformBitmapBase
    static member NULL_PLATFORM_BITMAP_BASE with get() : PlatformBitmapBase = (PlatformBitmapBase.jclinit(); PlatformBitmapBase.jcell_NULL_PLATFORM_BITMAP_BASE) and set (jvalue: PlatformBitmapBase) = (PlatformBitmapBase.jclinit(); PlatformBitmapBase.jcell_NULL_PLATFORM_BITMAP_BASE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformBitmapBase.jclinitDone then
            PlatformBitmapBase.jclinitDone <- true
            PlatformBitmapBase.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformBitmapBase.jcell_NULL_PLATFORM_BITMAP_BASE <- (new PlatformBitmapBase())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlatformBitmapBase()
    member this.jfields_PlatformBitmapBase() : unit =
        this.alpha <- 255
        this.basicColor <- BasicColorFactory.getInstance().NULL_COLOR
        ()
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        0
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        0
    
    abstract getImage : unit -> Image
    default this.getImage() : Image =
        NullImage.NULL_IMAGE


