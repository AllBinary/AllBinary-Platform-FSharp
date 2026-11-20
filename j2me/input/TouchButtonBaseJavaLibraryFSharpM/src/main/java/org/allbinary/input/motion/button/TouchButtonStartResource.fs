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
type TouchButtonStartResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonStartResource.jclinit(); TouchButtonStartResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonStartResource.jclinit(); TouchButtonStartResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonStartResource.jclinitDone then
            TouchButtonStartResource.jclinitDone <- true
            TouchButtonStartResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonStartResource.jcell_instance <- (new TouchButtonStartResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonStartResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_start_64_by_64.png", "/touch_button_start_hint_64_by_64.png") }


