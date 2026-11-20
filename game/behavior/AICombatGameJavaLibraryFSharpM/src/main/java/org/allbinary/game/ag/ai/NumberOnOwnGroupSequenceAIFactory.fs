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
type NumberOnOwnGroupSequenceAIFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberOnOwnGroupSequenceAIFactory.jclinitDone then
            NumberOnOwnGroupSequenceAIFactory.jclinitDone <- true
            NumberOnOwnGroupSequenceAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_NumberOnOwnGroupSequenceAIFactory()
    member this.jfields_NumberOnOwnGroupSequenceAIFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    abstract getInstance : hashtable: ABHashtable * artificialIntelligenceInterface: ArtificialIntelligenceInterface[] * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, artificialIntelligenceInterface: ArtificialIntelligenceInterface[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        let mutable jflow = 0
        let mutable jret : ArtificialIntelligenceInterface = Unchecked.defaultof<ArtificialIntelligenceInterface>
        let mutable integerArray : Integer[] = NumberInSameGroupSequence.getInstance().NUMBER_ON_SAME_TEAM_SEQUENCE
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable index : int = 0
        while jflow = 0 && (index < integerArray.Length) do
            let mutable integerCanBeNull : obj = hashtable.get((box (integerArray.[index])))
            if (JR.same(integerCanBeNull, null)) then
                jflow <- 100001
            if jflow = 0 then
                ignore (list_.add(integerCanBeNull))
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append("Total AI Properties: "))
            ignore (stringBuffer.appendint(list_.size()))
            ignore (stringBuffer.append(" == Total AI: "))
            ignore (stringBuffer.appendint(artificialIntelligenceInterface.Length))
            ignore (stringBuffer.append(" + 1"))
            let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
            this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.GET_INSTANCE)
            if (artificialIntelligenceInterface.Length - 1) > list_.size() then
                raise ((new JException("Not enough AI properties.")))
            if (artificialIntelligenceInterface.Length - 1) < list_.size() then
                raise ((new JException("Too Many AI properties.")))
            let mutable numberOnSameTeam : Integer[] = (Array.zeroCreate<Integer> (list_.size()))
            let mutable index : int = 0
            while index < numberOnSameTeam.Length do
                numberOnSameTeam.[index] <- (box (list_.objectArray.[index]) :?> Integer)
                index <- index + 1
            jret <- (new NumberOnOwnGroupSequenceAI(numberOnSameTeam, artificialIntelligenceInterface, ownerLayerInterface, gameInput))
            jflow <- 1
        jret


