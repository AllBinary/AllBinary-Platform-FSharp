namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullGL10 =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GL10 : NullGL10
    static member NULL_GL10 with get() : NullGL10 = (NullGL10.jclinit(); NullGL10.jcell_NULL_GL10) and set (jvalue: NullGL10) = (NullGL10.jclinit(); NullGL10.jcell_NULL_GL10 <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullGL10.jclinitDone then
            NullGL10.jclinitDone <- true
            NullGL10.jclinitBody()
    static member private jclinitBody() : unit =
        NullGL10.jcell_NULL_GL10 <- (new NullGL10())
        ()
    new () =
        {  }
    
    abstract glActiveTexture : texture: int -> unit
    default this.glActiveTexture(texture: int) : unit =
        ()
    
    abstract glAlphaFunc : func: int * ref_: float32 -> unit
    default this.glAlphaFunc(func: int, ref_: float32) : unit =
        ()
    
    abstract glBindTexture : target: int * texture: int -> unit
    default this.glBindTexture(target: int, texture: int) : unit =
        ()
    
    abstract glBlendFunc : sfactor: int * dfactor: int -> unit
    default this.glBlendFunc(sfactor: int, dfactor: int) : unit =
        ()
    
    abstract glClear : mask: int -> unit
    default this.glClear(mask: int) : unit =
        ()
    
    abstract glClearColor : red: float32 * green: float32 * blue: float32 * alpha: float32 -> unit
    default this.glClearColor(red: float32, green: float32, blue: float32, alpha: float32) : unit =
        ()
    
    abstract glClearDepthf : depth: float32 -> unit
    default this.glClearDepthf(depth: float32) : unit =
        ()
    
    abstract glClearStencil : s: int -> unit
    default this.glClearStencil(s: int) : unit =
        ()
    
    abstract glClientActiveTexture : texture: int -> unit
    default this.glClientActiveTexture(texture: int) : unit =
        ()
    
    abstract glColor4f : red: float32 * green: float32 * blue: float32 * alpha: float32 -> unit
    default this.glColor4f(red: float32, green: float32, blue: float32, alpha: float32) : unit =
        ()
    
    abstract glColorMask : red: bool * green: bool * blue: bool * alpha: bool -> unit
    default this.glColorMask(red: bool, green: bool, blue: bool, alpha: bool) : unit =
        ()
    
    abstract glColorPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    default this.glColorPointer(size: int, type_: int, stride: int, pointer: Buffer) : unit =
        ()
    
    abstract glCompressedTexImage2D : target: int * level: int * internalformat: int * width: int * height: int * border: int * imageSize: int * data: Buffer -> unit
    default this.glCompressedTexImage2D(target: int, level: int, internalformat: int, width: int, height: int, border: int, imageSize: int, data: Buffer) : unit =
        ()
    
    abstract glCompressedTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * width: int * height: int * format: int * imageSize: int * data: Buffer -> unit
    default this.glCompressedTexSubImage2D(target: int, level: int, xoffset: int, yoffset: int, width: int, height: int, format: int, imageSize: int, data: Buffer) : unit =
        ()
    
    abstract glCopyTexImage2D : target: int * level: int * internalformat: int * x: int * y: int * width: int * height: int * border: int -> unit
    default this.glCopyTexImage2D(target: int, level: int, internalformat: int, x: int, y: int, width: int, height: int, border: int) : unit =
        ()
    
    abstract glCopyTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * x: int * y: int * width: int * height: int -> unit
    default this.glCopyTexSubImage2D(target: int, level: int, xoffset: int, yoffset: int, x: int, y: int, width: int, height: int) : unit =
        ()
    
    abstract glCullFace : mode: int -> unit
    default this.glCullFace(mode: int) : unit =
        ()
    
    abstract glDeleteTextures : n: int * textures: int[] * offset: int -> unit
    default this.glDeleteTextures(n: int, textures: int[], offset: int) : unit =
        ()
    
    abstract glDeleteTextures : n: int * textures: IntBuffer -> unit
    default this.glDeleteTextures(n: int, textures: IntBuffer) : unit =
        ()
    
    abstract glDepthFunc : func: int -> unit
    default this.glDepthFunc(func: int) : unit =
        ()
    
    abstract glDepthMask : flag: bool -> unit
    default this.glDepthMask(flag: bool) : unit =
        ()
    
    abstract glDepthRangef : zNear: float32 * zFar: float32 -> unit
    default this.glDepthRangef(zNear: float32, zFar: float32) : unit =
        ()
    
    abstract glDisable : cap: int -> unit
    default this.glDisable(cap: int) : unit =
        ()
    
    abstract glDisableClientState : array_: int -> unit
    default this.glDisableClientState(array_: int) : unit =
        ()
    
    abstract glDrawArrays : mode: int * first: int * count: int -> unit
    default this.glDrawArrays(mode: int, first: int, count: int) : unit =
        ()
    
    abstract glDrawElements : mode: int * count: int * type_: int * indices: Buffer -> unit
    default this.glDrawElements(mode: int, count: int, type_: int, indices: Buffer) : unit =
        ()
    
    abstract glEnable : cap: int -> unit
    default this.glEnable(cap: int) : unit =
        ()
    
    abstract glEnableClientState : array_: int -> unit
    default this.glEnableClientState(array_: int) : unit =
        ()
    
    abstract glFinish : unit -> unit
    default this.glFinish() : unit =
        ()
    
    abstract glFlush : unit -> unit
    default this.glFlush() : unit =
        ()
    
    abstract glFogf : pname: int * param: float32 -> unit
    default this.glFogf(pname: int, param: float32) : unit =
        ()
    
    abstract glFogfv : pname: int * params_: float32[] * offset: int -> unit
    default this.glFogfv(pname: int, params_: float32[], offset: int) : unit =
        ()
    
    abstract glFogfv : pname: int * params_: FloatBuffer -> unit
    default this.glFogfv(pname: int, params_: FloatBuffer) : unit =
        ()
    
    abstract glFrontFace : mode: int -> unit
    default this.glFrontFace(mode: int) : unit =
        ()
    
    abstract glFrustumf : left: float32 * right: float32 * bottom: float32 * top: float32 * zNear: float32 * zFar: float32 -> unit
    default this.glFrustumf(left: float32, right: float32, bottom: float32, top: float32, zNear: float32, zFar: float32) : unit =
        ()
    
    abstract glGenTextures : n: int * textures: int[] * offset: int -> unit
    default this.glGenTextures(n: int, textures: int[], offset: int) : unit =
        ()
    
    abstract glGenTextures : n: int * textures: IntBuffer -> unit
    default this.glGenTextures(n: int, textures: IntBuffer) : unit =
        ()
    
    abstract glGetError : unit -> int
    default this.glGetError() : int =
        0
    
    abstract glGetIntegerv : pname: int * params_: int[] * offset: int -> unit
    default this.glGetIntegerv(pname: int, params_: int[], offset: int) : unit =
        ()
    
    abstract glGetIntegerv : pname: int * params_: IntBuffer -> unit
    default this.glGetIntegerv(pname: int, params_: IntBuffer) : unit =
        ()
    
    abstract glGetString : name: int -> string
    default this.glGetString(name: int) : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract glHint : target: int * mode: int -> unit
    default this.glHint(target: int, mode: int) : unit =
        ()
    
    abstract glLightModelf : pname: int * param: float32 -> unit
    default this.glLightModelf(pname: int, param: float32) : unit =
        ()
    
    abstract glLightModelfv : pname: int * params_: float32[] * offset: int -> unit
    default this.glLightModelfv(pname: int, params_: float32[], offset: int) : unit =
        ()
    
    abstract glLightModelfv : pname: int * params_: FloatBuffer -> unit
    default this.glLightModelfv(pname: int, params_: FloatBuffer) : unit =
        ()
    
    abstract glLightf : light: int * pname: int * param: float32 -> unit
    default this.glLightf(light: int, pname: int, param: float32) : unit =
        ()
    
    abstract glLightfv : light: int * pname: int * params_: float32[] * offset: int -> unit
    default this.glLightfv(light: int, pname: int, params_: float32[], offset: int) : unit =
        ()
    
    abstract glLightfv : light: int * pname: int * params_: FloatBuffer -> unit
    default this.glLightfv(light: int, pname: int, params_: FloatBuffer) : unit =
        ()
    
    abstract glLineWidth : width: float32 -> unit
    default this.glLineWidth(width: float32) : unit =
        ()
    
    abstract glLoadIdentity : unit -> unit
    default this.glLoadIdentity() : unit =
        ()
    
    abstract glLoadMatrixf : m: float32[] * offset: int -> unit
    default this.glLoadMatrixf(m: float32[], offset: int) : unit =
        ()
    
    abstract glLoadMatrixf : m: FloatBuffer -> unit
    default this.glLoadMatrixf(m: FloatBuffer) : unit =
        ()
    
    abstract glLogicOp : opcode: int -> unit
    default this.glLogicOp(opcode: int) : unit =
        ()
    
    abstract glMaterialf : face: int * pname: int * param: float32 -> unit
    default this.glMaterialf(face: int, pname: int, param: float32) : unit =
        ()
    
    abstract glMaterialfv : face: int * pname: int * params_: float32[] * offset: int -> unit
    default this.glMaterialfv(face: int, pname: int, params_: float32[], offset: int) : unit =
        ()
    
    abstract glMaterialfv : face: int * pname: int * params_: FloatBuffer -> unit
    default this.glMaterialfv(face: int, pname: int, params_: FloatBuffer) : unit =
        ()
    
    abstract glMatrixMode : mode: int -> unit
    default this.glMatrixMode(mode: int) : unit =
        ()
    
    abstract glMultMatrixf : m: float32[] * offset: int -> unit
    default this.glMultMatrixf(m: float32[], offset: int) : unit =
        ()
    
    abstract glMultMatrixf : m: FloatBuffer -> unit
    default this.glMultMatrixf(m: FloatBuffer) : unit =
        ()
    
    abstract glMultiTexCoord4f : target: int * s: float32 * t: float32 * r: float32 * q: float32 -> unit
    default this.glMultiTexCoord4f(target: int, s: float32, t: float32, r: float32, q: float32) : unit =
        ()
    
    abstract glNormal3f : nx: float32 * ny: float32 * nz: float32 -> unit
    default this.glNormal3f(nx: float32, ny: float32, nz: float32) : unit =
        ()
    
    abstract glNormalPointer : type_: int * stride: int * pointer: Buffer -> unit
    default this.glNormalPointer(type_: int, stride: int, pointer: Buffer) : unit =
        ()
    
    abstract glOrthof : left: float32 * right: float32 * bottom: float32 * top: float32 * zNear: float32 * zFar: float32 -> unit
    default this.glOrthof(left: float32, right: float32, bottom: float32, top: float32, zNear: float32, zFar: float32) : unit =
        ()
    
    abstract glPixelStorei : pname: int * param: int -> unit
    default this.glPixelStorei(pname: int, param: int) : unit =
        ()
    
    abstract glPointSize : size: float32 -> unit
    default this.glPointSize(size: float32) : unit =
        ()
    
    abstract glPolygonOffset : factor: float32 * units: float32 -> unit
    default this.glPolygonOffset(factor: float32, units: float32) : unit =
        ()
    
    abstract glPopMatrix : unit -> unit
    default this.glPopMatrix() : unit =
        ()
    
    abstract glPushMatrix : unit -> unit
    default this.glPushMatrix() : unit =
        ()
    
    abstract glReadPixels : x: int * y: int * width: int * height: int * format: int * type_: int * pixels: Buffer -> unit
    default this.glReadPixels(x: int, y: int, width: int, height: int, format: int, type_: int, pixels: Buffer) : unit =
        ()
    
    abstract glRotatef : angle: float32 * x: float32 * y: float32 * z: float32 -> unit
    default this.glRotatef(angle: float32, x: float32, y: float32, z: float32) : unit =
        ()
    
    abstract glRotatex : angle: int * x: int * y: int * z: int -> unit
    default this.glRotatex(angle: int, x: int, y: int, z: int) : unit =
        ()
    
    abstract glSampleCoverage : value: float32 * invert: bool -> unit
    default this.glSampleCoverage(value: float32, invert: bool) : unit =
        ()
    
    abstract glScalef : x: float32 * y: float32 * z: float32 -> unit
    default this.glScalef(x: float32, y: float32, z: float32) : unit =
        ()
    
    abstract glScalex : x: int * y: int * z: int -> unit
    default this.glScalex(x: int, y: int, z: int) : unit =
        ()
    
    abstract glScissor : x: int * y: int * width: int * height: int -> unit
    default this.glScissor(x: int, y: int, width: int, height: int) : unit =
        ()
    
    abstract glShadeModel : mode: int -> unit
    default this.glShadeModel(mode: int) : unit =
        ()
    
    abstract glStencilFunc : func: int * ref_: int * mask: int -> unit
    default this.glStencilFunc(func: int, ref_: int, mask: int) : unit =
        ()
    
    abstract glStencilMask : mask: int -> unit
    default this.glStencilMask(mask: int) : unit =
        ()
    
    abstract glStencilOp : fail: int * zfail: int * zpass: int -> unit
    default this.glStencilOp(fail: int, zfail: int, zpass: int) : unit =
        ()
    
    abstract glTexCoordPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    default this.glTexCoordPointer(size: int, type_: int, stride: int, pointer: Buffer) : unit =
        ()
    
    abstract glTexEnvf : target: int * pname: int * param: float32 -> unit
    default this.glTexEnvf(target: int, pname: int, param: float32) : unit =
        ()
    
    abstract glTexEnvfv : target: int * pname: int * params_: float32[] * offset: int -> unit
    default this.glTexEnvfv(target: int, pname: int, params_: float32[], offset: int) : unit =
        ()
    
    abstract glTexEnvfv : target: int * pname: int * params_: FloatBuffer -> unit
    default this.glTexEnvfv(target: int, pname: int, params_: FloatBuffer) : unit =
        ()
    
    abstract glTexImage2D : target: int * level: int * internalformat: int * width: int * height: int * border: int * format: int * type_: int * pixels: Buffer -> unit
    default this.glTexImage2D(target: int, level: int, internalformat: int, width: int, height: int, border: int, format: int, type_: int, pixels: Buffer) : unit =
        ()
    
    abstract glTexParameterf : target: int * pname: int * param: float32 -> unit
    default this.glTexParameterf(target: int, pname: int, param: float32) : unit =
        ()
    
    abstract glTexParameteri : target: int * pname: int * param: int -> unit
    default this.glTexParameteri(target: int, pname: int, param: int) : unit =
        ()
    
    abstract glTexSubImage2D : target: int * level: int * xoffset: int * yoffset: int * width: int * height: int * format: int * type_: int * pixels: Buffer -> unit
    default this.glTexSubImage2D(target: int, level: int, xoffset: int, yoffset: int, width: int, height: int, format: int, type_: int, pixels: Buffer) : unit =
        ()
    
    abstract glTranslatef : x: float32 * y: float32 * z: float32 -> unit
    default this.glTranslatef(x: float32, y: float32, z: float32) : unit =
        ()
    
    abstract glVertexPointer : size: int * type_: int * stride: int * pointer: Buffer -> unit
    default this.glVertexPointer(size: int, type_: int, stride: int, pointer: Buffer) : unit =
        ()
    
    abstract glViewport : x: int * y: int * width: int * height: int -> unit
    default this.glViewport(x: int, y: int, width: int, height: int) : unit =
        ()
    
    abstract glBegin : i: int -> unit
    default this.glBegin(i: int) : unit =
        ()
    
    abstract glEnd : unit -> unit
    default this.glEnd() : unit =
        ()
    
    abstract glVertex3f : f: float32 * f2: float32 * f3: float32 -> unit
    default this.glVertex3f(f: float32, f2: float32, f3: float32) : unit =
        ()
    
    abstract glPolygonMode : i: int * i1: int -> unit
    default this.glPolygonMode(i: int, i1: int) : unit =
        ()
    interface GL10 with
        member this.glActiveTexture(jp0: int) : unit = this.glActiveTexture(jp0)
        member this.glAlphaFunc(jp0: int, jp1: float32) : unit = this.glAlphaFunc(jp0, jp1)
        member this.glBindTexture(jp0: int, jp1: int) : unit = this.glBindTexture(jp0, jp1)
        member this.glBlendFunc(jp0: int, jp1: int) : unit = this.glBlendFunc(jp0, jp1)
        member this.glClear(jp0: int) : unit = this.glClear(jp0)
        member this.glClearColor(jp0: float32, jp1: float32, jp2: float32, jp3: float32) : unit = this.glClearColor(jp0, jp1, jp2, jp3)
        member this.glClearDepthf(jp0: float32) : unit = this.glClearDepthf(jp0)
        member this.glClearStencil(jp0: int) : unit = this.glClearStencil(jp0)
        member this.glClientActiveTexture(jp0: int) : unit = this.glClientActiveTexture(jp0)
        member this.glColor4f(jp0: float32, jp1: float32, jp2: float32, jp3: float32) : unit = this.glColor4f(jp0, jp1, jp2, jp3)
        member this.glColorMask(jp0: bool, jp1: bool, jp2: bool, jp3: bool) : unit = this.glColorMask(jp0, jp1, jp2, jp3)
        member this.glColorPointer(jp0: int, jp1: int, jp2: int, jp3: Buffer) : unit = this.glColorPointer(jp0, jp1, jp2, jp3)
        member this.glCompressedTexImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: Buffer) : unit = this.glCompressedTexImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7)
        member this.glCompressedTexSubImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: int, jp8: Buffer) : unit = this.glCompressedTexSubImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7, jp8)
        member this.glCopyTexImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: int) : unit = this.glCopyTexImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7)
        member this.glCopyTexSubImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: int) : unit = this.glCopyTexSubImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7)
        member this.glCullFace(jp0: int) : unit = this.glCullFace(jp0)
        member this.glDeleteTextures(jp0: int, jp1: int[], jp2: int) : unit = this.glDeleteTextures(jp0, jp1, jp2)
        member this.glDeleteTextures(jp0: int, jp1: IntBuffer) : unit = this.glDeleteTextures(jp0, jp1)
        member this.glDepthFunc(jp0: int) : unit = this.glDepthFunc(jp0)
        member this.glDepthMask(jp0: bool) : unit = this.glDepthMask(jp0)
        member this.glDepthRangef(jp0: float32, jp1: float32) : unit = this.glDepthRangef(jp0, jp1)
        member this.glDisable(jp0: int) : unit = this.glDisable(jp0)
        member this.glDisableClientState(jp0: int) : unit = this.glDisableClientState(jp0)
        member this.glDrawArrays(jp0: int, jp1: int, jp2: int) : unit = this.glDrawArrays(jp0, jp1, jp2)
        member this.glDrawElements(jp0: int, jp1: int, jp2: int, jp3: Buffer) : unit = this.glDrawElements(jp0, jp1, jp2, jp3)
        member this.glEnable(jp0: int) : unit = this.glEnable(jp0)
        member this.glEnableClientState(jp0: int) : unit = this.glEnableClientState(jp0)
        member this.glFinish() : unit = this.glFinish()
        member this.glFlush() : unit = this.glFlush()
        member this.glFogf(jp0: int, jp1: float32) : unit = this.glFogf(jp0, jp1)
        member this.glFogfv(jp0: int, jp1: float32[], jp2: int) : unit = this.glFogfv(jp0, jp1, jp2)
        member this.glFogfv(jp0: int, jp1: FloatBuffer) : unit = this.glFogfv(jp0, jp1)
        member this.glFrontFace(jp0: int) : unit = this.glFrontFace(jp0)
        member this.glFrustumf(jp0: float32, jp1: float32, jp2: float32, jp3: float32, jp4: float32, jp5: float32) : unit = this.glFrustumf(jp0, jp1, jp2, jp3, jp4, jp5)
        member this.glGenTextures(jp0: int, jp1: int[], jp2: int) : unit = this.glGenTextures(jp0, jp1, jp2)
        member this.glGenTextures(jp0: int, jp1: IntBuffer) : unit = this.glGenTextures(jp0, jp1)
        member this.glGetError() : int = this.glGetError()
        member this.glGetIntegerv(jp0: int, jp1: int[], jp2: int) : unit = this.glGetIntegerv(jp0, jp1, jp2)
        member this.glGetIntegerv(jp0: int, jp1: IntBuffer) : unit = this.glGetIntegerv(jp0, jp1)
        member this.glGetString(jp0: int) : string = this.glGetString(jp0)
        member this.glHint(jp0: int, jp1: int) : unit = this.glHint(jp0, jp1)
        member this.glLightModelf(jp0: int, jp1: float32) : unit = this.glLightModelf(jp0, jp1)
        member this.glLightModelfv(jp0: int, jp1: float32[], jp2: int) : unit = this.glLightModelfv(jp0, jp1, jp2)
        member this.glLightModelfv(jp0: int, jp1: FloatBuffer) : unit = this.glLightModelfv(jp0, jp1)
        member this.glLightf(jp0: int, jp1: int, jp2: float32) : unit = this.glLightf(jp0, jp1, jp2)
        member this.glLightfv(jp0: int, jp1: int, jp2: float32[], jp3: int) : unit = this.glLightfv(jp0, jp1, jp2, jp3)
        member this.glLightfv(jp0: int, jp1: int, jp2: FloatBuffer) : unit = this.glLightfv(jp0, jp1, jp2)
        member this.glLineWidth(jp0: float32) : unit = this.glLineWidth(jp0)
        member this.glLoadIdentity() : unit = this.glLoadIdentity()
        member this.glLoadMatrixf(jp0: float32[], jp1: int) : unit = this.glLoadMatrixf(jp0, jp1)
        member this.glLoadMatrixf(jp0: FloatBuffer) : unit = this.glLoadMatrixf(jp0)
        member this.glLogicOp(jp0: int) : unit = this.glLogicOp(jp0)
        member this.glMaterialf(jp0: int, jp1: int, jp2: float32) : unit = this.glMaterialf(jp0, jp1, jp2)
        member this.glMaterialfv(jp0: int, jp1: int, jp2: float32[], jp3: int) : unit = this.glMaterialfv(jp0, jp1, jp2, jp3)
        member this.glMaterialfv(jp0: int, jp1: int, jp2: FloatBuffer) : unit = this.glMaterialfv(jp0, jp1, jp2)
        member this.glMatrixMode(jp0: int) : unit = this.glMatrixMode(jp0)
        member this.glMultMatrixf(jp0: float32[], jp1: int) : unit = this.glMultMatrixf(jp0, jp1)
        member this.glMultMatrixf(jp0: FloatBuffer) : unit = this.glMultMatrixf(jp0)
        member this.glMultiTexCoord4f(jp0: int, jp1: float32, jp2: float32, jp3: float32, jp4: float32) : unit = this.glMultiTexCoord4f(jp0, jp1, jp2, jp3, jp4)
        member this.glNormal3f(jp0: float32, jp1: float32, jp2: float32) : unit = this.glNormal3f(jp0, jp1, jp2)
        member this.glNormalPointer(jp0: int, jp1: int, jp2: Buffer) : unit = this.glNormalPointer(jp0, jp1, jp2)
        member this.glOrthof(jp0: float32, jp1: float32, jp2: float32, jp3: float32, jp4: float32, jp5: float32) : unit = this.glOrthof(jp0, jp1, jp2, jp3, jp4, jp5)
        member this.glPixelStorei(jp0: int, jp1: int) : unit = this.glPixelStorei(jp0, jp1)
        member this.glPointSize(jp0: float32) : unit = this.glPointSize(jp0)
        member this.glPolygonOffset(jp0: float32, jp1: float32) : unit = this.glPolygonOffset(jp0, jp1)
        member this.glPopMatrix() : unit = this.glPopMatrix()
        member this.glPushMatrix() : unit = this.glPushMatrix()
        member this.glReadPixels(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: Buffer) : unit = this.glReadPixels(jp0, jp1, jp2, jp3, jp4, jp5, jp6)
        member this.glRotatef(jp0: float32, jp1: float32, jp2: float32, jp3: float32) : unit = this.glRotatef(jp0, jp1, jp2, jp3)
        member this.glRotatex(jp0: int, jp1: int, jp2: int, jp3: int) : unit = this.glRotatex(jp0, jp1, jp2, jp3)
        member this.glSampleCoverage(jp0: float32, jp1: bool) : unit = this.glSampleCoverage(jp0, jp1)
        member this.glScalef(jp0: float32, jp1: float32, jp2: float32) : unit = this.glScalef(jp0, jp1, jp2)
        member this.glScalex(jp0: int, jp1: int, jp2: int) : unit = this.glScalex(jp0, jp1, jp2)
        member this.glScissor(jp0: int, jp1: int, jp2: int, jp3: int) : unit = this.glScissor(jp0, jp1, jp2, jp3)
        member this.glShadeModel(jp0: int) : unit = this.glShadeModel(jp0)
        member this.glStencilFunc(jp0: int, jp1: int, jp2: int) : unit = this.glStencilFunc(jp0, jp1, jp2)
        member this.glStencilMask(jp0: int) : unit = this.glStencilMask(jp0)
        member this.glStencilOp(jp0: int, jp1: int, jp2: int) : unit = this.glStencilOp(jp0, jp1, jp2)
        member this.glTexCoordPointer(jp0: int, jp1: int, jp2: int, jp3: Buffer) : unit = this.glTexCoordPointer(jp0, jp1, jp2, jp3)
        member this.glTexEnvf(jp0: int, jp1: int, jp2: float32) : unit = this.glTexEnvf(jp0, jp1, jp2)
        member this.glTexEnvfv(jp0: int, jp1: int, jp2: float32[], jp3: int) : unit = this.glTexEnvfv(jp0, jp1, jp2, jp3)
        member this.glTexEnvfv(jp0: int, jp1: int, jp2: FloatBuffer) : unit = this.glTexEnvfv(jp0, jp1, jp2)
        member this.glTexImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: int, jp8: Buffer) : unit = this.glTexImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7, jp8)
        member this.glTexParameterf(jp0: int, jp1: int, jp2: float32) : unit = this.glTexParameterf(jp0, jp1, jp2)
        member this.glTexParameteri(jp0: int, jp1: int, jp2: int) : unit = this.glTexParameteri(jp0, jp1, jp2)
        member this.glTexSubImage2D(jp0: int, jp1: int, jp2: int, jp3: int, jp4: int, jp5: int, jp6: int, jp7: int, jp8: Buffer) : unit = this.glTexSubImage2D(jp0, jp1, jp2, jp3, jp4, jp5, jp6, jp7, jp8)
        member this.glTranslatef(jp0: float32, jp1: float32, jp2: float32) : unit = this.glTranslatef(jp0, jp1, jp2)
        member this.glVertexPointer(jp0: int, jp1: int, jp2: int, jp3: Buffer) : unit = this.glVertexPointer(jp0, jp1, jp2, jp3)
        member this.glViewport(jp0: int, jp1: int, jp2: int, jp3: int) : unit = this.glViewport(jp0, jp1, jp2, jp3)
        member this.glBegin(jp0: int) : unit = this.glBegin(jp0)
        member this.glEnd() : unit = this.glEnd()
        member this.glVertex3f(jp0: float32, jp1: float32, jp2: float32) : unit = this.glVertex3f(jp0, jp1, jp2)
        member this.glPolygonMode(jp0: int, jp1: int) : unit = this.glPolygonMode(jp0, jp1)
    interface GL


