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
type GPoint =
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable z : int
    static member POINT_LABEL : string = "Point: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GPoint.jclinitDone then
            GPoint.jclinitDone <- true
            GPoint.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member getInstance(point: GPoint) : GPoint =
        (new GPoint(point.getX(), point.getY(), point.getZ()))
    
    new (x: int, y: int, z: int) as this =
        {  }
        then
            this.jctor1(x, y, z)
    member this.jctor1(x: int, y: int, z: int) : unit =
        this.x <- x
        this.y <- y
        this.z <- z
        ()
    
    abstract getX : unit -> int
    default this.getX() : int =
        this.x
    
    abstract getY : unit -> int
    default this.getY() : int =
        this.y
    
    abstract getZ : unit -> int
    default this.getZ() : int =
        this.z
    
    abstract getRawX : unit -> int
    default this.getRawX() : int =
        this.x
    
    abstract getRawY : unit -> int
    default this.getRawY() : int =
        this.y
    
    abstract getRawZ : unit -> int
    default this.getRawZ() : int =
        this.z
    
    override this.ToString() : string =
        GPoint.toStringStatic(this.getX(), this.getY(), this.getZ())
    
    static member toStringStatic(x: int, y: int, z: int) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable positionStrings : PositionStrings = PositionStrings.getInstance()
        ignore (stringBuffer.append(GPoint.POINT_LABEL))
        ignore (stringBuffer.append(positionStrings.X_LABEL))
        ignore (stringBuffer.appendint(x))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(positionStrings.Y_LABEL))
        ignore (stringBuffer.appendint(y))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(positionStrings.Z_LABEL))
        ignore (stringBuffer.appendint(z))
        stringBuffer.ToString()


