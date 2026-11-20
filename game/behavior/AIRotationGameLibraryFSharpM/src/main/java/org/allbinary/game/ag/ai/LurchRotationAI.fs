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
type LurchRotationAI =
    inherit LurchAI
    [<DefaultValue(false)>] val mutable rotationAnimationInterface : IndexedAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LurchRotationAI.jclinitDone then
            LurchRotationAI.jclinitDone <- true
            LurchRotationAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit LurchAI(ownerLayerInterface, gameInput) }
        then
            this.jctor1(ownerLayerInterface, gameInput)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
        this.rotationAnimationInterface <- rotationAnimationInterfaceCompositeInterface.getRotationAnimationInterface()
        this.update()
        ()
    
    override this.reverse() : unit =
        base.reverse()
        this.update()
    
    member this.update() : unit =
        if this.currentRelativeAngle = 0 then
            let mutable rotationAnimationInterface : RotationAnimationInterface = (box (this.rotationAnimationInterface) :?> RotationAnimationInterface)
            let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
            let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
            rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.RIGHT_FRAME.intValue())
        elif this.currentRelativeAngle = 180 then
            let mutable rotationAnimationInterface : RotationAnimationInterface = (box (this.rotationAnimationInterface) :?> RotationAnimationInterface)
            let mutable angleIncrementInfo : AngleIncrementInfo = rotationAnimationInterface.getAngleInfoP().getAngleIncrementInfo()
            let mutable rotationAnimationInterfaceCompositeInterface : RotationAnimationInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> RotationAnimationInterfaceCompositeInterface)
            rotationAnimationInterfaceCompositeInterface.setFrame(angleIncrementInfo.LEFT_FRAME.intValue())


