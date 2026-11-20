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
type GraphicsStrings =
    [<DefaultValue(false)>] val mutable ANIMATION : string
    [<DefaultValue(false)>] val mutable ANGLE : string
    [<DefaultValue(false)>] val mutable MOVEMENT_ANGLE : string
    [<DefaultValue(false)>] val mutable ROTATION : string
    [<DefaultValue(false)>] val mutable OPACITY : string
    [<DefaultValue(false)>] val mutable HTML : string
    [<DefaultValue(false)>] val mutable WIDTH : string
    [<DefaultValue(false)>] val mutable HEIGHT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GraphicsStrings
    static member instance with get() : GraphicsStrings = (GraphicsStrings.jclinit(); GraphicsStrings.jcell_instance) and set (jvalue: GraphicsStrings) = (GraphicsStrings.jclinit(); GraphicsStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GraphicsStrings.jclinitDone then
            GraphicsStrings.jclinitDone <- true
            GraphicsStrings.jclinitBody()
    static member private jclinitBody() : unit =
        GraphicsStrings.jcell_instance <- (new GraphicsStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_GraphicsStrings()
    member this.jfields_GraphicsStrings() : unit =
        this.ANIMATION <- "animation"
        this.ANGLE <- "angle"
        this.MOVEMENT_ANGLE <- "movement_angle"
        this.ROTATION <- "rotation"
        this.OPACITY <- "opacity"
        this.HTML <- "HTML"
        this.WIDTH <- "width"
        this.HEIGHT <- "height"
        ()
    
    static member getInstance() : GraphicsStrings =
        GraphicsStrings.instance


