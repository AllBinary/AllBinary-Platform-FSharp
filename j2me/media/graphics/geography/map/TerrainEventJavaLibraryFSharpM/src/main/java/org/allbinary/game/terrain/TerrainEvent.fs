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
type TerrainEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable basicTerrainInfo : BasicTerrainInfo
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TerrainEvent.jclinitDone then
            TerrainEvent.jclinitDone <- true
            TerrainEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TerrainEvent() : unit =
        this.basicTerrainInfo <- BasicTerrainInfo.NULL_BASIC_TERRAIN_INFO
        ()
    
    new (basicTerrainInfo: obj) as this =
        { inherit AllBinaryEventObject(basicTerrainInfo) }
        then
            this.jfields_TerrainEvent()
            this.jctor1(basicTerrainInfo)
    member this.jctor1(basicTerrainInfo: obj) : unit =
        ()
        this.setBasicTerrainInfo(this.basicTerrainInfo)
        ()
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("TerrainEvent: \n"))
        ignore (stringBuffer.append("LayerInterface: "))
        ignore (stringBuffer.append(this.basicTerrainInfo.ToString()))
        stringBuffer.ToString()
    
    abstract getBasicTerrainInfo : unit -> BasicTerrainInfo
    default this.getBasicTerrainInfo() : BasicTerrainInfo =
        this.basicTerrainInfo
    
    abstract setBasicTerrainInfo : basicTerrainInfo: BasicTerrainInfo -> unit
    default this.setBasicTerrainInfo(basicTerrainInfo: BasicTerrainInfo) : unit =
        this.basicTerrainInfo <- basicTerrainInfo
    
    abstract setBasicTerrainInfoForCircularStaticPool : basicTerrainInfo: BasicTerrainInfo -> unit
    default this.setBasicTerrainInfoForCircularStaticPool(basicTerrainInfo: BasicTerrainInfo) : unit =
        this.basicTerrainInfo <- basicTerrainInfo


