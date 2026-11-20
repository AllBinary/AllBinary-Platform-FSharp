namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type GL10 =
    inherit GL
    abstract glActiveTexture : texture: int -> unit
    abstract glAlphaFunc : func: int * ref_: float32 -> unit
    abstract glBindTexture : target: int * texture: int -> unit
    abstract glBlendFunc : sfactor: int * dfactor: int -> unit
    abstract glClear : mask: int -> unit
    abstract glClearColor : red: float32 * green: float32 * blue: float32 * alpha: float32 -> unit
    abstract glClearDepthf : depth: float32 -> unit
    abstract glClearStencil : s: int -> unit
    abstract glClientActiveTexture : texture: int -> unit
    abstract glColor4f : red: float32 * green: float32 * blue: float32 * alpha: float32 -> unit
    abstract glColorMask : red: bool * green: bool * blue: bool * alpha: bool -> unit
    abstract glColorPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    abstract glCompressedTexImage2D : target: int * level: int * internalformat: int * width: int * height: int * border: int * imageSize: int * data: Buffer -> unit
    abstract glCompressedTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * width: int * height: int * format: int * imageSize: int * data: Buffer -> unit
    abstract glCopyTexImage2D : target: int * level: int * internalformat: int * x: int * y: int * width: int * height: int * border: int -> unit
    abstract glCopyTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * x: int * y: int * width: int * height: int -> unit
    abstract glCullFace : mode: int -> unit
    abstract glDeleteTextures : n: int * textures: int[] * offset: int -> unit
    abstract glDeleteTextures : n: int * textures: IntBuffer -> unit
    abstract glDepthFunc : func: int -> unit
    abstract glDepthMask : flag: bool -> unit
    abstract glDepthRangef : zNear: float32 * zFar: float32 -> unit
    abstract glDisable : cap: int -> unit
    abstract glDisableClientState : array_: int -> unit
    abstract glDrawArrays : mode: int * first: int * count: int -> unit
    abstract glDrawElements : mode: int * count: int * type_: int * indices: Buffer -> unit
    abstract glEnable : cap: int -> unit
    abstract glEnableClientState : array_: int -> unit
    abstract glFinish : unit -> unit
    abstract glFlush : unit -> unit
    abstract glFogf : pname: int * param: float32 -> unit
    abstract glFogfv : pname: int * params_: float32[] * offset: int -> unit
    abstract glFogfv : pname: int * params_: FloatBuffer -> unit
    abstract glFrontFace : mode: int -> unit
    abstract glFrustumf : left: float32 * right: float32 * bottom: float32 * top: float32 * zNear: float32 * zFar: float32 -> unit
    abstract glGenTextures : n: int * textures: int[] * offset: int -> unit
    abstract glGenTextures : n: int * textures: IntBuffer -> unit
    abstract glGetError : unit -> int
    abstract glGetIntegerv : pname: int * params_: int[] * offset: int -> unit
    abstract glGetIntegerv : pname: int * params_: IntBuffer -> unit
    abstract glGetString : name: int -> string
    abstract glHint : target: int * mode: int -> unit
    abstract glLightModelf : pname: int * param: float32 -> unit
    abstract glLightModelfv : pname: int * params_: float32[] * offset: int -> unit
    abstract glLightModelfv : pname: int * params_: FloatBuffer -> unit
    abstract glLightf : light: int * pname: int * param: float32 -> unit
    abstract glLightfv : light: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glLightfv : light: int * pname: int * params_: FloatBuffer -> unit
    abstract glLineWidth : width: float32 -> unit
    abstract glLoadIdentity : unit -> unit
    abstract glLoadMatrixf : m: float32[] * offset: int -> unit
    abstract glLoadMatrixf : m: FloatBuffer -> unit
    abstract glLogicOp : opcode: int -> unit
    abstract glMaterialf : face: int * pname: int * param: float32 -> unit
    abstract glMaterialfv : face: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glMaterialfv : face: int * pname: int * params_: FloatBuffer -> unit
    abstract glMatrixMode : mode: int -> unit
    abstract glMultMatrixf : m: float32[] * offset: int -> unit
    abstract glMultMatrixf : m: FloatBuffer -> unit
    abstract glMultiTexCoord4f : target: int * s: float32 * t: float32 * r: float32 * q: float32 -> unit
    abstract glNormal3f : nx: float32 * ny: float32 * nz: float32 -> unit
    abstract glNormalPointer : type_: int * stride: int * pointer: Buffer -> unit
    abstract glOrthof : left: float32 * right: float32 * bottom: float32 * top: float32 * zNear: float32 * zFar: float32 -> unit
    abstract glPixelStorei : pname: int * param: int -> unit
    abstract glPointSize : size: float32 -> unit
    abstract glPolygonOffset : factor: float32 * units: float32 -> unit
    abstract glPopMatrix : unit -> unit
    abstract glPushMatrix : unit -> unit
    abstract glReadPixels : x: int * y: int * width: int * height: int * format: int * type_: int * pixels: Buffer -> unit
    abstract glRotatef : angle: float32 * x: float32 * y: float32 * z: float32 -> unit
    abstract glRotatex : angle: int * x: int * y: int * z: int -> unit
    abstract glSampleCoverage : value: float32 * invert: bool -> unit
    abstract glScalef : x: float32 * y: float32 * z: float32 -> unit
    abstract glScalex : x: int * y: int * z: int -> unit
    abstract glScissor : x: int * y: int * width: int * height: int -> unit
    abstract glShadeModel : mode: int -> unit
    abstract glStencilFunc : func: int * ref_: int * mask: int -> unit
    abstract glStencilMask : mask: int -> unit
    abstract glStencilOp : fail: int * zfail: int * zpass: int -> unit
    abstract glTexCoordPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    abstract glTexEnvf : target: int * pname: int * param: float32 -> unit
    abstract glTexEnvfv : target: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glTexEnvfv : target: int * pname: int * params_: FloatBuffer -> unit
    abstract glTexImage2D : target: int * level: int * internalformat: int * width: int * height: int * border: int * format: int * type_: int * pixels: Buffer -> unit
    abstract glTexParameterf : target: int * pname: int * param: float32 -> unit
    abstract glTexParameteri : target: int * pname: int * param: int -> unit
    abstract glTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * width: int * height: int * format: int * type_: int * pixels: Buffer -> unit
    abstract glTranslatef : x: float32 * y: float32 * z: float32 -> unit
    abstract glVertexPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    abstract glViewport : x: int * y: int * width: int * height: int -> unit
    abstract glBegin : i: int -> unit
    abstract glEnd : unit -> unit
    abstract glVertex3f : f: float32 * f2: float32 * f3: float32 -> unit
    abstract glPolygonMode : i: int * i1: int -> unit

