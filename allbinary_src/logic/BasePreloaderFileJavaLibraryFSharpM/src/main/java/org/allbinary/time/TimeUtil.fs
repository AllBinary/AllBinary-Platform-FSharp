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
type TimeUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : TimeUtil
    static member instance with get() : TimeUtil = (TimeUtil.jclinit(); TimeUtil.jcell_instance) and set (jvalue: TimeUtil) = (TimeUtil.jclinit(); TimeUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_calendar : Calendar
    static member calendar with get() : Calendar = (TimeUtil.jclinit(); TimeUtil.jcell_calendar) and set (jvalue: Calendar) = (TimeUtil.jclinit(); TimeUtil.jcell_calendar <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimeUtil.jclinitDone then
            TimeUtil.jclinitDone <- true
            TimeUtil.jclinitBody()
    static member private jclinitBody() : unit =
        TimeUtil.jcell_instance <- (new TimeUtil())
        TimeUtil.jcell_calendar <- Calendar.getInstance()
        ()
    new () =
        {  }
    
    static member getInstance() : TimeUtil =
        TimeUtil.instance
    
    abstract setCalendar : calendar: Calendar * yearString: string * monthString: string * dayString: string * hourString: string -> unit
    default this.setCalendar(calendar: Calendar, yearString: string, monthString: string, dayString: string, hourString: string) : unit =
        let mutable year : int = (new Integer(yearString)).intValue()
        let mutable month : int = (new Integer(monthString)).intValue()
        let mutable day : int = (new Integer(dayString)).intValue()
        let mutable hour : int = (new Integer(hourString)).intValue()
        ignore (calendar.set(year, month, day, hour, 0))
    
    abstract setCalendarWithTime : calendar: Calendar * yearString: string * monthString: string * dayString: string * hourString: string * minuteString: string * secondString: string -> unit
    default this.setCalendarWithTime(calendar: Calendar, yearString: string, monthString: string, dayString: string, hourString: string, minuteString: string, secondString: string) : unit =
        let mutable year : int = (new Integer(yearString)).intValue()
        let mutable month : int = (new Integer(monthString)).intValue()
        let mutable day : int = (new Integer(dayString)).intValue()
        let mutable hour : int = (new Integer(hourString)).intValue()
        let mutable minute : int = (new Integer(minuteString)).intValue()
        let mutable second : int = (new Integer(secondString)).intValue()
        ignore (calendar.set(year, month, day, hour, minute, second))
    
    abstract setExpirationCalendar : calendar: Calendar * yearsString: string * monthsString: string * daysString: string * hoursString: string * minutesString: string * secondsString: string -> unit
    default this.setExpirationCalendar(calendar: Calendar, yearsString: string, monthsString: string, daysString: string, hoursString: string, minutesString: string, secondsString: string) : unit =
        let mutable year : int = calendar.get(Calendar.YEAR) + (new Integer(yearsString)).intValue()
        let mutable month : int = calendar.get(Calendar.MONTH) + (new Integer(monthsString)).intValue()
        let mutable day : int = calendar.get(Calendar.DAY_OF_MONTH) + (new Integer(daysString)).intValue()
        let mutable hour : int = calendar.get(Calendar.HOUR) + (new Integer(hoursString)).intValue()
        let mutable minute : int = calendar.get(Calendar.MINUTE) + (new Integer(minutesString)).intValue()
        let mutable second : int = calendar.get(Calendar.SECOND) + (new Integer(secondsString)).intValue()
        ignore (calendar.set(year, month, day, hour, minute, second))
    
    abstract getTotalTime : yearString: string * monthString: string * dayString: string * hourString: string * minuteString: string * secondString: string -> int64
    default this.getTotalTime(yearString: string, monthString: string, dayString: string, hourString: string, minuteString: string, secondString: string) : int64 =
        let mutable time : int64 = TimeUtil.calendar.getTimeInMillis()
        this.setExpirationCalendar(TimeUtil.calendar, yearString, monthString, dayString, hourString, minuteString, secondString)
        let mutable timeDelta : int64 = TimeUtil.calendar.getTimeInMillis()
        timeDelta - time


