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
            let mutable portion : int = 140
            let mutable loadingString : string = (new StringMaker()).append(this.ToString()).append(" Loading: ").ToString()
            let mutable index : int = 0
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            let mutable touchButtonBlankResource : TouchButtonResource = TouchButtonBlankResource.getInstance()
            let mutable touchButtonGenericActionResource : TouchButtonResource = TouchButtonGenericActionResource.getInstance()
            let mutable touchButtonStartResource : TouchButtonResource = TouchButtonStartResource.getInstance()
            let mutable touchButtonUpResource : TouchButtonResource = TouchButtonUpResource.getInstance()
            let mutable touchButtonDownResource : TouchButtonResource = TouchButtonDownResource.getInstance()
            let mutable touchButtonTurnLeftResource : TouchButtonResource = TouchButtonTurnLeftResource.getInstance()
            let mutable touchButtonTurnRightResource : TouchButtonResource = TouchButtonTurnRightResource.getInstance()
            let mutable touchButtonStrafeLeftResource : TouchButtonResource = TouchButtonStrafeLeftResource.getInstance()
            let mutable touchButtonStrafeRightResource : TouchButtonResource = TouchButtonStrafeRightResource.getInstance()
            let mutable touchButtonBlankResourceImage : Image = imageCache.getWithKey(touchButtonBlankResource.RESOURCE)
            let mutable touchButtonGenericActionResourceImage : Image = imageCache.getWithKey(touchButtonGenericActionResource.RESOURCE)
            let mutable touchButtonStartResourceImage : Image = imageCache.getWithKey(touchButtonStartResource.RESOURCE)
            let mutable touchButtonUpResourceImage : Image = imageCache.getWithKey(touchButtonUpResource.RESOURCE)
            let mutable touchButtonDownResourceImage : Image = imageCache.getWithKey(touchButtonDownResource.RESOURCE)
            let mutable touchButtonTurnLeftResourceImage : Image = imageCache.getWithKey(touchButtonTurnLeftResource.RESOURCE)
            let mutable touchButtonTurnRightResourceImage : Image = imageCache.getWithKey(touchButtonTurnRightResource.RESOURCE)
            let mutable touchButtonStrafeLeftResourceImage : Image = imageCache.getWithKey(touchButtonStrafeLeftResource.RESOURCE)
            let mutable touchButtonStrafeRightResourceImage : Image = imageCache.getWithKey(touchButtonStrafeRightResource.RESOURCE)
            let mutable nullAnimationFactory : NullAnimationFactory = NullAnimationFactory.getFactoryInstance()
            if OperatingSystemFactory.getInstance().getOperatingSystemInstance().isOverScan() then
                ignore (imageCache.getWithKey(TouchButtonStartResource.getInstance().HINT))
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            let mutable imageCompleteUtil : ImageCompleteUtil = ImageCompleteUtil.getInstance()
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonBlankResourceImage, touchButtonBlankResource.RESOURCE)
            this.add(touchButtonBlankResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonBlankResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonBlankResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonGenericActionResourceImage, touchButtonGenericActionResource.RESOURCE)
            this.add(touchButtonGenericActionResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonGenericActionResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonGenericActionResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonStartResourceImage, touchButtonStartResource.RESOURCE)
            this.add(touchButtonStartResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonStartResourceImage, AnimationBehaviorFactory.getInstance()))
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonUpResourceImage, touchButtonUpResource.RESOURCE)
            this.add(touchButtonUpResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonUpResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonUpResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonDownResourceImage, touchButtonDownResource.RESOURCE)
            this.add(touchButtonDownResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonDownResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonDownResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonTurnLeftResourceImage, touchButtonTurnLeftResource.RESOURCE)
            this.add(touchButtonTurnLeftResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonTurnLeftResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonTurnLeftResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonTurnRightResourceImage, touchButtonTurnRightResource.RESOURCE)
            this.add(touchButtonTurnRightResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonTurnRightResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonTurnRightResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonStrafeLeftResourceImage, touchButtonStrafeLeftResource.RESOURCE)
            this.add(touchButtonStrafeLeftResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonStrafeLeftResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonStrafeLeftResource.HINT, nullAnimationFactory)
            progressCanvas.addPortion(portion, loadingString, (let jt = index in index <- index + 1; jt))
            imageCompleteUtil.waitForImage(touchButtonStrafeRightResourceImage, touchButtonStrafeRightResource.RESOURCE)
            this.add(touchButtonStrafeRightResource.RESOURCE, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonStrafeRightResourceImage, AnimationBehaviorFactory.getInstance()))
            this.add(touchButtonStrafeRightResource.HINT, nullAnimationFactory)
            if OperatingSystemFactory.getInstance().getOperatingSystemInstance().isOverScan() then
                let mutable touchButtonStartHintResource : Image = imageCache.getWithKey(TouchButtonStartResource.getInstance().HINT)
                this.add(touchButtonStartResource.HINT, OneRowSpriteIndexedAnimationFactory.createFactory(touchButtonStartHintResource, AnimationBehaviorFactory.getInstance()))
            else
                this.add(touchButtonStartResource.HINT, nullAnimationFactory)
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


