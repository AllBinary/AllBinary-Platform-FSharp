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
type HighScoresHelperBase =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable highScoresArrayP : HighScores[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresHelperBase.jclinitDone then
            HighScoresHelperBase.jclinitDone <- true
            HighScoresHelperBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_HighScoresHelperBase()
    member this.jfields_HighScoresHelperBase() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.highScoresArrayP <- LastFetchHighScoresFactory.getInstance().highScoresArray
        ()
    
    abstract setHighScoresArray : highScoresArrayP: HighScores[] -> unit
    default this.setHighScoresArray(highScoresArrayP: HighScores[]) : unit =
        if not (JR.same(highScoresArrayP, null)) then
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            this.logUtil.putF((new StringMaker()).append(commonStrings.START).appendint(highScoresArrayP.Length).ToString(), this, "setHighScoresArray")
        else
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            this.logUtil.putF(commonStrings.START, this, "setHighScoresArray")
        this.highScoresArrayP <- highScoresArrayP
    
    abstract getNextHighScores : unit -> HighScores
    default this.getNextHighScores() : HighScores =
        NullHighScoresSingletonFactory.getInstance()
    
    abstract isAnyHighScores : unit -> bool
    default this.isAnyHighScores() : bool =
        raise ((new JRuntimeException()))
    
    abstract setSelectedHighScores : selectedHighScores: HighScores -> unit
    default this.setSelectedHighScores(selectedHighScores: HighScores) : unit =
        ()
    
    abstract getSelectedHighScores : unit -> HighScores
    default this.getSelectedHighScores() : HighScores =
        NullHighScoresSingletonFactory.getInstance()
    
    abstract getHighScoresArray : unit -> HighScores[]
    default this.getHighScoresArray() : HighScores[] =
        this.highScoresArrayP
    
    abstract selectHighScores : unit -> unit
    default this.selectHighScores() : unit =
        ()
    interface HighScoresHelperBaseInterface with
        member this.setSelectedHighScores(jp0: HighScores) : unit = this.setSelectedHighScores(jp0)
        member this.getHighScoresArray() : HighScores[] = this.getHighScoresArray()
        member this.getSelectedHighScores() : HighScores = this.getSelectedHighScores()
    interface HighScoresResultsListener with
        member this.setHighScoresArray(jp0: HighScores[]) : unit = this.setHighScoresArray(jp0)


