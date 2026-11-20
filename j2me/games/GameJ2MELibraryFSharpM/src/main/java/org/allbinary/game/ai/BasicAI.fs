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
type BasicAI =
    inherit ArtificialIntelligence
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable ownerLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable gameInput : GameInput
    [<DefaultValue(false)>] val mutable lastKey : int
    [<DefaultValue(false)>] static val mutable private jcell_AI_VISITOR : Integer
    static member AI_VISITOR with get() : Integer = (BasicAI.jclinit(); BasicAI.jcell_AI_VISITOR) and set (jvalue: Integer) = (BasicAI.jclinit(); BasicAI.jcell_AI_VISITOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_ID : Integer
    static member ID with get() : Integer = (BasicAI.jclinit(); BasicAI.jcell_ID) and set (jvalue: Integer) = (BasicAI.jclinit(); BasicAI.jcell_ID <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicAI.jclinitDone then
            BasicAI.jclinitDone <- true
            BasicAI.jclinitBody()
    static member private jclinitBody() : unit =
        BasicAI.jcell_AI_VISITOR <- SmallIntegerSingletonFactory.getInstance().getAt(2)
        BasicAI.jcell_ID <- SmallIntegerSingletonFactory.getInstance().getAt(1)
        ()
    member this.jfields_BasicAI() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.lastKey <- -1
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit ArtificialIntelligence() }
        then
            this.jfields_BasicAI()
            this.jctor1(ownerLayerInterface, gameInput)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        this.ownerLayerInterface <- ownerLayerInterface
        this.gameInput <- gameInput
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract processKeyAI : key: int -> unit
    default this.processKeyAI(key: int) : unit =
        if key <> (-1) then
            ignore (this.gameInput.add(this.gameKeyEventFactory.getInstanceForKey(this, key)))
    
    abstract setLastKey : lastKey: int -> unit
    default this.setLastKey(lastKey: int) : unit =
        this.lastKey <- lastKey
    
    abstract getLastKey : unit -> int
    default this.getLastKey() : int =
        this.lastKey
    
    abstract getOwnerLayerInterface : unit -> AllBinaryLayer
    default this.getOwnerLayerInterface() : AllBinaryLayer =
        this.ownerLayerInterface
    
    abstract getGameInput : unit -> GameInput
    default this.getGameInput() : GameInput =
        this.gameInput
    
    abstract getName : unit -> string
    default this.getName() : string =
        JR.getClass(this)
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(CommonSeps.getInstance().NEW_LINE))
        ignore (stringBuffer.append(this.getName()))
        ignore (stringBuffer.append(" LastKey: "))
        ignore (stringBuffer.append(CanvasUtil.getKeyName(this.getLastKey())))
        stringBuffer.ToString()
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        1
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()


