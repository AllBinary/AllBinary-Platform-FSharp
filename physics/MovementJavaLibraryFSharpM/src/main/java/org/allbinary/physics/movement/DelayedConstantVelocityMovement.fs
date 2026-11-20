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
type DelayedConstantVelocityMovement =
    inherit BasicConstantVelocityMovement
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DelayedConstantVelocityMovement.jclinitDone then
            DelayedConstantVelocityMovement.jclinitDone <- true
            DelayedConstantVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DelayedConstantVelocityMovement() : unit =
        this.timeDelayHelper <- (new TimeDelayHelper(60))
        ()
    
    new (basicDecimal: BasicDecimal, velocityProperties: BasicVelocityProperties) as this =
        { inherit BasicConstantVelocityMovement(basicDecimal, velocityProperties) }
        then
            this.jfields_DelayedConstantVelocityMovement()
    
    override this.init(speedBasicDecimal: BasicDecimal, angle: int, otherAngle: int) : unit =
        ()
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        if this.timeDelayHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            base.process_(layer)


