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
type ArtificialIntelligence =
    static member AI_ID : int = 2
    [<DefaultValue(false)>] static val mutable private jcell_instance : ArtificialIntelligence
    static member instance with get() : ArtificialIntelligence = (ArtificialIntelligence.jclinit(); ArtificialIntelligence.jcell_instance) and set (jvalue: ArtificialIntelligence) = (ArtificialIntelligence.jclinit(); ArtificialIntelligence.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArtificialIntelligence.jclinitDone then
            ArtificialIntelligence.jclinitDone <- true
            ArtificialIntelligence.jclinitBody()
    static member private jclinitBody() : unit =
        ArtificialIntelligence.jcell_instance <- (new ArtificialIntelligence())
        ()
    
    static member getInstance() : ArtificialIntelligence =
        ArtificialIntelligence.instance
    
    new () =
        {  }
    
    abstract processAI : layerManager: AllBinaryLayerManager -> unit
    default this.processAI(layerManager: AllBinaryLayerManager) : unit =
        ()
    
    abstract getId : unit -> int
    default this.getId() : int =
        1
    interface ArtificialIntelligenceInterface with
        member this.processAI(jp0: AllBinaryLayerManager) : unit = this.processAI(jp0)
    interface IdentifierInterface with
        member this.getId() : int = this.getId()


