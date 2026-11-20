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
type Layer =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable z : int
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] val mutable visible : bool
    [<DefaultValue(false)>] static val mutable private jcell_ID : Integer
    static member ID with get() : Integer = (Layer.jclinit(); Layer.jcell_ID) and set (jvalue: Integer) = (Layer.jclinit(); Layer.jcell_ID <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Layer.jclinitDone then
            Layer.jclinitDone <- true
            Layer.jclinitBody()
    static member private jclinitBody() : unit =
        Layer.jcell_ID <- SmallIntegerSingletonFactory.getInstance().getAt(0)
        ()
    member this.jfields_Layer() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.z <- 3
        this.visible <- true
        ()
    
    new (width: int, height: int) as this =
        {  }
        then
            this.jfields_Layer()
            this.jctor1(width, height)
    member this.jctor1(width: int, height: int) : unit =
        this.setLayerWidth(width)
        this.setLayerHeight(height)
        ()
    
    abstract setPosition : x: int * y: int * z: int -> unit
    default this.setPosition(x: int, y: int, z: int) : unit =
        this.x <- x
        this.y <- y
        this.z <- z
    
    abstract moveDXY : dx: int * dy: int -> unit
    default this.moveDXY(dx: int, dy: int) : unit =
        this.x <- this.x + dx
        this.y <- this.y + dy
    
    abstract moveDXYZ : dx: int * dy: int * dz: int -> unit
    default this.moveDXYZ(dx: int, dy: int, dz: int) : unit =
        this.x <- this.x + dx
        this.y <- this.y + dy
        this.z <- this.z + dz
    
    abstract getXP : unit -> int
    default this.getXP() : int =
        this.x
    
    abstract getYP : unit -> int
    default this.getYP() : int =
        this.y
    
    abstract getZP : unit -> int
    default this.getZP() : int =
        this.z
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        this.width
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        this.height
    
    abstract getDepth : unit -> int64
    default this.getDepth() : int64 =
        0L
    
    abstract setVisible : visible: bool -> unit
    default this.setVisible(visible: bool) : unit =
        this.visible <- visible
    
    abstract isVisible : unit -> bool
    default this.isVisible() : bool =
        this.visible
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable canvasStrings : CanvasStrings = CanvasStrings.getInstance()
        this.logUtil.putF(commonStrings.NOT_IMPLEMENTED, this, canvasStrings.PAINT)
    
    abstract setLayerWidth : width: int -> unit
    default this.setLayerWidth(width: int) : unit =
        if width < 0 then
            raise ((new JIllegalArgumentException()))
        this.width <- width
    
    abstract setLayerHeight : height: int -> unit
    default this.setLayerHeight(height: int) : unit =
        if height < 0 then
            raise ((new JIllegalArgumentException()))
        this.height <- height
    
    abstract toStringAppend : stringBuffer: StringMaker -> unit
    default this.toStringAppend(stringBuffer: StringMaker) : unit =
        ()


