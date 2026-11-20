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
type GameKeyEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable sourceId : int
    [<DefaultValue(false)>] val mutable repeated : bool
    [<DefaultValue(false)>] val mutable key : int
    [<DefaultValue(false)>] val mutable gameActionKey : int
    [<DefaultValue(false)>] val mutable originalKey : int
    [<DefaultValue(false)>] static val mutable private jcell_NONE : GameKeyEvent
    static member NONE with get() : GameKeyEvent = (GameKeyEvent.jclinit(); GameKeyEvent.jcell_NONE) and set (jvalue: GameKeyEvent) = (GameKeyEvent.jclinit(); GameKeyEvent.jcell_NONE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyEvent.jclinitDone then
            GameKeyEvent.jclinitDone <- true
            GameKeyEvent.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyEvent.jcell_NONE <- (new GameKeyEvent(NullUtil.getInstance().NULL_OBJECT, -1, -1, -1, -1, false))
        ()
    
    static member createEvent(anyType: obj, sourceId: int, key: int) : GameKeyEvent =
        (new GameKeyEvent(anyType, sourceId, 0, 0, key, false))
    
    new (anyType: obj, sourceId: int, originalKey: int, gameActionKey: int, key: int, repeated: bool) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jctor1(anyType, sourceId, originalKey, gameActionKey, key, repeated)
    member this.jctor1(anyType: obj, sourceId: int, originalKey: int, gameActionKey: int, key: int, repeated: bool) : unit =
        ()
        this.sourceId <- sourceId
        this.setOriginalKey(originalKey)
        this.key <- key
        this.setGameActionKey(gameActionKey)
        this.setRepeatEvents(repeated)
        ()
    
    abstract init : anyType: obj -> unit
    default this.init(anyType: obj) : unit =
        this.setSource(anyType)
    
    member this.setRepeatEvents(repeated: bool) : unit =
        this.repeated <- repeated
    
    abstract hasRepeatEvents : unit -> bool
    default this.hasRepeatEvents() : bool =
        this.repeated
    
    abstract getKey : unit -> int
    default this.getKey() : int =
        this.key
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("\nKey: "))
        ignore (stringBuffer.appendint(this.getKey()))
        stringBuffer.ToString()
    
    abstract getOriginalKey : unit -> int
    default this.getOriginalKey() : int =
        this.originalKey
    
    abstract setOriginalKey : originalKey: int -> unit
    default this.setOriginalKey(originalKey: int) : unit =
        this.originalKey <- originalKey
    
    abstract getGameActionKey : unit -> int
    default this.getGameActionKey() : int =
        this.gameActionKey
    
    abstract setGameActionKey : gameActionKey: int -> unit
    default this.setGameActionKey(gameActionKey: int) : unit =
        this.gameActionKey <- gameActionKey
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        this.sourceId


