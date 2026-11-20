namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullDisplayable =
    inherit Canvas
    [<DefaultValue(false)>] val mutable baseGameStatistics : BaseGameStatistics
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NullDisplayable
    static member SINGLETON with get() : NullDisplayable = (NullDisplayable.jclinit(); NullDisplayable.jcell_SINGLETON) and set (jvalue: NullDisplayable) = (NullDisplayable.jclinit(); NullDisplayable.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullDisplayable.jclinitDone then
            NullDisplayable.jclinitDone <- true
            NullDisplayable.jclinitBody()
    static member private jclinitBody() : unit =
        NullDisplayable.jcell_SINGLETON <- (new NullDisplayable())
        ()
    member this.jfields_NullDisplayable() : unit =
        this.baseGameStatistics <- GameStatisticsFactory.getInstance()
        ()
    
    static member getInstance() : NullDisplayable =
        NullDisplayable.SINGLETON
    
    new () as this =
        { inherit Canvas() }
        then
            this.jfields_NullDisplayable()
    
    override this.paint(graphics: Graphics) : unit =
        this.baseGameStatistics.nextRefresh()


