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
type NullAIFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_AI : NullAI
    static member NULL_AI with get() : NullAI = (NullAIFactory.jclinit(); NullAIFactory.jcell_NULL_AI) and set (jvalue: NullAI) = (NullAIFactory.jclinit(); NullAIFactory.jcell_NULL_AI <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullAIFactory.jclinitDone then
            NullAIFactory.jclinitDone <- true
            NullAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullAIFactory.jcell_NULL_AI <- (new NullAI())
        ()
    new () =
        {  }
    
    abstract getInstance : hashtable: ABHashtable * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        NullAIFactory.NULL_AI
    
    static member getInstance_jstatic() : ArtificialIntelligenceInterface =
        NullAIFactory.NULL_AI
    interface ArtificialIntelligenceInterfaceFactoryInterface with
        member this.getInstance(jp0: ABHashtable, jp1: AllBinaryLayer, jp2: GameInput) : ArtificialIntelligenceInterface = this.getInstance(jp0, jp1, jp2)


