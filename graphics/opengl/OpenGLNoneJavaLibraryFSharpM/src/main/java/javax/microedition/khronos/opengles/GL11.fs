namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type GL11 =
    inherit GL10
    abstract glBindBuffer : target: int * buffer: int -> unit
    abstract glBufferData : target: int * size: int * data: Buffer * usage: int -> unit
    abstract glBufferSubData : target: int * offset: int * size: int * data: Buffer -> unit
    abstract glClipPlanef : plane: int * equation: float32[] * offset: int -> unit
    abstract glClipPlanef : plane: int * equation: FloatBuffer -> unit
    abstract glColor4ub : red: sbyte * green: sbyte * blue: sbyte * alpha: sbyte -> unit
    abstract glColorPointer : size: int * type_: int * stride: int * offset: int -> unit
    abstract glDeleteBuffers : n: int * buffers: int[] * offset: int -> unit
    abstract glDeleteBuffers : n: int * buffers: IntBuffer -> unit
    abstract glDrawElements : mode: int * count: int * type_: int * offset: int -> unit
    abstract glGenBuffers : n: int * buffers: int[] * offset: int -> unit
    abstract glGenBuffers : n: int * buffers: IntBuffer -> unit
    abstract glGetBufferParameteriv : target: int * pname: int * params_: int[] * offset: int -> unit
    abstract glGetBufferParameteriv : target: int * pname: int * params_: IntBuffer -> unit
    abstract glGetClipPlanef : pname: int * eqn: float32[] * offset: int -> unit
    abstract glGetClipPlanef : pname: int * eqn: FloatBuffer -> unit
    abstract glGetFloatv : pname: int * params_: float32[] * offset: int -> unit
    abstract glGetFloatv : pname: int * params_: FloatBuffer -> unit
    abstract glGetLightfv : light: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glGetLightfv : light: int * pname: int * params_: FloatBuffer -> unit
    abstract glGetMaterialfv : face: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glGetMaterialfv : face: int * pname: int * params_: FloatBuffer -> unit
    abstract glGetTexEnviv : env: int * pname: int * params_: int[] * offset: int -> unit
    abstract glGetTexEnviv : env: int * pname: int * params_: IntBuffer -> unit
    abstract glGetTexParameterfv : target: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glGetTexParameterfv : target: int * pname: int * params_: FloatBuffer -> unit
    abstract glGetTexParameteriv : target: int * pname: int * params_: int[] * offset: int -> unit
    abstract glGetTexParameteriv : target: int * pname: int * params_: IntBuffer -> unit
    abstract glIsBuffer : buffer: int -> bool
    abstract glIsEnabled : cap: int -> bool
    abstract glIsTexture : texture: int -> bool
    abstract glNormalPointer : type_: int * stride: int * offset: int -> unit
    abstract glPointParameterf : pname: int * param: float32 -> unit
    abstract glPointParameterfv : pname: int * params_: float32[] * offset: int -> unit
    abstract glPointParameterfv : pname: int * params_: FloatBuffer -> unit
    abstract glTexCoordPointer : size: int * type_: int * stride: int * offset: int -> unit
    abstract glTexEnvi : target: int * pname: int * param: int -> unit
    abstract glTexEnviv : target: int * pname: int * params_: int[] * offset: int -> unit
    abstract glTexEnviv : target: int * pname: int * params_: IntBuffer -> unit
    abstract glTexParameterfv : target: int * pname: int * params_: float32[] * offset: int -> unit
    abstract glTexParameterfv : target: int * pname: int * params_: FloatBuffer -> unit
    abstract glTexParameteriv : target: int * pname: int * params_: int[] * offset: int -> unit
    abstract glTexParameteriv : target: int * pname: int * params_: IntBuffer -> unit
    abstract glVertexPointer : size: int * type_: int * stride: int * offset: int -> unit

