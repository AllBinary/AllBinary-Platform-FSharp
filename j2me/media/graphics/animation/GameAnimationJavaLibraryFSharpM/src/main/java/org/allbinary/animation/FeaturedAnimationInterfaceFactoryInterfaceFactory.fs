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
type FeaturedAnimationInterfaceFactoryInterfaceFactory =
    inherit FeaturedResourceFactory
    [<DefaultValue(false)>] static val mutable private jcell_INSTANCE : FeaturedAnimationInterfaceFactoryInterfaceFactory
    static member INSTANCE with get() : FeaturedAnimationInterfaceFactoryInterfaceFactory = (FeaturedAnimationInterfaceFactoryInterfaceFactory.jclinit(); FeaturedAnimationInterfaceFactoryInterfaceFactory.jcell_INSTANCE) and set (jvalue: FeaturedAnimationInterfaceFactoryInterfaceFactory) = (FeaturedAnimationInterfaceFactoryInterfaceFactory.jclinit(); FeaturedAnimationInterfaceFactoryInterfaceFactory.jcell_INSTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FeaturedAnimationInterfaceFactoryInterfaceFactory.jclinitDone then
            FeaturedAnimationInterfaceFactoryInterfaceFactory.jclinitDone <- true
            FeaturedAnimationInterfaceFactoryInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FeaturedAnimationInterfaceFactoryInterfaceFactory.jcell_INSTANCE <- (new FeaturedAnimationInterfaceFactoryInterfaceFactory())
        ()
    
    new () =
        { inherit FeaturedResourceFactory() }
    
    static member getInstance() : FeaturedAnimationInterfaceFactoryInterfaceFactory =
        FeaturedAnimationInterfaceFactoryInterfaceFactory.INSTANCE
    
    abstract getRectangle : resource: string -> Rectangle
    default this.getRectangle(resource: string) : Rectangle =
        this.getRectangleXY(resource, 0, 0)
    
    abstract getRectangleXY : resource: string * x: int * y: int -> Rectangle
    default this.getRectangleXY(resource: string, x: int, y: int) : Rectangle =
        let mutable jflow = 0
        let mutable jret : Rectangle = Unchecked.defaultof<Rectangle>
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable list_ : BasicArrayList = this.getList()
        let mutable scale : int = GameConfigurationCentral.getInstance().SCALE.getValue().intValue()
        let mutable size : int = this.getList().size()
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            let mutable featureInterface : FeatureResourceAnimationInterfaceFactoryInterface = (box (list_.objectArray.[index]) :?> FeatureResourceAnimationInterfaceFactoryInterface)
            if featureInterface.isFeature() then
                let mutable rectangle : Rectangle = featureInterface.getRectangle(resource)
                if not (JR.same(rectangle, RectangleFactory.SINGLETON)) then
                    jret <- (new Rectangle(pointFactory.createXY(x, y), ((rectangle.getWidth() * scale) >>> 1), ((rectangle.getHeight() * scale) >>> 1)))
                    jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            raise ((new JException((new StringMaker()).append("No rectangle available for current feature selection or Resource: ").append(resource).ToString())))
        jret
    
    abstract getProcedural : resource: string -> ProceduralAnimationInterfaceFactoryInterface
    default this.getProcedural(resource: string) : ProceduralAnimationInterfaceFactoryInterface =
        (box (this.getBasicAnimationInterfaceFactoryInstance(resource)) :?> ProceduralAnimationInterfaceFactoryInterface)
    
    abstract get : resource: string -> AnimationInterfaceFactoryInterface
    default this.get(resource: string) : AnimationInterfaceFactoryInterface =
        (box (this.getBasicAnimationInterfaceFactoryInstance(resource)) :?> AnimationInterfaceFactoryInterface)
    
    member this.getBasicAnimationInterfaceFactoryInstance(resource: string) : BasicAnimationInterfaceFactoryInterface =
        let mutable jflow = 0
        let mutable jret : BasicAnimationInterfaceFactoryInterface = Unchecked.defaultof<BasicAnimationInterfaceFactoryInterface>
        let mutable list_ : BasicArrayList = this.getList()
        let mutable resourceTypeAvailableList : BasicArrayList = (new BasicArrayListD())
        let mutable size : int = this.getList().size()
        let mutable featureInterface : FeatureResourceAnimationInterfaceFactoryInterface = null
        let mutable animationInterfaceFactoryInterface : BasicAnimationInterfaceFactoryInterface = null
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            featureInterface <- (box (list_.objectArray.[index]) :?> FeatureResourceAnimationInterfaceFactoryInterface)
            if featureInterface.isFeature() then
                ignore (resourceTypeAvailableList.add(featureInterface))
                animationInterfaceFactoryInterface <- featureInterface.getBasicAnimationInterfaceFactoryInstance(resource)
                if not (JR.same(animationInterfaceFactoryInterface, NullAnimationFactory.NULL_NOT_FOR_USE_ANIMATION_FACTORY)) then
                    jret <- animationInterfaceFactoryInterface
                    jflow <- 1
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            if resourceTypeAvailableList.size() > 0 then
                let mutable NO_ANIMATION_AVAILABLE_FROM : string = "No animation available from: "
                let mutable FOR_FACTORIES : string = " factories: "
                let mutable FOR_RESOURCE : string = " for Resource: "
                let mutable HAS_KEY : string = " has: "
                let mutable RESOURCES_LABEL : string = " resources "
                let mutable stringBuffer : StringMaker = (new StringMaker())
                ignore (stringBuffer.append(NO_ANIMATION_AVAILABLE_FROM))
                ignore (stringBuffer.appendint(resourceTypeAvailableList.size()))
                ignore (stringBuffer.append(CommonSeps.getInstance().FORWARD_SLASH))
                ignore (stringBuffer.appendint(size))
                ignore (stringBuffer.append(FOR_FACTORIES))
                let mutable size2 : int = resourceTypeAvailableList.size()
                let mutable index : int = 0
                while index < size2 do
                    ignore (stringBuffer.append(resourceTypeAvailableList.get(index).ToString()))
                    ignore (stringBuffer.append(CommonSeps.getInstance().COMMA_SEP))
                    index <- index + 1
                ignore (stringBuffer.append(FOR_RESOURCE))
                ignore (stringBuffer.append(resource))
                let mutable index : int = 0
                while index < size do
                    ignore (stringBuffer.append(CommonSeps.getInstance().NEW_LINE))
                    featureInterface <- (box (list_.objectArray.[index]) :?> FeatureResourceAnimationInterfaceFactoryInterface)
                    if featureInterface.isFeature() then
                        ignore (stringBuffer.append(StringUtil.getInstance().toString(featureInterface)))
                        ignore (stringBuffer.append(HAS_KEY))
                        ignore (stringBuffer.appendint(featureInterface.getHashtable().size()))
                        ignore (stringBuffer.append(RESOURCES_LABEL))
                    index <- index + 1
                raise ((new JException(stringBuffer.ToString())))
            else
                let mutable stringBuffer : StringMaker = (new StringMaker())
                let mutable index : int = 0
                while index < size do
                    featureInterface <- (box (list_.objectArray.[index]) :?> FeatureResourceAnimationInterfaceFactoryInterface)
                    ignore (stringBuffer.append(featureInterface.ToString()))
                    ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
                    index <- index + 1
                let mutable result : string = stringBuffer.ToString()
                ignore (stringBuffer.delete(0, stringBuffer.length()))
                raise ((new JException(stringBuffer.append("No feature resource type available for Resource: ").append(resource).append(" Resource Factories Available: ").append(result).ToString())))
        jret


