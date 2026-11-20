namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2022 AllBinary
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
type WebCommandProcessor =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable aboutCommandProcessor : AboutCommandProcessor
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : WebCommandProcessor
    static member instance with get() : WebCommandProcessor = (WebCommandProcessor.jclinit(); WebCommandProcessor.jcell_instance) and set (jvalue: WebCommandProcessor) = (WebCommandProcessor.jclinit(); WebCommandProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WebCommandProcessor.jclinitDone then
            WebCommandProcessor.jclinitDone <- true
            WebCommandProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        WebCommandProcessor.jcell_instance <- (new WebCommandProcessor())
        ()
    new () as this =
        {  }
        then
            this.jfields_WebCommandProcessor()
    member this.jfields_WebCommandProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.aboutCommandProcessor <- AboutCommandProcessor.getInstance()
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : WebCommandProcessor =
        WebCommandProcessor.instance
    
    abstract process_ : midletCommandListener: CommandListener * command: Command * canvas: Canvas -> unit
    default this.process_(midletCommandListener: CommandListener, command: Command, canvas: Canvas) : unit =
        try
            if Desktop.isDesktopSupported() && Desktop.getDesktop().isSupported(Desktop.Action.BROWSE) then
                ignore (Desktop.getDesktop().browse((new URI((box (this.list.removeAt(0)) :?> string)))))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.PROCESS, e)
            | _ -> reraise ()


