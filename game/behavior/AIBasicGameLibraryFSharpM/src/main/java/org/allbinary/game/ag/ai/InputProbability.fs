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
type InputProbability =
    [<DefaultValue(false)>] val mutable likelyhoodIntegerArray : Integer[][]
    [<DefaultValue(false)>] val mutable repeatLikelyhoodIntegerArray : Integer[]
    [<DefaultValue(false)>] val mutable max : int
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jcell_INPUT_PROBABILITY : Integer
    static member INPUT_PROBABILITY with get() : Integer = (InputProbability.jclinit(); InputProbability.jcell_INPUT_PROBABILITY) and set (jvalue: Integer) = (InputProbability.jclinit(); InputProbability.jcell_INPUT_PROBABILITY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputProbability.jclinitDone then
            InputProbability.jclinitDone <- true
            InputProbability.jclinitBody()
    static member private jclinitBody() : unit =
        InputProbability.jcell_INPUT_PROBABILITY <- SmallIntegerSingletonFactory.getInstance().getAt(0)
        ()
    
    new (likelyhoodIntegerArray: Integer[][], repeatLikelyhoodIntegerArray: Integer[], max_: int, timeDelayHelper: TimeDelayHelper) as this =
        {  }
        then
            this.jctor1(likelyhoodIntegerArray, repeatLikelyhoodIntegerArray, max_, timeDelayHelper)
    member this.jctor1(likelyhoodIntegerArray: Integer[][], repeatLikelyhoodIntegerArray: Integer[], max_: int, timeDelayHelper: TimeDelayHelper) : unit =
        this.likelyhoodIntegerArray <- likelyhoodIntegerArray
        this.repeatLikelyhoodIntegerArray <- repeatLikelyhoodIntegerArray
        this.max <- max_
        this.timeDelayHelper <- timeDelayHelper
        ()
    
    abstract getLikelyhoodIntegerArray : unit -> Integer[][]
    default this.getLikelyhoodIntegerArray() : Integer[][] =
        this.likelyhoodIntegerArray
    
    abstract getRepeatLikelyhoodIntegerArray : unit -> Integer[]
    default this.getRepeatLikelyhoodIntegerArray() : Integer[] =
        this.repeatLikelyhoodIntegerArray
    
    abstract getMax : unit -> int
    default this.getMax() : int =
        this.max
    
    abstract getTimeDelayHelper : unit -> TimeDelayHelper
    default this.getTimeDelayHelper() : TimeDelayHelper =
        this.timeDelayHelper
    
    abstract toHashtable : unit -> ABHashtable
    default this.toHashtable() : ABHashtable =
        let mutable hashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        ignore (hashtable.put(InputProbability.INPUT_PROBABILITY, this))
        hashtable


