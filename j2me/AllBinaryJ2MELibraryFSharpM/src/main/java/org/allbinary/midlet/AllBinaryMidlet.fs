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
type AllBinaryMidlet =
    inherit MIDlet
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable SET_DISPLAY : string
    [<DefaultValue(false)>] val mutable SETTING_ : string
    [<DefaultValue(false)>] val mutable _DISPLAY_ : string
    [<DefaultValue(false)>] val mutable SETTING_NO_TITLE : string
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable midletDestroyed : bool
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_MIDLET : obj
    static member NULL_ALLBINARY_MIDLET with get() : obj = (AllBinaryMidlet.jclinit(); AllBinaryMidlet.jcell_NULL_ALLBINARY_MIDLET) and set (jvalue: obj) = (AllBinaryMidlet.jclinit(); AllBinaryMidlet.jcell_NULL_ALLBINARY_MIDLET <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryMidlet.jclinitDone then
            AllBinaryMidlet.jclinitDone <- true
            AllBinaryMidlet.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryMidlet.jcell_NULL_ALLBINARY_MIDLET <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_AllBinaryMidlet() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.SET_DISPLAY <- "setDisplay"
        this.SETTING_ <- "Setting: "
        this._DISPLAY_ <- " Display: "
        this.SETTING_NO_TITLE <- "Setting: No Title, Display: "
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    static member getNullInstance() : AllBinaryMidlet =
        if (JR.same(AllBinaryMidlet.NULL_ALLBINARY_MIDLET, NullUtil.getInstance().NULL_OBJECT)) then
            AllBinaryMidlet.NULL_ALLBINARY_MIDLET <- (new AllBinaryMidlet())
        (box (AllBinaryMidlet.NULL_ALLBINARY_MIDLET) :?> AllBinaryMidlet)
    
    new () as this =
        { inherit MIDlet() }
        then
            this.jfields_AllBinaryMidlet()
            this.jctor1()
    member this.jctor1() : unit =
        this.logUtil.putF(this.commonStrings.CONSTRUCTOR, this, "AllBinaryMidlet::AllBinaryMidlet")
        ()
    
    abstract setDisplay : newDisplay: Displayable -> unit
    default this.setDisplay(newDisplay: Displayable) : unit =
        let mutable title : string = StringUtil.getInstance().EMPTY_STRING
        if not (JR.same(newDisplay, NullCanvas.NULL_CANVAS)) then
            title <- newDisplay.getTitle()
            this.logUtil.putF((new StringMaker()).append(this.SETTING_).append(title).append(this._DISPLAY_).append(StringUtil.getInstance().toString(newDisplay)).ToString(), this, this.SET_DISPLAY)
        let mutable display : Display = this.getDisplay()
        display.setCurrent(newDisplay)
    
    abstract getDisplay : unit -> Display
    default this.getDisplay() : Display =
        Display.getDisplay(this)
    
    abstract getCurrentDisplayable : unit -> Displayable
    default this.getCurrentDisplayable() : Displayable =
        Display.getDisplay(this).getCurrent()
    
    abstract setDestroyed : destroyed: bool -> unit
    default this.setDestroyed(destroyed: bool) : unit =
        this.midletDestroyed <- destroyed
    
    abstract isDestroyed : unit -> bool
    default this.isDestroyed() : bool =
        this.midletDestroyed
    
    override this.startApp() : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    override this.pauseApp() : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract destroyAppInRunnable : unconditional: bool * isProgress: bool -> unit
    default this.destroyAppInRunnable(unconditional: bool, isProgress: bool) : unit =
        ()
    
    override this.destroyApp(unconditional: bool) : unit =
        let mutable METHOD_NAME : string = "AllBinaryMidlet::destroyApp"
        try
            this.logUtil.putF(this.commonStrings.START, this, METHOD_NAME)
            PreLogUtil.put(Memory.getInfo(), this, METHOD_NAME)
            this.setDestroyed(true)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, METHOD_NAME, e)
            | _ -> reraise ()
    
    abstract setStartStateHashtable : hashtable: ABHashtable -> unit
    default this.setStartStateHashtable(hashtable: ABHashtable) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(StringUtil.getInstance().toString(hashtable)).ToString(), this, "setStartStateHashtable")
        this.hashtable <- hashtable
    
    abstract getStartStateHashtable : unit -> ABHashtable
    default this.getStartStateHashtable() : ABHashtable =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(StringUtil.getInstance().toString(this.hashtable)).ToString(), this, "getStartStateHashtable")
        this.hashtable
    
    abstract getCurrentStateHashtable : unit -> ABHashtable
    default this.getCurrentStateHashtable() : ABHashtable =
        this.logUtil.putF(this.commonStrings.START, this, "getStateHashtable")
        StdUtil.getInstance().NULL_TABLE
    
    abstract commandAction : command: Command * displayable: Displayable -> unit
    default this.commandAction(command: Command, displayable: Displayable) : unit =
        ()
    interface CommandListener with
        member this.commandAction(jp0: Command, jp1: Displayable) : unit = this.commandAction(jp0, jp1)


