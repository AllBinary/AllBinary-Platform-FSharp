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
type AngleInfo =
    [<DefaultValue(false)>] val mutable angleIncrementInfo : AngleIncrementInfo
    [<DefaultValue(false)>] val mutable angle : int16
    [<DefaultValue(false)>] val mutable frameUtil : FrameUtil
    static member ANGLE : string = "Angle: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AngleInfo.jclinitDone then
            AngleInfo.jclinitDone <- true
            AngleInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AngleInfo() : unit =
        this.angle <- (0s)
        this.frameUtil <- FrameUtil.getInstance()
        ()
    
    static member getInstance(angleIncrement: int16) : AngleInfo =
        (new AngleInfo(AngleIncrementInfoFactory.getInstance().getAt(angleIncrement)))
    
    new (angleIncrementInfo: AngleIncrementInfo) as this =
        {  }
        then
            this.jfields_AngleInfo()
            this.jctor1(angleIncrementInfo)
    member this.jctor1(angleIncrementInfo: AngleIncrementInfo) : unit =
        this.angleIncrementInfo <- angleIncrementInfo
        ()
    
    abstract adjustAngle : frame: int -> unit
    default this.adjustAngle(frame: int) : unit =
        let mutable newAngle : int = (int (int (this.angleIncrementInfo.getAngleIncrement())) * frame) - 90
        this.setAngle(int16 (this.frameUtil.adjustAngleToFrameAngle(newAngle)))
    
    abstract getAngle : unit -> int16
    default this.getAngle() : int16 =
        this.angle
    
    abstract setAngle : angle: int16 -> unit
    default this.setAngle(angle: int16) : unit =
        this.angle <- angle
    
    abstract getAngleIncrementInfo : unit -> AngleIncrementInfo
    default this.getAngleIncrementInfo() : AngleIncrementInfo =
        this.angleIncrementInfo
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(AngleInfo.ANGLE))
        ignore (stringBuffer.appendshort(this.angle))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.getAngleIncrementInfo())))
        stringBuffer.ToString()


