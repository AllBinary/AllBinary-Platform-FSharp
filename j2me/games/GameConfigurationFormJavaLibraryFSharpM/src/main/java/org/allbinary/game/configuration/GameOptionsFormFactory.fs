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
type GameOptionsFormFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameOptionsFormFactory
    static member instance with get() : GameOptionsFormFactory = (GameOptionsFormFactory.jclinit(); GameOptionsFormFactory.jcell_instance) and set (jvalue: GameOptionsFormFactory) = (GameOptionsFormFactory.jclinit(); GameOptionsFormFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameOptionsFormFactory.jclinitDone then
            GameOptionsFormFactory.jclinitDone <- true
            GameOptionsFormFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameOptionsFormFactory.jcell_instance <- (new GameOptionsFormFactory())
        ()
    member this.jfields_GameOptionsFormFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GameOptionsFormFactory()
    
    static member getInstance() : GameOptionsFormFactory =
        GameOptionsFormFactory.instance
    
    abstract init : commandListener: CommandListener * title: string * backgrounBasicColor: BasicColor * foregroundBasicColor: BasicColor -> CommandForm
    default this.init(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : CommandForm =
        let mutable jflow = 0
        let mutable jret : CommandForm = Unchecked.defaultof<CommandForm>
        try
            jret <- (new GameOptionsForm(commandListener, title, backgrounBasicColor, foregroundBasicColor))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.INIT, e)
                jret <- CommandForm.getNullCommandForm()
                jflow <- 1
            | _ -> reraise ()
        jret


