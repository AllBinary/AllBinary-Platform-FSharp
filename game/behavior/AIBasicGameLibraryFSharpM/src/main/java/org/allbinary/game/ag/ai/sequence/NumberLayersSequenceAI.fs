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
type NumberLayersSequenceAI =
    inherit SequenceAI
    [<DefaultValue(false)>] val mutable numberOfLayersLeft : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberLayersSequenceAI.jclinitDone then
            NumberLayersSequenceAI.jclinitDone <- true
            NumberLayersSequenceAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (numberOfEnemiesLeft: int, artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit SequenceAI(artificialIntelligenceInterface, ownerLayerInterface, gameInput) }
        then
            this.jctor1(numberOfEnemiesLeft, artificialIntelligenceInterface, ownerLayerInterface, gameInput)
    member this.jctor1(numberOfEnemiesLeft: int, artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.numberOfLayersLeft <- numberOfEnemiesLeft
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.getIndex() = 0 then
            if allBinaryLayerManager.getSize() < this.numberOfLayersLeft then
                this.setIndex(1)
        base.processAI(allBinaryLayerManager)


