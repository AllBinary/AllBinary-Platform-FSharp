namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2007 AllBinary 
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
type AutomaticCacheInterfaceFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AutomaticCacheInterfaceFactory.jclinitDone then
            AutomaticCacheInterfaceFactory.jclinitDone <- true
            AutomaticCacheInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member getInstance(cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface, cacheType: CacheType, cachePolicy: CachePolicy) : AutomaticCacheInterface =
        raise ((new JException((JR.nn("No such ") + JR.nn(cacheType.ToString())))))


