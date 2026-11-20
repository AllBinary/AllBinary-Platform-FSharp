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
type ComboSequenceAI =
    inherit SequenceAI
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ComboSequenceAI.jclinitDone then
            ComboSequenceAI.jclinitDone <- true
            ComboSequenceAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) =
        { inherit SequenceAI(artificialIntelligenceInterface, ownerLayerInterface, gameInput) }
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable artificialIntelligenceInterfaceArray : ArtificialIntelligenceInterface[] = this.getArtificialIntelligenceInterface()
        let mutable size : int = artificialIntelligenceInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            this.setIndex(index)
            base.processAI(allBinaryLayerManager)
            index <- index + 1


