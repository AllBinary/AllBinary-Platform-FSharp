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
type CanvasStrings =
    [<DefaultValue(false)>] val mutable CONSTRUCTOR : string
    [<DefaultValue(false)>] val mutable PAUSE : string
    [<DefaultValue(false)>] val mutable UN_PAUSE : string
    [<DefaultValue(false)>] val mutable SET_FULL_SCREEN_MODE : string
    [<DefaultValue(false)>] val mutable SIZE_CHANGED : string
    [<DefaultValue(false)>] val mutable SCALED_IMAGES : string
    [<DefaultValue(false)>] val mutable PAINT : string
    [<DefaultValue(false)>] val mutable ON_DISPLAY_CHANGE_EVENT : string
    [<DefaultValue(false)>] val mutable UPDATE_MEASUREMENT : string
    [<DefaultValue(false)>] val mutable FD_WIDTH : string
    [<DefaultValue(false)>] val mutable FD_HEIGHT : string
    [<DefaultValue(false)>] val mutable EMPTY_CHILD_NAME_LIST : BasicArrayList
    [<DefaultValue(false)>] val mutable ABOUT : string
    [<DefaultValue(false)>] val mutable OPTIONS : string
    [<DefaultValue(false)>] val mutable FONT_ATLAS : string
    [<DefaultValue(false)>] val mutable OBJ_MODEL : string
    [<DefaultValue(false)>] val mutable MD2_MODEL : string
    [<DefaultValue(false)>] val mutable _PNG : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CanvasStrings
    static member instance with get() : CanvasStrings = (CanvasStrings.jclinit(); CanvasStrings.jcell_instance) and set (jvalue: CanvasStrings) = (CanvasStrings.jclinit(); CanvasStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CanvasStrings.jclinitDone then
            CanvasStrings.jclinitDone <- true
            CanvasStrings.jclinitBody()
    static member private jclinitBody() : unit =
        CanvasStrings.jcell_instance <- (new CanvasStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_CanvasStrings()
    member this.jfields_CanvasStrings() : unit =
        this.CONSTRUCTOR <- "MyCanvas::MyCanvas"
        this.PAUSE <- "MyCanvas::pause"
        this.UN_PAUSE <- "MyCanvas::unPause"
        this.SET_FULL_SCREEN_MODE <- "setFullScreenMode"
        this.SIZE_CHANGED <- "sizeChanged"
        this.SCALED_IMAGES <- "scaledImages"
        this.PAINT <- "paint"
        this.ON_DISPLAY_CHANGE_EVENT <- "onDisplayChangeEvent"
        this.UPDATE_MEASUREMENT <- "updateMeasurement"
        this.FD_WIDTH <- " font/display width: "
        this.FD_HEIGHT <- " font/display height: "
        this.EMPTY_CHILD_NAME_LIST <- BasicArrayListUtil.getInstance().getImmutableInstance()
        this.ABOUT <- "About"
        this.OPTIONS <- "Options"
        this.FONT_ATLAS <- "/font.png"
        this.OBJ_MODEL <- "_obj"
        this.MD2_MODEL <- "_md2"
        this._PNG <- ".png"
        ()
    
    static member getInstance() : CanvasStrings =
        CanvasStrings.instance


