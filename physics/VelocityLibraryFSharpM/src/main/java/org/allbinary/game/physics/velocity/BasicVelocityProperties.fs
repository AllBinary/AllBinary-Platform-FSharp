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
type BasicVelocityProperties =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable velocityXBasicDecimal : BasicDecimal
    [<DefaultValue(false)>] val mutable velocityYBasicDecimal : BasicDecimal
    [<DefaultValue(false)>] val mutable velocityZBasicDecimal : BasicDecimal
    [<DefaultValue(false)>] val mutable axisMathVectorUtil : AxisMathVectorUtil
    [<DefaultValue(false)>] val mutable directionUtil : DirectionUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicVelocityProperties.jclinitDone then
            BasicVelocityProperties.jclinitDone <- true
            BasicVelocityProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicVelocityProperties() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.axisMathVectorUtil <- AxisMathVectorUtil.getInstance()
        this.directionUtil <- DirectionUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicVelocityProperties()
            this.jctor1()
    member this.jctor1() : unit =
        this.velocityXBasicDecimal <- (new BasicDecimal(0L))
        this.velocityYBasicDecimal <- (new BasicDecimal(0L))
        this.velocityZBasicDecimal <- (new BasicDecimal(0L))
        ()
    
    abstract zero : unit -> unit
    default this.zero() : unit =
        this.velocityXBasicDecimal.setint(0)
        this.velocityYBasicDecimal.setint(0)
        this.velocityZBasicDecimal.setint(0)
    
    abstract getVelocityXBasicDecimalP : unit -> BasicDecimal
    default this.getVelocityXBasicDecimalP() : BasicDecimal =
        this.velocityXBasicDecimal
    
    abstract getVelocityYBasicDecimalP : unit -> BasicDecimal
    default this.getVelocityYBasicDecimalP() : BasicDecimal =
        this.velocityYBasicDecimal
    
    abstract getVelocityZBasicDecimalP : unit -> BasicDecimal
    default this.getVelocityZBasicDecimalP() : BasicDecimal =
        this.velocityZBasicDecimal
    
    abstract setVelocityWithBigDecimalAndDirection : magnitudeBasicDecimal: BasicDecimal * direction: Direction * otherDirection: Direction -> unit
    default this.setVelocityWithBigDecimalAndDirection(magnitudeBasicDecimal: BasicDecimal, direction: Direction, otherDirection: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getAngle(direction)
        let mutable otherAngle : Angle = this.directionUtil.getAngle(otherDirection)
        this.setVelocityWithBigDecimal(magnitudeBasicDecimal, angle, otherAngle)
    
    abstract setVelocityWithDirection : magnitude: int64 * direction: Direction * otherDirection: Direction -> unit
    default this.setVelocityWithDirection(magnitude: int64, direction: Direction, otherDirection: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getAngle(direction)
        let mutable otherAngle : Angle = this.directionUtil.getAngle(otherDirection)
        this.setVelocity(magnitude, angle, otherAngle)
    
    abstract addVelocityWithBigDecimalAndDirection : magnitudeBasicDecimal: BasicDecimal * direction: Direction * otherDirection: Direction -> unit
    default this.addVelocityWithBigDecimalAndDirection(magnitudeBasicDecimal: BasicDecimal, direction: Direction, otherDirection: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getAngle(direction)
        let mutable otherAngle : Angle = this.directionUtil.getAngle(otherDirection)
        this.addVelocityWithBigDecimal(magnitudeBasicDecimal, angle, otherAngle)
    
    abstract addVelocityWithDirection : magnitude: int64 * direction: Direction * otherDirection: Direction -> unit
    default this.addVelocityWithDirection(magnitude: int64, direction: Direction, otherDirection: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getAngle(direction)
        let mutable otherAngle : Angle = this.directionUtil.getAngle(otherDirection)
        this.addVelocity(magnitude, angle, otherAngle)
    
    abstract setVelocityWithBigDecimal : magnitudeBasicDecimal: BasicDecimal * angle: Angle * otherAngle: Angle -> unit
    default this.setVelocityWithBigDecimal(magnitudeBasicDecimal: BasicDecimal, angle: Angle, otherAngle: Angle) : unit =
        let mutable magnitude : int64 = magnitudeBasicDecimal.getUnscaled()
        this.setVelocity(magnitude, angle, otherAngle)
    
    abstract addVelocityWithBigDecimal : magnitudeBasicDecimal: BasicDecimal * angle: Angle * otherAngle: Angle -> unit
    default this.addVelocityWithBigDecimal(magnitudeBasicDecimal: BasicDecimal, angle: Angle, otherAngle: Angle) : unit =
        let mutable magnitude : int64 = magnitudeBasicDecimal.getUnscaled()
        this.addVelocity(magnitude, angle, otherAngle)
    
    abstract setVelocity : magnitude: int64 * angle: Angle * otherAngle: Angle -> unit
    default this.setVelocity(magnitude: int64, angle: Angle, otherAngle: Angle) : unit =
        this.setVelocityi(magnitude, int (angle.getValue()), int (otherAngle.getValue()))
    
    abstract addVelocity : magnitude: int64 * angle: Angle * otherAngle: Angle -> unit
    default this.addVelocity(magnitude: int64, angle: Angle, otherAngle: Angle) : unit =
        this.addVelocityi(magnitude, int (angle.getValue()), int (otherAngle.getValue()))
    
    abstract setVelocityi : magnitude: int64 * angle: int * otherAngle: int -> unit
    default this.setVelocityi(magnitude: int64, angle: int, otherAngle: int) : unit =
        let mutable xVector : int64 = (this.axisMathVectorUtil.calculateX(magnitude, angle) / int64 (this.velocityXBasicDecimal.getScaledFactorValue()))
        let mutable yVector : int64 = (this.axisMathVectorUtil.calculateY(magnitude, angle) / int64 (this.velocityYBasicDecimal.getScaledFactorValue()))
        let mutable zVector : int64 = (this.axisMathVectorUtil.calculateZ(magnitude, otherAngle) / int64 (this.velocityZBasicDecimal.getScaledFactorValue()))
        this.velocityXBasicDecimal.setlong(xVector)
        this.velocityYBasicDecimal.setlong(yVector)
        this.velocityZBasicDecimal.setlong(zVector)
    
    abstract addVelocityi : magnitude: int64 * angle: int * otherAngle: int -> unit
    default this.addVelocityi(magnitude: int64, angle: int, otherAngle: int) : unit =
        let mutable xVector : int64 = (this.axisMathVectorUtil.calculateX(magnitude, angle) / int64 (this.velocityXBasicDecimal.getScaledFactorValue()))
        let mutable yVector : int64 = (this.axisMathVectorUtil.calculateY(magnitude, angle) / int64 (this.velocityYBasicDecimal.getScaledFactorValue()))
        let mutable zVector : int64 = (this.axisMathVectorUtil.calculateZ(magnitude, otherAngle) / int64 (this.velocityZBasicDecimal.getScaledFactorValue()))
        this.velocityXBasicDecimal.addlong(xVector)
        this.velocityYBasicDecimal.addlong(yVector)
        this.velocityZBasicDecimal.addlong(zVector)
    
    override this.ToString() : string =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable positionStrings : PositionStrings = PositionStrings.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        ignore (stringBuffer.append("Velocity "))
        ignore (stringBuffer.append(positionStrings.X_LABEL))
        ignore (stringBuffer.append(stringUtil.toString(this.velocityXBasicDecimal)))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.Y_LABEL))
        ignore (stringBuffer.append(stringUtil.toString(this.velocityYBasicDecimal)))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.Z_LABEL))
        ignore (stringBuffer.append(stringUtil.toString(this.velocityZBasicDecimal)))
        stringBuffer.ToString()
    interface BasicVelocityInterface with
        member this.getVelocityXBasicDecimalP() : BasicDecimal = this.getVelocityXBasicDecimalP()
        member this.getVelocityYBasicDecimalP() : BasicDecimal = this.getVelocityYBasicDecimalP()
        member this.zero() : unit = this.zero()
        member this.setVelocityWithBigDecimalAndDirection(jp0: BasicDecimal, jp1: Direction, jp2: Direction) : unit = this.setVelocityWithBigDecimalAndDirection(jp0, jp1, jp2)
        member this.addVelocityWithBigDecimalAndDirection(jp0: BasicDecimal, jp1: Direction, jp2: Direction) : unit = this.addVelocityWithBigDecimalAndDirection(jp0, jp1, jp2)
        member this.setVelocityWithDirection(jp0: int64, jp1: Direction, jp2: Direction) : unit = this.setVelocityWithDirection(jp0, jp1, jp2)
        member this.addVelocityWithDirection(jp0: int64, jp1: Direction, jp2: Direction) : unit = this.addVelocityWithDirection(jp0, jp1, jp2)
        member this.setVelocityWithBigDecimal(jp0: BasicDecimal, jp1: Angle, jp2: Angle) : unit = this.setVelocityWithBigDecimal(jp0, jp1, jp2)
        member this.addVelocityWithBigDecimal(jp0: BasicDecimal, jp1: Angle, jp2: Angle) : unit = this.addVelocityWithBigDecimal(jp0, jp1, jp2)
        member this.setVelocity(jp0: int64, jp1: Angle, jp2: Angle) : unit = this.setVelocity(jp0, jp1, jp2)
        member this.addVelocity(jp0: int64, jp1: Angle, jp2: Angle) : unit = this.addVelocity(jp0, jp1, jp2)
        member this.addVelocityi(jp0: int64, jp1: int, jp2: int) : unit = this.addVelocityi(jp0, jp1, jp2)