module GL10 =
    let GL_ADD : int = 260
    let GL_ALIASED_LINE_WIDTH_RANGE : int = 33902
    let GL_ALIASED_POINT_SIZE_RANGE : int = 33901
    let GL_ALPHA : int = 6406
    let GL_ALPHA_BITS : int = 3413
    let GL_ALPHA_TEST : int = 3008
    let GL_ALWAYS : int = 519
    let GL_AMBIENT : int = 4608
    let GL_AMBIENT_AND_DIFFUSE : int = 5634
    let GL_AND : int = 5377
    let GL_AND_INVERTED : int = 5380
    let GL_AND_REVERSE : int = 5378
    let GL_BACK : int = 1029
    let GL_BLEND : int = 3042
    let GL_BLUE_BITS : int = 3412
    let GL_BYTE : int = 5120
    let GL_CCW : int = 2305
    let GL_CLAMP_TO_EDGE : int = 33071
    let GL_CLEAR : int = 5376
    let GL_COLOR_ARRAY : int = 32886
    let GL_COLOR_BUFFER_BIT : int = 16384
    let GL_COLOR_LOGIC_OP : int = 3058
    let GL_COLOR_MATERIAL : int = 2903
    let GL_COMPRESSED_TEXTURE_FORMATS : int = 34467
    let GL_CONSTANT_ATTENUATION : int = 4615
    let GL_COPY : int = 5379
    let GL_COPY_INVERTED : int = 5388
    let GL_CULL_FACE : int = 2884
    let GL_CW : int = 2304
    let GL_DECAL : int = 8449
    let GL_DECR : int = 7683
    let GL_DEPTH_BITS : int = 3414
    let GL_DEPTH_BUFFER_BIT : int = 256
    let GL_DEPTH_TEST : int = 2929
    let GL_DIFFUSE : int = 4609
    let GL_DITHER : int = 3024
    let GL_DONT_CARE : int = 4352
    let GL_DST_ALPHA : int = 772
    let GL_DST_COLOR : int = 774
    let GL_EMISSION : int = 5632
    let GL_EQUAL : int = 514
    let GL_EQUIV : int = 5385
    let GL_EXP : int = 2048
    let GL_EXP2 : int = 2049
    let GL_EXTENSIONS : int = 7939
    let GL_FALSE : int = 0
    let GL_FASTEST : int = 4353
    let GL_FIXED : int = 5132
    let GL_FLAT : int = 7424
    let GL_FLOAT : int = 5126
    let GL_FOG : int = 2912
    let GL_FOG_COLOR : int = 2918
    let GL_FOG_DENSITY : int = 2914
    let GL_FOG_END : int = 2916
    let GL_FOG_HINT : int = 3156
    let GL_FOG_MODE : int = 2917
    let GL_FOG_START : int = 2915
    let GL_FRONT : int = 1028
    let GL_FRONT_AND_BACK : int = 1032
    let GL_GEQUAL : int = 518
    let GL_GREATER : int = 516
    let GL_GREEN_BITS : int = 3411
    let GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES : int = 35739
    let GL_IMPLEMENTATION_COLOR_READ_TYPE_OES : int = 35738
    let GL_INCR : int = 7682
    let GL_INVALID_ENUM : int = 1280
    let GL_INVALID_OPERATION : int = 1282
    let GL_INVALID_VALUE : int = 1281
    let GL_INVERT : int = 5386
    let GL_KEEP : int = 7680
    let GL_LEQUAL : int = 515
    let GL_LESS : int = 513
    let GL_LIGHT_MODEL_AMBIENT : int = 2899
    let GL_LIGHT_MODEL_TWO_SIDE : int = 2898
    let GL_LIGHT0 : int = 16384
    let GL_LIGHT1 : int = 16385
    let GL_LIGHT2 : int = 16386
    let GL_LIGHT3 : int = 16387
    let GL_LIGHT4 : int = 16388
    let GL_LIGHT5 : int = 16389
    let GL_LIGHT6 : int = 16390
    let GL_LIGHT7 : int = 16391
    let GL_LIGHTING : int = 2896
    let GL_LINE_LOOP : int = 2
    let GL_LINE_SMOOTH : int = 2848
    let GL_LINE_SMOOTH_HINT : int = 3154
    let GL_LINE_STRIP : int = 3
    let GL_LINEAR : int = 9729
    let GL_LINEAR_ATTENUATION : int = 4616
    let GL_LINEAR_MIPMAP_LINEAR : int = 9987
    let GL_LINEAR_MIPMAP_NEAREST : int = 9985
    let GL_LINES : int = 1
    let GL_LUMINANCE : int = 6409
    let GL_LUMINANCE_ALPHA : int = 6410
    let GL_MAX_ELEMENTS_INDICES : int = 33001
    let GL_MAX_ELEMENTS_VERTICES : int = 33000
    let GL_MAX_LIGHTS : int = 3377
    let GL_MAX_MODELVIEW_STACK_DEPTH : int = 3382
    let GL_MAX_PROJECTION_STACK_DEPTH : int = 3384
    let GL_MAX_TEXTURE_SIZE : int = 3379
    let GL_MAX_TEXTURE_STACK_DEPTH : int = 3385
    let GL_MAX_TEXTURE_UNITS : int = 34018
    let GL_MAX_VIEWPORT_DIMS : int = 3386
    let GL_MODELVIEW : int = 5888
    let GL_MODULATE : int = 8448
    let GL_MULTISAMPLE : int = 32925
    let GL_NAND : int = 5390
    let GL_NEAREST : int = 9728
    let GL_NEAREST_MIPMAP_LINEAR : int = 9986
    let GL_NEAREST_MIPMAP_NEAREST : int = 9984
    let GL_NEVER : int = 512
    let GL_NICEST : int = 4354
    let GL_NO_ERROR : int = 0
    let GL_NOOP : int = 5381
    let GL_NOR : int = 5384
    let GL_NORMAL_ARRAY : int = 32885
    let GL_NORMALIZE : int = 2977
    let GL_NOTEQUAL : int = 517
    let GL_NUM_COMPRESSED_TEXTURE_FORMATS : int = 34466
    let GL_ONE : int = 1
    let GL_ONE_MINUS_DST_ALPHA : int = 773
    let GL_ONE_MINUS_DST_COLOR : int = 775
    let GL_ONE_MINUS_SRC_ALPHA : int = 771
    let GL_ONE_MINUS_SRC_COLOR : int = 769
    let GL_OR : int = 5383
    let GL_OR_INVERTED : int = 5389
    let GL_OR_REVERSE : int = 5387
    let GL_OUT_OF_MEMORY : int = 1285
    let GL_PACK_ALIGNMENT : int = 3333
    let GL_PALETTE4_R5_G6_B5_OES : int = 35730
    let GL_PALETTE4_RGB5_A1_OES : int = 35732
    let GL_PALETTE4_RGB8_OES : int = 35728
    let GL_PALETTE4_RGBA4_OES : int = 35731
    let GL_PALETTE4_RGBA8_OES : int = 35729
    let GL_PALETTE8_R5_G6_B5_OES : int = 35735
    let GL_PALETTE8_RGB5_A1_OES : int = 35737
    let GL_PALETTE8_RGB8_OES : int = 35733
    let GL_PALETTE8_RGBA4_OES : int = 35736
    let GL_PALETTE8_RGBA8_OES : int = 35734
    let GL_PERSPECTIVE_CORRECTION_HINT : int = 3152
    let GL_POINT_SMOOTH : int = 2832
    let GL_POINT_SMOOTH_HINT : int = 3153
    let GL_POINTS : int = 0
    let GL_POINT_FADE_THRESHOLD_SIZE : int = 33064
    let GL_POINT_SIZE : int = 2833
    let GL_POLYGON_OFFSET_FILL : int = 32823
    let GL_POLYGON_SMOOTH_HINT : int = 3155
    let GL_POSITION : int = 4611
    let GL_PROJECTION : int = 5889
    let GL_QUADRATIC_ATTENUATION : int = 4617
    let GL_RED_BITS : int = 3410
    let GL_RENDERER : int = 7937
    let GL_REPEAT : int = 10497
    let GL_REPLACE : int = 7681
    let GL_RESCALE_NORMAL : int = 32826
    let GL_RGB : int = 6407
    let GL_RGBA : int = 6408
    let GL_SAMPLE_ALPHA_TO_COVERAGE : int = 32926
    let GL_SAMPLE_ALPHA_TO_ONE : int = 32927
    let GL_SAMPLE_COVERAGE : int = 32928
    let GL_SCISSOR_TEST : int = 3089
    let GL_SET : int = 5391
    let GL_SHININESS : int = 5633
    let GL_SHORT : int = 5122
    let GL_SMOOTH : int = 7425
    let GL_SMOOTH_LINE_WIDTH_RANGE : int = 2850
    let GL_SMOOTH_POINT_SIZE_RANGE : int = 2834
    let GL_SPECULAR : int = 4610
    let GL_SPOT_CUTOFF : int = 4614
    let GL_SPOT_DIRECTION : int = 4612
    let GL_SPOT_EXPONENT : int = 4613
    let GL_SRC_ALPHA : int = 770
    let GL_SRC_ALPHA_SATURATE : int = 776
    let GL_SRC_COLOR : int = 768
    let GL_STACK_OVERFLOW : int = 1283
    let GL_STACK_UNDERFLOW : int = 1284
    let GL_STENCIL_BITS : int = 3415
    let GL_STENCIL_BUFFER_BIT : int = 1024
    let GL_STENCIL_TEST : int = 2960
    let GL_SUBPIXEL_BITS : int = 3408
    let GL_TEXTURE : int = 5890
    let GL_TEXTURE_2D : int = 3553
    let GL_TEXTURE_COORD_ARRAY : int = 32888
    let GL_TEXTURE_ENV : int = 8960
    let GL_TEXTURE_ENV_COLOR : int = 8705
    let GL_TEXTURE_ENV_MODE : int = 8704
    let GL_TEXTURE_MAG_FILTER : int = 10240
    let GL_TEXTURE_MIN_FILTER : int = 10241
    let GL_TEXTURE_WRAP_S : int = 10242
    let GL_TEXTURE_WRAP_T : int = 10243
    let GL_TEXTURE0 : int = 33984
    let GL_TEXTURE1 : int = 33985
    let GL_TEXTURE2 : int = 33986
    let GL_TEXTURE3 : int = 33987
    let GL_TEXTURE4 : int = 33988
    let GL_TEXTURE5 : int = 33989
    let GL_TEXTURE6 : int = 33990
    let GL_TEXTURE7 : int = 33991
    let GL_TEXTURE8 : int = 33992
    let GL_TEXTURE9 : int = 33993
    let GL_TEXTURE10 : int = 33994
    let GL_TEXTURE11 : int = 33995
    let GL_TEXTURE12 : int = 33996
    let GL_TEXTURE13 : int = 33997
    let GL_TEXTURE14 : int = 33998
    let GL_TEXTURE15 : int = 33999
    let GL_TEXTURE16 : int = 34000
    let GL_TEXTURE17 : int = 34001
    let GL_TEXTURE18 : int = 34002
    let GL_TEXTURE19 : int = 34003
    let GL_TEXTURE20 : int = 34004
    let GL_TEXTURE21 : int = 34005
    let GL_TEXTURE22 : int = 34006
    let GL_TEXTURE23 : int = 34007
    let GL_TEXTURE24 : int = 34008
    let GL_TEXTURE25 : int = 34009
    let GL_TEXTURE26 : int = 34010
    let GL_TEXTURE27 : int = 34011
    let GL_TEXTURE28 : int = 34012
    let GL_TEXTURE29 : int = 34013
    let GL_TEXTURE30 : int = 34014
    let GL_TEXTURE31 : int = 34015
    let GL_TRIANGLE_FAN : int = 6
    let GL_TRIANGLE_STRIP : int = 5
    let GL_TRIANGLES : int = 4
    let GL_TRUE : int = 1
    let GL_UNPACK_ALIGNMENT : int = 3317
    let GL_UNSIGNED_BYTE : int = 5121
    let GL_UNSIGNED_SHORT : int = 5123
    let GL_UNSIGNED_SHORT_4_4_4_4 : int = 32819
    let GL_UNSIGNED_SHORT_5_5_5_1 : int = 32820
    let GL_UNSIGNED_SHORT_5_6_5 : int = 33635
    let GL_VENDOR : int = 7936
    let GL_VERSION : int = 7938
    let GL_VERTEX_ARRAY : int = 32884
    let GL_XOR : int = 5382
    let GL_ZERO : int = 0


