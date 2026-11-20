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
type FeaturedResourceRelativeRelationshipFactory =
    inherit FeaturedResourceFactory
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] static val mutable private jcell_INSTANCE : FeaturedResourceRelativeRelationshipFactory
    static member INSTANCE with get() : FeaturedResourceRelativeRelationshipFactory = (FeaturedResourceRelativeRelationshipFactory.jclinit(); FeaturedResourceRelativeRelationshipFactory.jcell_INSTANCE) and set (jvalue: FeaturedResourceRelativeRelationshipFactory) = (FeaturedResourceRelativeRelationshipFactory.jclinit(); FeaturedResourceRelativeRelationshipFactory.jcell_INSTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FeaturedResourceRelativeRelationshipFactory.jclinitDone then
            FeaturedResourceRelativeRelationshipFactory.jclinitDone <- true
            FeaturedResourceRelativeRelationshipFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FeaturedResourceRelativeRelationshipFactory.jcell_INSTANCE <- (new FeaturedResourceRelativeRelationshipFactory())
        ()
    member this.jfields_FeaturedResourceRelativeRelationshipFactory() : unit =
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        ()
    
    new () as this =
        { inherit FeaturedResourceFactory() }
        then
            this.jfields_FeaturedResourceRelativeRelationshipFactory()
    
    static member getInstance() : FeaturedResourceRelativeRelationshipFactory =
        FeaturedResourceRelativeRelationshipFactory.INSTANCE
    
    abstract getRelativeRelationshipList : resource: string * layer: AllBinaryLayer -> BasicArrayList
    default this.getRelativeRelationshipList(resource: string, layer: AllBinaryLayer) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable featureReleaseList : BasicArrayList = this.getList()
        let mutable size : int = this.getList().size()
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            let mutable featureInterface : ResourceRelativeRelationshipFactoryInterface = (box (featureReleaseList.objectArray.[index]) :?> ResourceRelativeRelationshipFactoryInterface)
            if featureInterface.isFeature() then
                let mutable list_ : BasicArrayList = featureInterface.getResourceRelativeRelationshipList(resource)
                if not (JR.same(list_, this.basicArrayListUtil.getImmutableInstance())) then
                    jret <- this.duplicate(list_, layer)
                    jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            raise ((new JException((new StringMaker()).append("Not available for current feature selection or Resource: ").append(resource).ToString())))
        jret
    
    member this.duplicate(list_: BasicArrayList, layer: AllBinaryLayer) : BasicArrayList =
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable newList : BasicArrayList = (new BasicArrayListD())
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable relativeRelationship : RelativeRelationship = (box (list_.objectArray.[index]) :?> RelativeRelationship)
            ignore (newList.add((new RelativeLayerRelationship(layer, pointFactory.createXY(relativeRelationship.getX(), relativeRelationship.getY()), BasicArrayListUtil.getInstance().getImmutableInstance()))))
            index <- index + 1
        newList


