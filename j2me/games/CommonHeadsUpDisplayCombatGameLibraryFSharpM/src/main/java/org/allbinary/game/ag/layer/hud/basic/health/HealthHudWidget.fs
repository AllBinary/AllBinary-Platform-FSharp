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
type HealthHudWidget =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable healthScale : int
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable healthInterface : Health
    [<DefaultValue(false)>] val mutable max : int
    [<DefaultValue(false)>] val mutable xArray : int[]
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable slowBeatTimeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable mediumBeatTimeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable fastBeatTimeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthHudWidget.jclinitDone then
            HealthHudWidget.jclinitDone <- true
            HealthHudWidget.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HealthHudWidget() : unit =
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        this.timeDelayHelper <- NoTimeDelayHelper.SINGLETON
        this.slowBeatTimeDelayHelper <- (new TimeDelayHelper(1280))
        this.mediumBeatTimeDelayHelper <- (new TimeDelayHelper(640))
        this.fastBeatTimeDelayHelper <- (new TimeDelayHelper(320))
        ()
    
    new (animationInterface: Animation, healthInterface: Health, location: int, direction: int) as this =
        { inherit BasicHud(location, direction, 2, BasicColorFactory.getInstance().WHITE) }
        then
            this.jfields_HealthHudWidget()
            this.jctor1(animationInterface, healthInterface, location, direction)
    member this.jctor1(animationInterface: Animation, healthInterface: Health, location: int, direction: int) : unit =
        ()
        this.animationInterface <- animationInterface
        this.healthInterface <- healthInterface
        this.healthInterface.addListener(this)
        this.healthScale <- (this.healthInterface.getMaxHealth() / 6) + 1
        this.onHealthChange()
        this.updateMaxWidth <- healthInterface.getMaxHealth() * 16
        this.updateMaxHeight <- 16
        this.xArray <- (Array.zeroCreate<int> (30))
        this.update()
        ()
    
    member this.update() : unit =
        if not (JR.same(this.xArray, null)) then
            let mutable index : int = 0
            while index < this.xArray.Length do
                this.xArray.[index] <- this.getX() + (index * 16)
                index <- index + 1
    
    override this.setX(x: int) : unit =
        base.setX(x)
        this.update()
    
    abstract onHealthChange : unit -> unit
    default this.onHealthChange() : unit =
        this.max <- (this.healthInterface.getHealth() / this.healthScale)
        this.timeDelayHelper <- NoTimeDelayHelper.SINGLETON
        if (this.max <= 1) && this.healthInterface.isAlive() then
            this.max <- 1
            if (this.healthScale - this.healthInterface.getHealth()) > ((this.healthScale * 2) / 3) then
                this.timeDelayHelper <- this.slowBeatTimeDelayHelper
            elif (this.healthScale - this.healthInterface.getHealth()) > (this.healthScale / 3) then
                this.timeDelayHelper <- this.mediumBeatTimeDelayHelper
            else
                this.timeDelayHelper <- this.fastBeatTimeDelayHelper
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable index : int = 0
        while index < this.max do
            if this.timeDelayHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
                this.animationInterface.paintXY(graphics, this.xArray.[index], this.getY())
            index <- index + 1
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface HealthListenerInterface with
        member this.onHealthChange() : unit = this.onHealthChange()


