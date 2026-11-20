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
type TouchButtonStrafeLeftResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonStrafeLeftResource.jclinit(); TouchButtonStrafeLeftResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonStrafeLeftResource.jclinit(); TouchButtonStrafeLeftResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonStrafeLeftResource.jclinitDone then
            TouchButtonStrafeLeftResource.jclinitDone <- true
            TouchButtonStrafeLeftResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonStrafeLeftResource.jcell_instance <- (new TouchButtonStrafeLeftResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonStrafeLeftResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_strafe_left_arrow_64_by_64.png", "/touch_button_strafe_left_arrow_hint_64_by_64.png") }


