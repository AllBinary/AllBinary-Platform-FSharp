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
type TimedFireAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable maxFireDelayTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable delay : int
    [<DefaultValue(false)>] static val mutable private jcell_TIME : Integer
    static member TIME with get() : Integer = (TimedFireAI.jclinit(); TimedFireAI.jcell_TIME) and set (jvalue: Integer) = (TimedFireAI.jclinit(); TimedFireAI.jcell_TIME <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimedFireAI.jclinitDone then
            TimedFireAI.jclinitDone <- true
            TimedFireAI.jclinitBody()
    static member private jclinitBody() : unit =
        TimedFireAI.jcell_TIME <- SmallIntegerSingletonFactory.getInstance().getAt(1)
        ()
    member this.jfields_TimedFireAI() : unit =
        this.maxFireDelayTimeHelper <- (new TimeDelayHelper(0))
        ()
    
    new (delay: int, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_TimedFireAI()
            this.jctor1(delay, ownerLayerInterface, gameInput)
    member this.jctor1(delay: int, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.delay <- delay
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable timeFiredInterface : TimeFiredInterface = (box (this.getOwnerLayerInterface()) :?> TimeFiredInterface)
        if this.maxFireDelayTimeHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) && (int64 (timeFiredInterface.getLastFireTime() + int64 (this.maxFireDelayTimeHelper.delay)) < this.maxFireDelayTimeHelper.getStartTime()) then
            base.processKeyAI(Canvas.KEY_NUM1)
            this.maxFireDelayTimeHelper.delay <- this.delay


