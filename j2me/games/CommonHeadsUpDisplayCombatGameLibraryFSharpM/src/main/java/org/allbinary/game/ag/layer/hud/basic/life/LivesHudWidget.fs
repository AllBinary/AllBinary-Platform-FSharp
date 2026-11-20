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
type LivesHudWidget =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable lifeInterface : Life
    [<DefaultValue(false)>] val mutable xArray : int[]
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LivesHudWidget.jclinitDone then
            LivesHudWidget.jclinitDone <- true
            LivesHudWidget.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterface: Animation, lifeInterface: Life, location: int, direction: int) as this =
        { inherit BasicHud(location, direction, 2, BasicColorFactory.getInstance().WHITE) }
        then
            this.jctor1(animationInterface, lifeInterface, location, direction)
    member this.jctor1(animationInterface: Animation, lifeInterface: Life, location: int, direction: int) : unit =
        ()
        this.lifeInterface <- lifeInterface
        let mutable size : int = int (this.getLifeInterface().getMaxlives())
        this.xArray <- (Array.zeroCreate<int> (size))
        this.animationInterface <- animationInterface
        this.updateMaxWidth <- int (int (this.lifeInterface.getMaxlives())) * 16
        this.updateMaxHeight <- 16
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        base.updateMeasurement(graphics)
        let mutable maxLives : int = int (this.getLifeInterface().getMaxlives())
        let mutable index : int = 0
        while index < maxLives do
            this.xArray.[index] <- this.getX() + (index * 16)
            index <- index + 1
    
    override this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        base.onDisplayChangeEvent(displayChangeEvent)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    override this.setX(x: int) : unit =
        base.setX(x)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable index : int = int (this.getLifeInterface().get())
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterface.paintXY(graphics, this.xArray.[index], this.getY())
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract getLifeInterface : unit -> Life
    default this.getLifeInterface() : Life =
        this.lifeInterface
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


