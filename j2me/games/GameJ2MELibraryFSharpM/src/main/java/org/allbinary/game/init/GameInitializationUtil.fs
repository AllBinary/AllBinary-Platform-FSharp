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
type GameInitializationUtil =
    [<DefaultValue(false)>] val mutable EVENT : GameInitializedEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameInitializationUtil
    static member instance with get() : GameInitializationUtil = (GameInitializationUtil.jclinit(); GameInitializationUtil.jcell_instance) and set (jvalue: GameInitializationUtil) = (GameInitializationUtil.jclinit(); GameInitializationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInitializationUtil.jclinitDone then
            GameInitializationUtil.jclinitDone <- true
            GameInitializationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameInitializationUtil.jcell_instance <- (new GameInitializationUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameInitializationUtil()
    member this.jfields_GameInitializationUtil() : unit =
        this.EVENT <- (new GameInitializedEvent(this))
        ()
    
    member this.initDemo(abeClientInformation: AbeClientInformationInterface, canvas: MyCanvas, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory) : unit =
        let mutable mainFeatureFactory : MainFeatureFactory = MainFeatureFactory.getInstance()
        if ChangedGameFeatureListener.getInstance().isChangedFeature(mainFeatureFactory.STATIC) then
            let mutable gameInitializationInterface : GameInitializationInterface = gameInitializationInterfaceFactoryInterface.getInstance()
            let mutable features : Features = Features.getInstance()
            if features.isFeature(mainFeatureFactory.LOAD_ALL) then
                this.initGame(abeClientInformation, canvas, gameInitializationInterfaceFactoryInterface)
            elif features.isFeature(mainFeatureFactory.LOAD_ONDEMAND) then
                let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
                gameInitializationInterface.init(abeClientInformation, canvas.getCustomCommandListener(), resourceLoadingLevelFactory.LOAD_EARLY.getLevel())
                this.EVENT.setResourceLoadingLevel(resourceLoadingLevelFactory.LOAD_EARLY)
            else
                raise ((new JException("No Loading Feature Available")))
            GameInitializedEventHandler.getInstance().fireEvent(this.EVENT)
    
    member this.initGame(abeClientInformation: AbeClientInformationInterface, canvas: MyCanvas, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory) : unit =
        if ChangedGameFeatureListener.getInstance().isChangedFeature(MainFeatureFactory.getInstance().STATIC) then
            let mutable gameInitializationInterface : GameInitializationInterface = gameInitializationInterfaceFactoryInterface.getInstance()
            let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
            gameInitializationInterface.init(abeClientInformation, canvas.getCustomCommandListener(), resourceLoadingLevelFactory.LOAD_ALL.getLevel())
            this.EVENT.setResourceLoadingLevel(resourceLoadingLevelFactory.LOAD_ALL)
            GameInitializedEventHandler.getInstance().fireEvent(this.EVENT)
            ignore (ChangedGameFeatureListener.getInstance().remove(MainFeatureFactory.getInstance().STATIC))
    
    static member getInstance() : GameInitializationUtil =
        GameInitializationUtil.instance


