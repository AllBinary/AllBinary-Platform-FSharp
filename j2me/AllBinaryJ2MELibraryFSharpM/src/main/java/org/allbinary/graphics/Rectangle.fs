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
type Rectangle =
    [<DefaultValue(false)>] val mutable point : GPoint
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Rectangle.jclinitDone then
            Rectangle.jclinitDone <- true
            Rectangle.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (point: GPoint, width: int, height: int) as this =
        {  }
        then
            this.jctor1(point, width, height)
    member this.jctor1(point: GPoint, width: int, height: int) : unit =
        this.point <- point
        this.width <- width
        this.height <- height
        ()
    
    abstract getPoint : unit -> GPoint
    default this.getPoint() : GPoint =
        this.point
    
    abstract setPoint : point: GPoint -> unit
    default this.setPoint(point: GPoint) : unit =
        this.point <- point
    
    abstract getMaxX : unit -> int
    default this.getMaxX() : int =
        this.point.getX() + this.width
    
    abstract getMaxY : unit -> int
    default this.getMaxY() : int =
        this.point.getY() + this.height
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        this.width
    
    abstract setWidth : width: int -> unit
    default this.setWidth(width: int) : unit =
        this.width <- width
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        this.height
    
    abstract setHeight : height: int -> unit
    default this.setHeight(height: int) : unit =
        this.height <- height
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.getPoint().ToString()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(CommonLabels.getInstance().WIDTH_LABEL))
        ignore (stringBuffer.appendint(this.getWidth()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(CommonLabels.getInstance().HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.getHeight()))
        ignore (stringBuffer.append(" MaxX: "))
        ignore (stringBuffer.appendint(this.getMaxX()))
        ignore (stringBuffer.append(" MaxY: "))
        ignore (stringBuffer.appendint(this.getMaxY()))
        stringBuffer.ToString()


