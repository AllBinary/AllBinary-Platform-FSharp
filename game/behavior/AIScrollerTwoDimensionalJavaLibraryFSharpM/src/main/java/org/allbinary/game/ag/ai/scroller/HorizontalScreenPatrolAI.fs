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
type HorizontalScreenPatrolAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable keyDirection : int
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable firingX : int
    [<DefaultValue(false)>] val mutable firedIndex : int
    [<DefaultValue(false)>] val mutable MAX_FIRE : int
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable secondaryPlayerQueue : PlayerQueue
    [<DefaultValue(false)>] val mutable sound : Sound
    [<DefaultValue(false)>] static val mutable private jcell_SOUND : Integer
    static member SOUND with get() : Integer = (HorizontalScreenPatrolAI.jclinit(); HorizontalScreenPatrolAI.jcell_SOUND) and set (jvalue: Integer) = (HorizontalScreenPatrolAI.jclinit(); HorizontalScreenPatrolAI.jcell_SOUND <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HorizontalScreenPatrolAI.jclinitDone then
            HorizontalScreenPatrolAI.jclinitDone <- true
            HorizontalScreenPatrolAI.jclinitBody()
    static member private jclinitBody() : unit =
        HorizontalScreenPatrolAI.jcell_SOUND <- SmallIntegerSingletonFactory.getInstance().getAt(433)
        ()
    member this.jfields_HorizontalScreenPatrolAI() : unit =
        this.keyDirection <- Canvas.LEFT
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.firingX <- this.displayInfoSingleton.getLastHalfWidth()
        this.firedIndex <- 0
        this.MAX_FIRE <- 28
        this.timeDelayHelper <- (new TimeDelayHelper(240))
        this.secondaryPlayerQueue <- SecondaryPlayerQueueFactory.getInstance()
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_HorizontalScreenPatrolAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.sound <- (box (hashtable.get(HorizontalScreenPatrolAI.SOUND)) :?> Sound)
        if (JR.same(this.sound, null)) then
            raise ((new JException("No Sound Provided!!")))
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        base.processKeyAI(this.keyDirection)
        if this.timeDelayHelper.isTimeTNT() then
            let mutable layerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
            let mutable currentOwnerLayerX : int = layerInterface.getXP()
            if currentOwnerLayerX < (-(layerInterface.getWidth())) then
                let mutable y : int = MyRandomFactory.getInstance().getAbsoluteNextIntAllowZero(50)
                layerInterface.setPosition(((this.displayInfoSingleton.getLastWidth() + layerInterface.getWidth()) + 50), y, layerInterface.getZP())
                this.firedIndex <- 0
                this.firingX <- this.displayInfoSingleton.getLastHalfWidth() + MyRandomFactory.getInstance().getNextInt(this.displayInfoSingleton.getLastHalfWidth())
                ignore (this.secondaryPlayerQueue.add(this.sound))
            if (currentOwnerLayerX < this.firingX) && (currentOwnerLayerX > (-(layerInterface.getWidth()))) then
                base.processKeyAI(Canvas.KEY_NUM1)
                let mutable gameLayerManager : AllBinaryGameLayerManager = (box (allBinaryLayerManager) :?> AllBinaryGameLayerManager)
                let mutable FIRE : int = (gameLayerManager.getGameInfo().getCurrentLevel() + 12) >>> 2
                if FIRE > this.MAX_FIRE then
                    FIRE <- this.MAX_FIRE
                if this.firedIndex > FIRE then
                    this.firedIndex <- 0
                    this.firingX <- Integer.MIN_VALUE
                this.firedIndex <- this.firedIndex + 1
    
    abstract nextDirection : unit -> unit
    default this.nextDirection() : unit =
        ()


