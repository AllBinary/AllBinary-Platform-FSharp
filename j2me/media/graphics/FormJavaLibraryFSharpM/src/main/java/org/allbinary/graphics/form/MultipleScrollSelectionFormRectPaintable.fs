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
type MultipleScrollSelectionFormRectPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable multipleScrollSelectionForm : MultipleScrollSelectionHorizontalForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultipleScrollSelectionFormRectPaintable.jclinitDone then
            MultipleScrollSelectionFormRectPaintable.jclinitDone <- true
            MultipleScrollSelectionFormRectPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (multipleScrollSelectionForm: MultipleScrollSelectionHorizontalForm) as this =
        { inherit Paintable() }
        then
            this.jctor1(multipleScrollSelectionForm)
    member this.jctor1(multipleScrollSelectionForm: MultipleScrollSelectionHorizontalForm) : unit =
        this.multipleScrollSelectionForm <- multipleScrollSelectionForm
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.multipleScrollSelectionForm.fillRect(graphics)


