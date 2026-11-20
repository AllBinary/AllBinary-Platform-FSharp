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
type MultiplayerBehavior =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_MULTIPLAYER_BEHAVIOR : MultiplayerBehavior
    static member NULL_MULTIPLAYER_BEHAVIOR with get() : MultiplayerBehavior = (MultiplayerBehavior.jclinit(); MultiplayerBehavior.jcell_NULL_MULTIPLAYER_BEHAVIOR) and set (jvalue: MultiplayerBehavior) = (MultiplayerBehavior.jclinit(); MultiplayerBehavior.jcell_NULL_MULTIPLAYER_BEHAVIOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultiplayerBehavior.jclinitDone then
            MultiplayerBehavior.jclinitDone <- true
            MultiplayerBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        MultiplayerBehavior.jcell_NULL_MULTIPLAYER_BEHAVIOR <- (new MultiplayerBehavior(StringUtil.getInstance().EMPTY_STRING))
        ()
    
    new (username: string) =
        {  }
    
    abstract startTick : unit -> unit
    default this.startTick() : unit =
        ()
    
    abstract endTick : unit -> unit
    default this.endTick() : unit =
        ()
    
    abstract getApproximateElapsed : unit -> int64
    default this.getApproximateElapsed() : int64 =
        0L


