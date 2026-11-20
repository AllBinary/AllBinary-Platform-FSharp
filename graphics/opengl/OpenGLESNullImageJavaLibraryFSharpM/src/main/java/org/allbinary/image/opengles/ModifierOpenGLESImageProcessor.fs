namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type ModifierOpenGLESImageProcessor =
    inherit OpenGLESImageProcessor
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : ModifierOpenGLESImageProcessor
    static member instanceC with get() : ModifierOpenGLESImageProcessor = (ModifierOpenGLESImageProcessor.jclinit(); ModifierOpenGLESImageProcessor.jcell_instanceC) and set (jvalue: ModifierOpenGLESImageProcessor) = (ModifierOpenGLESImageProcessor.jclinit(); ModifierOpenGLESImageProcessor.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ModifierOpenGLESImageProcessor.jclinitDone then
            ModifierOpenGLESImageProcessor.jclinitDone <- true
            ModifierOpenGLESImageProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ModifierOpenGLESImageProcessor.jcell_instanceC <- (new ModifierOpenGLESImageProcessor())
        ()
    new () =
        { inherit OpenGLESImageProcessor() }
    
    static member getInstance() : ModifierOpenGLESImageProcessor =
        ModifierOpenGLESImageProcessor.instanceC


