namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type PreciseConstantVelocityMovement =
    inherit BasicConstantVelocityMovement
    [<DefaultValue(false)>] val mutable accumulatedX : int
    [<DefaultValue(false)>] val mutable accumulatedY : int
    [<DefaultValue(false)>] val mutable accumulatedZ : int
    [<DefaultValue(false)>] val mutable factorValue : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PreciseConstantVelocityMovement.jclinitDone then
            PreciseConstantVelocityMovement.jclinitDone <- true
            PreciseConstantVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PreciseConstantVelocityMovement() : unit =
        this.factorValue <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_VALUE
        ()
    
    new (basicDecimal: BasicDecimal, velocityProperties: BasicVelocityProperties) as this =
        { inherit BasicConstantVelocityMovement(basicDecimal, velocityProperties) }
        then
            this.jfields_PreciseConstantVelocityMovement()
    
    override this.init(speedBasicDecimal: BasicDecimal, angle: int, otherAngle: int) : unit =
        ()
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        let mutable mathUtil : MathUtil = MathUtil.getInstance()
        let mutable velocityProperties : BasicVelocityProperties = this.getVelocityProperties()
        this.accumulatedX <- int ((int64 (this.accumulatedX) + velocityProperties.getVelocityXBasicDecimalP().getUnscaled()))
        this.accumulatedY <- int ((int64 (this.accumulatedY) + velocityProperties.getVelocityYBasicDecimalP().getUnscaled()))
        this.accumulatedZ <- int ((int64 (this.accumulatedZ) + velocityProperties.getVelocityZBasicDecimalP().getUnscaled()))
        layer.moveDXYZ((this.accumulatedX / this.factorValue), (this.accumulatedY / this.factorValue), (this.accumulatedZ / this.factorValue))
        if mathUtil.abs(this.accumulatedX) > this.factorValue then
            this.accumulatedX <- 0
        if mathUtil.abs(this.accumulatedY) > this.factorValue then
            this.accumulatedY <- 0
        if mathUtil.abs(this.accumulatedZ) > this.factorValue then
            this.accumulatedZ <- 0


