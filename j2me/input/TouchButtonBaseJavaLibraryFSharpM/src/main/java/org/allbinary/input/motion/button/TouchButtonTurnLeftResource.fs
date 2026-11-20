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
type TouchButtonTurnLeftResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonTurnLeftResource.jclinit(); TouchButtonTurnLeftResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonTurnLeftResource.jclinit(); TouchButtonTurnLeftResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonTurnLeftResource.jclinitDone then
            TouchButtonTurnLeftResource.jclinitDone <- true
            TouchButtonTurnLeftResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonTurnLeftResource.jcell_instance <- (new TouchButtonTurnLeftResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonTurnLeftResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_turn_left_arrow_64_by_64.png", "/touch_button_turn_left_arrow_hint_64_by_64.png") }


