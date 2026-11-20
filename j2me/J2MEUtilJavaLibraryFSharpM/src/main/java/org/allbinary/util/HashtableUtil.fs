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
type HashtableUtil =
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : HashtableUtil
    static member instance with get() : HashtableUtil = (HashtableUtil.jclinit(); HashtableUtil.jcell_instance) and set (jvalue: HashtableUtil) = (HashtableUtil.jclinit(); HashtableUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HashtableUtil.jclinitDone then
            HashtableUtil.jclinitDone <- true
            HashtableUtil.jclinitBody()
    static member private jclinitBody() : unit =
        HashtableUtil.jcell_instance <- (new HashtableUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_HashtableUtil()
    member this.jfields_HashtableUtil() : unit =
        this.enumerationUtil <- EnumerationUtil.getInstance()
        ()
    
    static member getInstance() : HashtableUtil =
        HashtableUtil.instance
    
    abstract putAll : fromHashtable: ABHashtable * hashtable: ABHashtable -> unit
    default this.putAll(fromHashtable: ABHashtable, hashtable: ABHashtable) : unit =
        let mutable enumeration : Enumeration = fromHashtable.keys()
        let mutable keyCanBeNull : obj = null
        let mutable valueCanBeNull : obj = null
        while this.enumerationUtil.hasMoreElements(enumeration) do
            keyCanBeNull <- this.enumerationUtil.nextElement(enumeration)
            valueCanBeNull <- hashtable.get(keyCanBeNull)
            if (JR.same(valueCanBeNull, null)) then
                ()
            else
                ignore (hashtable.put(keyCanBeNull, valueCanBeNull))
    
    abstract getKeysAsArray : hashtable: ABHashtable -> obj[]
    default this.getKeysAsArray(hashtable: ABHashtable) : obj[] =
        let mutable objectArray : obj[] = (Array.zeroCreate<obj> (hashtable.size()))
        let mutable index : int = 0
        let mutable enumeration : Enumeration = hashtable.keys()
        while this.enumerationUtil.hasMoreElements(enumeration) do
            objectArray.[(let jt = index in index <- index + 1; jt)] <- this.enumerationUtil.nextElement(enumeration)
        objectArray
    
    abstract getKeysAsList : hashtable: ABHashtable -> BasicArrayList
    default this.getKeysAsList(hashtable: ABHashtable) : BasicArrayList =
        let mutable list_ : BasicArrayList = (new BasicArrayListS(hashtable.size()))
        let mutable enumeration : Enumeration = hashtable.keys()
        while this.enumerationUtil.hasMoreElements(enumeration) do
            ignore (list_.add(this.enumerationUtil.nextElement(enumeration)))
        list_


