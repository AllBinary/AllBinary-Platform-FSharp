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
type TouchFeatureFactory =
    [<DefaultValue(false)>] val mutable TOUCH_ENABLED : TouchFeature
    [<DefaultValue(false)>] val mutable SHOW_SCREEN_BUTTONS : TouchFeature
    [<DefaultValue(false)>] val mutable AUTO_HIDE_SHOW_SCREEN_BUTTONS : TouchFeature
    [<DefaultValue(false)>] val mutable HIDE_SCREEN_BUTTONS : TouchFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchFeatureFactory
    static member instance with get() : TouchFeatureFactory = (TouchFeatureFactory.jclinit(); TouchFeatureFactory.jcell_instance) and set (jvalue: TouchFeatureFactory) = (TouchFeatureFactory.jclinit(); TouchFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchFeatureFactory.jclinitDone then
            TouchFeatureFactory.jclinitDone <- true
            TouchFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchFeatureFactory.jcell_instance <- (new TouchFeatureFactory())
        ()
    member this.jfields_TouchFeatureFactory() : unit =
        this.TOUCH_ENABLED <- (new TouchFeature("Touch Enabled"))
        this.SHOW_SCREEN_BUTTONS <- (new TouchFeature("Show"))
        this.AUTO_HIDE_SHOW_SCREEN_BUTTONS <- (new TouchFeature("Auto Hide (One Level)"))
        this.HIDE_SCREEN_BUTTONS <- (new TouchFeature("Hide"))
        ()
    
    static member getInstance() : TouchFeatureFactory =
        TouchFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_TouchFeatureFactory()


