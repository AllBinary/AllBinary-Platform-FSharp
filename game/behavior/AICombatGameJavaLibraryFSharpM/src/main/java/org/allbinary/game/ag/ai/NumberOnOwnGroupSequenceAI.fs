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
type NumberOnOwnGroupSequenceAI =
    inherit SequenceAI
    [<DefaultValue(false)>] val mutable numberOnSameTeam : Integer[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberOnOwnGroupSequenceAI.jclinitDone then
            NumberOnOwnGroupSequenceAI.jclinitDone <- true
            NumberOnOwnGroupSequenceAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (numberOnSameTeam: Integer[], artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit SequenceAI(artificialIntelligenceInterface, ownerLayerInterface, gameInput) }
        then
            this.jctor1(numberOnSameTeam, artificialIntelligenceInterface, ownerLayerInterface, gameInput)
    member this.jctor1(numberOnSameTeam: Integer[], artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.numberOnSameTeam <- numberOnSameTeam
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable layerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable index : int = this.getIndex()
        if this.numberOnSameTeam.Length > index then
            let mutable size : int = GroupLayerManagerListener.getInstance().getGroupSizeFromInterface(layerInterface)
            if this.numberOnSameTeam.[index].intValue() > size then
                this.next()
        base.processAI(allBinaryLayerManager)


