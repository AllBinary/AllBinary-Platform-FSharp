namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type StupidTimer =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable nullUtil : NullUtil
    [<DefaultValue(false)>] val mutable threadObjectUtil : ThreadObjectUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StupidTimer.jclinitDone then
            StupidTimer.jclinitDone <- true
            StupidTimer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_StupidTimer()
    member this.jfields_StupidTimer() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.nullUtil <- NullUtil.getInstance()
        this.threadObjectUtil <- ThreadObjectUtil.getInstance()
        ()
    
    member this.visitBool(visitorInterface: Visitor) : bool =
        let mutable result : Boolean = (box (visitorInterface.visit(this.nullUtil.NULL_OBJECT)) :?> Boolean)
        let mutable result2 : bool = result.booleanValue()
        result2
    
    member this.visit(visitorInterface: Visitor, timeDelayHelper: TimeDelayHelper) : unit =
        let mutable jflow = 0
        let mutable tookTooLong : bool = false
        let mutable WAITING_FOR : string = "Waiting for: "
        PreLogUtil.put((new StringMaker()).append(WAITING_FOR).append(StringUtil.getInstance().toString(visitorInterface)).ToString(), this, this.commonStrings.VISIT)
        let mutable index : int = 0
        while jflow = 0 && (this.visitBool(visitorInterface)) do
            if (index % 10) = 0 then
                PreLogUtil.put((new StringMaker()).append(WAITING_FOR).appendint(index).ToString(), this, this.commonStrings.VISIT)
            index <- index + 1
            if true then
                this.threadObjectUtil.waitObjectFor(this, 1800L)
            if timeDelayHelper.isTimeTNT() then
                tookTooLong <- true
                jflow <- 100001
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            if tookTooLong then
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.VISIT, (new JException((new StringMaker()).append("Took Too Long: ").append(StringUtil.getInstance().toString(visitorInterface)).ToString())))
            else
                PreLogUtil.put(timeDelayHelper.ToString(), this, this.commonStrings.VISIT)
    
    abstract stopWaiting : unit -> unit
    default this.stopWaiting() : unit =
        if true then
            this.threadObjectUtil.notifyObject(this)


