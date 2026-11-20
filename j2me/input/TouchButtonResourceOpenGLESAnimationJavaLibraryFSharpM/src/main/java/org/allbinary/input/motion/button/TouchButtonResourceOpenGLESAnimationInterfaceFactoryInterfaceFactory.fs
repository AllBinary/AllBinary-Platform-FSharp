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
type TouchButtonResourceOpenGLESAnimationInterfaceFactoryInterfaceFactory =
    inherit TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonResourceOpenGLESAnimationInterfaceFactoryInterfaceFactory.jclinitDone then
            TouchButtonResourceOpenGLESAnimationInterfaceFactoryInterfaceFactory.jclinitDone <- true
            TouchButtonResourceOpenGLESAnimationInterfaceFactoryInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory("OpenGL TouchButton Animations") }
    
    override this.init(level: int) : unit =
        base.initImageCache(OpenGLImageCacheFactory.getInstance(), level)
    
    override this.isFeature() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if Features.getInstance().isDefault(OpenGLFeatureFactory.getInstance().OPENGL) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


