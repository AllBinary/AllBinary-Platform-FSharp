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
type MainGameDemoStatePaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable ownershipPaintableInterface : Paintable
    [<DefaultValue(false)>] val mutable menuPaintableInterface : Paintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MainGameDemoStatePaintable.jclinitDone then
            MainGameDemoStatePaintable.jclinitDone <- true
            MainGameDemoStatePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (ownershipPaintableInterface: Paintable, menuPaintableInterface: Paintable) as this =
        { inherit Paintable() }
        then
            this.jctor1(ownershipPaintableInterface, menuPaintableInterface)
    member this.jctor1(ownershipPaintableInterface: Paintable, menuPaintableInterface: Paintable) : unit =
        this.ownershipPaintableInterface <- ownershipPaintableInterface
        this.menuPaintableInterface <- menuPaintableInterface
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.menuPaintableInterface.paint(graphics)
        this.ownershipPaintableInterface.paint(graphics)
    
    abstract getOwnershipPaintableInterface : unit -> Paintable
    default this.getOwnershipPaintableInterface() : Paintable =
        this.ownershipPaintableInterface
    
    abstract getMenuPaintableInterface : unit -> Paintable
    default this.getMenuPaintableInterface() : Paintable =
        this.menuPaintableInterface


