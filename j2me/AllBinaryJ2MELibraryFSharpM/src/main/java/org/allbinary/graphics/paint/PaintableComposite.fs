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
type PaintableComposite =
    inherit Paintable
    [<DefaultValue(false)>] val mutable paintableArray : PaintableInterface[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PaintableComposite.jclinitDone then
            PaintableComposite.jclinitDone <- true
            PaintableComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (paintableArray: PaintableInterface[]) as this =
        { inherit Paintable() }
        then
            this.jctor1(paintableArray)
    member this.jctor1(paintableArray: PaintableInterface[]) : unit =
        this.paintableArray <- paintableArray
        ()
    
    override this.paint(graphics: Graphics) : unit =
        let mutable index : int = this.paintableArray.Length - 1
        while index >= 0 do
            this.paintableArray.[index].paint(graphics)
            index <- index - 1
    
    override this.paintThreed(graphics: Graphics) : unit =
        let mutable index : int = this.paintableArray.Length - 1
        while index >= 0 do
            this.paintableArray.[index].paintThreed(graphics)
            index <- index - 1


