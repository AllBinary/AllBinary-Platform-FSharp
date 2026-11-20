namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ApplicationConfiguration =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable fullscreen : bool
    [<DefaultValue(false)>] val mutable showTitleBar : bool
    [<DefaultValue(false)>] val mutable progressBarView : bool
    [<DefaultValue(false)>] val mutable FILE : string
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
        this.FILE <- "ReloadConfiguration.dat"
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
            if FileFactory.getInstance_jstatic().isFile(this.FILE) then
                this.read()
            else
                this.write()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    member this.read() : unit =
        let mutable fileInputStreamFactory : FileStreamFactory = FileStreamFactory.getInstance()
        let mutable fileInputStream : InputStream = fileInputStreamFactory.getFileInputStreamInstance(StringUtil.getInstance().EMPTY_STRING, this.FILE)
        let mutable dataInputStream : AbDataInputStream = (new AbDataInputStream(fileInputStream))
        let mutable fullScreen : int = dataInputStream.readInt()
        if fullScreen = 0 then
            this.setFullscreen(false)
        elif fullScreen = 1 then
            this.setFullscreen(true)
        else
            raise ((new JException("Invalid FullScreen ActivityConfiguration")))
        let mutable progressBarView : int = dataInputStream.readInt()
        if progressBarView = 0 then
            this.setProgressBarView(false)
        elif progressBarView = 1 then
            this.setProgressBarView(true)
        else
            raise ((new JException("Invalid ProgressBarView ActivityConfiguration")))
        let mutable showTitleBar : int = dataInputStream.readInt()
        if showTitleBar = 0 then
            this.setShowTitleBar(false)
        elif showTitleBar = 1 then
            this.setShowTitleBar(true)
        else
            raise ((new JException("Invalid ShowTitleBar ActivityConfiguration")))
        this.logUtil.putF((JR.nn("Read Configuration: ") + JR.nn(this.ToString())), this, "read")
    
    abstract write : unit -> unit
    default this.write() : unit =
        let mutable closeable : Closeable = NullCloseable.NULL_CLOSEABLE
        try
            try
                this.logUtil.putF((JR.nn("Write Configuration: ") + JR.nn(this.ToString())), this, "write")
                let mutable fileInputStreamFactory : FileStreamFactory = FileStreamFactory.getInstance()
                let mutable fileOutputStream : OutputStream = fileInputStreamFactory.getFileOutputStreamInstance(StringUtil.getInstance().EMPTY_STRING, this.FILE)
                let mutable dataOutputStream : AbDataOutputStream = (new AbDataOutputStream(fileOutputStream))
                closeable <- dataOutputStream
                if this.isFullscreen() then
                    ignore (dataOutputStream.writeInt(1))
                else
                    ignore (dataOutputStream.writeInt(0))
                if this.isProgressBarView() then
                    ignore (dataOutputStream.writeInt(1))
                else
                    ignore (dataOutputStream.writeInt(0))
                if this.isShowTitleBar() then
                    ignore (dataOutputStream.writeInt(1))
                else
                    ignore (dataOutputStream.writeInt(0))
                ignore (dataOutputStream.flush())
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            ignore (StreamUtil.getInstance().close(closeable))
    
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


