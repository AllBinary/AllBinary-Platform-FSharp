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
type PositionStrings =
    [<DefaultValue(false)>] val mutable X : string
    [<DefaultValue(false)>] val mutable Y : string
    [<DefaultValue(false)>] val mutable X_LABEL : string
    [<DefaultValue(false)>] val mutable Y_LABEL : string
    [<DefaultValue(false)>] val mutable Z_LABEL : string
    [<DefaultValue(false)>] val mutable DX_LABEL : string
    [<DefaultValue(false)>] val mutable DY_LABEL : string
    [<DefaultValue(false)>] val mutable DZ_LABEL : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PositionStrings
    static member instance with get() : PositionStrings = (PositionStrings.jclinit(); PositionStrings.jcell_instance) and set (jvalue: PositionStrings) = (PositionStrings.jclinit(); PositionStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PositionStrings.jclinitDone then
            PositionStrings.jclinitDone <- true
            PositionStrings.jclinitBody()
    static member private jclinitBody() : unit =
        PositionStrings.jcell_instance <- (new PositionStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_PositionStrings()
    member this.jfields_PositionStrings() : unit =
        this.X <- "x"
        this.Y <- "y"
        this.X_LABEL <- "x: "
        this.Y_LABEL <- "y: "
        this.Z_LABEL <- "z: "
        this.DX_LABEL <- "dx: "
        this.DY_LABEL <- "dy: "
        this.DZ_LABEL <- "dz: "
        ()
    
    static member getInstance() : PositionStrings =
        PositionStrings.instance


