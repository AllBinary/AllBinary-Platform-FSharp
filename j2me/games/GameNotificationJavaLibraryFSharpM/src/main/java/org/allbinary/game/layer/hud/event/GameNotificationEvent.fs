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
type GameNotificationEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable string : string
    [<DefaultValue(false)>] val mutable seconds : Integer
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable removeable : Boolean
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameNotificationEvent.jclinitDone then
            GameNotificationEvent.jclinitDone <- true
            GameNotificationEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameNotificationEvent() : unit =
        this.string <- StringUtil.getInstance().EMPTY_STRING
        this.basicColor <- BasicColorFactory.getInstance().BLACK
        ()
    
    new (anyType: obj, string_: string, seconds: Integer, basicColor: BasicColor, permanent: Boolean) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jfields_GameNotificationEvent()
            this.jctor1(anyType, string_, seconds, basicColor, permanent)
    member this.jctor1(anyType: obj, string_: string, seconds: Integer, basicColor: BasicColor, permanent: Boolean) : unit =
        ()
        this.setString(string_)
        this.seconds <- seconds
        this.setBasicColorP(basicColor)
        this.removeable <- permanent
        ()
    
    abstract getString : unit -> string
    default this.getString() : string =
        this.string
    
    abstract getSeconds : unit -> Integer
    default this.getSeconds() : Integer =
        this.seconds
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract getPermanent : unit -> Boolean
    default this.getPermanent() : Boolean =
        this.removeable
    
    abstract setString : string_: string -> unit
    default this.setString(string_: string) : unit =
        this.string <- string_
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor


