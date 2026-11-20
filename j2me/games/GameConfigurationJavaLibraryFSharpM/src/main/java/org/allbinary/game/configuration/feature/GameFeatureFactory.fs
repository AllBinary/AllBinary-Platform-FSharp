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
type GameFeatureFactory =
    [<DefaultValue(false)>] val mutable SOUND : GameFeature
    [<DefaultValue(false)>] val mutable MUSIC : GameFeature
    [<DefaultValue(false)>] val mutable SCREEN_SHAKE : Feature
    [<DefaultValue(false)>] val mutable POST_IMAGE_LOADING_MODIFICATION : Feature
    [<DefaultValue(false)>] val mutable HEALTH_BARS : GameFeature
    [<DefaultValue(false)>] val mutable DAMAGE_FLOATERS : GameFeature
    [<DefaultValue(false)>] val mutable GAME_INPUT_LAYER_PROCESSOR : GameFeature
    [<DefaultValue(false)>] val mutable ARTIFICIAL_INTELLEGENCE_PROCESSOR : GameFeature
    [<DefaultValue(false)>] val mutable COLLIDABLE_INTERFACE_LAYER_PROCESSOR : GameFeature
    [<DefaultValue(false)>] val mutable TICKABLE_LAYER_PROCESSOR : GameFeature
    [<DefaultValue(false)>] val mutable CHEATING : GameFeature
    [<DefaultValue(false)>] val mutable DROPPED_ITEMS : GameFeature
    [<DefaultValue(false)>] val mutable DROPPED_ITEMS_FROM_DEATH : GameFeature
    [<DefaultValue(false)>] val mutable TEST_DESTROYED_LAYER_PROCESSOR : GameFeature
    [<DefaultValue(false)>] val mutable COLLISIONS_WITH_SOURCE : GameFeature
    [<DefaultValue(false)>] val mutable COLLISIONS_FORCED_TWO_DIMENSIONAL : GameFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameFeatureFactory
    static member instance with get() : GameFeatureFactory = (GameFeatureFactory.jclinit(); GameFeatureFactory.jcell_instance) and set (jvalue: GameFeatureFactory) = (GameFeatureFactory.jclinit(); GameFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureFactory.jclinitDone then
            GameFeatureFactory.jclinitDone <- true
            GameFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureFactory.jcell_instance <- (new GameFeatureFactory())
        ()
    member this.jfields_GameFeatureFactory() : unit =
        this.SOUND <- (new GameFeature("Sound"))
        this.MUSIC <- (new GameFeature("Music"))
        this.SCREEN_SHAKE <- (new Feature("Screen Shake"))
        this.POST_IMAGE_LOADING_MODIFICATION <- (new Feature("Post Image Loading Modification (Scaling, Rotation, or Other)"))
        this.HEALTH_BARS <- (new GameFeature("Health Bars"))
        this.DAMAGE_FLOATERS <- (new GameFeature("Damage Floaters"))
        this.GAME_INPUT_LAYER_PROCESSOR <- (new GameFeature("Game Input Layer Processor"))
        this.ARTIFICIAL_INTELLEGENCE_PROCESSOR <- (new GameFeature("Artificial Intelligence Layer Processor"))
        this.COLLIDABLE_INTERFACE_LAYER_PROCESSOR <- (new GameFeature("Collidable Interface Layer Processor"))
        this.TICKABLE_LAYER_PROCESSOR <- (new GameFeature("Tickable Layer Processor"))
        this.CHEATING <- (new GameFeature("Cheating"))
        this.DROPPED_ITEMS <- (new GameFeature("Drops"))
        this.DROPPED_ITEMS_FROM_DEATH <- (new GameFeature("Drops from Dead"))
        this.TEST_DESTROYED_LAYER_PROCESSOR <- (new GameFeature("Destroyed Layer Processor"))
        this.COLLISIONS_WITH_SOURCE <- (new GameFeature("Allow Collisions With Source"))
        this.COLLISIONS_FORCED_TWO_DIMENSIONAL <- (new GameFeature("Collisions Forced Two Dimensional"))
        ()
    
    static member getInstance() : GameFeatureFactory =
        GameFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_GameFeatureFactory()


