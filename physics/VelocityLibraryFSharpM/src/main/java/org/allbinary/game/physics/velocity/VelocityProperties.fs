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
type VelocityProperties =
    inherit BasicVelocityProperties
    [<DefaultValue(false)>] val mutable maxForwardVelocity : int
    [<DefaultValue(false)>] val mutable maxReverseVelocity : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_VELOCITY_PROPERTIES : VelocityProperties
    static member NULL_VELOCITY_PROPERTIES with get() : VelocityProperties = (VelocityProperties.jclinit(); VelocityProperties.jcell_NULL_VELOCITY_PROPERTIES) and set (jvalue: VelocityProperties) = (VelocityProperties.jclinit(); VelocityProperties.jcell_NULL_VELOCITY_PROPERTIES <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VelocityProperties.jclinitDone then
            VelocityProperties.jclinitDone <- true
            VelocityProperties.jclinitBody()
    static member private jclinitBody() : unit =
        VelocityProperties.jcell_NULL_VELOCITY_PROPERTIES <- (new VelocityProperties(0, 0))
        ()
    
    new (maxForwardVelocity: int, maxReverseVelocity: int) as this =
        { inherit BasicVelocityProperties() }
        then
            this.jctor1(maxForwardVelocity, maxReverseVelocity)
    member this.jctor1(maxForwardVelocity: int, maxReverseVelocity: int) : unit =
        this.setMaxForwardVelocity(maxForwardVelocity)
        this.setMaxReverseVelocity(maxReverseVelocity)
        ()
    
    abstract getMaxForwardVelocity : unit -> int
    default this.getMaxForwardVelocity() : int =
        this.maxForwardVelocity
    
    abstract setMaxForwardVelocity : maxForwardVelocity: int -> unit
    default this.setMaxForwardVelocity(maxForwardVelocity: int) : unit =
        this.maxForwardVelocity <- maxForwardVelocity
    
    abstract getMaxReverseVelocity : unit -> int
    default this.getMaxReverseVelocity() : int =
        this.maxReverseVelocity
    
    abstract setMaxReverseVelocity : maxReverseVelocity: int -> unit
    default this.setMaxReverseVelocity(maxReverseVelocity: int) : unit =
        this.maxReverseVelocity <- maxReverseVelocity
    
    abstract limitMaxXYForwardVelocity : unit -> unit
    default this.limitMaxXYForwardVelocity() : unit =
        this.limitMaxXYVelocity(this.getMaxForwardVelocity())
    
    abstract limitMaxXYReverseVelocity : unit -> unit
    default this.limitMaxXYReverseVelocity() : unit =
        this.limitMaxXYVelocity(this.getMaxReverseVelocity())
    
    abstract limitMaxYForwardVelocity : unit -> unit
    default this.limitMaxYForwardVelocity() : unit =
        this.limitMaxYVelocity(this.getMaxForwardVelocity())
    
    abstract limitMaxYReverseVelocity : unit -> unit
    default this.limitMaxYReverseVelocity() : unit =
        this.limitMaxYVelocity(this.getMaxReverseVelocity())
    
    abstract limitMaxXForwardVelocity : unit -> unit
    default this.limitMaxXForwardVelocity() : unit =
        this.limitMaxXVelocity(this.getMaxForwardVelocity())
    
    abstract limitMaxXReverseVelocity : unit -> unit
    default this.limitMaxXReverseVelocity() : unit =
        this.limitMaxXVelocity(this.getMaxReverseVelocity())
    
    abstract isOverXYMaxForwardVelocity : unit -> bool
    default this.isOverXYMaxForwardVelocity() : bool =
        this.isOverXYMaxVelocity(this.getMaxForwardVelocity())
    
    abstract isOverXYMaxReverseVelocity : unit -> bool
    default this.isOverXYMaxReverseVelocity() : bool =
        this.isOverXYMaxVelocity(this.getMaxReverseVelocity())
    
    abstract limitXYToForwardAndReverseMaxVelocity : unit -> unit
    default this.limitXYToForwardAndReverseMaxVelocity() : unit =
        this.limitMaxXYForwardVelocity()
        this.limitMaxXYReverseVelocity()
    
    abstract limitMaxXYVelocity : maxVelocity: int -> unit
    default this.limitMaxXYVelocity(maxVelocity: int) : unit =
        this.limitMaxXVelocity(maxVelocity)
        this.limitMaxYVelocity(maxVelocity)
    
    abstract limitMaxPositiveYVelocity : maxVelocity: int -> unit
    default this.limitMaxPositiveYVelocity(maxVelocity: int) : unit =
        if this.velocityYBasicDecimal.getUnscaled() > int64 (maxVelocity) then
            this.velocityYBasicDecimal.setint(maxVelocity)
    
    abstract limitMaxNegativeYVelocity : maxVelocity: int -> unit
    default this.limitMaxNegativeYVelocity(maxVelocity: int) : unit =
        if this.velocityYBasicDecimal.getUnscaled() < (int64 (-(maxVelocity))) then
            this.velocityYBasicDecimal.setint(-(maxVelocity))
    
    abstract limitMaxYVelocity : maxVelocity: int -> unit
    default this.limitMaxYVelocity(maxVelocity: int) : unit =
        this.limitMaxPositiveYVelocity(maxVelocity)
        this.limitMaxNegativeYVelocity(maxVelocity)
    
    abstract limitMaxXVelocity : maxVelocity: int -> unit
    default this.limitMaxXVelocity(maxVelocity: int) : unit =
        if this.velocityXBasicDecimal.getUnscaled() > int64 (maxVelocity) then
            this.velocityXBasicDecimal.setint(maxVelocity)
        if this.velocityXBasicDecimal.getUnscaled() < (int64 (-(maxVelocity))) then
            this.velocityXBasicDecimal.setint(-(maxVelocity))
    
    abstract isOverXYMaxVelocity : maxVelocity: int -> bool
    default this.isOverXYMaxVelocity(maxVelocity: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.velocityXBasicDecimal.getUnscaled() > int64 (maxVelocity) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            if this.velocityXBasicDecimal.getUnscaled() < (int64 (-(maxVelocity))) then
                jret <- true
                jflow <- 1
            if jflow = 0 then
                if this.velocityYBasicDecimal.getUnscaled() > int64 (maxVelocity) then
                    jret <- true
                    jflow <- 1
                if jflow = 0 then
                    if this.velocityYBasicDecimal.getUnscaled() < (int64 (-(maxVelocity))) then
                        jret <- true
                        jflow <- 1
                    if jflow = 0 then
                        jret <- false
                        jflow <- 1
        jret
    
    override this.setVelocityi(magnitude: int64, angle: int, otherAngle: int) : unit =
        base.setVelocityi(magnitude, angle, otherAngle)
        this.limitXYToForwardAndReverseMaxVelocity()
    
    override this.addVelocityi(magnitude: int64, angle: int, otherAngle: int) : unit =
        base.addVelocityi(magnitude, angle, otherAngle)
        this.limitXYToForwardAndReverseMaxVelocity()
    interface VelocityInterface with
        member this.getMaxForwardVelocity() : int = this.getMaxForwardVelocity()
        member this.getMaxReverseVelocity() : int = this.getMaxReverseVelocity()
        member this.limitMaxXYForwardVelocity() : unit = this.limitMaxXYForwardVelocity()
        member this.limitMaxXYReverseVelocity() : unit = this.limitMaxXYReverseVelocity()
        member this.limitXYToForwardAndReverseMaxVelocity() : unit = this.limitXYToForwardAndReverseMaxVelocity()
        member this.limitMaxXYVelocity(jp0: int) : unit = this.limitMaxXYVelocity(jp0)
        member this.setMaxForwardVelocity(jp0: int) : unit = this.setMaxForwardVelocity(jp0)
        member this.setMaxReverseVelocity(jp0: int) : unit = this.setMaxReverseVelocity(jp0)
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


