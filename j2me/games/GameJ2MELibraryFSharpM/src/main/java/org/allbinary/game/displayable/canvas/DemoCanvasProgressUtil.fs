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
type DemoCanvasProgressUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoCanvasProgressUtil.jclinitDone then
            DemoCanvasProgressUtil.jclinitDone <- true
            DemoCanvasProgressUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member showProgress(demoCanvas: DemoCanvas) : unit =
        DemoCanvasProgressUtil.showProgressOptionallyInTheBackground(demoCanvas, false)
    
    static member showProgressOptionallyInTheBackground(demoCanvas: DemoCanvas, background: bool) : unit =
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.startBackground(background)
        let mutable paintableArray : PaintableInterface[] = (Array.zeroCreate<PaintableInterface> (2))
        paintableArray.[0] <- progressCanvas
        paintableArray.[1] <- demoCanvas.getDefaultPaintableInterface()
        demoCanvas.setDefaultPaintableInterface((new PaintableComposite(paintableArray)))
        demoCanvas.setPaintableInterface(demoCanvas.getDefaultPaintableInterface())


