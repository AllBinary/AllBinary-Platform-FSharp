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
type OpenGLESImageProperties =
    [<DefaultValue(false)>] val mutable textureID : int
    [<DefaultValue(false)>] val mutable scaleX : float32
    [<DefaultValue(false)>] val mutable scaleY : float32
    [<DefaultValue(false)>] val mutable scaleX2 : float32
    [<DefaultValue(false)>] val mutable scaleY2 : float32
    [<DefaultValue(false)>] val mutable angle : int
    [<DefaultValue(false)>] val mutable redf : float32
    [<DefaultValue(false)>] val mutable greenf : float32
    [<DefaultValue(false)>] val mutable bluef : float32
    [<DefaultValue(false)>] val mutable alphaf : float32
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESImageProperties.jclinitDone then
            OpenGLESImageProperties.jclinitDone <- true
            OpenGLESImageProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLESImageProperties()
    member this.jfields_OpenGLESImageProperties() : unit =
        this.textureID <- -1
        this.scaleX <- 1.0f
        this.scaleY <- 1.0f
        this.scaleX2 <- 1.0f
        this.scaleY2 <- 1.0f
        this.redf <- 1.0f
        this.greenf <- 1.0f
        this.bluef <- 1.0f
        ()


