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
type Orientation =
    [<DefaultValue(false)>] val mutable yaw : BasicDecimal
    [<DefaultValue(false)>] val mutable pitch : BasicDecimal
    [<DefaultValue(false)>] val mutable roll : BasicDecimal
    [<DefaultValue(false)>] static val mutable private jcell_NONE : Orientation
    static member NONE with get() : Orientation = (Orientation.jclinit(); Orientation.jcell_NONE) and set (jvalue: Orientation) = (Orientation.jclinit(); Orientation.jcell_NONE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : Orientation
    static member SINGLETON with get() : Orientation = (Orientation.jclinit(); Orientation.jcell_SINGLETON) and set (jvalue: Orientation) = (Orientation.jclinit(); Orientation.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Orientation.jclinitDone then
            Orientation.jclinitDone <- true
            Orientation.jclinitBody()
    static member private jclinitBody() : unit =
        Orientation.jcell_NONE <- (new Orientation(0, 0, 0))
        Orientation.jcell_SINGLETON <- (new Orientation(0, 0, 0))
        ()
    member this.jfields_Orientation() : unit =
        this.yaw <- (new BasicDecimal(0L))
        this.pitch <- (new BasicDecimal(0L))
        this.roll <- (new BasicDecimal(0L))
        ()
    
    static member getInstance(yaw: int, pitch: int, roll: int) : Orientation =
        Orientation.SINGLETON.yaw.setint(yaw)
        Orientation.SINGLETON.pitch.setint(pitch)
        Orientation.SINGLETON.roll.setint(roll)
        Orientation.SINGLETON
    
    new (yaw: int, pitch: int, roll: int) as this =
        {  }
        then
            this.jfields_Orientation()
            this.jctor1(yaw, pitch, roll)
    member this.jctor1(yaw: int, pitch: int, roll: int) : unit =
        this.yaw.setint(yaw)
        this.pitch.setint(pitch)
        this.roll.setint(roll)
        ()
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Y: "))
        ignore (stringBuffer.append(this.yaw.ToString()))
        ignore (stringBuffer.append(" P: "))
        ignore (stringBuffer.append(this.pitch.ToString()))
        ignore (stringBuffer.append(" R: "))
        ignore (stringBuffer.append(this.roll.ToString()))
        stringBuffer.ToString()


