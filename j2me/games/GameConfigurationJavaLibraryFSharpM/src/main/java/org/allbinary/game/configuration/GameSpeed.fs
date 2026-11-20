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
type GameSpeed =
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameSpeed
    static member instance with get() : GameSpeed = (GameSpeed.jclinit(); GameSpeed.jcell_instance) and set (jvalue: GameSpeed) = (GameSpeed.jclinit(); GameSpeed.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameSpeed.jclinitDone then
            GameSpeed.jclinitDone <- true
            GameSpeed.jclinitBody()
    static member private jclinitBody() : unit =
        GameSpeed.jcell_instance <- (new GameSpeed())
        ()
    new () =
        {  }
    
    member this.getSpeed() : int =
        let mutable speedGameConfiguration : GameConfiguration = GameConfigurationCentral.getInstance().SPEED
        ((speedGameConfiguration.getMaxValue().intValue() - speedGameConfiguration.getValue().intValue()) + 1)
    
    member this.getDelay() : int =
        let mutable speedGameConfiguration : GameConfiguration = GameConfigurationCentral.getInstance().SPEED
        19 * (speedGameConfiguration.getMaxValue().intValue() - speedGameConfiguration.getValue().intValue())
    
    static member getInstance() : GameSpeed =
        GameSpeed.instance


