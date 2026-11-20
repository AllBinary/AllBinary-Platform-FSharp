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
type HighScore =
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable gameInfo : GameInfo
    [<DefaultValue(false)>] val mutable score : int64
    [<DefaultValue(false)>] val mutable scoreString : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScore.jclinitDone then
            HighScore.jclinitDone <- true
            HighScore.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (id_: int, name: string, gameInfo: GameInfo, score: int64) as this =
        {  }
        then
            this.jctor1(id_, name, gameInfo, score)
    member this.jctor1(id_: int, name: string, gameInfo: GameInfo, score: int64) : unit =
        this.id <- id_
        this.name <- name
        this.gameInfo <- gameInfo
        this.score <- score
        this.scoreString <- Long.toString(this.score)
        ()
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getScore : unit -> int64
    default this.getScore() : int64 =
        this.score
    
    abstract getAsBytes : unit -> sbyte[]
    default this.getAsBytes() : sbyte[] =
        let mutable byteArrayOutputStream : ByteArrayOutputStream = (new ByteArrayOutputStream())
        let mutable outputStream : DataOutputStream = (new DataOutputStream(byteArrayOutputStream))
        ignore (outputStream.writeUTF(this.getName()))
        ignore (outputStream.writeLong(this.getScore()))
        byteArrayOutputStream.toByteArray()
    
    abstract getGameInfo : unit -> GameInfo
    default this.getGameInfo() : GameInfo =
        this.gameInfo
    
    abstract getScoreString : unit -> string
    default this.getScoreString() : string =
        this.scoreString
    
    abstract setName : name: string -> unit
    default this.setName(name: string) : unit =
        this.name <- name
    
    override this.ToString() : string =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        (new StringMaker()).append(this.name).append(commonSeps.COLON).appendlong(this.score).append(commonSeps.FORWARD_SLASH).append(this.scoreString).ToString()


