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
type ColorChangeEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_eventHandler : ColorChangeEventHandler
    static member eventHandler with get() : ColorChangeEventHandler = (ColorChangeEventHandler.jclinit(); ColorChangeEventHandler.jcell_eventHandler) and set (jvalue: ColorChangeEventHandler) = (ColorChangeEventHandler.jclinit(); ColorChangeEventHandler.jcell_eventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorChangeEventHandler.jclinitDone then
            ColorChangeEventHandler.jclinitDone <- true
            ColorChangeEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ColorChangeEventHandler.jcell_eventHandler <- (new ColorChangeEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : ColorChangeEventHandler =
        ColorChangeEventHandler.eventHandler


