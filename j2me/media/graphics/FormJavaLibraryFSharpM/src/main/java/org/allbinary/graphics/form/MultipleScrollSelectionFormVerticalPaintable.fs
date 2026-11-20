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
type MultipleScrollSelectionFormVerticalPaintable =
    inherit ItemIndexPaintable
    [<DefaultValue(false)>] val mutable multipleScrollSelectionForm : MultipleScrollSelectionHorizontalForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultipleScrollSelectionFormVerticalPaintable.jclinitDone then
            MultipleScrollSelectionFormVerticalPaintable.jclinitDone <- true
            MultipleScrollSelectionFormVerticalPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (multipleScrollSelectionForm: MultipleScrollSelectionHorizontalForm) as this =
        { inherit ItemIndexPaintable() }
        then
            this.jctor1(multipleScrollSelectionForm)
    member this.jctor1(multipleScrollSelectionForm: MultipleScrollSelectionHorizontalForm) : unit =
        this.multipleScrollSelectionForm <- multipleScrollSelectionForm
        ()
    
    override this.paint(graphics: Graphics, index: int, item: ABCustomItem, dx: int, dy: int) : int =
        this.multipleScrollSelectionForm.paintVertical(graphics, index, item, dx, dy)


