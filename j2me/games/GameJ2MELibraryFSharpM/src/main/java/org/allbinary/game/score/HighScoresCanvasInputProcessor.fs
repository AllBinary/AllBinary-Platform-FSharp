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
type HighScoresCanvasInputProcessor =
    inherit PlayerGameInput
    [<DefaultValue(false)>] val mutable highScoresCanvas : HighScoresCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresCanvasInputProcessor.jclinitDone then
            HighScoresCanvasInputProcessor.jclinitDone <- true
            HighScoresCanvasInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (highScoresCanvas: HighScoresCanvas) as this =
        { inherit PlayerGameInput((new BasicArrayListD()), (new BasicArrayListD()), -1) }
        then
            this.jctor1(highScoresCanvas)
    member this.jctor1(highScoresCanvas: HighScoresCanvas) : unit =
        ()
        this.highScoresCanvas <- highScoresCanvas
        ()
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        ()
    
    abstract close : unit -> unit
    default this.close() : unit =
        ()
    
    override this.onPressGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        base.onPressGameKeyEvent(gameKeyEvent)
        this.update()
    
    override this.onDownGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        base.onDownGameKeyEvent(gameKeyEvent)
        this.update()
    
    override this.onUpGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        base.onUpGameKeyEvent(gameKeyEvent)
        this.update()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract getHighScoresCanvas : unit -> HighScoresCanvas
    default this.getHighScoresCanvas() : HighScoresCanvas =
        this.highScoresCanvas


