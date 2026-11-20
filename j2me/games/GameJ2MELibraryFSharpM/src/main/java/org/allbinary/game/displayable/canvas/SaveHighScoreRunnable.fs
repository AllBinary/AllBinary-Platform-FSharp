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
type SaveHighScoreRunnable =
    [<DefaultValue(false)>] val mutable progressCanvas : ProgressCanvas
    [<DefaultValue(false)>] val mutable isLast : bool
    [<DefaultValue(false)>] val mutable textBox : HighScoreTextBox
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SaveHighScoreRunnable.jclinitDone then
            SaveHighScoreRunnable.jclinitDone <- true
            SaveHighScoreRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_SaveHighScoreRunnable() : unit =
        this.progressCanvas <- ProgressCanvasFactory.getInstance()
        ()
    
    new (isLast: bool, textBox: HighScoreTextBox) as this =
        {  }
        then
            this.jfields_SaveHighScoreRunnable()
            this.jctor1(isLast, textBox)
    member this.jctor1(isLast: bool, textBox: HighScoreTextBox) : unit =
        this.isLast <- isLast
        this.textBox <- textBox
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        try
            if this.isLast then
                this.textBox.submit()
            else
                this.textBox.saveHighScore()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                logUtil.put(commonStrings.EXCEPTION, this, "run", e)
                this.progressCanvas.end_()
            | _ -> reraise ()
    interface Runnable with
        member this.run() : unit = this.run()


