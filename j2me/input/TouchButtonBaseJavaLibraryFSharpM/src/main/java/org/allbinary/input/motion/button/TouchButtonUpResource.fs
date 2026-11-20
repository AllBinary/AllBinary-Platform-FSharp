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
type TouchButtonUpResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonUpResource.jclinit(); TouchButtonUpResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonUpResource.jclinit(); TouchButtonUpResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonUpResource.jclinitDone then
            TouchButtonUpResource.jclinitDone <- true
            TouchButtonUpResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonUpResource.jcell_instance <- (new TouchButtonUpResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonUpResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_up_arrow_64_by_64.png", "/touch_button_up_arrow_hint_64_by_64.png") }


