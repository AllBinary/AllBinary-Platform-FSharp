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
type LockableFormPaintableFactory =
    inherit ItemPaintableFactory
    [<DefaultValue(false)>] val mutable lockedIndex : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockableFormPaintableFactory.jclinitDone then
            LockableFormPaintableFactory.jclinitDone <- true
            LockableFormPaintableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (lockedIndex: int) as this =
        { inherit ItemPaintableFactory() }
        then
            this.jctor1(lockedIndex)
    member this.jctor1(lockedIndex: int) : unit =
        this.lockedIndex <- lockedIndex
        ()
    
    override this.getInstanceItemPaintable(paintableForm: PaintableForm) : ItemPaintable =
        (new LockablePaintable(this.lockedIndex))


