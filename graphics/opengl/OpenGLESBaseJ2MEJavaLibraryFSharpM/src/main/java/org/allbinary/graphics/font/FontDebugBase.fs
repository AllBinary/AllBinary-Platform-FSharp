namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type FontDebugBase =
    [<DefaultValue(false)>] val mutable SET_FONT : string
    [<DefaultValue(false)>] static val mutable private jcell_instanceBase : FontDebugBase
    static member instanceBase with get() : FontDebugBase = (FontDebugBase.jclinit(); FontDebugBase.jcell_instanceBase) and set (jvalue: FontDebugBase) = (FontDebugBase.jclinit(); FontDebugBase.jcell_instanceBase <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FontDebugBase.jclinitDone then
            FontDebugBase.jclinitDone <- true
            FontDebugBase.jclinitBody()
    static member private jclinitBody() : unit =
        FontDebugBase.jcell_instanceBase <- (new FontDebugBase())
        ()
    new () as this =
        {  }
        then
            this.jfields_FontDebugBase()
    member this.jfields_FontDebugBase() : unit =
        this.SET_FONT <- "setFont"
        ()
    
    static member getInstance() : FontDebugBase =
        FontDebugBase.instanceBase
    
    abstract debugMetrics : currentFont: Font * convertedTextSize: float32 * displayMetrics: obj * stringBuffer: StringMaker -> unit
    default this.debugMetrics(currentFont: Font, convertedTextSize: float32, displayMetrics: obj, stringBuffer: StringMaker) : unit =
        ()
    
    abstract debugDpi : densityDpi: int * stringBuffer: StringMaker -> unit
    default this.debugDpi(densityDpi: int, stringBuffer: StringMaker) : unit =
        ()
    
    abstract debugDimension : currentFont: Font * convertedTextSize: float32 * longestDimensionTotalPixels: int * stringBuffer: StringMaker -> unit
    default this.debugDimension(currentFont: Font, convertedTextSize: float32, longestDimensionTotalPixels: int, stringBuffer: StringMaker) : unit =
        ()


