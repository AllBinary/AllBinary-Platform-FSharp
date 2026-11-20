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
type ConstantVelocityNotifyViewChangeMovement =
    inherit Movement
    [<DefaultValue(false)>] val mutable basicVelocityProperties : BasicVelocityProperties
    [<DefaultValue(false)>] val mutable speedBasicDecimal : BasicDecimal
    [<DefaultValue(false)>] val mutable axisMathVectorUtil : AxisMathVectorUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ConstantVelocityNotifyViewChangeMovement.jclinitDone then
            ConstantVelocityNotifyViewChangeMovement.jclinitDone <- true
            ConstantVelocityNotifyViewChangeMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ConstantVelocityNotifyViewChangeMovement() : unit =
        this.axisMathVectorUtil <- AxisMathVectorUtil.getInstance()
        ()
    
    new () as this =
        { inherit Movement() }
        then
            this.jfields_ConstantVelocityNotifyViewChangeMovement()
            this.jctor1()
    member this.jctor1() : unit =
        this.speedBasicDecimal <- BasicDecimal.ZERO_BIGDECIMAL
        this.basicVelocityProperties <- (new BasicVelocityProperties())
        ()
    
    override this.init(speedBasicDecimal: BasicDecimal, angle: int, otherAngle: int) : unit =
        this.speedBasicDecimal <- speedBasicDecimal
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        this.basicVelocityProperties.setVelocityWithBigDecimal(speedBasicDecimal, angleFactory.getAt(angle), angleFactory.getAt(otherAngle))
    
    abstract moveOutsideRadius : layer: AllBinaryLayer * radius: int64 * angle: int * otherAngle: int -> unit
    default this.moveOutsideRadius(layer: AllBinaryLayer, radius: int64, angle: int, otherAngle: int) : unit =
        let mutable scaleFactorValue : int = this.speedBasicDecimal.getScaledFactorValue()
        let mutable xVector : int = int ((this.axisMathVectorUtil.calculateX(radius, angle) / int64 (scaleFactorValue)))
        let mutable yVector : int = int ((this.axisMathVectorUtil.calculateY(radius, angle) / int64 (scaleFactorValue)))
        let mutable zVector : int = int ((this.axisMathVectorUtil.calculateZ(radius, otherAngle) / int64 (scaleFactorValue)))
        layer.moveDXYZ(xVector, yVector, zVector)
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        let mutable x : int = this.basicVelocityProperties.getVelocityXBasicDecimalP().getScaled()
        let mutable y : int = this.basicVelocityProperties.getVelocityYBasicDecimalP().getScaled()
        let mutable z : int = this.basicVelocityProperties.getVelocityZBasicDecimalP().getScaled()
        layer.moveDXYZ(x, y, z)
        if ((x <> 0) || (y <> 0)) || (z <> 0) then
            layer.onViewPositionChangeEvent()
    
    override this.stop() : unit =
        this.basicVelocityProperties.zero()


