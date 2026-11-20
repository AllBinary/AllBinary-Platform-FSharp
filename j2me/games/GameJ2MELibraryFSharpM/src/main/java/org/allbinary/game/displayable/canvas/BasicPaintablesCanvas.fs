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
type BasicPaintablesCanvas =
    inherit GameCommandCanvas
    [<DefaultValue(false)>] val mutable paintableArray : Paintable[]
    [<DefaultValue(false)>] val mutable colorFillPaintable : ColorFillBasePaintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicPaintablesCanvas.jclinitDone then
            BasicPaintablesCanvas.jclinitDone <- true
            BasicPaintablesCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (cmdListener: CommandListener, name: string, allBinaryGameLayerManager: AllBinaryGameLayerManager, paintableArray: Paintable[]) as this =
        { inherit GameCommandCanvas(cmdListener, name, allBinaryGameLayerManager.getBackgroundBasicColor(), allBinaryGameLayerManager.getForegroundBasicColor()) }
        then
            this.jctor1(cmdListener, name, allBinaryGameLayerManager, paintableArray)
    member this.jctor1(cmdListener: CommandListener, name: string, allBinaryGameLayerManager: AllBinaryGameLayerManager, paintableArray: Paintable[]) : unit =
        ()
        this.paintableArray <- paintableArray
        this.colorFillPaintable <- ColorFillPaintableFactory.getInstance_jstatic().getInstance(allBinaryGameLayerManager.getBackgroundBasicColor(), false)
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.colorFillPaintable.paint(graphics)
        graphics.setColor(this.foregroundColor)
        let mutable index : int = this.paintableArray.Length - 1
        while index >= 0 do
            this.paintableArray.[index].paint(graphics)
            index <- index - 1
        base.paint(graphics)


