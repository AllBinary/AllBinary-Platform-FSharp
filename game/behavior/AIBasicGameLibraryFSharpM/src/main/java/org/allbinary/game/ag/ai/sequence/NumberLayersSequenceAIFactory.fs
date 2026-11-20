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
type NumberLayersSequenceAIFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberLayersSequenceAIFactory.jclinitDone then
            NumberLayersSequenceAIFactory.jclinitDone <- true
            NumberLayersSequenceAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : numberOfEnemiesLeft: int * artificialIntelligenceInterface: ArtificialIntelligenceInterface[] * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(numberOfEnemiesLeft: int, artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        (new NumberLayersSequenceAI(numberOfEnemiesLeft, artificialIntelligenceInterface, ownerLayerInterface, gameInput))


