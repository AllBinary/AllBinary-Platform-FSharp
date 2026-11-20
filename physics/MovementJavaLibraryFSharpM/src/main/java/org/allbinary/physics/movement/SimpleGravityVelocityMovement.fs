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
type SimpleGravityVelocityMovement =
    inherit BasicConstantVelocityMovement
    [<DefaultValue(false)>] val mutable gravityUtil : GravityUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleGravityVelocityMovement.jclinitDone then
            SimpleGravityVelocityMovement.jclinitDone <- true
            SimpleGravityVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_SimpleGravityVelocityMovement() : unit =
        this.gravityUtil <- GravityUtil.getInstance()
        ()
    
    new (speedBasicDecimal: BasicDecimal) as this =
        { inherit BasicConstantVelocityMovement(speedBasicDecimal, (new VelocityProperties(int (speedBasicDecimal.getUnscaled()), int (speedBasicDecimal.getUnscaled())))) }
        then
            this.jfields_SimpleGravityVelocityMovement()
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        this.gravityUtil.process_(this.getVelocityProperties(), this.gravityUtil.GAME_GRAVITY_VELOCITY)
        base.process_(layer)


