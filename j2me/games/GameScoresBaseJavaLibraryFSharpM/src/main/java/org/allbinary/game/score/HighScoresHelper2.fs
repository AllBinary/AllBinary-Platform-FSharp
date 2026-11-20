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
type HighScoresHelper2 =
    inherit HighScoresHelperBase
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable selectedHighScores : HighScores
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresHelper2.jclinitDone then
            HighScoresHelper2.jclinitDone <- true
            HighScoresHelper2.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit HighScoresHelperBase() }
        then
            this.jfields_HighScoresHelper2()
    member this.jfields_HighScoresHelper2() : unit =
        this.circularIndexUtil <- CircularIndexUtil.createInstanceAt(0, 0)
        this.selectedHighScores <- NullHighScoresSingletonFactory.getInstance()
        ()
    
    override this.setSelectedHighScores(selectedHighScores: HighScores) : unit =
        this.selectedHighScores <- selectedHighScores
    
    override this.getSelectedHighScores() : HighScores =
        this.selectedHighScores
    
    override this.setHighScoresArray(highScoresArrayP: HighScores[]) : unit =
        base.setHighScoresArray(highScoresArrayP)
        this.circularIndexUtil.setSize(this.highScoresArrayP.Length)
        this.selectHighScores()
    
    override this.selectHighScores() : unit =
        let mutable jflow = 0
        if this.highScoresArrayP.Length = 0 then
            this.setSelectedHighScores(NullHighScoresSingletonFactory.getInstance())
            jflow <- 1
        if jflow = 0 then
            ignore (this.circularIndexUtil.next())
            let mutable highScores : HighScores = this.highScoresArrayP.[this.circularIndexUtil.getIndex()]
            let mutable index : int = 0
            while (highScores.getTotal() < 1) && (index < this.highScoresArrayP.Length) do
                highScores <- this.highScoresArrayP.[this.circularIndexUtil.next()]
                index <- index + 1
            this.setSelectedHighScores(highScores)


