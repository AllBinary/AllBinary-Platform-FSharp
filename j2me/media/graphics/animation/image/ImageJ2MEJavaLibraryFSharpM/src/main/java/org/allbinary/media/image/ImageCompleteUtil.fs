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
type ImageCompleteUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageCompleteUtil
    static member instance with get() : ImageCompleteUtil = (ImageCompleteUtil.jclinit(); ImageCompleteUtil.jcell_instance) and set (jvalue: ImageCompleteUtil) = (ImageCompleteUtil.jclinit(); ImageCompleteUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCompleteUtil.jclinitDone then
            ImageCompleteUtil.jclinitDone <- true
            ImageCompleteUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageCompleteUtil.jcell_instance <- (new ImageCompleteUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : ImageCompleteUtil =
        ImageCompleteUtil.instance
    
    abstract waitForImage : image: Image * name: string -> unit
    default this.waitForImage(image: Image, name: string) : unit =
        ()


