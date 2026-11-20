namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type GL11Ext =
    inherit GL
    abstract glTexParameterfv : target: int * pname: int * param: float32[] * offset: int -> unit
    abstract glCurrentPaletteMatrixOES : matrixpaletteindex: int -> unit
    abstract glDrawTexfOES : x: float32 * y: float32 * z: float32 * width: float32 * height: float32 -> unit
    abstract glDrawTexfvOES : coords: float32[] * offset: int -> unit
    abstract glDrawTexfvOES : coords: FloatBuffer -> unit
    abstract glDrawTexiOES : x: int * y: int * z: int * width: int * height: int -> unit
    abstract glDrawTexivOES : coords: int[] * offset: int -> unit
    abstract glDrawTexivOES : coords: IntBuffer -> unit
    abstract glDrawTexsOES : x: int16 * y: int16 * z: int16 * width: int16 * height: int16 -> unit
    abstract glDrawTexsvOES : coords: int16[] * offset: int -> unit
    abstract glDrawTexsvOES : coords: ShortBuffer -> unit
    abstract glDrawTexxOES : x: int * y: int * z: int * width: int * height: int -> unit
    abstract glDrawTexxvOES : coords: int[] * offset: int -> unit
    abstract glDrawTexxvOES : coords: IntBuffer -> unit
    abstract glEnable : cap: int -> unit
    abstract glEnableClientState : array_: int -> unit
    abstract glLoadPaletteFromModelViewMatrixOES : unit -> unit
    abstract glMatrixIndexPointerOES : size: int * type_: int * stride: int * pointer: Buffer -> unit
    abstract glMatrixIndexPointerOES : size: int * type_: int * stride: int * offset: int -> unit
    abstract glWeightPointerOES : size: int * type_: int * stride: int * pointer: Buffer -> unit
    abstract glWeightPointerOES : size: int * type_: int * stride: int * offset: int -> unit

module GL11Ext =
    let GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES : int = 35742
    let GL_MATRIX_INDEX_ARRAY_OES : int = 34884
    let GL_MATRIX_INDEX_ARRAY_POINTER_OES : int = 34889
    let GL_MATRIX_INDEX_ARRAY_SIZE_OES : int = 34886
    let GL_MATRIX_INDEX_ARRAY_STRIDE_OES : int = 34888
    let GL_MATRIX_INDEX_ARRAY_TYPE_OES : int = 34887
    let GL_MATRIX_PALETTE_OES : int = 34880
    let GL_MAX_PALETTE_MATRICES_OES : int = 34882
    let GL_MAX_VERTEX_UNITS_OES : int = 34468
    let GL_TEXTURE_CROP_RECT_OES : int = 35741
    let GL_WEIGHT_ARRAY_BUFFER_BINDING_OES : int = 34974
    let GL_WEIGHT_ARRAY_OES : int = 34477
    let GL_WEIGHT_ARRAY_POINTER_OES : int = 34476
    let GL_WEIGHT_ARRAY_SIZE_OES : int = 34475
    let GL_WEIGHT_ARRAY_STRIDE_OES : int = 34474
    let GL_WEIGHT_ARRAY_TYPE_OES : int = 34473


