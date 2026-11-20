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
type ImageCache =
    inherit ImageCacheBase
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] static val mutable private jcell_NULL_IMAGE_CACHE : ImageCache
    static member NULL_IMAGE_CACHE with get() : ImageCache = (ImageCache.jclinit(); ImageCache.jcell_NULL_IMAGE_CACHE) and set (jvalue: ImageCache) = (ImageCache.jclinit(); ImageCache.jcell_NULL_IMAGE_CACHE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCache.jclinitDone then
            ImageCache.jclinitDone <- true
            ImageCache.jclinitBody()
    static member private jclinitBody() : unit =
        ImageCache.jcell_NULL_IMAGE_CACHE <- (new ImageCache())
        ()
    member this.jfields_ImageCache() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        ()
    
    new () as this =
        { inherit ImageCacheBase() }
        then
            this.jfields_ImageCache()
    
    abstract addListener : renderer: obj -> unit
    default this.addListener(renderer: obj) : unit =
        ()
    
    abstract getIndex : key: obj -> int
    default this.getIndex(key: obj) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable gdResources : GDResources = GDResources.getInstance()
        let mutable resourceStringArray : string[] = gdResources.resourceStringArray
        let mutable size : int = resourceStringArray.Length
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            if (JR.same(resourceStringArray.[index], key)) then
                jret <- index
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            this.logUtil.putF((new StringMaker()).append("unable to find key: ").append(StringUtil.getInstance().toString(key)).ToString(), this, this.commonStrings.RUN)
            raise ((new JRuntimeException()))
        jret
    
    override this.get(caller: string, width: int, height: int) : Image =
        let mutable foundIndex : int = this.getIndexWH(width, height)
        let mutable image : Image = this.getFromAvailable(foundIndex, width, height)
        if (JR.same(image, NullImage.NULL_IMAGE)) then
            this.volume <- this.volume + (width * height)
            if this.volume > 32000 then
                this.tsUtil.gc()
                this.volume <- 0
            image <- this.createImage(caller, width, height)
            let mutable widths : int[] = this.widths
            if this.nextIndex > (widths.Length - 1) then
                if foundIndex = (-1) then
                    foundIndex <- this.nextIndex
                    widths.[this.nextIndex] <- width
                    this.heights.[this.nextIndex] <- height
                    this.nextIndex <- this.nextIndex + 1
                ignore (this.listOfList.[foundIndex].add(image))
        image
    
    override this.getWithKey(key: obj) : Image =
        let mutable image : Image = this.getImage(key)
        if (JR.same(image, NullImage.NULL_IMAGE)) then
            let mutable resourceUtil : ResourceUtil = ResourceUtil.getInstance()
            let mutable resourceInputStream : InputStream = resourceUtil.getResourceAsStream((box (key) :?> string))
            if (JR.same(resourceInputStream, null)) then
                raise ((new JRuntimeException((new StringMaker()).append("Image resource is not available for key: ").append(StringUtil.getInstance().toString(key)).ToString())))
            try
                image <- this.createImageFromInputStream(key, resourceInputStream)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put("Exception: Trying Again After GC", this, this.commonStrings.GET, e)
                    this.logUtil.putF((new StringMaker()).append("InputStream: ").append(StringUtil.getInstance().toString(resourceInputStream)).ToString(), this, this.commonStrings.GET)
                    this.tsUtil.gc()
                    this.tsUtil.gc()
                    this.logUtil.putF(Memory.getInfo(), this, this.commonStrings.GET)
                    ignore (Thread.sleep(100))
                    image <- this.createImageFromInputStream(key, resourceInputStream)
                | _ -> reraise ()
            if J2MEUtil.isHTML() then
                ()
            else
                ignore (resourceInputStream.close())
            ignore (this.hashtable.put(key, image))
        image
    
    abstract loadImageForAnimation : unit -> unit
    default this.loadImageForAnimation() : unit =
        ()
    
    abstract progressEnded : unit -> unit
    default this.progressEnded() : unit =
        ()
    
    abstract runTask : unit -> unit
    default this.runTask() : unit =
        ()
    
    abstract isLazy : unit -> bool
    default this.isLazy() : bool =
        false


