namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type OpenGLBitmapConfig =
    [<DefaultValue(false)>] val mutable bitmapConfig : obj
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLBitmapConfig.jclinitDone then
            OpenGLBitmapConfig.jclinitDone <- true
            OpenGLBitmapConfig.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (bitmapConfig: obj) as this =
        {  }
        then
            this.jctor1(bitmapConfig)
    member this.jctor1(bitmapConfig: obj) : unit =
        this.bitmapConfig <- bitmapConfig
        ()


