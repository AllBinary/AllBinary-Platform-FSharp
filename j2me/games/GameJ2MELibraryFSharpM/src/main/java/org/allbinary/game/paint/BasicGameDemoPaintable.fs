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
type BasicGameDemoPaintable =
    inherit StatePaintable
    [<DefaultValue(false)>] val mutable mainDemoStatePaintable : Paintable
    [<DefaultValue(false)>] val mutable ownershipPaintable : Paintable
    [<DefaultValue(false)>] val mutable helpPaintableInterface : Paintable
    [<DefaultValue(false)>] val mutable currentStatePaintable : Paintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicGameDemoPaintable.jclinitDone then
            BasicGameDemoPaintable.jclinitDone <- true
            BasicGameDemoPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicGameDemoPaintable() : unit =
        this.currentStatePaintable <- NullPaintable.getInstance()
        ()
    
    new (mainDemoStatePaintable: Paintable, ownershipPaintable: Paintable, helpPaintableInterface: Paintable) as this =
        { inherit StatePaintable() }
        then
            this.jfields_BasicGameDemoPaintable()
            this.jctor1(mainDemoStatePaintable, ownershipPaintable, helpPaintableInterface)
    member this.jctor1(mainDemoStatePaintable: Paintable, ownershipPaintable: Paintable, helpPaintableInterface: Paintable) : unit =
        this.mainDemoStatePaintable <- mainDemoStatePaintable
        this.setCurrentStatePaintable(NullPaintable.getInstance())
        this.ownershipPaintable <- ownershipPaintable
        this.helpPaintableInterface <- helpPaintableInterface
        ()
    
    override this.setState(state: int) : unit =
        if state = 0 then
            this.setCurrentStatePaintable(this.getMainDemoStatePaintable())
        elif state = 1 then
            this.setCurrentStatePaintable(this.helpPaintableInterface)
        else
            this.setCurrentStatePaintable(this.ownershipPaintable)
    
    override this.paint(graphics: Graphics) : unit =
        this.getCurrentStatePaintable().paint(graphics)
    
    abstract getHelpPaintableInterface : unit -> Paintable
    default this.getHelpPaintableInterface() : Paintable =
        this.helpPaintableInterface
    
    abstract setCurrentStatePaintable : currentStatePaintable: Paintable -> unit
    default this.setCurrentStatePaintable(currentStatePaintable: Paintable) : unit =
        this.currentStatePaintable <- currentStatePaintable
    
    abstract getCurrentStatePaintable : unit -> Paintable
    default this.getCurrentStatePaintable() : Paintable =
        this.currentStatePaintable
    
    abstract getMainDemoStatePaintable : unit -> Paintable
    default this.getMainDemoStatePaintable() : Paintable =
        this.mainDemoStatePaintable


