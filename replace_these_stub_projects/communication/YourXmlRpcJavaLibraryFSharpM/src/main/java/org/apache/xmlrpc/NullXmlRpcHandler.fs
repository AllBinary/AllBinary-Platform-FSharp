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
type NullXmlRpcHandler =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_XML_RPC_HANDLER : NullXmlRpcHandler
    static member NULL_XML_RPC_HANDLER with get() : NullXmlRpcHandler = (NullXmlRpcHandler.jclinit(); NullXmlRpcHandler.jcell_NULL_XML_RPC_HANDLER) and set (jvalue: NullXmlRpcHandler) = (NullXmlRpcHandler.jclinit(); NullXmlRpcHandler.jcell_NULL_XML_RPC_HANDLER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullXmlRpcHandler.jclinitDone then
            NullXmlRpcHandler.jclinitDone <- true
            NullXmlRpcHandler.jclinitBody()
    static member private jclinitBody() : unit =
        NullXmlRpcHandler.jcell_NULL_XML_RPC_HANDLER <- (new NullXmlRpcHandler())
        ()
    new () =
        {  }
    
    abstract execute : method_: string * params_: BasicArrayList -> obj
    default this.execute(method_: string, params_: BasicArrayList) : obj =
        NullUtil.getInstance().NULL_OBJECT
    interface XmlRpcHandler with
        member this.execute(jp0: string, jp1: BasicArrayList) : obj = this.execute(jp0, jp1)


