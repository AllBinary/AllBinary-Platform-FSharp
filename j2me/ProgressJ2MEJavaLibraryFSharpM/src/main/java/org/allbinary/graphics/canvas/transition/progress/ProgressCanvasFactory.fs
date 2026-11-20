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
type ProgressCanvasFactory =
    [<DefaultValue(false)>] static val mutable private jcell_PROGRESS_FORM_SCREEN : obj
    static member PROGRESS_FORM_SCREEN with get() : obj = (ProgressCanvasFactory.jclinit(); ProgressCanvasFactory.jcell_PROGRESS_FORM_SCREEN) and set (jvalue: obj) = (ProgressCanvasFactory.jclinit(); ProgressCanvasFactory.jcell_PROGRESS_FORM_SCREEN <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ProgressCanvasFactory.jclinitDone then
            ProgressCanvasFactory.jclinitDone <- true
            ProgressCanvasFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ProgressCanvasFactory.jcell_PROGRESS_FORM_SCREEN <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () =
        {  }
    
    static member getInstance() : ProgressCanvas =
        if (JR.same(ProgressCanvasFactory.PROGRESS_FORM_SCREEN, NullUtil.getInstance().NULL_OBJECT)) then
            ProgressCanvasFactory.PROGRESS_FORM_SCREEN <- (new ProgressCanvas(StringUtil.getInstance().EMPTY_STRING, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        (box (ProgressCanvasFactory.PROGRESS_FORM_SCREEN) :?> ProgressCanvas)
    
    static member getLazyInstance() : PaintableInterface =
        NullPaintable.getInstance()


