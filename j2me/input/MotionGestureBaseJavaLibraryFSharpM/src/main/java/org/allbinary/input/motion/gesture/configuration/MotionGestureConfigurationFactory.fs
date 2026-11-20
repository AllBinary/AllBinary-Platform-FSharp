namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
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
type MotionGestureConfigurationFactory =
    [<DefaultValue(false)>] static val mutable private jcell_config : MotionGestureConfiguration
    static member config with get() : MotionGestureConfiguration = (MotionGestureConfigurationFactory.jclinit(); MotionGestureConfigurationFactory.jcell_config) and set (jvalue: MotionGestureConfiguration) = (MotionGestureConfigurationFactory.jclinit(); MotionGestureConfigurationFactory.jcell_config <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureConfigurationFactory.jclinitDone then
            MotionGestureConfigurationFactory.jclinitDone <- true
            MotionGestureConfigurationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MotionGestureConfigurationFactory.jcell_config <- (new MotionGestureConfiguration())
        ()
    
    new () =
        {  }
    
    static member getInstance() : MotionGestureConfiguration =
        MotionGestureConfigurationFactory.config


