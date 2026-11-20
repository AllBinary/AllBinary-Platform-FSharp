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
type OscillateVelocityMovement =
    inherit BasicConstantVelocityMovement
    [<DefaultValue(false)>] val mutable oscillateMin : int
    [<DefaultValue(false)>] val mutable oscillateMax : int
    [<DefaultValue(false)>] val mutable oscillate : int
    [<DefaultValue(false)>] val mutable oscillatePositive : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OscillateVelocityMovement.jclinitDone then
            OscillateVelocityMovement.jclinitDone <- true
            OscillateVelocityMovement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (speedBasicDecimal: BasicDecimal, oscillateMin: int, oscillateMax: int) as this =
        { inherit BasicConstantVelocityMovement(speedBasicDecimal, (new VelocityProperties(int (speedBasicDecimal.getUnscaled()), int (speedBasicDecimal.getUnscaled())))) }
        then
            this.jctor1(speedBasicDecimal, oscillateMin, oscillateMax)
    member this.jctor1(speedBasicDecimal: BasicDecimal, oscillateMin: int, oscillateMax: int) : unit =
        ()
        this.oscillateMin <- oscillateMin
        this.oscillateMax <- oscillateMax
        ()
    
    override this.process_(layer: AllBinaryGameLayer) : unit =
        base.process_(layer)
        if this.oscillate < this.oscillateMin then
            this.oscillatePositive <- true
        elif this.oscillate > this.oscillateMax then
            this.oscillatePositive <- false
        if this.oscillatePositive then
            this.oscillate <- this.oscillate + 1
            this.getVelocityProperties().getVelocityXBasicDecimalP().addint(2000)
        else
            this.oscillate <- this.oscillate - 1
            this.getVelocityProperties().getVelocityXBasicDecimalP().subtractint(2000)


