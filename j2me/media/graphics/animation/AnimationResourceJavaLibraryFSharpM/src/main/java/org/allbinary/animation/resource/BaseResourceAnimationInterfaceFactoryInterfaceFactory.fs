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
type BaseResourceAnimationInterfaceFactoryInterfaceFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable rectangleHashtable : ABHashtable
    [<DefaultValue(false)>] val mutable rectangleArrayOfArraysHashtable : ABHashtable
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseResourceAnimationInterfaceFactoryInterfaceFactory.jclinitDone then
            BaseResourceAnimationInterfaceFactoryInterfaceFactory.jclinitDone <- true
            BaseResourceAnimationInterfaceFactoryInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BaseResourceAnimationInterfaceFactoryInterfaceFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (name: string, hashtable: ABHashtable, rectangleHashtable: ABHashtable, rectangleArrayHashtable: ABHashtable) as this =
        {  }
        then
            this.jfields_BaseResourceAnimationInterfaceFactoryInterfaceFactory()
            this.jctor1(name, hashtable, rectangleHashtable, rectangleArrayHashtable)
    member this.jctor1(name: string, hashtable: ABHashtable, rectangleHashtable: ABHashtable, rectangleArrayHashtable: ABHashtable) : unit =
        this.hashtable <- hashtable
        this.rectangleHashtable <- rectangleHashtable
        this.rectangleArrayOfArraysHashtable <- rectangleArrayHashtable
        this.name <- name
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract init : level: int -> unit
    default this.init(level: int) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF((new StringMaker()).append("Available List of Animations: ").append(this.hashtable.ToString()).ToString(), this, commonStrings.INIT)
        this.setInitialized(true)
    
    abstract initImageCache : imageCache: ImageCache * level: int -> unit
    default this.initImageCache(imageCache: ImageCache, level: int) : unit =
        ()
    
    abstract add : resource: string * animationInterfaceFactoryInterface: BasicAnimationInterfaceFactoryInterface -> unit
    default this.add(resource: string, animationInterfaceFactoryInterface: BasicAnimationInterfaceFactoryInterface) : unit =
        if this.hashtable.containsKey((box (resource))) then
            raise ((new JException((new StringMaker()).append("Resource Already Created: ").append(resource).ToString())))
        ignore (this.hashtable.put(resource, animationInterfaceFactoryInterface))
    
    abstract getBasicAnimationInterfaceFactoryInstance : resource: string -> BasicAnimationInterfaceFactoryInterface
    default this.getBasicAnimationInterfaceFactoryInstance(resource: string) : BasicAnimationInterfaceFactoryInterface =
        let mutable jflow = 0
        let mutable jret : BasicAnimationInterfaceFactoryInterface = Unchecked.defaultof<BasicAnimationInterfaceFactoryInterface>
        let mutable basicAnimationInterfaceFactoryInterfaceCanBeNull : obj = this.hashtable.get(resource)
        if (JR.same(basicAnimationInterfaceFactoryInterfaceCanBeNull, null)) then
            jret <- NullAnimationFactory.NULL_NOT_FOR_USE_ANIMATION_FACTORY
            jflow <- 1
        if jflow = 0 then
            jret <- (box (basicAnimationInterfaceFactoryInterfaceCanBeNull) :?> BasicAnimationInterfaceFactoryInterface)
            jflow <- 1
        jret
    
    abstract getRectangle : resource: string -> Rectangle
    default this.getRectangle(resource: string) : Rectangle =
        let mutable jflow = 0
        let mutable jret : Rectangle = Unchecked.defaultof<Rectangle>
        let mutable rectangleCanBeNull : obj = this.rectangleHashtable.get(resource)
        if (JR.same(rectangleCanBeNull, null)) then
            jret <- RectangleFactory.SINGLETON
            jflow <- 1
        if jflow = 0 then
            jret <- (box (rectangleCanBeNull) :?> Rectangle)
            jflow <- 1
        jret
    
    abstract addRectangle : resource: string * rectangle: Rectangle -> unit
    default this.addRectangle(resource: string, rectangle: Rectangle) : unit =
        ignore (this.rectangleHashtable.put(resource, rectangle))
    
    abstract getRectangleArrayOfArrays : resource: string -> Rectangle[][]
    default this.getRectangleArrayOfArrays(resource: string) : Rectangle[][] =
        let mutable jflow = 0
        let mutable jret : Rectangle[][] = Unchecked.defaultof<Rectangle[][]>
        let mutable valueCanBeNull : obj = this.rectangleArrayOfArraysHashtable.get(resource)
        if not (JR.same(valueCanBeNull, null)) then
            let mutable rectangleArrayOfArrays : Rectangle[][] = (box (valueCanBeNull) :?> Rectangle[][])
            jret <- rectangleArrayOfArrays
            jflow <- 1
        else
            jret <- RectangleFactory.ARRAY_OF_ARRAYS
            jflow <- 1
        jret
    
    abstract addRectangleArrayOfArrays : resource: string * rectangleArrayOfArrays: Rectangle[][] -> unit
    default this.addRectangleArrayOfArrays(resource: string, rectangleArrayOfArrays: Rectangle[][]) : unit =
        ignore (this.rectangleArrayOfArraysHashtable.put(resource, rectangleArrayOfArrays))
    
    abstract isFeature : unit -> bool
    default this.isFeature() : bool =
        false
    
    abstract isLoadingLevel : level: int -> bool
    default this.isLoadingLevel(level: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable resourceLoadingLevelFactory : ResourceLoadingLevelFactory = ResourceLoadingLevelFactory.getInstance()
        if level = resourceLoadingLevelFactory.LOAD_ALL.getLevel() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    override this.ToString() : string =
        (new StringMaker()).append(JR.getClass(this)).append(CommonSeps.getInstance().SEMICOLON).append(CommonSeps.getInstance().SPACE).append(this.name).ToString()
    
    abstract getHashtable : unit -> ABHashtable
    default this.getHashtable() : ABHashtable =
        this.hashtable
    
    abstract getRectangleHashtable : unit -> ABHashtable
    default this.getRectangleHashtable() : ABHashtable =
        this.rectangleHashtable
    
    abstract getRectangleArrayOfArraysHashtable : unit -> ABHashtable
    default this.getRectangleArrayOfArraysHashtable() : ABHashtable =
        this.rectangleArrayOfArraysHashtable
    
    abstract setInitialized : initialized: bool -> unit
    default this.setInitialized(initialized: bool) : unit =
        this.initialized <- initialized
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    interface FeatureResourceAnimationInterfaceFactoryInterface with
        member this.getHashtable() : ABHashtable = this.getHashtable()
    interface ResourceAnimationInterfaceFactoryInterface with
        member this.getBasicAnimationInterfaceFactoryInstance(jp0: string) : BasicAnimationInterfaceFactoryInterface = this.getBasicAnimationInterfaceFactoryInstance(jp0)
    interface RectangleResourceFactoryInterface with
        member this.getRectangle(jp0: string) : Rectangle = this.getRectangle(jp0)
        member this.getRectangleArrayOfArrays(jp0: string) : Rectangle[][] = this.getRectangleArrayOfArrays(jp0)
    interface GameFeatureControlledInterface with
        member this.init(jp0: int) : unit = this.init(jp0)
        member this.isFeature() : bool = this.isFeature()
        member this.isLoadingLevel(jp0: int) : bool = this.isLoadingLevel(jp0)


