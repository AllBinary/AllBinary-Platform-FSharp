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
type ImageTypeUtil =
    [<DefaultValue(false)>] val mutable PNG : string
    [<DefaultValue(false)>] val mutable JPG : string
    [<DefaultValue(false)>] val mutable GIF : string
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : ImageTypeUtil
    static member SINGLETON with get() : ImageTypeUtil = (ImageTypeUtil.jclinit(); ImageTypeUtil.jcell_SINGLETON) and set (jvalue: ImageTypeUtil) = (ImageTypeUtil.jclinit(); ImageTypeUtil.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageTypeUtil.jclinitDone then
            ImageTypeUtil.jclinitDone <- true
            ImageTypeUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ImageTypeUtil.jcell_SINGLETON <- (new ImageTypeUtil())
        ()
    member this.jfields_ImageTypeUtil() : unit =
        this.PNG <- "png"
        this.JPG <- "jpg"
        this.GIF <- "gif"
        this.list <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_ImageTypeUtil()
            this.jctor1()
    member this.jctor1() : unit =
        ignore (this.list.add(this.JPG))
        ignore (this.list.add(this.GIF))
        ignore (this.list.add(this.PNG))
        ()
    
    abstract isSupported : mediaFileType: string -> bool
    default this.isSupported(mediaFileType: string) : bool =
        let mutable mediaFileType = mediaFileType
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        mediaFileType <- JString.toLowerCase(mediaFileType)
        let mutable index : int = this.list.size() - 1
        while jflow = 0 && (index >= 0) do
            let mutable name : string = (box (this.list.get(index)) :?> string)
            if JString.compareTo(mediaFileType, name) = 0 then
                jret <- true
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    static member getInstance() : ImageTypeUtil =
        ImageTypeUtil.SINGLETON


