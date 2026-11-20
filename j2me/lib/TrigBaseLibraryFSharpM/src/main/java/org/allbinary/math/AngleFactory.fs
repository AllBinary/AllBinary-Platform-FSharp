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
type AngleFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable TOTAL_ANGLE : int16
    [<DefaultValue(false)>] val mutable QUARTER_TOTAL_ANGLE : int16
    [<DefaultValue(false)>] val mutable angleArray : Angle[]
    [<DefaultValue(false)>] val mutable NEGATIVE_ONE : int16
    [<DefaultValue(false)>] val mutable NOT_ANGLE : NamedAngle
    [<DefaultValue(false)>] val mutable DOWN : NamedAngle
    [<DefaultValue(false)>] val mutable UP : NamedAngle
    [<DefaultValue(false)>] val mutable LEFT : NamedAngle
    [<DefaultValue(false)>] val mutable RIGHT : NamedAngle
    [<DefaultValue(false)>] val mutable frameUtil : FrameUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : AngleFactory
    static member instance with get() : AngleFactory = (AngleFactory.jclinit(); AngleFactory.jcell_instance) and set (jvalue: AngleFactory) = (AngleFactory.jclinit(); AngleFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AngleFactory.jclinitDone then
            AngleFactory.jclinitDone <- true
            AngleFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AngleFactory.jcell_instance <- (new AngleFactory())
        ()
    member this.jfields_AngleFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.TOTAL_ANGLE <- (360s)
        this.QUARTER_TOTAL_ANGLE <- (90s)
        this.angleArray <- (Array.zeroCreate<Angle> (int (this.TOTAL_ANGLE)))
        this.NEGATIVE_ONE <- (-1s)
        this.NOT_ANGLE <- (new NamedAngle(this.NEGATIVE_ONE, CommonStrings.getInstance().EMPTY))
        this.frameUtil <- FrameUtil.getInstance()
        ()
    
    static member getInstance() : AngleFactory =
        AngleFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AngleFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable commonPhoneStrings : CommonPhoneStrings = CommonPhoneStrings.getInstance()
        let mutable total : int16 = int16 (this.angleArray.Length)
        this.UP <- (new NamedAngle(int16 (0), commonPhoneStrings.UP))
        this.angleArray.[0] <- this.UP
        let mutable index : int = 1
        while index < 90 do
            this.angleArray.[index] <- (new Angle(int16 (index)))
            index <- index + 1
        this.RIGHT <- (new NamedAngle(int16 (90), commonPhoneStrings.RIGHT))
        this.angleArray.[90] <- this.RIGHT
        let mutable index : int = 91
        while index < 180 do
            this.angleArray.[index] <- (new Angle(int16 (index)))
            index <- index + 1
        this.DOWN <- (new NamedAngle(int16 (180), commonPhoneStrings.DOWN))
        this.angleArray.[180] <- this.DOWN
        let mutable index : int = 181
        while index < 270 do
            this.angleArray.[index] <- (new Angle(int16 (index)))
            index <- index + 1
        this.LEFT <- (new NamedAngle(int16 (270), commonPhoneStrings.LEFT))
        this.angleArray.[270] <- this.LEFT
        let mutable index : int = 271
        while index < int (int (total)) do
            this.angleArray.[index] <- (new Angle(int16 (index)))
            index <- index + 1
        ()
    
    abstract getAt : index: int -> Angle
    default this.getAt(index: int) : Angle =
        let mutable adjustedIndex : int = this.frameUtil.adjustAngleToFrameAngle(index)
        this.angleArray.[adjustedIndex]
    
    abstract getClosestDirection : angle: int -> Angle
    default this.getClosestDirection(angle: int) : Angle =
        let mutable jflow = 0
        let mutable jret : Angle = Unchecked.defaultof<Angle>
        if ((angle >= 315) && (angle < 360)) || ((angle >= 0) && (angle < 45)) then
            jret <- this.UP
            jflow <- 1
        elif (angle >= 45) && (angle < 135) then
            jret <- this.RIGHT
            jflow <- 1
        elif (angle >= 135) && (angle < 225) then
            jret <- this.DOWN
            jflow <- 1
        elif (angle >= 225) && (angle < 315) then
            jret <- this.LEFT
            jflow <- 1
        if jflow = 0 then
            raise ((new JRuntimeException()))
        jret
    
    abstract getGeneralDirection : unit -> Angle
    default this.getGeneralDirection() : Angle =
        this.NOT_ANGLE
    
    static member main(args: string[]) : unit =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        let mutable index : int = 0
        while index < 360 do
            ignore (stringMaker.appendint(index).append(CommonSeps.getInstance().FORWARD_SLASH).appendshort(angleFactory.getClosestDirection(index).getValue()).append(CommonSeps.getInstance().NEW_LINE))
            index <- index + 1
        LogUtil.getInstance().putF(stringMaker.ToString(), "main", "main")


