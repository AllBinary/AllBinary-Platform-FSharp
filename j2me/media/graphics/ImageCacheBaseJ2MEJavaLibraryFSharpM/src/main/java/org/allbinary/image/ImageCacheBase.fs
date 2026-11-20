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
type ImageCacheBase =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable imageFactory : ImageFactory
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable SIZE : int
    [<DefaultValue(false)>] val mutable widths : int[]
    [<DefaultValue(false)>] val mutable heights : int[]
    [<DefaultValue(false)>] val mutable listOfList : BasicArrayList[]
    [<DefaultValue(false)>] val mutable availableListOfList : BasicArrayList[]
    [<DefaultValue(false)>] val mutable volume : int
    [<DefaultValue(false)>] val mutable nextIndex : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCacheBase.jclinitDone then
            ImageCacheBase.jclinitDone <- true
            ImageCacheBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageCacheBase() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.imageFactory <- ImageFactory.getInstance()
        this.hashtable <- StdUtil.getInstance().createHashtable()
        this.SIZE <- 128
        this.widths <- (Array.zeroCreate<int> (this.SIZE))
        this.heights <- (Array.zeroCreate<int> (this.SIZE))
        this.listOfList <- (Array.zeroCreate<BasicArrayList> (this.SIZE))
        this.availableListOfList <- (Array.zeroCreate<BasicArrayList> (this.SIZE))
        this.volume <- 0
        this.nextIndex <- 0
        ()
    
    new () as this =
        {  }
        then
            this.jfields_ImageCacheBase()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable index : int = this.listOfList.Length - 1
        while index >= 0 do
            this.listOfList.[index] <- (new BasicArrayListD())
            index <- index - 1
        let mutable index : int = this.availableListOfList.Length - 1
        while index >= 0 do
            this.availableListOfList.[index] <- (new BasicArrayListD())
            index <- index - 1
        ()
    
    abstract getImage : resourceId: obj -> Image
    default this.getImage(resourceId: obj) : Image =
        let mutable jflow = 0
        let mutable jret : Image = Unchecked.defaultof<Image>
        let mutable imageCanBeNull : obj = this.hashtable.get(resourceId)
        if (JR.same(imageCanBeNull, null)) then
            jret <- NullImage.NULL_IMAGE
            jflow <- 1
        if jflow = 0 then
            jret <- (box (imageCanBeNull) :?> Image)
            jflow <- 1
        jret
    
    abstract releaseAll : unit -> unit
    default this.releaseAll() : unit =
        let mutable index : int = this.listOfList.Length - 1
        while index >= 0 do
            this.availableListOfList.[index].clear()
            ignore (this.availableListOfList.[index].addAllList(this.listOfList.[index]))
            index <- index - 1
        this.logUtil.putF((new StringMaker()).append("ImageCache: ").append(this.ToString()).ToString(), this, "releaseAll")
    
    abstract getIndexWH : width: int * height: int -> int
    default this.getIndexWH(width: int, height: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable foundIndex : int = -1
        let mutable size : int = this.widths.Length
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            if (this.widths.[index] = width) && (this.heights.[index] = height) then
                foundIndex <- index
                jret <- foundIndex
                jflow <- 1
            if jflow = 200004 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100004 then jflow <- 0
        if jflow = 0 then
            jret <- foundIndex
            jflow <- 1
        jret
    
    abstract getFromAvailable : foundIndex: int * width: int * height: int -> Image
    default this.getFromAvailable(foundIndex: int, width: int, height: int) : Image =
        let mutable jflow = 0
        let mutable jret : Image = Unchecked.defaultof<Image>
        if foundIndex <> (-1) then
            if this.availableListOfList.[foundIndex].size() > 0 then
                let mutable list_ : BasicArrayList = this.availableListOfList.[foundIndex]
                jret <- (box (list_.removeAt((list_.size() - 1))) :?> Image)
                jflow <- 1
        if jflow = 0 then
            jret <- NullImage.NULL_IMAGE
            jflow <- 1
        jret
    
    abstract get : caller: string * width: int * height: int -> Image
    default this.get(caller: string, width: int, height: int) : Image =
        raise ((new JRuntimeException()))
    
    abstract getWithKey : key: obj -> Image
    default this.getWithKey(key: obj) : Image =
        raise ((new JRuntimeException()))
    
    abstract createImage : caller: string * width: int * height: int -> Image
    default this.createImage(caller: string, width: int, height: int) : Image =
        this.imageFactory.createImage(caller, width, height)
    
    abstract createImageFromInputStream : key: obj * inputStream: InputStream -> Image
    default this.createImageFromInputStream(key: obj, inputStream: InputStream) : Image =
        this.imageFactory.createImageFromInputStream(key, inputStream)
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable index : int = this.nextIndex - 1
        while index >= 0 do
            let mutable width : int = this.widths.[index]
            let mutable height : int = this.heights.[index]
            let mutable total : int = this.listOfList.[index].size()
            let mutable totalAvailable : int = this.availableListOfList.[index].size()
            ignore (stringBuffer.append(" w: "))
            ignore (stringBuffer.appendint(width))
            ignore (stringBuffer.append(" h: "))
            ignore (stringBuffer.appendint(height))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(CommonLabels.getInstance().TOTAL_LABEL))
            ignore (stringBuffer.appendint(total))
            ignore (stringBuffer.append(" available: "))
            ignore (stringBuffer.appendint(totalAvailable))
            index <- index - 1
        stringBuffer.ToString()
    
    abstract getHashtableP : unit -> ABHashtable
    default this.getHashtableP() : ABHashtable =
        this.hashtable
    
    abstract init : image: Image -> unit
    default this.init(image: Image) : unit =
        ()
    
    abstract initProgress : unit -> unit
    default this.initProgress() : unit =
        ()


