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
type RandomPatrolFlockingFiringAIFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RandomPatrolFlockingFiringAIFactory.jclinitDone then
            RandomPatrolFlockingFiringAIFactory.jclinitDone <- true
            RandomPatrolFlockingFiringAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : hashtable: ABHashtable * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        let mutable artificialIntelligenceInterface : ArtificialIntelligenceInterface[] = (Array.zeroCreate<ArtificialIntelligenceInterface> (2))
        artificialIntelligenceInterface.[0] <- (new RandomPatrolAI(hashtable, ownerLayerInterface, gameInput))
        artificialIntelligenceInterface.[1] <- (new TimedFireAI(1800, ownerLayerInterface, gameInput))
        (new ArrayAI(artificialIntelligenceInterface, ownerLayerInterface, gameInput))
    interface ArtificialIntelligenceInterfaceFactoryInterface with
        member this.getInstance(jp0: ABHashtable, jp1: AllBinaryLayer, jp2: GameInput) : ArtificialIntelligenceInterface = this.getInstance(jp0, jp1, jp2)


