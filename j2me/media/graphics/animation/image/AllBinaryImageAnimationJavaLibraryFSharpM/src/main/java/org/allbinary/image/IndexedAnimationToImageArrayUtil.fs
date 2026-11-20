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
type IndexedAnimationToImageArrayUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IndexedAnimationToImageArrayUtil.jclinitDone then
            IndexedAnimationToImageArrayUtil.jclinitDone <- true
            IndexedAnimationToImageArrayUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstance(width: int, height: int, sequentialAnimationInterface: IndexedAnimation) : Image[] =
        let mutable size : int = sequentialAnimationInterface.getAnimationSize()
        let mutable imageArray : Image[] = (Array.zeroCreate<Image> (size))
        let mutable index : int = 0
        while index < size do
            sequentialAnimationInterface.setFrame(index)
            imageArray.[index] <- AnimationFrameToImageUtil.getInstance().getInstanceWH(width, height, sequentialAnimationInterface)
            index <- index + 1
        imageArray


