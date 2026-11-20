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
type ChangedGameFeatureListener =
    inherit BaseChangedGameFeatureListener
    [<DefaultValue(false)>] static val mutable private jcell_gameFeatureListener : ChangedGameFeatureListener
    static member gameFeatureListener with get() : ChangedGameFeatureListener = (ChangedGameFeatureListener.jclinit(); ChangedGameFeatureListener.jcell_gameFeatureListener) and set (jvalue: ChangedGameFeatureListener) = (ChangedGameFeatureListener.jclinit(); ChangedGameFeatureListener.jcell_gameFeatureListener <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ChangedGameFeatureListener.jclinitDone then
            ChangedGameFeatureListener.jclinitDone <- true
            ChangedGameFeatureListener.jclinitBody()
    static member private jclinitBody() : unit =
        ChangedGameFeatureListener.jcell_gameFeatureListener <- (new ChangedGameFeatureListener())
        ()
    new () =
        { inherit BaseChangedGameFeatureListener() }
    
    static member getInstance() : ChangedGameFeatureListener =
        ChangedGameFeatureListener.gameFeatureListener
    
    abstract isChangedGameConfiguration : gameConfiguration: GameConfiguration -> bool
    default this.isChangedGameConfiguration(gameConfiguration: GameConfiguration) : bool =
        this.list.contains(gameConfiguration)


