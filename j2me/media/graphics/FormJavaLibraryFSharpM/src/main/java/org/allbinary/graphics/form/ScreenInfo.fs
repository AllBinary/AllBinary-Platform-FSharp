namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ScreenInfo =
    [<DefaultValue(false)>] val mutable SMALL_WIDTH : int
    [<DefaultValue(false)>] val mutable SMALL_HEIGHT : int
    [<DefaultValue(false)>] val mutable MEDIUM_WIDTH : int
    [<DefaultValue(false)>] val mutable MEDIUM_HEIGHT : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScreenInfo
    static member instance with get() : ScreenInfo = (ScreenInfo.jclinit(); ScreenInfo.jcell_instance) and set (jvalue: ScreenInfo) = (ScreenInfo.jclinit(); ScreenInfo.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenInfo.jclinitDone then
            ScreenInfo.jclinitDone <- true
            ScreenInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ScreenInfo.jcell_instance <- (new ScreenInfo())
        ()
    new () as this =
        {  }
        then
            this.jfields_ScreenInfo()
    member this.jfields_ScreenInfo() : unit =
        this.SMALL_WIDTH <- 320
        this.SMALL_HEIGHT <- 240
        this.MEDIUM_WIDTH <- 800
        this.MEDIUM_HEIGHT <- 600
        ()
    
    static member getInstance() : ScreenInfo =
        ScreenInfo.instance


