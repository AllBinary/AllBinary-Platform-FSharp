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
type KeyPressesAIFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyPressesAIFactory.jclinitDone then
            KeyPressesAIFactory.jclinitDone <- true
            KeyPressesAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : hashtable: ABHashtable * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        let mutable jflow = 0
        let mutable jret : ArtificialIntelligenceInterface = Unchecked.defaultof<ArtificialIntelligenceInterface>
        let mutable isSingleKeyProcessing : bool = InputFeatureFactory.getInstance().isSingleKeyProcessing()
        if isSingleKeyProcessing then
            jret <- (new KeyPressesAI(hashtable, ownerLayerInterface, gameInput))
            jflow <- 1
        else
            jret <- (new MultiKeyPressesAI(hashtable, ownerLayerInterface, gameInput))
            jflow <- 1
        jret
    interface ArtificialIntelligenceInterfaceFactoryInterface with
        member this.getInstance(jp0: ABHashtable, jp1: AllBinaryLayer, jp2: GameInput) : ArtificialIntelligenceInterface = this.getInstance(jp0, jp1, jp2)


