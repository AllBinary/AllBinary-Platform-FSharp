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
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable touch : bool
    [<DefaultValue(false)>] val mutable multiTouch : bool
    [<DefaultValue(false)>] val mutable multiTouchDistinct : bool
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
        this.logUtil <- LogUtil.getInstance()
        this.touchScreenType <- TouchScreenTypesFactory.getInstance().NOTOUCH
        ()
    
    new () as this =
        {  }
        then
            this.jfields_TouchScreenFactory()
            this.jctor1()
    member this.jctor1() : unit =
        try
            this.setTouch(true)
            this.setMultiTouch(false)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, TouchScreenFactory.SINGLETON, commonStrings.GET_INSTANCE, e)
            | _ -> reraise ()
        ()
    
    static member getInstance() : TouchScreenFactory =
        TouchScreenFactory.SINGLETON
    
    abstract setMultiTouch : multiTouch: bool -> unit
    default this.setMultiTouch(multiTouch: bool) : unit =
        this.multiTouch <- multiTouch
    
    abstract isMultiTouch : unit -> bool
    default this.isMultiTouch() : bool =
        this.multiTouch
    
    abstract setTouch : touch: bool -> unit
    default this.setTouch(touch: bool) : unit =
        this.touch <- touch
    
    abstract isTouch : unit -> bool
    default this.isTouch() : bool =
        this.touch
    
    abstract setMultiTouchDistinct : multiTouchDistinct: bool -> unit
    default this.setMultiTouchDistinct(multiTouchDistinct: bool) : unit =
        this.multiTouchDistinct <- multiTouchDistinct
    
    abstract isMultiTouchDistinct : unit -> bool
    default this.isMultiTouchDistinct() : bool =
        this.multiTouchDistinct
    
    abstract setTouchScreenType : touchScreenType: TouchScreenType -> unit
    default this.setTouchScreenType(touchScreenType: TouchScreenType) : unit =
        this.touchScreenType <- touchScreenType
    
    abstract getTouchScreenType : unit -> TouchScreenType
    default this.getTouchScreenType() : TouchScreenType =
        this.touchScreenType
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("TouchScreen: "))
        ignore (stringBuffer.appendboolean(this.isTouch()))
        ignore (stringBuffer.append(" MultiTouch: "))
        ignore (stringBuffer.appendboolean(this.isMultiTouch()))
        ignore (stringBuffer.append(" Distinct MultiTouch: "))
        ignore (stringBuffer.appendboolean(this.isMultiTouchDistinct()))
        ignore (stringBuffer.append(" TouchScreenType: "))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.getTouchScreenType())))
        stringBuffer.ToString()


