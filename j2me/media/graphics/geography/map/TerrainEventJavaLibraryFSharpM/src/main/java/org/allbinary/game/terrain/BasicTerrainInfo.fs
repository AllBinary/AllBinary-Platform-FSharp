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
type BasicTerrainInfo =
    [<DefaultValue(false)>] val mutable angle : Angle
    [<DefaultValue(false)>] static val mutable private jcell_NULL_BASIC_TERRAIN_INFO : BasicTerrainInfo
    static member NULL_BASIC_TERRAIN_INFO with get() : BasicTerrainInfo = (BasicTerrainInfo.jclinit(); BasicTerrainInfo.jcell_NULL_BASIC_TERRAIN_INFO) and set (jvalue: BasicTerrainInfo) = (BasicTerrainInfo.jclinit(); BasicTerrainInfo.jcell_NULL_BASIC_TERRAIN_INFO <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicTerrainInfo.jclinitDone then
            BasicTerrainInfo.jclinitDone <- true
            BasicTerrainInfo.jclinitBody()
    static member private jclinitBody() : unit =
        BasicTerrainInfo.jcell_NULL_BASIC_TERRAIN_INFO <- (new BasicTerrainInfo(AngleFactory.getInstance().NOT_ANGLE))
        ()
    
    new (angle: Angle) as this =
        {  }
        then
            this.jctor1(angle)
    member this.jctor1(angle: Angle) : unit =
        this.angle <- angle
        ()
    
    abstract getAngle : unit -> Angle
    default this.getAngle() : Angle =
        this.angle
    
    abstract setAngle : angle: Angle -> unit
    default this.setAngle(angle: Angle) : unit =
        this.angle <- angle


