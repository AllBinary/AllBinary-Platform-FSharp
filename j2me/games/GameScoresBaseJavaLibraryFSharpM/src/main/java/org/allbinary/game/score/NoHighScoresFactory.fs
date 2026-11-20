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
type NoHighScoresFactory =
    inherit HighScoresBase
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable NO_HIGH_SCORES : HighScores[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoHighScoresFactory
    static member instance with get() : NoHighScoresFactory = (NoHighScoresFactory.jclinit(); NoHighScoresFactory.jcell_instance) and set (jvalue: NoHighScoresFactory) = (NoHighScoresFactory.jclinit(); NoHighScoresFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoHighScoresFactory.jclinitDone then
            NoHighScoresFactory.jclinitDone <- true
            NoHighScoresFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NoHighScoresFactory.jcell_instance <- (new NoHighScoresFactory())
        ()
    member this.jfields_NoHighScoresFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.NO_HIGH_SCORES <- (Array.zeroCreate<HighScores> (0))
        ()
    
    static member getInstance() : NoHighScoresFactory =
        NoHighScoresFactory.instance
    
    new () as this =
        { inherit HighScoresBase() }
        then
            this.jfields_NoHighScoresFactory()
    
    override this.fetchHighScores(gameInfo: GameInfo, highScoresResultsListener: HighScoresResultsListener) : unit =
        this.logUtil.putF("Getting No HighScores", this, "fetchHighScores")
        highScoresResultsListener.setHighScoresArray(this.NO_HIGH_SCORES)
    
    override this.createHighScoresHelper() : HighScoresHelperBaseInterface =
        (new HighScoresHelperBase())


