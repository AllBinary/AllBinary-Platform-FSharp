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
type NullHighScoresSingletonFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : HighScores
    static member SINGLETON with get() : HighScores = (NullHighScoresSingletonFactory.jclinit(); NullHighScoresSingletonFactory.jcell_SINGLETON) and set (jvalue: HighScores) = (NullHighScoresSingletonFactory.jclinit(); NullHighScoresSingletonFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullHighScoresSingletonFactory.jclinitDone then
            NullHighScoresSingletonFactory.jclinitDone <- true
            NullHighScoresSingletonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullHighScoresSingletonFactory.jcell_SINGLETON <- (new HighScores(CommonStrings.getInstance().LOADING, "High Scores Not Loaded", CommonStrings.getInstance().PERIODS))
        ()
    new () =
        {  }
    
    static member getInstance() : HighScores =
        NullHighScoresSingletonFactory.SINGLETON


