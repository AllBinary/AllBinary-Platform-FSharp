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
type NoPlayer =
    inherit BasicPlayer
    [<DefaultValue(false)>] static val mutable private jcell_NO_PLAYER : NoPlayer
    static member NO_PLAYER with get() : NoPlayer = (NoPlayer.jclinit(); NoPlayer.jcell_NO_PLAYER) and set (jvalue: NoPlayer) = (NoPlayer.jclinit(); NoPlayer.jcell_NO_PLAYER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoPlayer.jclinitDone then
            NoPlayer.jclinitDone <- true
            NoPlayer.jclinitBody()
    static member private jclinitBody() : unit =
        NoPlayer.jcell_NO_PLAYER <- (new NoPlayer())
        ()
    
    new () =
        { inherit BasicPlayer() }
    
    override this.close() : unit =
        ()
    
    override this.getContentType() : string =
        StringUtil.getInstance().NULL_STRING
    
    override this.getControl(controlType: string) : Control =
        (new NullControl())
    
    override this.getControls() : Control[] =
        (Array.zeroCreate<Control> (0))


