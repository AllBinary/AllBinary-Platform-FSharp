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
type UpDownVectorAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable velocityInterface : BasicVelocityProperties
    [<DefaultValue(false)>] val mutable index : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpDownVectorAI.jclinitDone then
            UpDownVectorAI.jclinitDone <- true
            UpDownVectorAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_UpDownVectorAI() : unit =
        this.index <- 0
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_UpDownVectorAI()
            this.jctor1(ownerLayerInterface, gameInput)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> VelocityInterfaceCompositeInterface)
        this.velocityInterface <- velocityInterfaceCompositeInterface.getVelocityProperties()
        this.velocityInterface.getVelocityYBasicDecimalP().setint(0)
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable y : int = this.getOwnerLayerInterface().getHeight() * 270
        if this.index < 5 then
            let mutable basicDecimal : BasicDecimal = this.velocityInterface.getVelocityYBasicDecimalP()
            basicDecimal.setint(0)
            basicDecimal.addint(y)
            this.index <- this.index + 1
        elif this.index < 10 then
            let mutable basicDecimal : BasicDecimal = this.velocityInterface.getVelocityYBasicDecimalP()
            basicDecimal.setint(0)
            basicDecimal.subtractint(y)
            this.index <- this.index + 1
        else
            this.index <- 0
            this.processAI(allBinaryLayerManager)


