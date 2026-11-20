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
type RendererStateFactory =
    [<DefaultValue(false)>] val mutable loaded : bool
    [<DefaultValue(false)>] val mutable surfaceChanged : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : RendererStateFactory
    static member instance with get() : RendererStateFactory = (RendererStateFactory.jclinit(); RendererStateFactory.jcell_instance) and set (jvalue: RendererStateFactory) = (RendererStateFactory.jclinit(); RendererStateFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RendererStateFactory.jclinitDone then
            RendererStateFactory.jclinitDone <- true
            RendererStateFactory.jclinitBody()
    static member private jclinitBody() : unit =
        RendererStateFactory.jcell_instance <- (new RendererStateFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_RendererStateFactory()
    member this.jfields_RendererStateFactory() : unit =
        this.loaded <- false
        this.surfaceChanged <- false
        ()
    
    static member getInstance() : RendererStateFactory =
        RendererStateFactory.instance
    
    abstract setLoaded : loaded: bool -> unit
    default this.setLoaded(loaded: bool) : unit =
        this.loaded <- loaded
    
    abstract isLoaded : unit -> bool
    default this.isLoaded() : bool =
        this.loaded
    
    abstract setSurfaceChanged : initialized: bool -> unit
    default this.setSurfaceChanged(initialized: bool) : unit =
        this.surfaceChanged <- initialized
    
    abstract isSurfaceChanged : unit -> bool
    default this.isSurfaceChanged() : bool =
        this.surfaceChanged


