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
type LevelLayersFinder =
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : LevelLayersFinder
    static member instance with get() : LevelLayersFinder = (LevelLayersFinder.jclinit(); LevelLayersFinder.jcell_instance) and set (jvalue: LevelLayersFinder) = (LevelLayersFinder.jclinit(); LevelLayersFinder.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LevelLayersFinder.jclinitDone then
            LevelLayersFinder.jclinitDone <- true
            LevelLayersFinder.jclinitBody()
    static member private jclinitBody() : unit =
        LevelLayersFinder.jcell_instance <- (new LevelLayersFinder())
        ()
    new () as this =
        {  }
        then
            this.jfields_LevelLayersFinder()
    member this.jfields_LevelLayersFinder() : unit =
        this.enumerationUtil <- EnumerationUtil.getInstance()
        ()
    
    static member getInstance() : LevelLayersFinder =
        LevelLayersFinder.instance
    
    abstract get : hashtable: ABHashtable -> BasicArrayList
    default this.get(hashtable: ABHashtable) : BasicArrayList =
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable enumeration : Enumeration = hashtable.keys()
        let mutable layerHashtableCanBeNull : ABHashtable = null
        let mutable integerCanBeNull : Integer = null
        let mutable cachedIntegerCanBeNull : Integer = null
        while this.enumerationUtil.hasMoreElements(enumeration) do
            layerHashtableCanBeNull <- (box (hashtable.get((box (this.enumerationUtil.nextElement(enumeration))))) :?> ABHashtable)
            integerCanBeNull <- (box (layerHashtableCanBeNull.get((box (Layer.ID)))) :?> Integer)
            cachedIntegerCanBeNull <- smallIntegerSingletonFactory.getAt(integerCanBeNull.intValue())
            if not (list_.contains(cachedIntegerCanBeNull)) then
                ignore (list_.add(cachedIntegerCanBeNull))
        list_


