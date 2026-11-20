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
type OnDemandLoader =
    [<DefaultValue(false)>] val mutable onDemandResourcesFactory : OnDemandResourcesFactory
    [<DefaultValue(false)>] val mutable gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory : GameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory
    [<DefaultValue(false)>] val mutable resourceAnimationInterfaceFactoryInterfaceFactory : BaseResourceAnimationInterfaceFactoryInterfaceFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OnDemandLoader.jclinitDone then
            OnDemandLoader.jclinitDone <- true
            OnDemandLoader.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (onDemandResourcesFactory: OnDemandResourcesFactory, gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory: GameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory, resourceAnimationInterfaceFactoryInterfaceFactory: BaseResourceAnimationInterfaceFactoryInterfaceFactory) as this =
        {  }
        then
            this.jctor1(onDemandResourcesFactory, gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory, resourceAnimationInterfaceFactoryInterfaceFactory)
    member this.jctor1(onDemandResourcesFactory: OnDemandResourcesFactory, gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory: GameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory, resourceAnimationInterfaceFactoryInterfaceFactory: BaseResourceAnimationInterfaceFactoryInterfaceFactory) : unit =
        this.onDemandResourcesFactory <- onDemandResourcesFactory
        this.gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory <- gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory
        this.resourceAnimationInterfaceFactoryInterfaceFactory <- resourceAnimationInterfaceFactoryInterfaceFactory
        ()
    
    abstract init : imageCache: ImageCache * level: int * loadingString: string -> unit
    default this.init(imageCache: ImageCache, level: int, loadingString: string) : unit =
        let mutable jflow = 0
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if Features.getInstance().isFeature(MainFeatureFactory.getInstance().LOAD_ALL) then
            if this.resourceAnimationInterfaceFactoryInterfaceFactory.isInitialized() then
                jflow <- 1
            if jflow = 0 then
                this.initAll(imageCache, loadingString)
        elif level <> resourceLoadingLevelFactory.LOAD_ALL.getLevel() then
            let mutable layerPlacementInterfaceBasicArrayListFactoryInterface : LayerPlacementInterfaceBasicArrayListFactoryInterface = this.gameLayerPlacementInterfaceBasicArrayListFactoryInterfaceFactory.getInstance(level)
            this.initLevel(layerPlacementInterfaceBasicArrayListFactoryInterface, imageCache, level, loadingString)
    
    member this.initAll(imageCache: ImageCache, loadingString: string) : unit =
        let mutable index : int = 0
        let mutable portion : int = 120
        let mutable onDemandResources : OnDemandResources = null
        let mutable onDemandIndex : int = this.onDemandResourcesFactory.size()
        while ((onDemandIndex <- onDemandIndex - 1; onDemandIndex)) >= 0 do
            onDemandResources <- this.onDemandResourcesFactory.remove(onDemandIndex)
            if not (JR.same(onDemandResources, OnDemandResources.NULL_ON_DEMAND_RESOURCES)) then
                index <- onDemandResources.initAt(imageCache, this.resourceAnimationInterfaceFactoryInterfaceFactory, portion, loadingString, index)
    
    member this.initLevel(layerPlacementInterfaceBasicArrayListFactoryInterface: LayerPlacementInterfaceBasicArrayListFactoryInterface, imageCache: ImageCache, level: int, loadingString: string) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable portion : int = 120
        let mutable index : int = 0
        let mutable onDemandArray : int[] = layerPlacementInterfaceBasicArrayListFactoryInterface.getOnDemandResources()
        PreLogUtil.put((new StringMaker()).append(commonStrings.START).appendint(onDemandArray.Length).ToString(), this, "initLevel")
        let mutable onDemandResources : OnDemandResources = null
        let mutable onDemandIndex : int = onDemandArray.Length
        while ((onDemandIndex <- onDemandIndex - 1; onDemandIndex)) >= 0 do
            onDemandResources <- this.onDemandResourcesFactory.remove(onDemandArray.[onDemandIndex])
            if not (JR.same(onDemandResources, OnDemandResources.NULL_ON_DEMAND_RESOURCES)) then
                index <- onDemandResources.initAt(imageCache, this.resourceAnimationInterfaceFactoryInterfaceFactory, portion, loadingString, index)


