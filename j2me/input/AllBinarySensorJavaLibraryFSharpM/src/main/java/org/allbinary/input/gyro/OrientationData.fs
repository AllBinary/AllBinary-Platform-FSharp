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
type OrientationData =
    [<DefaultValue(false)>] val mutable ORIENTATION_SENSOR_INPUT : string
    [<DefaultValue(false)>] val mutable ORIENTATION_TYPE : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : OrientationData
    static member SINGLETON with get() : OrientationData = (OrientationData.jclinit(); OrientationData.jcell_SINGLETON) and set (jvalue: OrientationData) = (OrientationData.jclinit(); OrientationData.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OrientationData.jclinitDone then
            OrientationData.jclinitDone <- true
            OrientationData.jclinitBody()
    static member private jclinitBody() : unit =
        OrientationData.jcell_SINGLETON <- (new OrientationData())
        ()
    member this.jfields_OrientationData() : unit =
        this.ORIENTATION_SENSOR_INPUT <- "Orientation Sensor Input"
        this.ORIENTATION_TYPE <- "Orientation Type"
        ()
    
    new () as this =
        {  }
        then
            this.jfields_OrientationData()
    
    static member getInstance() : OrientationData =
        OrientationData.SINGLETON


