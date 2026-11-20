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
type ArrayAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable artificialIntelligenceInterfaceArray : ArtificialIntelligenceInterface[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArrayAI.jclinitDone then
            ArrayAI.jclinitDone <- true
            ArrayAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jctor1(artificialIntelligenceInterface, ownerLayerInterface, gameInput)
    member this.jctor1(artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.artificialIntelligenceInterfaceArray <- artificialIntelligenceInterface
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable size : int = this.artificialIntelligenceInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            this.artificialIntelligenceInterfaceArray.[index].processAI(allBinaryLayerManager)
            index <- index + 1
    
    abstract getArtificialIntelligenceInterface : unit -> ArtificialIntelligenceInterface[]
    default this.getArtificialIntelligenceInterface() : ArtificialIntelligenceInterface[] =
        this.artificialIntelligenceInterfaceArray


