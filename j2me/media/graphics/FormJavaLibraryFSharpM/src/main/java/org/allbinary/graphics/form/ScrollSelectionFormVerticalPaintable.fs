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
type ScrollSelectionFormVerticalPaintable =
    inherit ItemIndexPaintable
    [<DefaultValue(false)>] val mutable scrollSelectionForm : ScrollSelectionForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollSelectionFormVerticalPaintable.jclinitDone then
            ScrollSelectionFormVerticalPaintable.jclinitDone <- true
            ScrollSelectionFormVerticalPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (scrollSelectionForm: ScrollSelectionForm) as this =
        { inherit ItemIndexPaintable() }
        then
            this.jctor1(scrollSelectionForm)
    member this.jctor1(scrollSelectionForm: ScrollSelectionForm) : unit =
        this.scrollSelectionForm <- scrollSelectionForm
        ()
    
    override this.paint(graphics: Graphics, index: int, item: ABCustomItem, dx: int, dy: int) : int =
        this.scrollSelectionForm.paintItemVertical(graphics, index, item, dx, dy)


