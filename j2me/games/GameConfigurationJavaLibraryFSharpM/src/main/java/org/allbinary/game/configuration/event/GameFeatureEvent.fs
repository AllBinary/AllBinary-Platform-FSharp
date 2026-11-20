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
type GameFeatureEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable whatChanged : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureEvent.jclinitDone then
            GameFeatureEvent.jclinitDone <- true
            GameFeatureEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (anyType: obj, whatChanged: string) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jctor1(anyType, whatChanged)
    member this.jctor1(anyType: obj, whatChanged: string) : unit =
        ()
        this.whatChanged <- whatChanged
        ()
    
    abstract getWhatChanged : unit -> string
    default this.getWhatChanged() : string =
        this.whatChanged
    
    abstract getGameOption : unit -> obj
    default this.getGameOption() : obj =
        this.getSource()


