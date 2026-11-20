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
type TouchScreenFactory =
    [<DefaultValue(false)>] val mutable multiTouch : bool
    [<DefaultValue(false)>] val mutable touch : bool
    [<DefaultValue(false)>] val mutable touchScreenType : TouchScreenType
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : TouchScreenFactory
    static member SINGLETON with get() : TouchScreenFactory = (TouchScreenFactory.jclinit(); TouchScreenFactory.jcell_SINGLETON) and set (jvalue: TouchScreenFactory) = (TouchScreenFactory.jclinit(); TouchScreenFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchScreenFactory.jclinitDone then
            TouchScreenFactory.jclinitDone <- true
            TouchScreenFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchScreenFactory.jcell_SINGLETON <- (new TouchScreenFactory())
        ()
    member this.jfields_TouchScreenFactory() : unit =
        this.touchScreenType <- TouchScreenTypesFactory.getInstance().NOTOUCH
        ()
    
    new () as this =
        {  }
        then
            this.jfields_TouchScreenFactory()
    
    static member getInstance() : TouchScreenFactory =
        TouchScreenFactory.SINGLETON
    
    abstract isMultiTouch : unit -> bool
    default this.isMultiTouch() : bool =
        this.multiTouch
    
    abstract setTouch : touch: bool -> unit
    default this.setTouch(touch: bool) : unit =
        ()
    
    abstract isTouch : unit -> bool
    default this.isTouch() : bool =
        this.touch
    
    abstract getTouchScreenType : unit -> TouchScreenType
    default this.getTouchScreenType() : TouchScreenType =
        this.touchScreenType


