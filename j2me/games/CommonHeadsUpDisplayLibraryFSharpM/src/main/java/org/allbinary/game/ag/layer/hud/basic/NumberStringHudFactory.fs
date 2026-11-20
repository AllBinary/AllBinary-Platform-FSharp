namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NumberStringHudFactory =
    [<DefaultValue(false)>] val mutable NULL_NUMBER_STRING_HUD : NumberStringHud
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (NumberStringHudFactory.jclinit(); NumberStringHudFactory.jcell_instance) and set (jvalue: obj) = (NumberStringHudFactory.jclinit(); NumberStringHudFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberStringHudFactory.jclinitDone then
            NumberStringHudFactory.jclinitDone <- true
            NumberStringHudFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NumberStringHudFactory.jcell_instance <- NullUtil.getInstance()
        ()
    new () as this =
        {  }
        then
            this.jfields_NumberStringHudFactory()
    member this.jfields_NumberStringHudFactory() : unit =
        this.NULL_NUMBER_STRING_HUD <- this.createHud()
        ()
    
    static member getInstance() : NumberStringHudFactory =
        if (JR.same(NumberStringHudFactory.instance, NullUtil.getInstance())) then
            NumberStringHudFactory.instance <- (new NumberStringHudFactory())
        (box (NumberStringHudFactory.instance) :?> NumberStringHudFactory)
    
    abstract createHud : unit -> NumberStringHud
    default this.createHud() : NumberStringHud =
        let mutable jflow = 0
        let mutable jret : NumberStringHud = Unchecked.defaultof<NumberStringHud>
        try
            jret <- (new NumberStringHud(StringUtil.getInstance().EMPTY_STRING, 9, BasicHudFactory.getInstance().ABSOLUTE, 1, 0, BasicColorFactory.getInstance().NULL_COLOR))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
                raise ((new JRuntimeException()))
            | _ -> reraise ()
        jret


