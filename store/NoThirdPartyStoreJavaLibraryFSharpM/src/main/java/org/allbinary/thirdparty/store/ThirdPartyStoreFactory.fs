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
type ThirdPartyStoreFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoThirdPartyStore
    static member instance with get() : NoThirdPartyStore = (ThirdPartyStoreFactory.jclinit(); ThirdPartyStoreFactory.jcell_instance) and set (jvalue: NoThirdPartyStore) = (ThirdPartyStoreFactory.jclinit(); ThirdPartyStoreFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThirdPartyStoreFactory.jclinitDone then
            ThirdPartyStoreFactory.jclinitDone <- true
            ThirdPartyStoreFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ThirdPartyStoreFactory.jcell_instance <- (new NoThirdPartyStore())
        ()
    
    static member getInstance() : ThirdPartyStore =
        ThirdPartyStoreFactory.instance
    
    new () =
        {  }


