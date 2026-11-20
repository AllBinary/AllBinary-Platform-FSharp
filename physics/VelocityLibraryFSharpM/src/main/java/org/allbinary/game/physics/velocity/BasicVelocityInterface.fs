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
type BasicVelocityInterface =
    abstract getVelocityXBasicDecimalP : unit -> BasicDecimal
    abstract getVelocityYBasicDecimalP : unit -> BasicDecimal
    abstract zero : unit -> unit
    abstract setVelocityWithBigDecimalAndDirection : magnitudeBasicDecimal: BasicDecimal * direction: Direction * otherDirection: Direction -> unit
    abstract addVelocityWithBigDecimalAndDirection : magnitudeBasicDecimal: BasicDecimal * direction: Direction * otherDirection: Direction -> unit
    abstract setVelocityWithDirection : magnitude: int64 * direction: Direction * otherDirection: Direction -> unit
    abstract addVelocityWithDirection : magnitude: int64 * direction: Direction * otherDirection: Direction -> unit
    abstract setVelocityWithBigDecimal : magnitudeBasicDecimal: BasicDecimal * angle: Angle * otherAngle: Angle -> unit
    abstract addVelocityWithBigDecimal : magnitudeBasicDecimal: BasicDecimal * angle: Angle * otherAngle: Angle -> unit
    abstract setVelocity : magnitude: int64 * angle: Angle * otherAngle: Angle -> unit
    abstract addVelocity : magnitude: int64 * angle: Angle * otherAngle: Angle -> unit
    abstract addVelocityi : magnitude: int64 * angle: int * otherAngle: int -> unit


