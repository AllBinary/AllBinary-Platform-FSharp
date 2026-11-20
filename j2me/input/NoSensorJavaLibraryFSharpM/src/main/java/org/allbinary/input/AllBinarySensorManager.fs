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
type AllBinarySensorManager =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable ORIENTATION_SENSOR_INPUT : string
    [<DefaultValue(false)>] val mutable ORIENTATION_TYPE : string
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (AllBinarySensorManager.jclinit(); AllBinarySensorManager.jcell_instance) and set (jvalue: obj) = (AllBinarySensorManager.jclinit(); AllBinarySensorManager.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinarySensorManager.jclinitDone then
            AllBinarySensorManager.jclinitDone <- true
            AllBinarySensorManager.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinarySensorManager.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_AllBinarySensorManager() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.ORIENTATION_SENSOR_INPUT <- "Orientation Sensor Input"
        this.ORIENTATION_TYPE <- "Orientation Type"
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : AllBinarySensorManager =
        if (JR.same(AllBinarySensorManager.instance, NullUtil.getInstance().NULL_OBJECT)) then
            AllBinarySensorManager.instance <- (new AllBinarySensorManager())
        (box (AllBinarySensorManager.instance) :?> AllBinarySensorManager)
    
    new () as this =
        {  }
        then
            this.jfields_AllBinarySensorManager()
            this.jctor1()
    member this.jctor1() : unit =
        try
            GyroSensorFactory.init()
            AccelerometerSensorFactory.init()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract getSensorNamesList : unit -> BasicArrayList
    default this.getSensorNamesList() : BasicArrayList =
        this.list
    
    abstract shutdown : unit -> unit
    default this.shutdown() : unit =
        ()


