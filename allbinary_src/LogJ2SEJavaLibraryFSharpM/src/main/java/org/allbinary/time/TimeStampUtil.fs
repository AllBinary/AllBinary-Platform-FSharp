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
type TimeStampUtil =
    [<DefaultValue(false)>] val mutable simpleDataFormat : SimpleDateFormat
    [<DefaultValue(false)>] static val mutable private jcell_instance : TimeStampUtil
    static member instance with get() : TimeStampUtil = (TimeStampUtil.jclinit(); TimeStampUtil.jcell_instance) and set (jvalue: TimeStampUtil) = (TimeStampUtil.jclinit(); TimeStampUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimeStampUtil.jclinitDone then
            TimeStampUtil.jclinitDone <- true
            TimeStampUtil.jclinitBody()
    static member private jclinitBody() : unit =
        TimeStampUtil.jcell_instance <- (new TimeStampUtil())
        ()
    member this.jfields_TimeStampUtil() : unit =
        this.simpleDataFormat <- (new SimpleDateFormat("yyyy-MM-dd HH:mm:ss.SSS"))
        ()
    
    static member getInstance() : TimeStampUtil =
        TimeStampUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_TimeStampUtil()
    
    abstract getAsString : unit -> string
    default this.getAsString() : string =
        let mutable calendar : Calendar = Calendar.getInstance()
        let mutable date : Date = calendar.getTime()
        this.simpleDataFormat.format(date)


