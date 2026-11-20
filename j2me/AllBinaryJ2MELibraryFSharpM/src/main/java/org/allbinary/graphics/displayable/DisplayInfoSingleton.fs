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
type DisplayInfoSingleton =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonLabels : CommonLabels
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable ORIENTATION : string
    [<DefaultValue(false)>] val mutable ADJUSTING_FOR_SCALING_IN_PORTRAIT : string
    [<DefaultValue(false)>] val mutable ADJUSTING_FOR_SCALING_IN_LANDSCAPE : string
    [<DefaultValue(false)>] val mutable last : int[]
    [<DefaultValue(false)>] val mutable lastHalf : int[]
    [<DefaultValue(false)>] val mutable full : int[]
    [<DefaultValue(false)>] val mutable top : int
    [<DefaultValue(false)>] val mutable left : int
    [<DefaultValue(false)>] val mutable xOffset : int
    [<DefaultValue(false)>] val mutable yOffset : int
    [<DefaultValue(false)>] val mutable scaleLargestTo : float32
    [<DefaultValue(false)>] val mutable WIDTH : int
    [<DefaultValue(false)>] val mutable HEIGHT : int
    [<DefaultValue(false)>] val mutable CUSTOM_WIDTH : int
    [<DefaultValue(false)>] val mutable CUSTOM_HEIGHT : int
    [<DefaultValue(false)>] val mutable scalableListener : BaseScalable
    [<DefaultValue(false)>] val mutable displayRatio : float32
    [<DefaultValue(false)>] val mutable ratio : float32
    [<DefaultValue(false)>] val mutable SET_LAST_SIZE_METHOD_NAME : string
    [<DefaultValue(false)>] val mutable FULL_WIDTH : string
    [<DefaultValue(false)>] val mutable FULL_HEIGHT : string
    [<DefaultValue(false)>] val mutable LAST_WIDTH : string
    [<DefaultValue(false)>] val mutable LAST_HEIGHT : string
    [<DefaultValue(false)>] val mutable PORTRAIT : string
    [<DefaultValue(false)>] val mutable LANDSCAPE : string
    [<DefaultValue(false)>] val mutable displayChangeEvent : DisplayChangeEvent
    [<DefaultValue(false)>] val mutable FIRE_METHOD_NAME : string
    [<DefaultValue(false)>] val mutable REASON : string
    [<DefaultValue(false)>] val mutable UPDATE_FROM_ORIENTATION_CHANGE : string
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable DISPLAY_INFO : string
    [<DefaultValue(false)>] val mutable FULL : string
    [<DefaultValue(false)>] val mutable LAST : string
    [<DefaultValue(false)>] val mutable LAST_HALF : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : DisplayInfoSingleton
    static member SINGLETON with get() : DisplayInfoSingleton = (DisplayInfoSingleton.jclinit(); DisplayInfoSingleton.jcell_SINGLETON) and set (jvalue: DisplayInfoSingleton) = (DisplayInfoSingleton.jclinit(); DisplayInfoSingleton.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DisplayInfoSingleton.jclinitDone then
            DisplayInfoSingleton.jclinitDone <- true
            DisplayInfoSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        DisplayInfoSingleton.jcell_SINGLETON <- (new DisplayInfoSingleton())
        ()
    member this.jfields_DisplayInfoSingleton() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonLabels <- CommonLabels.getInstance()
        this.commonSeps <- CommonSeps.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.ORIENTATION <- "ORIENTATION"
        this.ADJUSTING_FOR_SCALING_IN_PORTRAIT <- "Adjusting for Scaling in portrait display ratio: "
        this.ADJUSTING_FOR_SCALING_IN_LANDSCAPE <- "Adjusting for Scaling in landscape display ratio: "
        this.last <- (Array.zeroCreate<int> (4))
        this.lastHalf <- (Array.zeroCreate<int> (4))
        this.full <- (Array.zeroCreate<int> (4))
        this.WIDTH <- 0
        this.HEIGHT <- 1
        this.CUSTOM_WIDTH <- 2
        this.CUSTOM_HEIGHT <- 3
        this.scalableListener <- (new BaseScalable())
        this.ratio <- 1.0f
        this.SET_LAST_SIZE_METHOD_NAME <- "setLastSize"
        this.FULL_WIDTH <- " FullWidth: "
        this.FULL_HEIGHT <- " FullHeight: "
        this.LAST_WIDTH <- "LastWidth: "
        this.LAST_HEIGHT <- " LastHeight: "
        this.PORTRAIT <- "Portrait"
        this.LANDSCAPE <- "Landscape"
        this.displayChangeEvent <- (new DisplayChangeEvent(this))
        this.FIRE_METHOD_NAME <- "fire"
        this.REASON <- "reason: "
        this.UPDATE_FROM_ORIENTATION_CHANGE <- "Updating from Orientation Change "
        this.list <- (new BasicArrayListD())
        this.DISPLAY_INFO <- "Display Info: "
        this.FULL <- "full"
        this.LAST <- "last"
        this.LAST_HALF <- "lastHalf"
        ()
    
    static member getInstance() : DisplayInfoSingleton =
        DisplayInfoSingleton.SINGLETON
    
    new () as this =
        {  }
        then
            this.jfields_DisplayInfoSingleton()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable size : int = this.last.Length
        let mutable index : int = 0
        while index < size do
            this.last.[index] <- 0
            this.lastHalf.[index] <- 0
            this.full.[index] <- 0
            index <- index + 1
        if AndroidUtil.isAndroid() then
            this.scaleLargestTo <- 640.0f
        else
            this.scaleLargestTo <- 1080.0f
        ()
    
    abstract getLastHalf : unit -> int[]
    default this.getLastHalf() : int[] =
        this.lastHalf
    
    abstract getLast : unit -> int[]
    default this.getLast() : int[] =
        this.last
    
    abstract getFull : unit -> int[]
    default this.getFull() : int[] =
        this.full
    
    abstract getScaleLargestTo : unit -> float32
    default this.getScaleLargestTo() : float32 =
        this.scaleLargestTo
    
    abstract setScaleLargestTo : scaleLargestTo: int -> unit
    default this.setScaleLargestTo(scaleLargestTo: int) : unit =
        this.scaleLargestTo <- float32 (scaleLargestTo)
    
    abstract setLastSize : aLastWidth: int * aLastHeight: int * reason: string -> unit
    default this.setLastSize(aLastWidth: int, aLastHeight: int, reason: string) : unit =
        if (this.full.[this.WIDTH] <> aLastWidth) || (this.full.[this.HEIGHT] <> aLastHeight) then
            this.setLastSizeForce(aLastWidth, aLastHeight, reason)
    
    member this.setLastSizeForce(aLastWidth: int, aLastHeight: int, reason: string) : unit =
        let mutable aLastWidth = aLastWidth
        let mutable aLastHeight = aLastHeight
        let mutable stringMaker : StringMaker = (new StringMaker())
        this.logUtil.putF(stringMaker.append(CommonLabels.getInstance().START_LABEL).append(reason).ToString(), this, this.SET_LAST_SIZE_METHOD_NAME)
        let mutable aFullWidth : int = aLastWidth
        let mutable aFullHeight : int = aLastHeight
        ignore (stringMaker.delete(0, stringMaker.length()))
        this.logUtil.putF(stringMaker.append(this.FULL_WIDTH).appendint(aFullWidth).append(this.FULL_HEIGHT).appendint(aFullHeight).append(this.ToString()).ToString(), this, this.SET_LAST_SIZE_METHOD_NAME)
        let mutable operatingSystemInterface : GenericOperatingSystem = OperatingSystemFactory.getInstance().getOperatingSystemInstance()
        if operatingSystemInterface.isOverScan() then
            aLastWidth <- (aLastWidth * operatingSystemInterface.getOverScanXPercent()) / 100
            aLastHeight <- (aLastHeight * operatingSystemInterface.getOverScanYPercent()) / 100
        if operatingSystemInterface.isScalable() then
            if this.isPortraitWH(aLastWidth, aLastHeight) then
                if float32 (aLastHeight) > this.scaleLargestTo then
                    this.displayRatio <- this.scaleLargestTo / float32 (aLastHeight)
                    this.ratio <- float32 (aLastHeight) / this.scaleLargestTo
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    this.logUtil.putF(stringMaker.append(this.ADJUSTING_FOR_SCALING_IN_PORTRAIT).appendfloat(this.displayRatio).ToString(), this, this.SET_LAST_SIZE_METHOD_NAME)
                    aLastWidth <- JR.d2i(float ((float32 (aLastWidth) * this.displayRatio)))
                    aLastHeight <- JR.d2i(float ((float32 (aLastHeight) * this.displayRatio)))
                    this.scalableListener.scale(this.ratio)
                else
                    this.ratio <- 1.0f
                    this.scalableListener.scale(this.ratio)
            else
                if float32 (aLastWidth) > this.scaleLargestTo then
                    this.displayRatio <- this.scaleLargestTo / float32 (aLastWidth)
                    this.ratio <- float32 (aLastWidth) / this.scaleLargestTo
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    this.logUtil.putF(stringMaker.append(this.ADJUSTING_FOR_SCALING_IN_LANDSCAPE).appendfloat(this.displayRatio).ToString(), this, this.SET_LAST_SIZE_METHOD_NAME)
                    aLastWidth <- JR.d2i(float ((float32 (aLastWidth) * this.displayRatio)))
                    aLastHeight <- JR.d2i(float ((float32 (aLastHeight) * this.displayRatio)))
                    this.scalableListener.scale(this.ratio)
                else
                    this.ratio <- 1.0f
                    this.scalableListener.scale(this.ratio)
        ignore (stringMaker.delete(0, stringMaker.length()))
        this.logUtil.putF(stringMaker.append(this.LAST_WIDTH).appendint(aLastWidth).append(this.LAST_HEIGHT).appendint(aLastHeight).ToString(), this, this.SET_LAST_SIZE_METHOD_NAME)
        this.xOffset <- aFullWidth - aLastWidth
        this.yOffset <- aFullHeight - aLastHeight
        this.left <- this.scalableListener.getLeft(this.xOffset)
        this.top <- this.scalableListener.getTop(this.yOffset)
        this.full.[this.WIDTH] <- aFullWidth
        this.full.[this.HEIGHT] <- aFullHeight
        this.last.[this.WIDTH] <- aLastWidth
        this.lastHalf.[this.WIDTH] <- (this.last.[this.WIDTH] >>> 1)
        this.last.[this.HEIGHT] <- aLastHeight
        this.lastHalf.[this.HEIGHT] <- (this.last.[this.HEIGHT] >>> 1)
        SWTJOGLProcessor.getInstance().setCustom(aLastWidth, aLastHeight, this.ratio)
        this.add(this.SET_LAST_SIZE_METHOD_NAME)
    
    abstract isPortraitWH : lastWidth: int * lastHeight: int -> bool
    default this.isPortraitWH(lastWidth: int, lastHeight: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if lastHeight > lastWidth then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract isPortrait : unit -> bool
    default this.isPortrait() : bool =
        this.isPortraitWH(this.last.[this.WIDTH], this.last.[this.HEIGHT])
    
    abstract add : reason: string -> unit
    default this.add(reason: string) : unit =
        let mutable stringMaker : StringMaker = (new StringMaker())
        this.logUtil.putF(stringMaker.append(this.REASON).append(reason).ToString(), this, this.FIRE_METHOD_NAME)
        ignore (stringMaker.delete(0, stringMaker.length()))
        this.logUtil.putF(this.toStringAppend(stringMaker), this, this.FIRE_METHOD_NAME)
        ignore (this.list.add(reason))
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        try
            if this.list.size() > 0 then
                this.processForced()
            this.list.clear()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE(this.commonStrings.EXCEPTION, this, this.FIRE_METHOD_NAME, e)
            | _ -> reraise ()
    
    abstract processForced : unit -> unit
    default this.processForced() : unit =
        try
            let mutable swtJOGLProcessor : SWTJOGLProcessor = SWTJOGLProcessor.getInstance()
            swtJOGLProcessor.clear()
            DisplayChangeEventHandler.getInstance().fireEvent(this.displayChangeEvent)
            LastDisplayChangeEventHandler.getInstance().fireEvent(this.displayChangeEvent)
            swtJOGLProcessor.onSurfaceChanged()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE(this.commonStrings.EXCEPTION, this, this.FIRE_METHOD_NAME, e)
            | _ -> reraise ()
    
    abstract update : displayable: Displayable * reason: string -> unit
    default this.update(displayable: Displayable, reason: string) : unit =
        let mutable aLastWidth : int = displayable.getWidth()
        let mutable aLastHeight : int = displayable.getHeight()
        let mutable aFullWidth : int = aLastWidth
        let mutable aFullHeight : int = aLastHeight
        let mutable stringMaker : StringMaker = (new StringMaker())
        this.logUtil.putF(stringMaker.append(CommonLabels.getInstance().START_LABEL).append(reason).append(this.LAST_WIDTH).appendint(aLastWidth).append(this.LAST_HEIGHT).appendint(aLastHeight).append(this.commonSeps.SPACE).append(this.ToString()).ToString(), this, this.commonStrings.UPDATE)
        if (aLastWidth > 0) && (aLastHeight > 0) then
            let mutable features : Features = Features.getInstance()
            let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
            if ((not (features.isDefault(openGLFeatureFactory.OPENGL))) || (this.last.[this.WIDTH] <> aLastWidth)) || (this.last.[this.HEIGHT] <> aLastHeight) then
                ignore (stringMaker.delete(0, stringMaker.length()))
                this.logUtil.putF(stringMaker.append(this.UPDATE_FROM_ORIENTATION_CHANGE).ToString(), this, this.commonStrings.UPDATE)
                let mutable operatingSystemInterface : GenericOperatingSystem = OperatingSystemFactory.getInstance().getOperatingSystemInstance()
                if operatingSystemInterface.isOverScan() then
                    aLastWidth <- (aLastWidth * operatingSystemInterface.getOverScanXPercent()) / 100
                    aLastHeight <- (aLastHeight * operatingSystemInterface.getOverScanYPercent()) / 100
                if operatingSystemInterface.isScalable() then
                    if this.isPortraitWH(aLastWidth, aLastHeight) then
                        if float32 (aLastHeight) > this.scaleLargestTo then
                            this.displayRatio <- this.scaleLargestTo / float32 (aLastHeight)
                            this.ratio <- float32 (aLastHeight) / this.scaleLargestTo
                            ignore (stringMaker.delete(0, stringMaker.length()))
                            this.logUtil.putF(stringMaker.append(this.ADJUSTING_FOR_SCALING_IN_PORTRAIT).appendfloat(this.displayRatio).ToString(), this, this.commonStrings.UPDATE)
                            aLastWidth <- JR.d2i(float ((float32 (aLastWidth) * this.displayRatio)))
                            aLastHeight <- JR.d2i(float ((float32 (aLastHeight) * this.displayRatio)))
                            this.scalableListener.scale(this.ratio)
                        else
                            this.ratio <- 1.0f
                            this.scalableListener.scale(this.ratio)
                    else
                        if float32 (aLastWidth) > this.scaleLargestTo then
                            this.displayRatio <- this.scaleLargestTo / float32 (aLastWidth)
                            this.ratio <- float32 (aLastWidth) / this.scaleLargestTo
                            ignore (stringMaker.delete(0, stringMaker.length()))
                            this.logUtil.putF(stringMaker.append(this.ADJUSTING_FOR_SCALING_IN_LANDSCAPE).appendfloat(this.displayRatio).ToString(), this, this.commonStrings.UPDATE)
                            aLastWidth <- JR.d2i(float ((float32 (aLastWidth) * this.displayRatio)))
                            aLastHeight <- JR.d2i(float ((float32 (aLastHeight) * this.displayRatio)))
                            this.scalableListener.scale(this.ratio)
                        else
                            this.ratio <- 1.0f
                            this.scalableListener.scale(this.ratio)
                ignore (stringMaker.delete(0, stringMaker.length()))
                this.logUtil.putF(stringMaker.append(this.UPDATE_FROM_ORIENTATION_CHANGE).append(this.LAST_WIDTH).appendint(aLastWidth).append(this.LAST_HEIGHT).appendint(aLastHeight).ToString(), this, this.commonStrings.UPDATE)
                this.xOffset <- aFullWidth - aLastWidth
                this.yOffset <- aFullHeight - aLastHeight
                this.left <- this.scalableListener.getLeft(this.xOffset)
                this.top <- this.scalableListener.getTop(this.yOffset)
                this.full.[this.WIDTH] <- aFullWidth
                this.full.[this.HEIGHT] <- aFullHeight
                this.last.[this.WIDTH] <- aLastWidth
                this.lastHalf.[this.WIDTH] <- (this.last.[this.WIDTH] >>> 1)
                this.last.[this.HEIGHT] <- aLastHeight
                this.lastHalf.[this.HEIGHT] <- (this.last.[this.HEIGHT] >>> 1)
                SWTJOGLProcessor.getInstance().setCustom(aLastWidth, aLastHeight, this.ratio)
                this.add(this.commonStrings.UPDATE)
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        this.toStringAppend(stringBuffer)
    
    abstract toStringAppend : stringBuffer: StringMaker -> string
    default this.toStringAppend(stringBuffer: StringMaker) : string =
        ignore (stringBuffer.append(this.DISPLAY_INFO))
        ignore (stringBuffer.append(this.FULL))
        ignore (stringBuffer.append(this.commonLabels.WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.full.[this.WIDTH]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append(this.FULL))
        ignore (stringBuffer.append(this.commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.full.[this.HEIGHT]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append(this.LAST))
        ignore (stringBuffer.append(this.commonLabels.WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.last.[this.WIDTH]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append(this.LAST))
        ignore (stringBuffer.append(this.commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.last.[this.HEIGHT]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append(this.LAST_HALF))
        ignore (stringBuffer.append(this.commonLabels.WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.lastHalf.[this.WIDTH]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append(this.LAST_HALF))
        ignore (stringBuffer.append(this.commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.lastHalf.[this.HEIGHT]))
        ignore (stringBuffer.append(this.commonSeps.SPACE))
        ignore (stringBuffer.append((if this.isPortrait() then this.PORTRAIT else this.LANDSCAPE)))
        stringBuffer.ToString()
    
    abstract getTop : unit -> int
    default this.getTop() : int =
        this.top
    
    abstract getLeft : unit -> int
    default this.getLeft() : int =
        this.left
    
    abstract getLastWidth : unit -> int
    default this.getLastWidth() : int =
        this.last.[this.WIDTH]
    
    abstract getLastHeight : unit -> int
    default this.getLastHeight() : int =
        this.last.[this.HEIGHT]
    
    abstract getLastHalfWidth : unit -> int
    default this.getLastHalfWidth() : int =
        this.lastHalf.[this.WIDTH]
    
    abstract getLastHalfHeight : unit -> int
    default this.getLastHalfHeight() : int =
        this.lastHalf.[this.HEIGHT]
    
    abstract getCustomLastWidth : unit -> int
    default this.getCustomLastWidth() : int =
        this.last.[this.CUSTOM_WIDTH]
    
    abstract getCustomLastHeight : unit -> int
    default this.getCustomLastHeight() : int =
        this.last.[this.CUSTOM_HEIGHT]
    
    abstract getRawLastWidth : unit -> int
    default this.getRawLastWidth() : int =
        this.last.[this.WIDTH]
    
    abstract getRawLastHeight : unit -> int
    default this.getRawLastHeight() : int =
        this.last.[this.HEIGHT]
    
    abstract setCustom : width: int * height: int -> unit
    default this.setCustom(width: int, height: int) : unit =
        this.last.[this.CUSTOM_WIDTH] <- width
        this.lastHalf.[this.CUSTOM_WIDTH] <- (this.last.[this.CUSTOM_WIDTH] >>> 1)
        this.last.[this.CUSTOM_HEIGHT] <- height
        this.lastHalf.[this.CUSTOM_HEIGHT] <- (this.last.[this.CUSTOM_HEIGHT] >>> 1)
    
    abstract setScalableListener : scalableListener: BaseScalable -> unit
    default this.setScalableListener(scalableListener: BaseScalable) : unit =
        this.scalableListener <- scalableListener
    
    abstract getScalableListener : unit -> ScalableListener
    default this.getScalableListener() : ScalableListener =
        this.scalableListener
    
    abstract getRatio : unit -> float32
    default this.getRatio() : float32 =
        this.ratio
    
    abstract getDisplayRatio : unit -> float32
    default this.getDisplayRatio() : float32 =
        this.displayRatio
    
    abstract setOffset : left: int * top: int -> unit
    default this.setOffset(left: int, top: int) : unit =
        this.left <- left
    
    abstract getxOffset : unit -> int
    default this.getxOffset() : int =
        this.xOffset
    
    abstract getyOffset : unit -> int
    default this.getyOffset() : int =
        this.yOffset


