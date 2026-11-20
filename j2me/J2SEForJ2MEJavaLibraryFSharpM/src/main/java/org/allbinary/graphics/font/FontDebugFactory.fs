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
type FontDebugFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : FontDebugFactory
    static member instance with get() : FontDebugFactory = (FontDebugFactory.jclinit(); FontDebugFactory.jcell_instance) and set (jvalue: FontDebugFactory) = (FontDebugFactory.jclinit(); FontDebugFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FontDebugFactory.jclinitDone then
            FontDebugFactory.jclinitDone <- true
            FontDebugFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FontDebugFactory.jcell_instance <- (new FontDebugFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : FontDebugFactory =
        FontDebugFactory.instance
    
    abstract setFont : font: Font * graphics: Graphics -> unit
    default this.setFont(font: Font, graphics: Graphics) : unit =
        graphics.setFont(font)


