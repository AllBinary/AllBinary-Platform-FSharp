namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type NoCrypt =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoCrypt.jclinitDone then
            NoCrypt.jclinitDone <- true
            NoCrypt.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract encrypt : array_: sbyte[] -> sbyte[]
    default this.encrypt(array_: sbyte[]) : sbyte[] =
        array_
    
    abstract decrypt : array_: sbyte[] -> sbyte[]
    default this.decrypt(array_: sbyte[]) : sbyte[] =
        array_
    interface CryptInterface with
        member this.encrypt(jp0: sbyte[]) : sbyte[] = this.encrypt(jp0)
        member this.decrypt(jp0: sbyte[]) : sbyte[] = this.decrypt(jp0)


