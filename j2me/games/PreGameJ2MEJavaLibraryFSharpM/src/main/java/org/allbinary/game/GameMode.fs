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
type GameMode =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jcell_NONE : GameMode
    static member NONE with get() : GameMode = (GameMode.jclinit(); GameMode.jcell_NONE) and set (jvalue: GameMode) = (GameMode.jclinit(); GameMode.jcell_NONE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SERVER : GameMode
    static member SERVER with get() : GameMode = (GameMode.jclinit(); GameMode.jcell_SERVER) and set (jvalue: GameMode) = (GameMode.jclinit(); GameMode.jcell_SERVER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_CLIENT : GameMode
    static member CLIENT with get() : GameMode = (GameMode.jclinit(); GameMode.jcell_CLIENT) and set (jvalue: GameMode) = (GameMode.jclinit(); GameMode.jcell_CLIENT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameMode.jclinitDone then
            GameMode.jclinitDone <- true
            GameMode.jclinitBody()
    static member private jclinitBody() : unit =
        GameMode.jcell_NONE <- (new GameMode(StringUtil.getInstance().NULL_STRING))
        GameMode.jcell_SERVER <- (new GameMode("Server"))
        GameMode.jcell_CLIENT <- (new GameMode("Client"))
        ()
    member this.jfields_GameMode() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (name: string) as this =
        {  }
        then
            this.jfields_GameMode()
            this.jctor1(name)
    member this.jctor1(name: string) : unit =
        this.setName(name)
        ()
    
    member this.setName(name: string) : unit =
        this.name <- name
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    override this.ToString() : string =
        this.getName()


