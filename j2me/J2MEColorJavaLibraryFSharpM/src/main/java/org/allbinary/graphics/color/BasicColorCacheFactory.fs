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
type BasicColorCacheFactory =
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicColorCacheFactory
    static member instance with get() : BasicColorCacheFactory = (BasicColorCacheFactory.jclinit(); BasicColorCacheFactory.jcell_instance) and set (jvalue: BasicColorCacheFactory) = (BasicColorCacheFactory.jclinit(); BasicColorCacheFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColorCacheFactory.jclinitDone then
            BasicColorCacheFactory.jclinitDone <- true
            BasicColorCacheFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicColorCacheFactory.jcell_instance <- (new BasicColorCacheFactory())
        ()
    member this.jfields_BasicColorCacheFactory() : unit =
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    static member getInstance() : BasicColorCacheFactory =
        BasicColorCacheFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_BasicColorCacheFactory()
    
    abstract add : basicDefaultColor: BasicColor -> unit
    default this.add(basicDefaultColor: BasicColor) : unit =
        ignore (this.hashtable.put((new Integer(basicDefaultColor.intValue())), basicDefaultColor))
    
    abstract getAndOrCreate : integer: Integer -> BasicColor
    default this.getAndOrCreate(integer: Integer) : BasicColor =
        let mutable basicColor : BasicColor = (box (this.hashtable.get(integer)) :?> BasicColor)
        if (JR.same(basicColor, null)) then
            basicColor <- BasicColorFactory.getInstance().createInstance(integer.intValue())
            ignore (this.hashtable.put(integer, basicColor))
        basicColor


