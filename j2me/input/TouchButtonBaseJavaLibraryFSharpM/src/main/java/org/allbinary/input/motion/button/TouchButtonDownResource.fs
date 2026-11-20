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
type TouchButtonDownResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonDownResource.jclinit(); TouchButtonDownResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonDownResource.jclinit(); TouchButtonDownResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonDownResource.jclinitDone then
            TouchButtonDownResource.jclinitDone <- true
            TouchButtonDownResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonDownResource.jcell_instance <- (new TouchButtonDownResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonDownResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_down_arrow_64_by_64.png", "/touch_button_down_arrow_hint_64_by_64.png") }


