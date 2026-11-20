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
type ScrollSelectionFormHorizontalDx =
    inherit ItemIndexDx
    [<DefaultValue(false)>] val mutable scrollSelectionForm : ScrollSelectionForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollSelectionFormHorizontalDx.jclinitDone then
            ScrollSelectionFormHorizontalDx.jclinitDone <- true
            ScrollSelectionFormHorizontalDx.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (scrollSelectionForm: ScrollSelectionForm) as this =
        { inherit ItemIndexDx() }
        then
            this.jctor1(scrollSelectionForm)
    member this.jctor1(scrollSelectionForm: ScrollSelectionForm) : unit =
        this.scrollSelectionForm <- scrollSelectionForm
        ()
    
    override this.getDx(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        this.scrollSelectionForm.getSelectedIndexForPointHorizontalDx(index, item, dx, dy)


