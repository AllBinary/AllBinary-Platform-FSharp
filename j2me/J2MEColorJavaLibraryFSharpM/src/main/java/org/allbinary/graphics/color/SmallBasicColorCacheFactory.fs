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
type SmallBasicColorCacheFactory =
    [<DefaultValue(false)>] val mutable SIZE : int
    [<DefaultValue(false)>] val mutable INDEX_TO_COLOR : int[]
    [<DefaultValue(false)>] val mutable BASIC_COLOR_ARRAY : BasicColor[]
    [<DefaultValue(false)>] val mutable colorIndex : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : SmallBasicColorCacheFactory
    static member instance with get() : SmallBasicColorCacheFactory = (SmallBasicColorCacheFactory.jclinit(); SmallBasicColorCacheFactory.jcell_instance) and set (jvalue: SmallBasicColorCacheFactory) = (SmallBasicColorCacheFactory.jclinit(); SmallBasicColorCacheFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SmallBasicColorCacheFactory.jclinitDone then
            SmallBasicColorCacheFactory.jclinitDone <- true
            SmallBasicColorCacheFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SmallBasicColorCacheFactory.jcell_instance <- (new SmallBasicColorCacheFactory())
        ()
    member this.jfields_SmallBasicColorCacheFactory() : unit =
        this.SIZE <- 255
        this.INDEX_TO_COLOR <- (Array.zeroCreate<int> (this.SIZE))
        this.BASIC_COLOR_ARRAY <- (Array.zeroCreate<BasicColor> (this.SIZE))
        this.colorIndex <- 0
        ()
    
    static member getInstance() : SmallBasicColorCacheFactory =
        SmallBasicColorCacheFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_SmallBasicColorCacheFactory()
    
    abstract add : basicDefaultColor: BasicColor -> unit
    default this.add(basicDefaultColor: BasicColor) : unit =
        this.BASIC_COLOR_ARRAY.[this.colorIndex] <- basicDefaultColor
        this.INDEX_TO_COLOR.[this.colorIndex] <- basicDefaultColor.intValue()
        this.colorIndex <- this.colorIndex + 1
    
    abstract getAndOrCreate : colorAsInt: int -> BasicColor
    default this.getAndOrCreate(colorAsInt: int) : BasicColor =
        let mutable jflow = 0
        let mutable jret : BasicColor = Unchecked.defaultof<BasicColor>
        let mutable basicColor : BasicColor = null
        let mutable index : int = 0
        while jflow = 0 && (index < this.SIZE) do
            if this.INDEX_TO_COLOR.[index] = colorAsInt then
                jret <- this.BASIC_COLOR_ARRAY.[index]
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            let mutable ALPHA_MASK : int = 0xFF000000
            basicColor <- BasicColorFactory.getInstance().createInstanceAN((colorAsInt &&& ALPHA_MASK), (colorAsInt &&& 0x00FFFFFF), StringUtil.getInstance().EMPTY_STRING)
            this.add(basicColor)
            jret <- basicColor
            jflow <- 1
        jret


