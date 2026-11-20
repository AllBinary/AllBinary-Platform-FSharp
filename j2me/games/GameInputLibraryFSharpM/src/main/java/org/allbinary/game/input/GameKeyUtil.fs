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
type GameKeyUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameKeyUtil
    static member instance with get() : GameKeyUtil = (GameKeyUtil.jclinit(); GameKeyUtil.jcell_instance) and set (jvalue: GameKeyUtil) = (GameKeyUtil.jclinit(); GameKeyUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyUtil.jclinitDone then
            GameKeyUtil.jclinitDone <- true
            GameKeyUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyUtil.jcell_instance <- (new GameKeyUtil())
        ()
    new () =
        {  }
    
    abstract isDirectionKey : key: int -> bool
    default this.isDirectionKey(key: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((key = Canvas.UP) || (key = Canvas.DOWN)) || (key = Canvas.LEFT)) || (key = Canvas.RIGHT) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    static member getInstance() : GameKeyUtil =
        GameKeyUtil.instance


