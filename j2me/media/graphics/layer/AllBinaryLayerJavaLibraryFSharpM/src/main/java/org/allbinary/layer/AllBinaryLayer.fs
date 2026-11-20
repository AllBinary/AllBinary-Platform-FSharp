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
type AllBinaryLayer =
    inherit Layer
    [<DefaultValue(false)>] val mutable viewPositionEvent : ViewPositionEvent
    [<DefaultValue(false)>] val mutable halfWidth : int
    [<DefaultValue(false)>] val mutable halfHeight : int
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable viewPosition : ViewPositionBase
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_LAYER : AllBinaryLayer
    static member NULL_ALLBINARY_LAYER with get() : AllBinaryLayer = (AllBinaryLayer.jclinit(); AllBinaryLayer.jcell_NULL_ALLBINARY_LAYER) and set (jvalue: AllBinaryLayer) = (AllBinaryLayer.jclinit(); AllBinaryLayer.jcell_NULL_ALLBINARY_LAYER <- jvalue)
    static member TYPE : string = "Type: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryLayer.jclinitDone then
            AllBinaryLayer.jclinitDone <- true
            AllBinaryLayer.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryLayer.jcell_NULL_ALLBINARY_LAYER <- (new AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, RectangleFactory.SINGLETON, ViewPositionBase.NULL_VIEW_POSITION))
        ()
    member this.jfields_AllBinaryLayer() : unit =
        this.viewPositionEvent <- (new ViewPositionEvent(this))
        this.viewPosition <- ViewPositionBase.NULL_VIEW_POSITION
        ()
    
    new (name: string, rectangle: Rectangle, viewPosition: ViewPositionBase) as this =
        { inherit Layer(rectangle.getWidth(), rectangle.getHeight()) }
        then
            this.jfields_AllBinaryLayer()
            this.jctor1(name, rectangle, viewPosition)
    member this.jctor1(name: string, rectangle: Rectangle, viewPosition: ViewPositionBase) : unit =
        ()
        let mutable localName : string = null
        localName <- (new StringMaker()).append(name).append(CommonSeps.getInstance().COLON).append(Integer.toHexString(TsUtil.getInstance().hashCode(this))).ToString()
        this.name <- localName
        let mutable point : GPoint = rectangle.getPoint()
        this.setPosition(point.getX(), point.getY(), point.getZ())
        this.setHalfWidth((this.getWidth() >>> 1))
        this.setHalfHeight((this.getHeight() >>> 1))
        this.viewPosition <- viewPosition
        this.viewPosition.setAllbinaryLayer(this)
        ()
    
    override this.setPosition(x: int, y: int, z: int) : unit =
        base.setPosition(x, y, z)
    
    override this.moveDXYZ(dx: int, dy: int, dz: int) : unit =
        base.moveDXYZ(dx, dy, dz)
    
    override this.getXP() : int =
        base.getXP()
    
    override this.getYP() : int =
        base.getYP()
    
    override this.getZP() : int =
        base.getZP()
    
    override this.getWidth() : int =
        base.getWidth()
    
    override this.getHeight() : int =
        base.getHeight()
    
    override this.setVisible(visible: bool) : unit =
        base.setVisible(visible)
    
    override this.isVisible() : bool =
        base.isVisible()
    
    override this.paint(graphics: Graphics) : unit =
        base.paint(graphics)
    
    abstract onChangeEvent : layerManagerEvent: ViewPositionEvent -> unit
    default this.onChangeEvent(layerManagerEvent: ViewPositionEvent) : unit =
        ()
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract getX2 : unit -> int
    default this.getX2() : int =
        this.getXP() + this.getWidth()
    
    abstract getY2 : unit -> int
    default this.getY2() : int =
        this.getYP() + this.getHeight()
    
    abstract getZ2 : unit -> int
    default this.getZ2() : int =
        int ((int64 (this.getZP()) + this.getDepth()))
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract setHalfWidth : halfWidth: int -> unit
    default this.setHalfWidth(halfWidth: int) : unit =
        this.halfWidth <- halfWidth
    
    abstract getHalfWidth : unit -> int
    default this.getHalfWidth() : int =
        this.halfWidth
    
    abstract setHalfHeight : halfHeight: int -> unit
    default this.setHalfHeight(halfHeight: int) : unit =
        this.halfHeight <- halfHeight
    
    abstract getHalfHeight : unit -> int
    default this.getHalfHeight() : int =
        this.halfHeight
    
    abstract getHalfDepth : unit -> int
    default this.getHalfDepth() : int =
        int (this.getDepth()) / 2
    
    abstract getViewPosition : unit -> ViewPositionBase
    default this.getViewPosition() : ViewPositionBase =
        this.viewPosition
    
    abstract setViewPosition : viewPosition: ViewPositionBase -> unit
    default this.setViewPosition(viewPosition: ViewPositionBase) : unit =
        this.viewPosition <- viewPosition
    
    abstract getGroupInterface : unit -> Group[]
    default this.getGroupInterface() : Group[] =
        BasicGroupFactory.getInstance().NONE_ARRAY
    
    abstract implmentsTickableInterface : unit -> bool
    default this.implmentsTickableInterface() : bool =
        false
    
    abstract implmentsGameInputInterface : unit -> bool
    default this.implmentsGameInputInterface() : bool =
        false
    
    abstract implmentsArtificialIntelligenceCompositeInterface : unit -> bool
    default this.implmentsArtificialIntelligenceCompositeInterface() : bool =
        false
    
    abstract implmentsCollidableInterface : unit -> bool
    default this.implmentsCollidableInterface() : bool =
        false
    
    abstract implementsThreedInterface : unit -> bool
    default this.implementsThreedInterface() : bool =
        OpenGLFeatureUtil.getInstance().isAnyThreed()
    
    abstract getType : unit -> int
    default this.getType() : int =
        -1
    
    abstract getMultiPlayerType : unit -> int
    default this.getMultiPlayerType() : int =
        -1
    
    override this.toStringAppend(stringBuffer: StringMaker) : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable positionStrings : PositionStrings = PositionStrings.getInstance()
        let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
        ignore (stringBuffer.append(this.getName()))
        ignore (stringBuffer.append(commonSeps.COLON))
        ignore (stringBuffer.append(AllBinaryLayer.TYPE))
        ignore (stringBuffer.appendint(this.getType()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.X_LABEL))
        ignore (stringBuffer.appendint(this.getXP()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.Y_LABEL))
        ignore (stringBuffer.appendint(this.getYP()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.Z_LABEL))
        ignore (stringBuffer.appendint(this.getZP()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(commonLabels.WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.getWidth()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.getHeight()))
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        this.toStringAppend(stringBuffer)
        stringBuffer.ToString()
    interface LayerInterface with
        member this.getHeight() : int = this.getHeight()
        member this.getWidth() : int = this.getWidth()
        member this.getHalfHeight() : int = this.getHalfHeight()
        member this.getHalfWidth() : int = this.getHalfWidth()
        member this.getXP() : int = this.getXP()
        member this.getYP() : int = this.getYP()
        member this.getZP() : int = this.getZP()
        member this.getX2() : int = this.getX2()
        member this.getY2() : int = this.getY2()
        member this.getZ2() : int = this.getZ2()
        member this.isVisible() : bool = this.isVisible()
        member this.moveDXYZ(jp0: int, jp1: int, jp2: int) : unit = this.moveDXYZ(jp0, jp1, jp2)
        member this.setVisible(jp0: bool) : unit = this.setVisible(jp0)
        member this.implmentsTickableInterface() : bool = this.implmentsTickableInterface()
        member this.implmentsCollidableInterface() : bool = this.implmentsCollidableInterface()
        member this.implmentsGameInputInterface() : bool = this.implmentsGameInputInterface()
        member this.implmentsArtificialIntelligenceCompositeInterface() : bool = this.implmentsArtificialIntelligenceCompositeInterface()
        member this.getType() : int = this.getType()
    interface NamedInterface with
        member this.getName() : string = this.getName()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface GroupInterfaceCompositeInterface with
        member this.getGroupInterface() : Group[] = this.getGroupInterface()
    interface PositionInterface with
        member this.setPosition(jp0: int, jp1: int, jp2: int) : unit = this.setPosition(jp0, jp1, jp2)


