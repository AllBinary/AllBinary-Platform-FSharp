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
type ImageArrayRotationAnimationPool =
    inherit BasicArrayListResetablePool
    [<DefaultValue(false)>] static val mutable private jcell_IMAGE_ROTATION_ANIMATION_POOL : PoolInterface
    static member IMAGE_ROTATION_ANIMATION_POOL with get() : PoolInterface = (ImageArrayRotationAnimationPool.jclinit(); ImageArrayRotationAnimationPool.jcell_IMAGE_ROTATION_ANIMATION_POOL) and set (jvalue: PoolInterface) = (ImageArrayRotationAnimationPool.jclinit(); ImageArrayRotationAnimationPool.jcell_IMAGE_ROTATION_ANIMATION_POOL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayRotationAnimationPool.jclinitDone then
            ImageArrayRotationAnimationPool.jclinitDone <- true
            ImageArrayRotationAnimationPool.jclinitBody()
    static member private jclinitBody() : unit =
        ImageArrayRotationAnimationPool.jcell_IMAGE_ROTATION_ANIMATION_POOL <- (new ImageArrayRotationAnimationPool((new ImageArrayRotationAnimationCacheableInterfaceFactory())))
        ()
    
    new (cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface) =
        { inherit BasicArrayListResetablePool(cacheableInterfaceFactoryInterface) }
    
    static member getInstance() : PoolInterface =
        ImageArrayRotationAnimationPool.IMAGE_ROTATION_ANIMATION_POOL
    
    override this.remove(key: obj) : CacheableInterface =
        let mutable cacheableInterface : CacheableInterface = base.remove(key)
        let mutable allBinaryImageRotationAnimationInfo : ImageArrayRotationAnimationInfo = (box (key) :?> ImageArrayRotationAnimationInfo)
        let mutable imageArrayRotationAnimationCacheable : ImageArrayRotationAnimationCacheable = ((box (cacheableInterface) :?> ImageArrayRotationAnimationCacheable))
        imageArrayRotationAnimationCacheable.setImageArray(allBinaryImageRotationAnimationInfo.getImageArray())
        cacheableInterface


