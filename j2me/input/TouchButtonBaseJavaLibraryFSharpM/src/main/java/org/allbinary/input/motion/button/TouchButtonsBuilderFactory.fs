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
type TouchButtonsBuilderFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NO_TOUCH_BUTTON_BUILDER_FACTORY : TouchButtonsBuilderFactory
    static member NO_TOUCH_BUTTON_BUILDER_FACTORY with get() : TouchButtonsBuilderFactory = (TouchButtonsBuilderFactory.jclinit(); TouchButtonsBuilderFactory.jcell_NO_TOUCH_BUTTON_BUILDER_FACTORY) and set (jvalue: TouchButtonsBuilderFactory) = (TouchButtonsBuilderFactory.jclinit(); TouchButtonsBuilderFactory.jcell_NO_TOUCH_BUTTON_BUILDER_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonsBuilderFactory.jclinitDone then
            TouchButtonsBuilderFactory.jclinitDone <- true
            TouchButtonsBuilderFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchButtonsBuilderFactory.jcell_NO_TOUCH_BUTTON_BUILDER_FACTORY <- (new TouchButtonsBuilderFactory())
        ()
    new () =
        {  }
    
    abstract getInstance : unit -> BaseTouchInput
    default this.getInstance() : BaseTouchInput =
        NoButtonsTouchInputFactory.getInstance()


