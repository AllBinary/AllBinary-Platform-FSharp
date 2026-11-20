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
type OpenGLESDeviceImageTranslate =
    inherit OpenGLESImageTranslate
    [<DefaultValue(false)>] val mutable translateX : float32
    [<DefaultValue(false)>] val mutable translateY : float32
    [<DefaultValue(false)>] val mutable translateX2 : float32
    [<DefaultValue(false)>] val mutable translateY2 : float32
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESDeviceImageTranslate.jclinitDone then
            OpenGLESDeviceImageTranslate.jclinitDone <- true
            OpenGLESDeviceImageTranslate.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit OpenGLESImageTranslate() }
        then
            this.jfields_OpenGLESDeviceImageTranslate()
    member this.jfields_OpenGLESDeviceImageTranslate() : unit =
        this.translateX <- 0.0f
        this.translateY <- 0.0f
        this.translateX2 <- 0.0f
        this.translateY2 <- 0.0f
        ()
    
    override this.translate(gl: GL10, openGLESImage: OpenGLESImage, x: float32, y: float32) : unit =
        openGLESImage.imageProcessor.translate(gl, (this.translateX + (openGLESImage.openGLESImageProperties.scaleX * x)), (this.translateY + (openGLESImage.openGLESImageProperties.scaleY * y)))
    
    override this.translate2(gl: GL10, openGLESImage: OpenGLESImage) : unit =
        openGLESImage.imageProcessor.translate(gl, this.translateX2, this.translateY2)


