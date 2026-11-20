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
type ImageCopyUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable imageCreationUtil : ImageCreationUtil
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable gameFeatureFactory : GameFeatureFactory
    [<DefaultValue(false)>] val mutable features : Features
    [<DefaultValue(false)>] val mutable NO_COPY : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ImageCopyUtil
    static member instance with get() : ImageCopyUtil = (ImageCopyUtil.jclinit(); ImageCopyUtil.jcell_instance) and set (jvalue: ImageCopyUtil) = (ImageCopyUtil.jclinit(); ImageCopyUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCopyUtil.jclinitDone then
            ImageCopyUtil.jclinitDone <- true
            ImageCopyUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageCopyUtil.jcell_instance <- (new ImageCopyUtil())
        ()
    member this.jfields_ImageCopyUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.imageCreationUtil <- ImageCreationUtil.getInstance()
        this.anchor <- Anchor.TOP_LEFT
        this.gameFeatureFactory <- GameFeatureFactory.getInstance()
        this.features <- Features.getInstance()
        this.NO_COPY <- "J2ME does not need to copy images after initial loading"
        ()
    
    static member getInstance() : ImageCopyUtil =
        ImageCopyUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_ImageCopyUtil()
    
    abstract createImageForRotation : originalImage: Image -> Image
    default this.createImageForRotation(originalImage: Image) : Image =
        this.createImage(originalImage)
    
    abstract createImage : originalImage: Image -> Image
    default this.createImage(originalImage: Image) : Image =
        let mutable jflow = 0
        let mutable jret : Image = Unchecked.defaultof<Image>
        if not (this.features.isFeature(this.gameFeatureFactory.POST_IMAGE_LOADING_MODIFICATION)) then
            this.logUtil.put(this.NO_COPY, this, this.commonStrings.CONSTRUCTOR, (new JException()))
            jret <- originalImage
            jflow <- 1
        if jflow = 0 then
            let mutable image : Image = this.imageCreationUtil.createImageWH(originalImage.getWidth(), originalImage.getHeight())
            if image.isMutable() then
                image.getGraphics().drawImage(originalImage, 0, 0, this.anchor)
                jret <- image
                jflow <- 1
            else
                raise ((new JException("Not Mutable")))
        jret
    
    abstract createImageScale : originalImage: Image * canvasScale: float32 * resize: bool -> Image
    default this.createImageScale(originalImage: Image, canvasScale: float32, resize: bool) : Image =
        let mutable jflow = 0
        let mutable jret : Image = Unchecked.defaultof<Image>
        if not (this.features.isFeature(this.gameFeatureFactory.POST_IMAGE_LOADING_MODIFICATION)) then
            this.logUtil.put(this.NO_COPY, this, this.commonStrings.CONSTRUCTOR, (new JException()))
            jret <- originalImage
            jflow <- 1
        if jflow = 0 then
            let mutable newWidth : int = JR.d2i(float ((float32 (originalImage.getWidth()) * canvasScale)))
            let mutable newHeight : int = JR.d2i(float ((float32 (originalImage.getHeight()) * canvasScale)))
            if resize then
                if newWidth < newHeight then
                    newWidth <- newHeight
                if newHeight < newWidth then
                    newHeight <- newWidth
            let mutable image : Image = this.imageCreationUtil.createImageWH(newWidth, newHeight)
            if image.isMutable() then
                let mutable halfWidthDelta : int = (newWidth - originalImage.getWidth()) / 2
                let mutable halfHeightDelta : int = (newHeight - originalImage.getHeight()) / 2
                let mutable graphics : Graphics = image.getGraphics()
                graphics.drawImage(originalImage, halfWidthDelta, halfHeightDelta, this.anchor)
                jret <- image
                jflow <- 1
            else
                raise ((new JException("Not Mutable")))
        jret