module GL11 =
    let GL_ACTIVE_TEXTURE : int = 34016
    let GL_ADD_SIGNED : int = 34164
    let GL_ALPHA_SCALE : int = 3356
    let GL_ALPHA_TEST_FUNC : int = 3009
    let GL_ALPHA_TEST_REF : int = 3010
    let GL_ARRAY_BUFFER : int = 34962
    let GL_ARRAY_BUFFER_BINDING : int = 34964
    let GL_BLEND_DST : int = 3040
    let GL_BLEND_SRC : int = 3041
    let GL_BUFFER_ACCESS : int = 35003
    let GL_BUFFER_SIZE : int = 34660
    let GL_BUFFER_USAGE : int = 34661
    let GL_CLIENT_ACTIVE_TEXTURE : int = 34017
    let GL_CLIP_PLANE0 : int = 12288
    let GL_CLIP_PLANE1 : int = 12289
    let GL_CLIP_PLANE2 : int = 12290
    let GL_CLIP_PLANE3 : int = 12291
    let GL_CLIP_PLANE4 : int = 12292
    let GL_CLIP_PLANE5 : int = 12293
    let GL_COLOR_ARRAY_BUFFER_BINDING : int = 34968
    let GL_COLOR_ARRAY_POINTER : int = 32912
    let GL_COLOR_ARRAY_SIZE : int = 32897
    let GL_COLOR_ARRAY_STRIDE : int = 32899
    let GL_COLOR_ARRAY_TYPE : int = 32898
    let GL_COLOR_CLEAR_VALUE : int = 3106
    let GL_COLOR_WRITEMASK : int = 3107
    let GL_COMBINE : int = 34160
    let GL_COMBINE_ALPHA : int = 34162
    let GL_COMBINE_RGB : int = 34161
    let GL_CONSTANT : int = 34166
    let GL_COORD_REPLACE_OES : int = 34914
    let GL_CULL_FACE_MODE : int = 2885
    let GL_CURRENT_COLOR : int = 2816
    let GL_CURRENT_NORMAL : int = 2818
    let GL_CURRENT_TEXTURE_COORDS : int = 2819
    let GL_DEPTH_CLEAR_VALUE : int = 2931
    let GL_DEPTH_FUNC : int = 2932
    let GL_DEPTH_RANGE : int = 2928
    let GL_DEPTH_WRITEMASK : int = 2930
    let GL_DOT3_RGB : int = 34478
    let GL_DOT3_RGBA : int = 34479
    let GL_DYNAMIC_DRAW : int = 35048
    let GL_ELEMENT_ARRAY_BUFFER : int = 34963
    let GL_ELEMENT_ARRAY_BUFFER_BINDING : int = 34965
    let GL_FRONT_FACE : int = 2886
    let GL_GENERATE_MIPMAP : int = 33169
    let GL_GENERATE_MIPMAP_HINT : int = 33170
    let GL_INTERPOLATE : int = 34165
    let GL_LINE_WIDTH : int = 2849
    let GL_LOGIC_OP_MODE : int = 3056
    let GL_MATRIX_MODE : int = 2976
    let GL_MAX_CLIP_PLANES : int = 3378
    let GL_MODELVIEW_MATRIX : int = 2982
    let GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES : int = 35213
    let GL_MODELVIEW_STACK_DEPTH : int = 2979
    let GL_NORMAL_ARRAY_BUFFER_BINDING : int = 34967
    let GL_NORMAL_ARRAY_POINTER : int = 32911
    let GL_NORMAL_ARRAY_STRIDE : int = 32895
    let GL_NORMAL_ARRAY_TYPE : int = 32894
    let GL_OPERAND0_ALPHA : int = 34200
    let GL_OPERAND0_RGB : int = 34192
    let GL_OPERAND1_ALPHA : int = 34201
    let GL_OPERAND1_RGB : int = 34193
    let GL_OPERAND2_ALPHA : int = 34202
    let GL_OPERAND2_RGB : int = 34194
    let GL_POINT_DISTANCE_ATTENUATION : int = 33065
    let GL_POINT_FADE_THRESHOLD_SIZE : int = 33064
    let GL_POINT_SIZE : int = 2833
    let GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES : int = 35743
    let GL_POINT_SIZE_ARRAY_OES : int = 35740
    let GL_POINT_SIZE_ARRAY_POINTER_OES : int = 35212
    let GL_POINT_SIZE_ARRAY_STRIDE_OES : int = 35211
    let GL_POINT_SIZE_ARRAY_TYPE_OES : int = 35210
    let GL_POINT_SIZE_MAX : int = 33063
    let GL_POINT_SIZE_MIN : int = 33062
    let GL_POINT_SPRITE_OES : int = 34913
    let GL_POLYGON_OFFSET_FACTOR : int = 32824
    let GL_POLYGON_OFFSET_UNITS : int = 10752
    let GL_PREVIOUS : int = 34168
    let GL_PRIMARY_COLOR : int = 34167
    let GL_PROJECTION_MATRIX : int = 2983
    let GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES : int = 35214
    let GL_PROJECTION_STACK_DEPTH : int = 2980
    let GL_RGB_SCALE : int = 34163
    let GL_SAMPLE_BUFFERS : int = 32936
    let GL_SAMPLE_COVERAGE_INVERT : int = 32939
    let GL_SAMPLE_COVERAGE_VALUE : int = 32938
    let GL_SAMPLES : int = 32937
    let GL_SCISSOR_BOX : int = 3088
    let GL_SHADE_MODEL : int = 2900
    let GL_SRC0_ALPHA : int = 34184
    let GL_SRC0_RGB : int = 34176
    let GL_SRC1_ALPHA : int = 34185
    let GL_SRC1_RGB : int = 34177
    let GL_SRC2_ALPHA : int = 34186
    let GL_SRC2_RGB : int = 34178
    let GL_STATIC_DRAW : int = 35044
    let GL_STENCIL_CLEAR_VALUE : int = 2961
    let GL_STENCIL_FAIL : int = 2964
    let GL_STENCIL_FUNC : int = 2962
    let GL_STENCIL_PASS_DEPTH_FAIL : int = 2965
    let GL_STENCIL_PASS_DEPTH_PASS : int = 2966
    let GL_STENCIL_REF : int = 2967
    let GL_STENCIL_VALUE_MASK : int = 2963
    let GL_STENCIL_WRITEMASK : int = 2968
    let GL_SUBTRACT : int = 34023
    let GL_TEXTURE_BINDING_2D : int = 32873
    let GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING : int = 34970
    let GL_TEXTURE_COORD_ARRAY_POINTER : int = 32914
    let GL_TEXTURE_COORD_ARRAY_SIZE : int = 32904
    let GL_TEXTURE_COORD_ARRAY_STRIDE : int = 32906
    let GL_TEXTURE_COORD_ARRAY_TYPE : int = 32905
    let GL_TEXTURE_MATRIX : int = 2984
    let GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES : int = 35215
    let GL_TEXTURE_STACK_DEPTH : int = 2981
    let GL_VERTEX_ARRAY_BUFFER_BINDING : int = 34966
    let GL_VERTEX_ARRAY_POINTER : int = 32910
    let GL_VERTEX_ARRAY_SIZE : int = 32890
    let GL_VERTEX_ARRAY_STRIDE : int = 32892
    let GL_VERTEX_ARRAY_TYPE : int = 32891
    let GL_VIEWPORT : int = 2978
    let GL_WRITE_ONLY : int = 35001


