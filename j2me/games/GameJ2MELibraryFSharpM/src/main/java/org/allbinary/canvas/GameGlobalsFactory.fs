namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type GameGlobalsFactory =
    [<DefaultValue(false)>] val mutable newCanvas : bool
    [<DefaultValue(false)>] val mutable newDisplaybleTime : int64
    [<DefaultValue(false)>] val mutable point : GPoint
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameGlobalsFactory
    static member instance with get() : GameGlobalsFactory = (GameGlobalsFactory.jclinit(); GameGlobalsFactory.jcell_instance) and set (jvalue: GameGlobalsFactory) = (GameGlobalsFactory.jclinit(); GameGlobalsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameGlobalsFactory.jclinitDone then
            GameGlobalsFactory.jclinitDone <- true
            GameGlobalsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameGlobalsFactory.jcell_instance <- (new GameGlobalsFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameGlobalsFactory()
    member this.jfields_GameGlobalsFactory() : unit =
        this.newCanvas <- true
        this.newDisplaybleTime <- int64 (Integer.MIN_VALUE)
        this.point <- PointFactory.getInstance().ZERO_ZERO
        ()
    
    static member getInstance() : GameGlobalsFactory =
        GameGlobalsFactory.instance


