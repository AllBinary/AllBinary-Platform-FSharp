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
type FlockingAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable allowedDistance : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FlockingAI.jclinitDone then
            FlockingAI.jclinitDone <- true
            FlockingAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        let mutable allowedDistance : Integer = (box (hashtable.get(BasePatrolAI.MAX_DISTANCE)) :?> Integer)
        this.allowedDistance <- allowedDistance.intValue()
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable jflow = 0
        let mutable maxDistance : int = 0
        let mutable farAllbinaryLayer : AllBinaryLayer = AllBinaryLayer.NULL_ALLBINARY_LAYER
        let mutable groupLayerManagerListener : GroupLayerManagerListener = GroupLayerManagerListener.getInstance()
        let mutable list_ : BasicArrayList = groupLayerManagerListener.getList(BasicGroupFactory.getInstance().ENEMY)
        let mutable size : int = list_.size()
        let mutable allBinaryLayer : AllBinaryLayer = null
        let mutable ownerLayerInterface : AllBinaryLayer = null
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            allBinaryLayer <- (box (list_.get(index)) :?> AllBinaryLayer)
            if allBinaryLayer.getType() <> WeaponLayer.getStaticType() then
                let mutable distance : int = this.getXYDistance(allBinaryLayer)
                if distance > maxDistance then
                    maxDistance <- distance
                    farAllbinaryLayer <- allBinaryLayer
                    if distance > this.allowedDistance then
                        jflow <- 100001
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            if maxDistance > this.allowedDistance then
                if not (JR.same(farAllbinaryLayer, AllBinaryLayer.NULL_ALLBINARY_LAYER)) then
                    ownerLayerInterface <- this.getOwnerLayerInterface()
                    if farAllbinaryLayer.getXP() < ownerLayerInterface.getXP() then
                        this.processKeyAI(Canvas.LEFT)
                    elif farAllbinaryLayer.getXP() > ownerLayerInterface.getXP() then
                        this.processKeyAI(Canvas.RIGHT)
                    elif farAllbinaryLayer.getYP() > ownerLayerInterface.getYP() then
                        this.processKeyAI(Canvas.UP)
                    elif farAllbinaryLayer.getYP() < ownerLayerInterface.getYP() then
                        this.processKeyAI(Canvas.DOWN)
    
    member this.getXYDistance(allBinaryLayer: AllBinaryLayer) : int =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable xTotalDistance : int = (allBinaryLayer.getXP() + allBinaryLayer.getHalfWidth()) - (ownerLayerInterface.getXP() + ownerLayerInterface.getHalfWidth())
        let mutable yTotalDistance : int = (allBinaryLayer.getYP() + allBinaryLayer.getHalfHeight()) - (ownerLayerInterface.getYP() + ownerLayerInterface.getHalfHeight())
        let mutable mathUtil : MathUtil = MathUtil.getInstance()
        let mutable totalDistance : int = mathUtil.abs(xTotalDistance) + mathUtil.abs(yTotalDistance)
        totalDistance


