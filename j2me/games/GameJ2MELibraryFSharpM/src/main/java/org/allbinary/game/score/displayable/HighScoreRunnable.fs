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
type HighScoreRunnable =
    inherit ARunnable
    [<DefaultValue(false)>] val mutable highScoresCanvas : HighScoresCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreRunnable.jclinitDone then
            HighScoreRunnable.jclinitDone <- true
            HighScoreRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (highScoresCanvas: HighScoresCanvas) as this =
        { inherit ARunnable() }
        then
            this.jctor1(highScoresCanvas)
    member this.jctor1(highScoresCanvas: HighScoresCanvas) : unit =
        this.highScoresCanvas <- highScoresCanvas
        ()
    
    override this.run() : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        let mutable highScoresCanvas : HighScoresCanvas = this.highScoresCanvas
        try
            let mutable isHTML : bool = J2MEUtil.isHTML()
            if not (isHTML) then
                while not (highScoresCanvas.hasPainted) do
                    ()
                highScoresCanvas.hasPainted <- false
            let mutable stringMaker : StringMaker = (new StringMaker())
            let mutable systemWrapper : ABSystemWrapper = ABSystemWrapper.getInstance()
            let mutable currentTimeMillis : int64 = systemWrapper.currentTimeMillis()
            logUtil.putF(stringMaker.append("HighScoresCanvas - Request repaint to be sure: ").appendlong(currentTimeMillis).ToString(), this, commonStrings.RUN)
            highScoresCanvas.repaintBehavior.onChangeRepaint(highScoresCanvas)
            if not (isHTML) then
                while not (highScoresCanvas.hasPainted) do
                    ()
            ignore (stringMaker.delete(0, stringMaker.length()))
            logUtil.putF(stringMaker.append("HighScoresCanvas - Now that the canvas has completed repaint go ahead and fetch the scores: ").appendlong(currentTimeMillis).ToString(), this, commonStrings.RUN)
            highScoresCanvas.executeUpdate()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()


