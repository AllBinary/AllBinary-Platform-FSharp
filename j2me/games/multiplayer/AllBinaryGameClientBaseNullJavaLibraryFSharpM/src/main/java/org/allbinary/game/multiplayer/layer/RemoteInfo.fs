namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * To change this license header, choose License Headers in Project Properties. 
 * To change this template file, choose Tools | Templates 
 * and open the template in the editor.  
 *)

[<AllowNullLiteral>]
type RemoteInfo =
    static member NEW_PLAYER_ID : int = 0
    [<DefaultValue(false)>] static val mutable private jcell_REMOTE_INFO : RemoteInfo
    static member REMOTE_INFO with get() : RemoteInfo = (RemoteInfo.jclinit(); RemoteInfo.jcell_REMOTE_INFO) and set (jvalue: RemoteInfo) = (RemoteInfo.jclinit(); RemoteInfo.jcell_REMOTE_INFO <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RemoteInfo.jclinitDone then
            RemoteInfo.jclinitDone <- true
            RemoteInfo.jclinitBody()
    static member private jclinitBody() : unit =
        RemoteInfo.jcell_REMOTE_INFO <- (new RemoteInfo(StringUtil.getInstance().EMPTY_STRING, -1, -1, RemoteInfo.NEW_PLAYER_ID))
        ()
    
    new (username: string, actorSessionId: int, playerInputId: int, id_: int) =
        {  }


