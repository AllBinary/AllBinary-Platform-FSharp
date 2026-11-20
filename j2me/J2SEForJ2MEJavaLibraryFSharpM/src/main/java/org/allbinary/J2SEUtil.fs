namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type J2SEUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : J2SEUtil
    static member instance with get() : J2SEUtil = (J2SEUtil.jclinit(); J2SEUtil.jcell_instance) and set (jvalue: J2SEUtil) = (J2SEUtil.jclinit(); J2SEUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not J2SEUtil.jclinitDone then
            J2SEUtil.jclinitDone <- true
            J2SEUtil.jclinitBody()
    static member private jclinitBody() : unit =
        J2SEUtil.jcell_instance <- (new J2SEUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : J2SEUtil =
        J2SEUtil.instance
    
    abstract getHashMapAsArray : hashMap: HashMap -> obj[]
    default this.getHashMapAsArray(hashMap: HashMap) : obj[] =
        let mutable objectArray : obj[] = hashMap.keySet().toArray()
        objectArray
    
    abstract getMapAsArray : map: Map -> obj[]
    default this.getMapAsArray(map: Map) : obj[] =
        let mutable objectArray : obj[] = map.keySet().toArray()
        objectArray
    
    abstract getSetAsArray : set: Set -> obj[]
    default this.getSetAsArray(set: Set) : obj[] =
        let mutable objectArray : obj[] = set.toArray()
        objectArray


