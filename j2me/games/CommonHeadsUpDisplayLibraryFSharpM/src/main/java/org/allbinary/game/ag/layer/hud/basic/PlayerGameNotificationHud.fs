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
type PlayerGameNotificationHud =
    inherit GameNotificationHud
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable gameNotification : GameNotification
    [<DefaultValue(false)>] val mutable permanentGameNotification : GameNotification
    [<DefaultValue(false)>] val mutable setAndRemoveProcessor : Processor
    [<DefaultValue(false)>] val mutable nextUnremoveableProcessor : Processor
    [<DefaultValue(false)>] val mutable processor : Processor
    [<DefaultValue(false)>] val mutable PERMANENT_GAME_NOTIFICATION : string
    [<DefaultValue(false)>] val mutable lastString : string
    [<DefaultValue(false)>] val mutable string : string
    [<DefaultValue(false)>] val mutable point : CustomGPoint
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerGameNotificationHud.jclinitDone then
            PlayerGameNotificationHud.jclinitDone <- true
            PlayerGameNotificationHud.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PlayerGameNotificationHud() : unit =
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.timeDelayHelper <- (new TimeDelayHelper(0))
        this.gameNotification <- (new GameNotification())
        this.permanentGameNotification <- (new GameNotification())
        this.setAndRemoveProcessor <- (new SetAndRemoveProcessor(this))
        this.nextUnremoveableProcessor <- (new NextUnremoveableProcessor(this))
        this.processor <- Processor.getInstance()
        this.PERMANENT_GAME_NOTIFICATION <- "Permanent Game Notification: "
        this.lastString <- StringUtil.getInstance().EMPTY_STRING
        this.string <- this.EMPTY_STRING
        this.point <- CustomGPoint.NULL_CUSTOM_POINT
        ()
    
    new (location: int, direction: int, bufferZone: int, basicColor: BasicColor) as this =
        { inherit GameNotificationHud(location, direction, bufferZone, basicColor) }
        then
            this.jfields_PlayerGameNotificationHud()
            this.jctor1(location, direction, bufferZone, basicColor)
    member this.jctor1(location: int, direction: int, bufferZone: int, basicColor: BasicColor) : unit =
        ()
        this.circularIndexUtil <- CircularIndexUtil.createInstance(0)
        let mutable gameNotificationEventHandler : GameNotificationEventHandler = GameNotificationEventHandler.getInstance()
        gameNotificationEventHandler.removeAllListeners()
        gameNotificationEventHandler.addListenerInterface(this)
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        try
            base.updateMeasurement(graphics)
            let mutable font : Font = graphics.getFont()
            this.width <- font.stringWidth(this.string)
            this.processor.process_()
            this.processor <- Processor.getInstance()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                logUtil.put(commonStrings.EXCEPTION, this, commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    override this.getPoint(x: int, y: int) : GPoint =
        this.point <- CustomGPoint.getInstance3(0, 0)
        this.point.setX(x)
        this.point.setY(y)
        this.point
    
    override this.add(string_: string, seconds: Integer, basicColor: BasicColor, permanent: Boolean) : unit =
        if permanent.booleanValue() then
            if not (JR.sameString(this.lastString, string_)) then
                this.lastString <- string_
                this.logUtil.putF((new StringMaker()).append(this.PERMANENT_GAME_NOTIFICATION).append(string_).ToString(), this, this.commonStrings.ADD)
            this.permanentGameNotification.add(string_, seconds, basicColor)
            this.circularIndexUtil.setSize(this.permanentGameNotification.getSize())
        else
            this.gameNotification.add(string_, seconds, basicColor)
    
    override this.processTick() : unit =
        if this.timeDelayHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            let mutable gameAdState : GameAdState = GameAdStateFactory.getInstance().getCurrentInstance()
            if gameAdState.isShowingAtLocation(this.getLocation()) then
                this.offsetY <- -54
            else
                this.offsetY <- 0
            if this.gameNotification.getSize() > 0 then
                this.setAndRemove()
            elif this.permanentGameNotification.getSize() > 0 then
                this.setNextUnremoveable()
            else
                this.string <- this.EMPTY_STRING
    
    member this.setAndRemove() : unit =
        this.string <- (box (this.gameNotification.stringList.removeAt(0)) :?> string)
        this.processor <- this.setAndRemoveProcessor
    
    abstract setAndRemoveProcess : unit -> unit
    default this.setAndRemoveProcess() : unit =
        this.setX(((this.displayInfo.getLastWidth() - this.width) >>> 1))
        this.point.setX(this.getX())
        this.point.setY(this.getY())
        let mutable time : Integer = (box (this.gameNotification.timeList.removeAt(0)) :?> Integer)
        let mutable iTime : int = time.intValue() * 1000
        if iTime = 0 then
            iTime <- 500
        this.timeDelayHelper.delay <- iTime
        this.setBasicColorP((box (this.gameNotification.colorList.removeAt(0)) :?> BasicColor))
    
    member this.setNextUnremoveable() : unit =
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.string <- (box (this.permanentGameNotification.stringList.objectArray.[index]) :?> string)
        this.processor <- this.nextUnremoveableProcessor
    
    abstract setNextUnremoveableProcess : unit -> unit
    default this.setNextUnremoveableProcess() : unit =
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.setX(((this.displayInfo.getLastWidth() - this.width) >>> 1))
        this.point.setX(this.getX())
        this.point.setY(this.getY())
        let mutable time : Integer = (box (this.permanentGameNotification.timeList.objectArray.[index]) :?> Integer)
        this.timeDelayHelper.delay <- time.intValue() * 1000
        this.setBasicColorP((box (this.permanentGameNotification.colorList.objectArray.[index]) :?> BasicColor))
        ignore (this.circularIndexUtil.next())
    
    override this.clear() : unit =
        this.gameNotification.clear()
        this.permanentGameNotification.clear()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        base.paintString(graphics, this.string)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


