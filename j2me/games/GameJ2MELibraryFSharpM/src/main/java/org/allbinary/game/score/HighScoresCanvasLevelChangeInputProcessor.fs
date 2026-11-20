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
type HighScoresCanvasLevelChangeInputProcessor =
    inherit HighScoresCanvasInputProcessor
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable INSTRUCTIONS : string
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable fontHeight : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresCanvasLevelChangeInputProcessor.jclinitDone then
            HighScoresCanvasLevelChangeInputProcessor.jclinitDone <- true
            HighScoresCanvasLevelChangeInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScoresCanvasLevelChangeInputProcessor() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.INSTRUCTIONS <- "(Right = Next Track, Left = Previous Track)"
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.anchor <- Anchor.TOP_LEFT
        this.fontHeight <- 0
        ()
    
    new (highScoresCanvas: HighScoresCanvas) as this =
        { inherit HighScoresCanvasInputProcessor(highScoresCanvas) }
        then
            this.jfields_HighScoresCanvasLevelChangeInputProcessor()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.fontHeight <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.open_() : unit =
        GameKeyEventHandler.getInstance().addListener(this)
    
    override this.close() : unit =
        GameKeyEventHandler.getInstance().removeListener(this)
    
    override this.update() : unit =
        let mutable list_ : BasicArrayList = this.getGameKeyEventList()
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable anyType : obj = list_.objectArray.[index]
            let mutable key : int = GameKeyEventUtil.getKey(anyType)
            if key = Canvas.RIGHT then
                this.getHighScoresCanvas().getGameInfo().nextGameLevel()
            elif key = Canvas.LEFT then
                this.getHighScoresCanvas().getGameInfo().previousGameLevel()
            this.getHighScoresCanvas().executeUpdate()
            index <- index + 1
        list_.clear()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable width : int = this.displayInfoSingleton.getLastWidth()
        let mutable topScoresWidth : int = (graphics.getFont().stringWidth(this.INSTRUCTIONS) >>> 1)
        graphics.drawString(this.INSTRUCTIONS, ((width >>> 1) - topScoresWidth), (this.fontHeight * 2), this.anchor)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


