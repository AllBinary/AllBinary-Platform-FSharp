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
type FeaturedResourceFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable ANIMATION_FEATURES : string
    [<DefaultValue(false)>] val mutable IMAGE_LABEL : string
    [<DefaultValue(false)>] val mutable IMAGE_GRAPHICS_ARRAY : string
    [<DefaultValue(false)>] val mutable IMAGE_GRAPHICS_ROTATION : string
    [<DefaultValue(false)>] val mutable SPRITE_QUARTER : string
    [<DefaultValue(false)>] val mutable SPRITE_FULL : string
    [<DefaultValue(false)>] val mutable IS_LOADING_LEVEL_LABEL : string
    [<DefaultValue(false)>] val mutable IS_FEATURE : string
    [<DefaultValue(false)>] val mutable GAME_FEATURE_CONTROLLED : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FeaturedResourceFactory.jclinitDone then
            FeaturedResourceFactory.jclinitDone <- true
            FeaturedResourceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_FeaturedResourceFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- (new BasicArrayListD())
        this.commonStrings <- CommonStrings.getInstance()
        this.ANIMATION_FEATURES <- "Animation Features: Vector: "
        this.IMAGE_LABEL <- " Image: "
        this.IMAGE_GRAPHICS_ARRAY <- "Image Array: "
        this.IMAGE_GRAPHICS_ROTATION <- "Image Rotate: "
        this.SPRITE_QUARTER <- " Sprite Quarter: "
        this.SPRITE_FULL <- " Sprite Full: "
        this.IS_LOADING_LEVEL_LABEL <- " isLoadingLevel "
        this.IS_FEATURE <- " isFeature: "
        this.GAME_FEATURE_CONTROLLED <- "GameFeatureControlledInterface: "
        ()
    
    new () as this =
        {  }
        then
            this.jfields_FeaturedResourceFactory()
    
    abstract init : level: int -> unit
    default this.init(level: int) : unit =
        let mutable size : int = this.list.size()
        let mutable index : int = 0
        while index < size do
            let mutable featureInterface : GameFeatureControlledInterface = (box (this.list.objectArray.[index]) :?> GameFeatureControlledInterface)
            let mutable isLoadingLevel : bool = featureInterface.isLoadingLevel(level)
            let mutable isFeature : bool = featureInterface.isFeature()
            this.logUtil.putF((new StringMaker()).append(this.GAME_FEATURE_CONTROLLED).append(featureInterface.ToString()).append(this.IS_LOADING_LEVEL_LABEL).append(ResourceLoadingLevelFactory.getInstance().getLevelString(level)).append(CommonSeps.getInstance().COLON_SEP).appendboolean(isLoadingLevel).append(this.IS_FEATURE).appendboolean(isFeature).ToString(), this, this.commonStrings.INIT)
            if isLoadingLevel && isFeature then
                featureInterface.init(level)
            index <- index + 1
        let mutable features : Features = Features.getInstance()
        let mutable graphicsFeatureFactory : GraphicsFeatureFactory = GraphicsFeatureFactory.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.ANIMATION_FEATURES))
        ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.VECTOR_GRAPHICS)))
        ignore (stringBuffer.append(this.IMAGE_LABEL))
        ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.IMAGE_GRAPHICS)))
        this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.INIT)
        if features.isFeature(graphicsFeatureFactory.IMAGE_GRAPHICS) then
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append(this.IMAGE_GRAPHICS_ARRAY))
            ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.IMAGE_TO_ARRAY_GRAPHICS)))
            ignore (stringBuffer.append(this.IMAGE_GRAPHICS_ROTATION))
            ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.IMAGE_TO_ARRAY_GRAPHICS)))
            ignore (stringBuffer.append(this.SPRITE_QUARTER))
            ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.SPRITE_QUARTER_ROTATION_GRAPHICS)))
            ignore (stringBuffer.append(this.SPRITE_FULL))
            ignore (stringBuffer.appendboolean(features.isFeature(graphicsFeatureFactory.SPRITE_FULL_GRAPHICS)))
            this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.INIT)
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list.clear()
    
    abstract add : featureInterface: GameFeatureControlledInterface -> unit
    default this.add(featureInterface: GameFeatureControlledInterface) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(StringUtil.getInstance().toString(featureInterface)).ToString(), this, this.commonStrings.ADD)
        ignore (this.list.add(featureInterface))
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


