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
type CustomGravityConstantVelocityMovement =
    inherit BasicConstantVelocityMovement
    [<DefaultValue(false)>] val mutable customGravity : int
    [<DefaultValue(false)>] val mutable gravityUtil : GravityUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomGravityConstantVelocityMovement.jclinitDone then
            CustomGravityConstantVelocityMovement.jclinitDone <- true
            CustomGravityConstantVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomGravityConstantVelocityMovement() : unit =
        this.gravityUtil <- GravityUtil.getInstance()
        ()
    
    new (speedBasicDecimal: BasicDecimal, customGravity: int) as this =
        { inherit BasicConstantVelocityMovement(speedBasicDecimal, (new VelocityProperties(int (speedBasicDecimal.getUnscaled()), int (speedBasicDecimal.getUnscaled())))) }
        then
            this.jfields_CustomGravityConstantVelocityMovement()
            this.jctor1(speedBasicDecimal, customGravity)
    member this.jctor1(speedBasicDecimal: BasicDecimal, customGravity: int) : unit =
        ()
        this.customGravity <- customGravity
        ()
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        base.process_(layer)
        this.gravityUtil.process_(this.getVelocityProperties(), this.customGravity)
        let mutable velocityProperties : VelocityProperties = (box (this.getVelocityProperties()) :?> VelocityProperties)
        velocityProperties.limitMaxYForwardVelocity()


