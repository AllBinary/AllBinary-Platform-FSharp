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
type RendererStrings =
    [<DefaultValue(false)>] val mutable ON_SURFACE_CREATED : string
    [<DefaultValue(false)>] val mutable ON_SURFACE_CHANGED : string
    [<DefaultValue(false)>] val mutable ON_DRAW_FRAME : string
    [<DefaultValue(false)>] val mutable ON_DRAW_FRAME_THREED : string
    [<DefaultValue(false)>] val mutable ON_DRAW_FRAME_2D : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : RendererStrings
    static member instance with get() : RendererStrings = (RendererStrings.jclinit(); RendererStrings.jcell_instance) and set (jvalue: RendererStrings) = (RendererStrings.jclinit(); RendererStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RendererStrings.jclinitDone then
            RendererStrings.jclinitDone <- true
            RendererStrings.jclinitBody()
    static member private jclinitBody() : unit =
        RendererStrings.jcell_instance <- (new RendererStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_RendererStrings()
    member this.jfields_RendererStrings() : unit =
        this.ON_SURFACE_CREATED <- "onSurfaceCreated"
        this.ON_SURFACE_CHANGED <- "onSurfaceChanged"
        this.ON_DRAW_FRAME <- "onDrawFrame"
        this.ON_DRAW_FRAME_THREED <- "onDrawFrameThreed"
        this.ON_DRAW_FRAME_2D <- "onDrawFrame2d"
        ()
    
    static member getInstance() : RendererStrings =
        RendererStrings.instance


