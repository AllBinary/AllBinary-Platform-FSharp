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
type NoCacheableFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoCacheableFactory.jclinitDone then
            NoCacheableFactory.jclinitDone <- true
            NoCacheableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    abstract getInstance : key: obj -> CacheableInterface
    default this.getInstance(key: obj) : CacheableInterface =
        raise ((new JException("This Factory Does Not")))
    interface CacheableInterfaceFactoryInterface with
        member this.getInstance(jp0: obj) : CacheableInterface = this.getInstance(jp0)


