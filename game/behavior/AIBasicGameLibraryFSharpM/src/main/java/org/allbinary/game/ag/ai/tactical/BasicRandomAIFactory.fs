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
type BasicRandomAIFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicRandomAIFactory.jclinitDone then
            BasicRandomAIFactory.jclinitDone <- true
            BasicRandomAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : hashtable: ABHashtable * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        let mutable visitor : Visitor = (box (hashtable.get((box (BasicAI.AI_VISITOR)))) :?> Visitor)
        if (JR.same(visitor, null)) then
            raise ((new JException("No Visitor Provided")))
        let mutable inputProbability : InputProbability = (box (hashtable.get((box (InputProbability.INPUT_PROBABILITY)))) :?> InputProbability)
        (new BasicRandomAI(ownerLayerInterface, gameInput, inputProbability, visitor))
    interface ArtificialIntelligenceInterfaceFactoryInterface with
        member this.getInstance(jp0: ABHashtable, jp1: AllBinaryLayer, jp2: GameInput) : ArtificialIntelligenceInterface = this.getInstance(jp0, jp1, jp2)


