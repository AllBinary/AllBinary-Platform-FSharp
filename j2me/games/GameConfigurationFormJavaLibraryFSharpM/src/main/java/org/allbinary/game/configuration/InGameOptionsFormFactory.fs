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
type InGameOptionsFormFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable SINGLETON : CommandForm
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (InGameOptionsFormFactory.jclinit(); InGameOptionsFormFactory.jcell_instance) and set (jvalue: obj) = (InGameOptionsFormFactory.jclinit(); InGameOptionsFormFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InGameOptionsFormFactory.jclinitDone then
            InGameOptionsFormFactory.jclinitDone <- true
            InGameOptionsFormFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InGameOptionsFormFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_InGameOptionsFormFactory()
    member this.jfields_InGameOptionsFormFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.SINGLETON <- CommandForm.getNullCommandForm()
        ()
    
    static member getInstance() : InGameOptionsFormFactory =
        if (JR.same(InGameOptionsFormFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            InGameOptionsFormFactory.instance <- (new InGameOptionsFormFactory())
        (box (InGameOptionsFormFactory.instance) :?> InGameOptionsFormFactory)
    
    abstract init : commandListener: CommandListener * initInterface: Init * title: string * backgrounBasicColor: BasicColor * foregroundBasicColor: BasicColor -> unit
    default this.init(commandListener: CommandListener, initInterface: Init, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        try
            if (JR.same(this.SINGLETON, CommandForm.getNullCommandForm())) then
                initInterface.init()
                this.SINGLETON <- (new InGameOptionsForm(commandListener, title, backgrounBasicColor, foregroundBasicColor))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.INIT, e)
            | _ -> reraise ()
    
    abstract get : unit -> CommandForm
    default this.get() : CommandForm =
        this.SINGLETON


