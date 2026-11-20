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
type HighScoresBase =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresBase.jclinitDone then
            HighScoresBase.jclinitDone <- true
            HighScoresBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoresBase() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_HighScoresBase()
    
    abstract fetchHighScores : gameInfo: GameInfo * highScoresResultsListener: HighScoresResultsListener -> unit
    default this.fetchHighScores(gameInfo: GameInfo, highScoresResultsListener: HighScoresResultsListener) : unit =
        raise ((new JRuntimeException()))
    
    abstract fetchHighScoresPreload : gameInfo: GameInfo * highScoresResultsListener: HighScoresResultsListener * preload: bool -> unit
    default this.fetchHighScoresPreload(gameInfo: GameInfo, highScoresResultsListener: HighScoresResultsListener, preload: bool) : unit =
        raise ((new JRuntimeException()))
    
    abstract createHighScoresHelper : unit -> HighScoresHelperBaseInterface
    default this.createHighScoresHelper() : HighScoresHelperBaseInterface =
        raise ((new JRuntimeException()))
    interface HighScoresFactoryInterface with
        member this.fetchHighScores(jp0: GameInfo, jp1: HighScoresResultsListener) : unit = this.fetchHighScores(jp0, jp1)
        member this.fetchHighScoresPreload(jp0: GameInfo, jp1: HighScoresResultsListener, jp2: bool) : unit = this.fetchHighScoresPreload(jp0, jp1, jp2)
        member this.createHighScoresHelper() : HighScoresHelperBaseInterface = this.createHighScoresHelper()


