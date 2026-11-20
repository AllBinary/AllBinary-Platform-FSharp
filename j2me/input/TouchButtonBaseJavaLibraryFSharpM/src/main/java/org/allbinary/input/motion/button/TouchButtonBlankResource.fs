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
type TouchButtonBlankResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonBlankResource.jclinit(); TouchButtonBlankResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonBlankResource.jclinit(); TouchButtonBlankResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonBlankResource.jclinitDone then
            TouchButtonBlankResource.jclinitDone <- true
            TouchButtonBlankResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonBlankResource.jcell_instance <- (new TouchButtonBlankResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonBlankResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_64_by_64.png", "/touch_button_hint_64_by_64.png") }


