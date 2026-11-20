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
type BaseGameInitialization =
    [<DefaultValue(false)>] val mutable resourceInitializationArray : ResourceInitialization[]
    [<DefaultValue(false)>] val mutable portion : int
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] val mutable EARLY_RESOURCES : int
    [<DefaultValue(false)>] val mutable GAME_RESOURCES : int
    [<DefaultValue(false)>] val mutable EARLY_CHANGABLE_RESOURCES : int
    [<DefaultValue(false)>] val mutable GAME_CHANGABLE_RESOURCES : int
    [<DefaultValue(false)>] val mutable gameInitialized : bool
    [<DefaultValue(false)>] val mutable allLoaded : bool
    [<DefaultValue(false)>] static val mutable private jcell_NULL_BASE_GAME_INITIALIZATION : BaseGameInitialization
    static member NULL_BASE_GAME_INITIALIZATION with get() : BaseGameInitialization = (BaseGameInitialization.jclinit(); BaseGameInitialization.jcell_NULL_BASE_GAME_INITIALIZATION) and set (jvalue: BaseGameInitialization) = (BaseGameInitialization.jclinit(); BaseGameInitialization.jcell_NULL_BASE_GAME_INITIALIZATION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseGameInitialization.jclinitDone then
            BaseGameInitialization.jclinitDone <- true
            BaseGameInitialization.jclinitBody()
    static member private jclinitBody() : unit =
        BaseGameInitialization.jcell_NULL_BASE_GAME_INITIALIZATION <- (new BaseGameInitialization((Array.zeroCreate<ResourceInitialization> (0)), 0))
        ()
    member this.jfields_BaseGameInitialization() : unit =
        this.EARLY_RESOURCES <- 0
        this.GAME_RESOURCES <- 1
        this.EARLY_CHANGABLE_RESOURCES <- 2
        this.GAME_CHANGABLE_RESOURCES <- 3
        ()
    
    new (resourceInitializationArray: ResourceInitialization[], portion: int) as this =
        {  }
        then
            this.jfields_BaseGameInitialization()
            this.jctor1(resourceInitializationArray, portion)
    member this.jctor1(resourceInitializationArray: ResourceInitialization[], portion: int) : unit =
        this.resourceInitializationArray <- resourceInitializationArray
        this.portion <- portion
        ()
    
    abstract initKey : portion: int -> unit
    default this.initKey(portion: int) : unit =
        ()
    
    abstract initKeyMapping : abeClientInformation: AbeClientInformationInterface * portion: int -> unit
    default this.initKeyMapping(abeClientInformation: AbeClientInformationInterface, portion: int) : unit =
        if ChangedGameFeatureListener.getInstance().isChangedFeature(InputFeatureFactory.getInstance().INPUT_MAPPING) then
            PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().init(abeClientInformation)
            ProgressCanvasFactory.getInstance().addNormalPortion(50, "Game Keys")
            ignore (ChangedGameFeatureListener.getInstance().remove(InputFeatureFactory.getInstance().INPUT_MAPPING))
    
    abstract init : abeClientInformation: AbeClientInformationInterface * commandListener: CommandListener * level: int -> unit
    default this.init(abeClientInformation: AbeClientInformationInterface, commandListener: CommandListener, level: int) : unit =
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if (not (this.isInitialized())) && ((level = resourceLoadingLevelFactory.LOAD_ALL.getLevel()) || (level = resourceLoadingLevelFactory.LOAD_EARLY.getLevel())) then
            let mutable localPortion : int = 40
            if level = resourceLoadingLevelFactory.LOAD_EARLY.getLevel() then
                localPortion <- 8
            this.setInitialized(true)
            this.initKey(this.getPortion())
            this.initKeyMapping(abeClientInformation, this.getPortion())
            GameKeyEventFactory.getInstance().init()
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            progressCanvas.addNormalPortion(localPortion, "Game Key Events")
            BasicTouchInputFactory.getInstance().init(PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance().getInputMapping())
            ignore (CancelTouchButtonInputFactory.getInstance())
            progressCanvas.addNormalPortion(localPortion, "Touch Input")
            CompleteMotionGestureInputToGameMotionGestureInput.getInstance().init()
            progressCanvas.addNormalPortion(localPortion, "Motion Input")
            GameFeatureImageCacheFactory.init()
            progressCanvas.addNormalPortion(localPortion, "Image Cache")
            this.resourceInitializationArray.[this.EARLY_RESOURCES].init()
    
    abstract resourceInitialization : level: int -> unit
    default this.resourceInitialization(level: int) : unit =
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if this.resourceAnimationChange() && (level = resourceLoadingLevelFactory.LOAD_EARLY.getLevel()) then
            this.clearResources()
            this.resourceInitializationArray.[this.EARLY_CHANGABLE_RESOURCES].init()
        if this.resourceAnimationChange() && (level = resourceLoadingLevelFactory.LOAD_ALL.getLevel()) then
            if this.allLoaded then
                this.clearResources()
            if FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().getList().size() = 0 then
                this.resourceInitializationArray.[this.EARLY_CHANGABLE_RESOURCES].init()
            this.resourceInitializationArray.[this.GAME_CHANGABLE_RESOURCES].init()
            this.allLoaded <- true
    
    abstract resourceAnimationChange : unit -> bool
    default this.resourceAnimationChange() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable changedGameFeatureListener : ChangedGameFeatureListener = ChangedGameFeatureListener.getInstance()
        let mutable gameConfigurationCentral : GameConfigurationCentral = GameConfigurationCentral.getInstance()
        if changedGameFeatureListener.isChangedGameConfiguration(gameConfigurationCentral.SCALE) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            if ChangedGameFeatureListener.getInstance().isChangedFeature(MainFeatureFactory.getInstance().STATIC) then
                jret <- true
                jflow <- 1
            if jflow = 0 then
                jret <- false
                jflow <- 1
        jret
    
    member this.clearResources() : unit =
        this.allLoaded <- false
        GameFeatureImageCacheFactory.releaseAll()
        let mutable featuredAnimationInterfaceFactoryInterfaceFactory : FeaturedAnimationInterfaceFactoryInterfaceFactory = FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance()
        featuredAnimationInterfaceFactoryInterfaceFactory.clear()
        FeaturedResourceRelativeRelationshipFactory.getInstance().clear()
    
    abstract setGameInitialized : gameInitialized: bool -> unit
    default this.setGameInitialized(gameInitialized: bool) : unit =
        this.gameInitialized <- gameInitialized
    
    abstract isGameInitialized : unit -> bool
    default this.isGameInitialized() : bool =
        this.gameInitialized
    
    abstract getPortion : unit -> int
    default this.getPortion() : int =
        this.portion
    
    abstract setInitialized : initialized: bool -> unit
    default this.setInitialized(initialized: bool) : unit =
        this.initialized <- initialized
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    interface GameInitializationInterface with
        member this.init(jp0: AbeClientInformationInterface, jp1: CommandListener, jp2: int) : unit = this.init(jp0, jp1, jp2)


