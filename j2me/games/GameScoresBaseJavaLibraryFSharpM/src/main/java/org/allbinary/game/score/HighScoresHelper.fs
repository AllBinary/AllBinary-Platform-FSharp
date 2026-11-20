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
type HighScoresHelper =
    inherit HighScoresHelperBase
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable lastIndex : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresHelper.jclinitDone then
            HighScoresHelper.jclinitDone <- true
            HighScoresHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit HighScoresHelperBase() }
        then
            this.jfields_HighScoresHelper()
    member this.jfields_HighScoresHelper() : unit =
        this.circularIndexUtil <- CircularIndexUtil.createInstanceAt(0, 0)
        this.lastIndex <- -1
        ()
    
    override this.setHighScoresArray(highScoresArrayP: HighScores[]) : unit =
        base.setHighScoresArray(highScoresArrayP)
        this.circularIndexUtil.setSize(this.highScoresArrayP.Length)
    
    override this.getNextHighScores() : HighScores =
        let mutable highScores : HighScores = this.highScoresArrayP.[this.circularIndexUtil.getIndex()]
        let mutable index : int = 0
        while ((highScores.getTotal() < 1) || (this.lastIndex = this.circularIndexUtil.getIndex())) && (index < this.highScoresArrayP.Length) do
            ignore (this.circularIndexUtil.next())
            highScores <- this.highScoresArrayP.[this.circularIndexUtil.getIndex()]
            index <- index + 1
        this.lastIndex <- this.circularIndexUtil.getIndex()
        highScores
    
    override this.isAnyHighScores() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.highScoresArrayP.Length < 1 then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            let mutable anyScores : bool = false
            let mutable highScores : HighScores = null
            let mutable index : int = this.highScoresArrayP.Length - 1
            while index >= 0 do
                highScores <- this.highScoresArrayP.[index]
                if highScores.getTotal() > 0 then
                    anyScores <- true
                index <- index - 1
            jret <- anyScores
            jflow <- 1
        jret


