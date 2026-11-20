namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ScreenRelationalUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScreenRelationalUtil
    static member instance with get() : ScreenRelationalUtil = (ScreenRelationalUtil.jclinit(); ScreenRelationalUtil.jcell_instance) and set (jvalue: ScreenRelationalUtil) = (ScreenRelationalUtil.jclinit(); ScreenRelationalUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenRelationalUtil.jclinitDone then
            ScreenRelationalUtil.jclinitDone <- true
            ScreenRelationalUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ScreenRelationalUtil.jcell_instance <- (new ScreenRelationalUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : ScreenRelationalUtil =
        ScreenRelationalUtil.instance
    
    abstract getScaleImage : image: Image -> float32
    default this.getScaleImage(image: Image) : float32 =
        this.getScaleWH(image.getWidth(), image.getHeight())
    
    abstract getScaleWH : aWidth: int * aHeight: int -> float32
    default this.getScaleWH(aWidth: int, aHeight: int) : float32 =
        this.getScaleWHA(aWidth, aHeight, 20)
    
    abstract getScaleWHA : aWidth: int * aHeight: int * add: int -> float32
    default this.getScaleWHA(aWidth: int, aHeight: int, add: int) : float32 =
        let mutable displayInfoSingleton : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable last : int[] = displayInfoSingleton.getLast()
        let mutable width : float32 = float32 (last.[displayInfoSingleton.WIDTH])
        let mutable height : float32 = float32 (last.[displayInfoSingleton.HEIGHT])
        let mutable largestSize : float32 = width
        if largestSize < height then
            largestSize <- height
        let mutable scale : float32 = (largestSize) / float32 (aWidth)
        scale
    
    abstract getScaledHeight : aWidth: int * aHeight: int -> int
    default this.getScaledHeight(aWidth: int, aHeight: int) : int =
        JR.d2i(float ((this.getScaleWH(aWidth, aHeight) * float32 (aHeight))))
    
    abstract getScaledHeightAdd : aWidth: int * aHeight: int * add: int -> int
    default this.getScaledHeightAdd(aWidth: int, aHeight: int, add: int) : int =
        JR.d2i(float ((this.getScaleWHA(aWidth, aHeight, add) * float32 (aHeight))))


