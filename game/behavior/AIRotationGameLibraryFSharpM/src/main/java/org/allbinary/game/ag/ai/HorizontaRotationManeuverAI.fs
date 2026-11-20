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
type HorizontaRotationManeuverAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable currentSpeedDivisor : int
    [<DefaultValue(false)>] val mutable rotationAnimationInterface : IndexedAnimation
    [<DefaultValue(false)>] val mutable baseVelocityInterface : BasicVelocityProperties
    [<DefaultValue(false)>] val mutable velocityInterface : VelocityInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HorizontaRotationManeuverAI.jclinitDone then
            HorizontaRotationManeuverAI.jclinitDone <- true
            HorizontaRotationManeuverAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HorizontaRotationManeuverAI() : unit =
        this.circularIndexUtil <- CircularIndexUtil.createInstanceAt(10, Integer.MAX_VALUE)
        this.currentSpeedDivisor <- 5
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_HorizontaRotationManeuverAI()
            this.jctor1(ownerLayerInterface, gameInput)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
        this.rotationAnimationInterface <- rotationAnimationInterfaceCompositeInterface.getRotationAnimationInterface()
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> VelocityInterfaceCompositeInterface)
        this.baseVelocityInterface <- velocityInterfaceCompositeInterface.getVelocityProperties()
        this.velocityInterface <- (box (this.baseVelocityInterface) :?> VelocityInterface)
        let mutable rotationAnimationInterface : RotationAnimationInterface = (box (this.rotationAnimationInterface) :?> RotationAnimationInterface)
        let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
        rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.RIGHT_FRAME.intValue())
        ()
    
    abstract transition : unit -> unit
    default this.transition() : unit =
        let mutable rotationAnimationInterface : RotationAnimationInterface = (box (this.rotationAnimationInterface) :?> RotationAnimationInterface)
        let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
        let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
        rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.RIGHT_FRAME.intValue())
        let mutable allbinaryLayer : AllBinaryLayer = this.getOwnerLayerInterface()
        allbinaryLayer.setPosition(allbinaryLayer.getXP(), 1, allbinaryLayer.getZP())
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable rotationAnimationInterface : RotationAnimationInterface = ((box (this.rotationAnimationInterface) :?> RotationAnimationInterface))
        let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
        let mutable frame : int = this.rotationAnimationInterface.getFrame()
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        if ((ownerLayerInterface.getXP() - ownerLayerInterface.getWidth()) <= 0) && (frame = angleIncrementInfo.LEFT_FRAME.intValue()) then
            this.reverse()
            this.drop()
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        if ((ownerLayerInterface.getX2() + ownerLayerInterface.getWidth()) > displayInfo.getLastWidth()) && (frame = angleIncrementInfo.RIGHT_FRAME.intValue()) then
            this.reverse()
            this.accelerate()
            this.drop()
        let mutable index : int = this.circularIndexUtil.getIndex()
        if ((index % this.currentSpeedDivisor) = 0) && ((index % 2) = 0) then
            base.processKeyAI(Canvas.UP)
            this.velocityInterface.limitMaxXYVelocity((this.velocityInterface.getMaxForwardVelocity() / this.currentSpeedDivisor))
        ignore (this.circularIndexUtil.next())
        if frame = angleIncrementInfo.LEFT_FRAME.intValue() then
            base.processKeyAI(Canvas.KEY_NUM0)
        elif frame = angleIncrementInfo.RIGHT_FRAME.intValue() then
            base.processKeyAI(Canvas.KEY_POUND)
    
    abstract reverse : unit -> unit
    default this.reverse() : unit =
        let mutable rotationAnimationInterface : RotationAnimationInterface = (box (this.rotationAnimationInterface) :?> RotationAnimationInterface)
        let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
        let mutable frame : int = this.rotationAnimationInterface.getFrame()
        if frame = angleIncrementInfo.LEFT_FRAME.intValue() then
            let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
            rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.RIGHT_FRAME.intValue())
            this.baseVelocityInterface.zero()
        elif frame = angleIncrementInfo.RIGHT_FRAME.intValue() then
            let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
            rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.LEFT_FRAME.intValue())
            this.baseVelocityInterface.zero()
    
    member this.accelerate() : unit =
        if this.currentSpeedDivisor > 1 then
            this.currentSpeedDivisor <- this.currentSpeedDivisor - 1
    
    member this.drop() : unit =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable y : int = ownerLayerInterface.getYP()
        if (ownerLayerInterface.getY2() + ownerLayerInterface.getHeight()) > displayInfo.getLastHeight() then
            y <- 0
        else
            y <- y + (ownerLayerInterface.getHeight() + 1)
        ownerLayerInterface.setPosition(ownerLayerInterface.getXP(), y, ownerLayerInterface.getZP())
    
    override this.getId() : int =
        ArtificialIntelligence.AI_ID
    interface ArtificialIntelligenceTransitionInterface with
        member this.transition() : unit = this.transition()


