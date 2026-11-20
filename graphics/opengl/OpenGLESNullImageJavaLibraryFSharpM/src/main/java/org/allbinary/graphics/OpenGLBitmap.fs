namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLBitmap =
    inherit PlatformBitmapBase
    [<DefaultValue(false)>] val mutable bitmap : obj
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLBitmap.jclinitDone then
            OpenGLBitmap.jclinitDone <- true
            OpenGLBitmap.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (bitmap: obj) as this =
        { inherit PlatformBitmapBase() }
        then
            this.jctor1(bitmap)
    member this.jctor1(bitmap: obj) : unit =
        this.bitmap <- bitmap
        ()
    
    abstract getPixels : pixels: int[] * offset: int * stride: int * x: int * y: int * width: int * height: int -> unit
    default this.getPixels(pixels: int[], offset: int, stride: int, x: int, y: int, width: int, height: int) : unit =
        ()
    
    abstract setPixels : pixels: int[] * offset: int * stride: int * x: int * y: int * width: int * height: int -> unit
    default this.setPixels(pixels: int[], offset: int, stride: int, x: int, y: int, width: int, height: int) : unit =
        ()
    
    abstract recycle : unit -> unit
    default this.recycle() : unit =
        ()


