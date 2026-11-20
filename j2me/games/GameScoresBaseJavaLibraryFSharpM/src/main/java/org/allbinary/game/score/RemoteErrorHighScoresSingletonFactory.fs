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
type RemoteErrorHighScoresSingletonFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : HighScores
    static member SINGLETON with get() : HighScores = (RemoteErrorHighScoresSingletonFactory.jclinit(); RemoteErrorHighScoresSingletonFactory.jcell_SINGLETON) and set (jvalue: HighScores) = (RemoteErrorHighScoresSingletonFactory.jclinit(); RemoteErrorHighScoresSingletonFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RemoteErrorHighScoresSingletonFactory.jclinitDone then
            RemoteErrorHighScoresSingletonFactory.jclinitDone <- true
            RemoteErrorHighScoresSingletonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        RemoteErrorHighScoresSingletonFactory.jcell_SINGLETON <- (new HighScores(CommonStrings.getInstance().LOADING, "Remote High Scores Did Not Load", CommonStrings.getInstance().PERIODS))
        ()
    new () =
        {  }
    
    static member getInstance() : HighScores =
        RemoteErrorHighScoresSingletonFactory.SINGLETON


