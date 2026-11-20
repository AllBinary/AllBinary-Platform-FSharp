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
type Features =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable defaultList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : obj
    static member SINGLETON with get() : obj = (Features.jclinit(); Features.jcell_SINGLETON) and set (jvalue: obj) = (Features.jclinit(); Features.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Features.jclinitDone then
            Features.jclinitDone <- true
            Features.jclinitBody()
    static member private jclinitBody() : unit =
        Features.jcell_SINGLETON <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_Features() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    static member getInstance() : Features =
        if (JR.same(Features.SINGLETON, NullUtil.getInstance().NULL_OBJECT)) then
            Features.SINGLETON <- (new Features())
        (box (Features.SINGLETON) :?> Features)
    
    new () as this =
        {  }
        then
            this.jfields_Features()
            this.jctor1()
    member this.jctor1() : unit =
        this.list <- (new BasicArrayListD())
        this.defaultList <- (new BasicArrayListD())
        this.init()
        ()
    
    abstract addDefault : gameFeature: Feature -> unit
    default this.addDefault(gameFeature: Feature) : unit =
        this.add(gameFeature)
        if not (this.defaultList.contains(gameFeature)) then
            ignore (this.defaultList.add(gameFeature))
    
    abstract add : gameFeature: Feature -> unit
    default this.add(gameFeature: Feature) : unit =
        if not (this.list.contains(gameFeature)) then
            this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(gameFeature.ToString()).ToString(), this, this.commonStrings.ADD)
            ignore (this.list.add(gameFeature))
            GameFeatureEventHandler.getInstance().fireEvent((new GameFeatureEvent(gameFeature, gameFeature.ToString())))
    
    abstract removeDefault : gameFeature: Feature -> unit
    default this.removeDefault(gameFeature: Feature) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(gameFeature.ToString()).ToString(), this, "removeDefault")
        this.remove(gameFeature)
        ignore (this.defaultList.remove(gameFeature))
    
    abstract remove : gameFeature: Feature -> unit
    default this.remove(gameFeature: Feature) : unit =
        if this.list.contains(gameFeature) then
            this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.REMOVE)
            ignore (this.list.remove(gameFeature))
            GameFeatureEventHandler.getInstance().fireEvent((new GameFeatureEvent(gameFeature, gameFeature.ToString())))
    
    member this.init() : unit =
        try
            let mutable gameFeatureFactory : GameFeatureFactory = GameFeatureFactory.getInstance()
            let mutable inputFeatureFactory : InputFeatureFactory = InputFeatureFactory.getInstance()
            let mutable sensorFeatureFactory : SensorFeatureFactory = SensorFeatureFactory.getInstance()
            let mutable touchFeatureFactory : TouchFeatureFactory = TouchFeatureFactory.getInstance()
            this.addDefault(gameFeatureFactory.ARTIFICIAL_INTELLEGENCE_PROCESSOR)
            this.addDefault(gameFeatureFactory.COLLIDABLE_INTERFACE_LAYER_PROCESSOR)
            this.addDefault(gameFeatureFactory.GAME_INPUT_LAYER_PROCESSOR)
            this.addDefault(gameFeatureFactory.TICKABLE_LAYER_PROCESSOR)
            this.addDefault(inputFeatureFactory.MULTI_KEY_PRESS)
            this.addDefault(inputFeatureFactory.REMOVE_DUPLICATE_KEY_PRESSES)
            this.addDefault(gameFeatureFactory.SCREEN_SHAKE)
            this.addDefault(gameFeatureFactory.POST_IMAGE_LOADING_MODIFICATION)
            let mutable operatingSystemInterface : GenericOperatingSystem = OperatingSystemFactory.getInstance().getOperatingSystemInstance()
            if operatingSystemInterface.isOverScan() then
                this.addDefault(sensorFeatureFactory.NO_ORIENTATION)
                this.addDefault(touchFeatureFactory.HIDE_SCREEN_BUTTONS)
            else
                this.addDefault(sensorFeatureFactory.ORIENTATION_SENSORS)
                this.addDefault(touchFeatureFactory.AUTO_HIDE_SHOW_SCREEN_BUTTONS)
            this.addDefault(touchFeatureFactory.TOUCH_ENABLED)
            this.addDefault(MainFeatureFactory.getInstance().FULL_SCREEN)
            this.addDefault(MainFeatureFactory.getInstance().LOAD_ONDEMAND)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE(this.commonStrings.EXCEPTION, this, this.commonStrings.INIT, e)
            | _ -> reraise ()
    
    abstract isDefault : gameFeature: Feature -> bool
    default this.isDefault(gameFeature: Feature) : bool =
        this.defaultList.contains(gameFeature)
    
    abstract isFeature : gameFeature: Feature -> bool
    default this.isFeature(gameFeature: Feature) : bool =
        this.list.contains(gameFeature)
    
    abstract toggle : gameFeature: Feature -> unit
    default this.toggle(gameFeature: Feature) : unit =
        if this.isFeature(gameFeature) then
            this.remove(gameFeature)
        else
            this.add(gameFeature)


