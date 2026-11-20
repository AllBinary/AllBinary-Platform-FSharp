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
type SalvoInterface =
    abstract process_ : allbinaryLayerManager: AllBinaryLayerManager * angle: int16 * otherAngle: int16 -> unit
    abstract processScore : allbinaryLayerManager: AllBinaryLayerManager * angle: int16 * otherAngle: int16 * weaponProperties: WeaponProperties * scoreableInterface: ScoreableInterface -> unit


