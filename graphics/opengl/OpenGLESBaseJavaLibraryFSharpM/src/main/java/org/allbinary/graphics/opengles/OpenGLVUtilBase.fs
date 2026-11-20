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
type OpenGLVUtilBase =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLVUtilBase.jclinitDone then
            OpenGLVUtilBase.jclinitDone <- true
            OpenGLVUtilBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract glTexEnvix : gl: GL10 * target: int * pname: int * param: int -> unit
    default this.glTexEnvix(gl: GL10, target: int, pname: int, param: int) : unit =
        ()
    
    abstract glTexParameterix : gl: GL10 * target: int * pname: int * param: int -> unit
    default this.glTexParameterix(gl: GL10, target: int, pname: int, param: int) : unit =
        ()
    
    abstract glGenerateMipmap : gl: GL10 * textureId: int * target: int * generateMipMap: bool -> unit
    default this.glGenerateMipmap(gl: GL10, textureId: int, target: int, generateMipMap: bool) : unit =
        ()


