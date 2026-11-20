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
type TerrainPatrolAI =
    inherit PacePatrolAI
    [<DefaultValue(false)>] val mutable terrainEventListener : TerrainEventListener
    [<DefaultValue(false)>] val mutable DOWN : Angle
    [<DefaultValue(false)>] val mutable CLIFF : BasicTerrainInfo
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TerrainPatrolAI.jclinitDone then
            TerrainPatrolAI.jclinitDone <- true
            TerrainPatrolAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TerrainPatrolAI() : unit =
        this.terrainEventListener <- (new TerrainEventListener())
        this.DOWN <- AngleFactory.getInstance().DOWN
        this.CLIFF <- (new BasicTerrainInfo(this.DOWN))
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit PacePatrolAI(hashtable, ownerLayerInterface, gameInput) }
        then
            this.jfields_TerrainPatrolAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        TerrainEventHandler.getInstance(ownerLayerInterface).addListener(this.terrainEventListener)
        this.terrainEventListener.onTerrainEvent(TerrainEventCircularStaticPool.getInstance().getNext(this.CLIFF))
        ()
    
    override this.update() : unit =
        base.update()
        this.changeDirectionIfCliffReached()
    
    member this.changeDirectionIfCliffReached() : unit =
        let mutable list_ : BasicArrayList = this.terrainEventListener.getList()
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable terrainEvent : TerrainEvent = (box (list_.removeAt(index)) :?> TerrainEvent)
            let mutable basicTerrainInfo : BasicTerrainInfo = terrainEvent.getBasicTerrainInfo()
            let mutable angle : Angle = basicTerrainInfo.getAngle()
            if (JR.same(angle, this.DOWN)) then
                this.nextDirection()
                if not (this.isFollowLimitedByTerrain) then
                    this.logUtil.putF("Following Limited", this, "onTerrainEvent")
                    this.isFollowLimitedByTerrain <- true
            index <- index + 1


