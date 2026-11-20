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
type PreResourceImageUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : PreResourceImageUtil
    static member instance with get() : PreResourceImageUtil = (PreResourceImageUtil.jclinit(); PreResourceImageUtil.jcell_instance) and set (jvalue: PreResourceImageUtil) = (PreResourceImageUtil.jclinit(); PreResourceImageUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PreResourceImageUtil.jclinitDone then
            PreResourceImageUtil.jclinitDone <- true
            PreResourceImageUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PreResourceImageUtil.jcell_instance <- (new PreResourceImageUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : PreResourceImageUtil =
        PreResourceImageUtil.instance
    
    abstract encapsulate : image: Image -> Image
    default this.encapsulate(image: Image) : Image =
        image
    
    abstract updateGL : gl: GL * image: Image -> unit
    default this.updateGL(gl: GL, image: Image) : unit =
        ()
    
    abstract update : graphics: Graphics * image: Image -> unit
    default this.update(graphics: Graphics, image: Image) : unit =
        ()


