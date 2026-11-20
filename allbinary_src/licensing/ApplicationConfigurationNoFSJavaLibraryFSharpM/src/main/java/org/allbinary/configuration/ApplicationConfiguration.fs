namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ApplicationConfiguration =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable fullscreen : bool
    [<DefaultValue(false)>] val mutable showTitleBar : bool
    [<DefaultValue(false)>] val mutable progressBarView : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (ApplicationConfiguration.jclinit(); ApplicationConfiguration.jcell_instance) and set (jvalue: obj) = (ApplicationConfiguration.jclinit(); ApplicationConfiguration.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ApplicationConfiguration.jclinitDone then
            ApplicationConfiguration.jclinitDone <- true
            ApplicationConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        ApplicationConfiguration.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_ApplicationConfiguration() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.fullscreen <- true
        this.showTitleBar <- false
        this.progressBarView <- false
        ()
    
    static member getInstance() : ApplicationConfiguration =
        if (JR.same(ApplicationConfiguration.instance, NullUtil.getInstance().NULL_OBJECT)) then
            ApplicationConfiguration.instance <- (new ApplicationConfiguration())
        (box (ApplicationConfiguration.instance) :?> ApplicationConfiguration)
    
    new () as this =
        {  }
        then
            this.jfields_ApplicationConfiguration()
            this.jctor1()
    member this.jctor1() : unit =
        try
            this.read()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    member this.read() : unit =
        this.setFullscreen(true)
        this.setProgressBarView(false)
        this.setShowTitleBar(false)
        this.logUtil.putF((JR.nn("Read Configuration: ") + JR.nn(this.ToString())), this, "read")
    
    abstract write : unit -> unit
    default this.write() : unit =
        ()
    
    abstract update : gameFeature: Feature -> unit
    default this.update(gameFeature: Feature) : unit =
        if (JR.same(gameFeature, MainFeatureFactory.getInstance().FULL_SCREEN)) then
            let mutable features : Features = Features.getInstance()
            if features.isFeature(gameFeature) then
                if not (this.isFullscreen()) then
                    this.setFullscreen(true)
                    this.write()
            else
                if this.isFullscreen() then
                    this.setFullscreen(false)
                    this.write()
    
    abstract setFullscreen : fullscreen: bool -> unit
    default this.setFullscreen(fullscreen: bool) : unit =
        this.fullscreen <- fullscreen
    
    abstract isFullscreen : unit -> bool
    default this.isFullscreen() : bool =
        this.fullscreen
    
    abstract setShowTitleBar : showTitleBar: bool -> unit
    default this.setShowTitleBar(showTitleBar: bool) : unit =
        this.showTitleBar <- showTitleBar
    
    abstract isShowTitleBar : unit -> bool
    default this.isShowTitleBar() : bool =
        this.showTitleBar
    
    abstract setProgressBarView : progressBarView: bool -> unit
    default this.setProgressBarView(progressBarView: bool) : unit =
        this.progressBarView <- progressBarView
    
    abstract isProgressBarView : unit -> bool
    default this.isProgressBarView() : bool =
        this.progressBarView
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("isFullscreen: "))
        ignore (stringBuffer.appendboolean(this.isFullscreen()))
        ignore (stringBuffer.append(" isProgressBarView: "))
        ignore (stringBuffer.appendboolean(this.isProgressBarView()))
        ignore (stringBuffer.append(" isShowTitleBar: "))
        ignore (stringBuffer.appendboolean(this.isShowTitleBar()))
        stringBuffer.ToString()


