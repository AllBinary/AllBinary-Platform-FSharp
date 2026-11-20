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
type AnimationFrameToImageUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnimationFrameToImageUtil
    static member instance with get() : AnimationFrameToImageUtil = (AnimationFrameToImageUtil.jclinit(); AnimationFrameToImageUtil.jcell_instance) and set (jvalue: AnimationFrameToImageUtil) = (AnimationFrameToImageUtil.jclinit(); AnimationFrameToImageUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationFrameToImageUtil.jclinitDone then
            AnimationFrameToImageUtil.jclinitDone <- true
            AnimationFrameToImageUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationFrameToImageUtil.jcell_instance <- (new AnimationFrameToImageUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : AnimationFrameToImageUtil =
        AnimationFrameToImageUtil.instance
    
    abstract getInstanceTranslate : width: int * height: int * animationInterface: Animation -> Image
    default this.getInstanceTranslate(width: int, height: int, animationInterface: Animation) : Image =
        let mutable image : Image = GameFeatureImageCacheFactory.getInstance().get(JR.getClass(AnimationFrameToImageUtil.instance), ((width * 3) >>> 1), ((height * 3) >>> 1))
        let mutable graphics : Graphics = image.getGraphics()
        let mutable tranlateX : int = (width >>> 2)
        let mutable tranlateY : int = (height >>> 2)
        graphics.translate(tranlateX, tranlateY)
        animationInterface.paintXY(graphics, 0, 0)
        graphics.translate(-(tranlateX), -(tranlateY))
        image
    
    abstract getInstanceWH : width: int * height: int * animationInterface: Animation -> Image
    default this.getInstanceWH(width: int, height: int, animationInterface: Animation) : Image =
        let mutable image : Image = GameFeatureImageCacheFactory.getInstance().get(JR.getClass(AnimationFrameToImageUtil.instance), width, height)
        let mutable graphics : Graphics = image.getGraphics()
        animationInterface.paintXY(graphics, 0, 0)
        image


