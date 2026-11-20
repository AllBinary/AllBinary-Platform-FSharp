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
type AllBinaryGameLayer =
    inherit AllBinaryLayer
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable RED : BasicColor
    [<DefaultValue(false)>] val mutable paintable : Paintable
    [<DefaultValue(false)>] val mutable gameKeyEventList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryGameLayer.jclinitDone then
            AllBinaryGameLayer.jclinitDone <- true
            AllBinaryGameLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AllBinaryGameLayer() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.RED <- BasicColorFactory.getInstance().RED
        this.paintable <- AllBinaryGameLayer.createPaintable()
        this.gameKeyEventList <- (new BasicArrayListD())
        ()
    
    static member createPaintable() : Paintable =
        let mutable jflow = 0
        let mutable jret : Paintable = Unchecked.defaultof<Paintable>
        if SWTUtil.isSWT then
            jret <- (new SWTBlackPaintable())
            jflow <- 1
        if jflow = 0 then
            jret <- NullPaintable.getInstance()
            jflow <- 1
        jret
    
    new (name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase) as this =
        { inherit AllBinaryLayer(name, layerInfo, viewPosition) }
        then
            this.jfields_AllBinaryGameLayer()
    
    abstract set : gl: GL -> unit
    default this.set(gl: GL) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract move : unit -> unit
    default this.move() : unit =
        ()
    
    abstract getGameKeyEventList : unit -> BasicArrayList
    default this.getGameKeyEventList() : BasicArrayList =
        this.gameKeyEventList
    
    abstract processInput : allBinaryLayerManager: AllBinaryLayerManager -> unit
    default this.processInput(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract processTick : allBinaryLayerManager: AllBinaryLayerManager -> unit
    default this.processTick(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onViewPositionChangeEvent : unit -> unit
    default this.onViewPositionChangeEvent() : unit =
        this.onChangeEvent(this.viewPositionEvent)
    
    override this.onChangeEvent(layerManagerEvent: ViewPositionEvent) : unit =
        if GameLayerUtil.isOnScreen(this) then
            this.setVisible(true)
        else
            this.setVisible(false)
    
    abstract paintFirst : graphics: Graphics -> unit
    default this.paintFirst(graphics: Graphics) : unit =
        this.paintable.paint(graphics)
    
    abstract paintDebug : graphics: Graphics -> unit
    default this.paintDebug(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getViewPosition()
        let mutable viewX : int = viewPosition.getX()
        let mutable viewY : int = viewPosition.getY()
        this.basicSetColorUtil.setBasicColorP(graphics, this.RED)
        graphics.drawRect(viewX, viewY, this.getWidth(), this.getHeight())
    
    abstract setWidth : width: int -> unit
    default this.setWidth(width: int) : unit =
        base.setLayerWidth(width)
        this.setHalfWidth((width >>> 1))
    
    abstract setHeight : height: int -> unit
    default this.setHeight(height: int) : unit =
        base.setLayerHeight(height)
        this.setHalfHeight((height >>> 1))
    interface ViewPositionEventListenerInterface with
        member this.onChangeEvent(jp0: ViewPositionEvent) : unit = this.onChangeEvent(jp0)
    interface OpenGLSurfaceChangedInterface with
        member this.set(jp0: GL) : unit = this.set(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


