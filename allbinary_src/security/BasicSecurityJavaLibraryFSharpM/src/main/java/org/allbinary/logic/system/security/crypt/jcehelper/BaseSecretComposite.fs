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
type BaseSecretComposite =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_SECRET_COMPOSITE : BaseSecretComposite
    static member NULL_SECRET_COMPOSITE with get() : BaseSecretComposite = (BaseSecretComposite.jclinit(); BaseSecretComposite.jcell_NULL_SECRET_COMPOSITE) and set (jvalue: BaseSecretComposite) = (BaseSecretComposite.jclinit(); BaseSecretComposite.jcell_NULL_SECRET_COMPOSITE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseSecretComposite.jclinitDone then
            BaseSecretComposite.jclinitDone <- true
            BaseSecretComposite.jclinitBody()
    static member private jclinitBody() : unit =
        BaseSecretComposite.jcell_NULL_SECRET_COMPOSITE <- (new BaseSecretComposite())
        ()
    new () =
        {  }
    
    abstract encrypt : array_: sbyte[] -> sbyte[]
    default this.encrypt(array_: sbyte[]) : sbyte[] =
        NullUtil.getInstance().NULL_BYTE_ARRAY
    
    abstract decrypt : array_: sbyte[] -> sbyte[]
    default this.decrypt(array_: sbyte[]) : sbyte[] =
        NullUtil.getInstance().NULL_BYTE_ARRAY


