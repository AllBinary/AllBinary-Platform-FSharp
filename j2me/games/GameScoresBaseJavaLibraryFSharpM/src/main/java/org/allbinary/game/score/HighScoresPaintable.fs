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
type HighScoresPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable highScores : HighScores
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable charHeight : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresPaintable.jclinitDone then
            HighScoresPaintable.jclinitDone <- true
            HighScoresPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoresPaintable() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        this.highScores <- NullHighScoresSingletonFactory.getInstance()
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new () as this =
        { inherit Paintable() }
        then
            this.jfields_HighScoresPaintable()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.charHeight <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable colorChangeEvent : ColorChangeEvent = (box (eventObject) :?> ColorChangeEvent)
        this.basicColor <- colorChangeEvent.getBasicColorP()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable width : int = this.displayInfoSingleton.getLastWidth()
        let mutable height : int = this.displayInfoSingleton.getLastHeight()
        graphics.setColor(this.getBasicColorP().intValue())
        let mutable heading : string = this.highScores.getHeading()
        let mutable topScoresWidth : int = (graphics.getFont().stringWidth(heading) >>> 1)
        let mutable charHeight : int = this.charHeight
        graphics.drawString(heading, ((width >>> 1) - topScoresWidth), charHeight, this.anchor)
        graphics.drawString(this.highScores.getColumnOneHeading(), 10, (charHeight * 3), this.anchor)
        let mutable columnTwoHeading : string = this.highScores.getColumnTwoHeading()
        let mutable columnTwoHeadingWidth : int = graphics.getFont().stringWidth(columnTwoHeading)
        graphics.drawString(columnTwoHeading, ((width - 10) - columnTwoHeadingWidth), (charHeight * 3), this.anchor)
        let mutable index : int = 4
        let mutable largestSecondColumnWidth : int = columnTwoHeadingWidth
        let mutable list_ : BasicArrayList = this.highScores.getList()
        let mutable size : int = list_.size()
        let mutable vectorIndex : int = 0
        let mutable highScore : HighScore = null
        while (vectorIndex < size) && ((charHeight * index) < (height - (charHeight * 2))) do
            highScore <- (box (list_.objectArray.[vectorIndex]) :?> HighScore)
            let mutable nextScoreWidth : int = graphics.getFont().stringWidth(highScore.getScoreString())
            if nextScoreWidth > largestSecondColumnWidth then
                largestSecondColumnWidth <- nextScoreWidth
            vectorIndex <- vectorIndex + 1
        vectorIndex <- 0
        while (vectorIndex < size) && ((charHeight * index) < (height - (charHeight * 2))) do
            highScore <- (box (list_.objectArray.[vectorIndex]) :?> HighScore)
            graphics.drawString(highScore.getName(), 10, (charHeight * index), this.anchor)
            graphics.drawString(highScore.getScoreString(), ((width - 10) - largestSecondColumnWidth), (charHeight * index), this.anchor)
            index <- index + 1
            vectorIndex <- vectorIndex + 1
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract setHighScores : highScores: HighScores -> unit
    default this.setHighScores(highScores: HighScores) : unit =
        this.highScores <- highScores
    interface ColorChangeListener
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


