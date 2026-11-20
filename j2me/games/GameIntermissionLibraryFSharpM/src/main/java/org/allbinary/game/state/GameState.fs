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
type GameState =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameState.jclinitDone then
            GameState.jclinitDone <- true
            GameState.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, state: int) as this =
        {  }
        then
            this.jctor1(name, state)
    member this.jctor1(name: string, state: int) : unit =
        this.name <- name
        ()
    
    override this.ToString() : string =
        this.name


