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
type SequenceAI =
    inherit ArrayAI
    [<DefaultValue(false)>] val mutable index : int
    static member SEQUENCE_AI : string = "Sequence AI"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SequenceAI.jclinitDone then
            SequenceAI.jclinitDone <- true
            SequenceAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (artificialIntelligenceInterfaceArray: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) =
        { inherit ArrayAI(artificialIntelligenceInterfaceArray, ownerLayerInterface, gameInput) }
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        this.getArtificialIntelligenceInterface().[this.index].processAI(allBinaryLayerManager)
    
    abstract next : unit -> unit
    default this.next() : unit =
        this.index <- this.index + 1
        let mutable artificialIntelligenceInterface : ArtificialIntelligenceInterface = this.getSelectedArtificialIntelligenceInterface()
        if artificialIntelligenceInterface.getId() = ArtificialIntelligence.AI_ID then
            let mutable artificialIntelligenceTransitionInterface : ArtificialIntelligenceTransitionInterface = (box (artificialIntelligenceInterface) :?> ArtificialIntelligenceTransitionInterface)
            artificialIntelligenceTransitionInterface.transition()
    
    abstract getIndex : unit -> int
    default this.getIndex() : int =
        this.index
    
    abstract setIndex : index: int -> unit
    default this.setIndex(index: int) : unit =
        this.index <- index
    
    abstract getSelectedArtificialIntelligenceInterface : unit -> ArtificialIntelligenceInterface
    default this.getSelectedArtificialIntelligenceInterface() : ArtificialIntelligenceInterface =
        this.getArtificialIntelligenceInterface().[this.index]
    
    override this.getName() : string =
        SequenceAI.SEQUENCE_AI
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(base.ToString()))
        ignore (stringBuffer.append(" Selected AI: "))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.getSelectedArtificialIntelligenceInterface())))
        stringBuffer.ToString()


