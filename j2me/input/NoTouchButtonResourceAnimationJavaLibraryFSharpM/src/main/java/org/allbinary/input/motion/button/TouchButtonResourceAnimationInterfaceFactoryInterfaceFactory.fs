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
type TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory =
    inherit BaseResourceAnimationInterfaceFactoryInterfaceFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory.jclinitDone then
            TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory.jclinitDone <- true
            TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createFactory() : TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory =
        (new TouchButtonResourceAnimationInterfaceFactoryInterfaceFactory("TouchButton Animations"))
    
    new (name: string) =
        { inherit BaseResourceAnimationInterfaceFactoryInterfaceFactory(name, StdUtil.getInstance().createHashtable(), StdUtil.getInstance().createHashtable(), StdUtil.getInstance().createHashtable()) }
    
    override this.init(level: int) : unit =
        this.initImageCache(ImageCacheFactory.getInstance(), level)
    
    override this.initImageCache(imageCache: ImageCache, level: int) : unit =
        let mutable jflow = 0
        if this.isInitialized() then
            jflow <- 1
        if jflow = 0 then
            base.init(level)
    
    override this.isLoadingLevel(level: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if level = resourceLoadingLevelFactory.LOAD_TOUCH.getLevel() then
            jret <- true
            jflow <- 1
        else
            jret <- base.isLoadingLevel(level)
            jflow <- 1
        jret
    
    override this.isFeature() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if not (Features.getInstance().isDefault(OpenGLFeatureFactory.getInstance().OPENGL)) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


