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
type DragVelocityBehavior =
    inherit VelocityBehaviorBase
    [<DefaultValue(false)>] static val mutable private jcell_instance : DragVelocityBehavior
    static member instance with get() : DragVelocityBehavior = (DragVelocityBehavior.jclinit(); DragVelocityBehavior.jcell_instance) and set (jvalue: DragVelocityBehavior) = (DragVelocityBehavior.jclinit(); DragVelocityBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DragVelocityBehavior.jclinitDone then
            DragVelocityBehavior.jclinitDone <- true
            DragVelocityBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        DragVelocityBehavior.jcell_instance <- (new DragVelocityBehavior())
        ()
    new () =
        { inherit VelocityBehaviorBase() }
    
    override this.reduce(velocityProperties: BasicVelocityProperties, nominator: int, denominator: int) : unit =
        if velocityProperties.getVelocityXBasicDecimalP().getUnscaled() <> 0L then
            let mutable basicDecimal : BasicDecimal = velocityProperties.getVelocityXBasicDecimalP()
            basicDecimal.multiplyint(nominator)
            basicDecimal.divideint(denominator)
        if velocityProperties.getVelocityYBasicDecimalP().getUnscaled() <> 0L then
            let mutable basicDecimal : BasicDecimal = velocityProperties.getVelocityYBasicDecimalP()
            basicDecimal.multiplyint(nominator)
            basicDecimal.divideint(denominator)
    
    override this.reduceX(velocityProperties: BasicVelocityProperties, nominator: int, denominator: int) : unit =
        let mutable basicDecimal : BasicDecimal = velocityProperties.getVelocityXBasicDecimalP()
        if basicDecimal.getUnscaled() <> 0L then
            basicDecimal.multiplyint(nominator)
            basicDecimal.divideint(denominator)
    
    override this.reduceY(velocityProperties: BasicVelocityProperties, nominator: int, denominator: int) : unit =
        if velocityProperties.getVelocityYBasicDecimalP().getUnscaled() <> 0L then
            let mutable basicDecimal : BasicDecimal = velocityProperties.getVelocityYBasicDecimalP()
            basicDecimal.multiplyint(nominator)
            basicDecimal.divideint(denominator)


