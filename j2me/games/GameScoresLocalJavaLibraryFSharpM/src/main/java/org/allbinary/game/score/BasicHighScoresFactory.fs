namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type BasicHighScoresFactory =
    inherit HighScoresBase
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] val mutable highScoresArray : HighScores[]
    [<DefaultValue(false)>] val mutable TOP : string
    [<DefaultValue(false)>] val mutable SCORES : string
    [<DefaultValue(false)>] val mutable PERSONAL_HIGH_SCORES : string
    [<DefaultValue(false)>] val mutable FETCH : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicHighScoresFactory.jclinitDone then
            BasicHighScoresFactory.jclinitDone <- true
            BasicHighScoresFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicHighScoresFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.highScoresArray <- (Array.zeroCreate<HighScores> (1))
        this.TOP <- "Top"
        this.SCORES <- "Scores"
        this.PERSONAL_HIGH_SCORES <- "Personal Top Scores"
        this.FETCH <- "fetchHighScores"
        ()
    
    new (abeClientInformation: AbeClientInformationInterface, softwareInformation: SoftwareInformation) as this =
        { inherit HighScoresBase() }
        then
            this.jfields_BasicHighScoresFactory()
            this.jctor1(abeClientInformation, softwareInformation)
    member this.jctor1(abeClientInformation: AbeClientInformationInterface, softwareInformation: SoftwareInformation) : unit =
        this.abeClientInformation <- abeClientInformation
        ()
    
    override this.fetchHighScores(gameInfo: GameInfo, highScoresResultsListener: HighScoresResultsListener) : unit =
        this.logUtil.putF("Getting Local HighScores", this, this.FETCH)
        this.fetchHighScoresPreload(gameInfo, highScoresResultsListener, true)
    
    override this.fetchHighScoresPreload(gameInfo: GameInfo, highScoresResultsListener: HighScoresResultsListener, preload: bool) : unit =
        try
            this.highScoresArray.[0] <- RecordStoreHighScores.getInstance(this.abeClientInformation, gameInfo, this.TOP, this.PERSONAL_HIGH_SCORES, this.SCORES, (new ScoreComparator(true)))
            highScoresResultsListener.setHighScoresArray(this.highScoresArray)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.FETCH, e)
            | _ -> reraise ()
    
    override this.createHighScoresHelper() : HighScoresHelperBaseInterface =
        (new HighScoresHelper2())
    
    static member loaded(index2: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if index2 >= 0 then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret


