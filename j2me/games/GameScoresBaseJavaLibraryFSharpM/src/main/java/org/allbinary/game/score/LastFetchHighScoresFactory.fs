namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type LastFetchHighScoresFactory =
    [<DefaultValue(false)>] val mutable highScoresArray : HighScores[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (LastFetchHighScoresFactory.jclinit(); LastFetchHighScoresFactory.jcell_instance) and set (jvalue: obj) = (LastFetchHighScoresFactory.jclinit(); LastFetchHighScoresFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LastFetchHighScoresFactory.jclinitDone then
            LastFetchHighScoresFactory.jclinitDone <- true
            LastFetchHighScoresFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LastFetchHighScoresFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_LastFetchHighScoresFactory()
    member this.jfields_LastFetchHighScoresFactory() : unit =
        this.highScoresArray <- NoHighScoresFactory.getInstance().NO_HIGH_SCORES
        ()
    
    static member getInstance() : LastFetchHighScoresFactory =
        if (JR.same(LastFetchHighScoresFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            LastFetchHighScoresFactory.instance <- (new LastFetchHighScoresFactory())
        (box (LastFetchHighScoresFactory.instance) :?> LastFetchHighScoresFactory)


