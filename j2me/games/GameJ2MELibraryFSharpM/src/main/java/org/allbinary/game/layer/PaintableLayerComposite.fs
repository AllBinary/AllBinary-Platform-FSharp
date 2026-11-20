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
type PaintableLayerComposite =
    inherit Paintable
    [<DefaultValue(false)>] val mutable paintableArray : Layer[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PaintableLayerComposite.jclinitDone then
            PaintableLayerComposite.jclinitDone <- true
            PaintableLayerComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (paintableArray: Layer[]) as this =
        { inherit Paintable() }
        then
            this.jctor1(paintableArray)
    member this.jctor1(paintableArray: Layer[]) : unit =
        this.paintableArray <- paintableArray
        ()
    
    override this.paint(graphics: Graphics) : unit =
        let mutable index : int = this.paintableArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.paintableArray.[index].paint(graphics)
    
    override this.paintThreed(graphics: Graphics) : unit =
        let mutable paintableInterface : PaintableInterface = null
        let mutable index : int = this.paintableArray.Length
        while ((index <- index - 1; index)) >= 0 do
            paintableInterface <- (box (this.paintableArray.[index]) :?> PaintableInterface)
            paintableInterface.paintThreed(graphics)


