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
type HorizontalManeuverAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable currentRelativeAngle : int
    [<DefaultValue(false)>] val mutable currentSpeed : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HorizontalManeuverAI.jclinitDone then
            HorizontalManeuverAI.jclinitDone <- true
            HorizontalManeuverAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HorizontalManeuverAI() : unit =
        this.currentRelativeAngle <- 0
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_HorizontalManeuverAI()
            this.jctor1(ownerLayerInterface, gameInput)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.currentSpeed <- 5
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable x : int = ownerLayerInterface.getXP()
        if (ownerLayerInterface.getXP() - this.currentSpeed) <= 0 then
            this.reverse()
            this.drop()
        if (ownerLayerInterface.getX2() + this.currentSpeed) > DisplayInfoSingleton.getInstance().getLastWidth() then
            this.reverse()
            this.accelerate()
            this.drop()
        if this.currentRelativeAngle = 0 then
            x <- x + this.currentSpeed
        elif this.currentRelativeAngle = 180 then
            x <- x - this.currentSpeed
        ownerLayerInterface.setPosition(x, ownerLayerInterface.getYP(), ownerLayerInterface.getZP())
        if this.currentRelativeAngle = 0 then
            base.processKeyAI(Canvas.KEY_NUM0)
        elif this.currentRelativeAngle = 180 then
            base.processKeyAI(Canvas.KEY_POUND)
    
    abstract reverse : unit -> unit
    default this.reverse() : unit =
        if this.currentRelativeAngle = 180 then
            this.currentRelativeAngle <- 0
        elif this.currentRelativeAngle = 0 then
            this.currentRelativeAngle <- 180
    
    member this.accelerate() : unit =
        if this.currentSpeed < 20 then
            this.currentSpeed <- this.currentSpeed + 1
    
    member this.drop() : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable y : int = ownerLayerInterface.getYP()
        if (ownerLayerInterface.getY2() + ownerLayerInterface.getHeight()) > DisplayInfoSingleton.getInstance().getLastHeight() then
            y <- 0
        else
            y <- y + (ownerLayerInterface.getHeight() + 1)
        ownerLayerInterface.setPosition(ownerLayerInterface.getXP(), y, ownerLayerInterface.getZP())


