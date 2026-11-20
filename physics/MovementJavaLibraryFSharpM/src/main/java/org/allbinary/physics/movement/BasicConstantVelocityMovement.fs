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
type BasicConstantVelocityMovement =
    inherit Movement
    [<DefaultValue(false)>] val mutable velocityProperties : BasicVelocityProperties
    [<DefaultValue(false)>] val mutable speedBasicDecimal : BasicDecimal
    [<DefaultValue(false)>] val mutable axisMathVectorUtil : AxisMathVectorUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicConstantVelocityMovement.jclinitDone then
            BasicConstantVelocityMovement.jclinitDone <- true
            BasicConstantVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicConstantVelocityMovement() : unit =
        this.speedBasicDecimal <- BasicDecimal.ZERO_BIGDECIMAL
        this.axisMathVectorUtil <- AxisMathVectorUtil.getInstance()
        ()
    
    new (basicDecimal: BasicDecimal, velocityProperties: BasicVelocityProperties) as this =
        { inherit Movement() }
        then
            this.jfields_BasicConstantVelocityMovement()
            this.jctor1(basicDecimal, velocityProperties)
    member this.jctor1(basicDecimal: BasicDecimal, velocityProperties: BasicVelocityProperties) : unit =
        this.setSpeedBasicDecimal(basicDecimal)
        this.velocityProperties <- velocityProperties
        ()
    
    override this.init(speedBasicDecimal: BasicDecimal, angle: int, otherAngle: int) : unit =
        this.speedBasicDecimal <- speedBasicDecimal
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        this.velocityProperties.setVelocityWithBigDecimal(speedBasicDecimal, angleFactory.getAt(angle), angleFactory.getAt(otherAngle))
    
    abstract moveOutsideRadius : layer: AllBinaryLayer * radius: int64 * angle: int * otherAngle: int -> unit
    default this.moveOutsideRadius(layer: AllBinaryLayer, radius: int64, angle: int, otherAngle: int) : unit =
        let mutable scaleFactorValue : int = this.speedBasicDecimal.getScaledFactorValue()
        let mutable xVector : int = int ((this.axisMathVectorUtil.calculateX(radius, angle) / int64 (scaleFactorValue)))
        let mutable yVector : int = int ((this.axisMathVectorUtil.calculateY(radius, angle) / int64 (scaleFactorValue)))
        let mutable zVector : int = int ((this.axisMathVectorUtil.calculateZ(radius, otherAngle) / int64 (scaleFactorValue)))
        layer.moveDXYZ(xVector, yVector, zVector)
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        layer.moveDXYZ(this.velocityProperties.getVelocityXBasicDecimalP().getScaled(), this.velocityProperties.getVelocityYBasicDecimalP().getScaled(), this.velocityProperties.getVelocityZBasicDecimalP().getScaled())
    
    override this.ToString() : string =
        this.velocityProperties.ToString()
    
    override this.stop() : unit =
        this.velocityProperties.zero()
    
    abstract getVelocityProperties : unit -> BasicVelocityProperties
    default this.getVelocityProperties() : BasicVelocityProperties =
        this.velocityProperties
    
    abstract setVelocityProperties : velocityProperties: BasicVelocityProperties -> unit
    default this.setVelocityProperties(velocityProperties: BasicVelocityProperties) : unit =
        this.velocityProperties <- velocityProperties
    
    abstract setSpeedBasicDecimal : speedBasicDecimal: BasicDecimal -> unit
    default this.setSpeedBasicDecimal(speedBasicDecimal: BasicDecimal) : unit =
        this.speedBasicDecimal <- speedBasicDecimal
    
    abstract getSpeedBasicDecimal : unit -> BasicDecimal
    default this.getSpeedBasicDecimal() : BasicDecimal =
        this.speedBasicDecimal
    interface VelocityInterfaceCompositeInterface with
        member this.getVelocityProperties() : BasicVelocityProperties = this.getVelocityProperties()


