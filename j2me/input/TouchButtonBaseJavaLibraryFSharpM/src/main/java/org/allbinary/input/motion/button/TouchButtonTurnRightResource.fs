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
type TouchButtonTurnRightResource =
    inherit TouchButtonResource
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchButtonResource
    static member instance with get() : TouchButtonResource = (TouchButtonTurnRightResource.jclinit(); TouchButtonTurnRightResource.jcell_instance) and set (jvalue: TouchButtonResource) = (TouchButtonTurnRightResource.jclinit(); TouchButtonTurnRightResource.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonTurnRightResource.jclinitDone then
            TouchButtonTurnRightResource.jclinitDone <- true
            TouchButtonTurnRightResource.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonTurnRightResource.jcell_instance <- (new TouchButtonTurnRightResource())
        ()
    
    static member getInstance() : TouchButtonResource =
        TouchButtonTurnRightResource.instance
    
    new () =
        { inherit TouchButtonResource("/touch_button_turn_right_arrow_64_by_64.png", "/touch_button_turn_right_arrow_hint_64_by_64.png") }


