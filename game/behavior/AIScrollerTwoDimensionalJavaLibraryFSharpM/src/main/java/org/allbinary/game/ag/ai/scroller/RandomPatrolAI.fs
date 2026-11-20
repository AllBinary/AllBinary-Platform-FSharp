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
type RandomPatrolAI =
    inherit BasePatrolAI
    [<DefaultValue(false)>] val mutable changedDirection : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RandomPatrolAI.jclinitDone then
            RandomPatrolAI.jclinitDone <- true
            RandomPatrolAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RandomPatrolAI() : unit =
        this.changedDirection <- true
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasePatrolAI(hashtable, ownerLayerInterface, gameInput) }
        then
            this.jfields_RandomPatrolAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.updateRandomDistance()
        ()
    
    member this.updateRandomDistance() : unit =
        this.currentDistance <- MyRandomFactory.getInstance().getAbsoluteNextInt(this.maxDistance.intValue())
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        base.update()
        base.processKeyAI(this.keyDirection)
        if this.changedDirection then
            base.processKeyAI(Canvas.KEY_NUM1)
            this.updateRandomDistance()
            this.changedDirection <- false
    
    override this.nextDirection() : unit =
        base.nextDirection()
        this.changedDirection <- true


