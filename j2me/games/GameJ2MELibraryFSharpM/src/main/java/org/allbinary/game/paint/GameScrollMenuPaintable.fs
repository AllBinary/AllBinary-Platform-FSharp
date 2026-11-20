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
type GameScrollMenuPaintable =
    inherit BasicGameDemoPaintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameScrollMenuPaintable.jclinitDone then
            GameScrollMenuPaintable.jclinitDone <- true
            GameScrollMenuPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (mainDemoStatePaintable: Paintable, ownershipPaintable: Paintable, helpPaintableInterface: Paintable, basicColor: BasicColor) as this =
        { inherit BasicGameDemoPaintable(mainDemoStatePaintable, ownershipPaintable, helpPaintableInterface) }
        then
            this.jctor1(mainDemoStatePaintable, ownershipPaintable, helpPaintableInterface, basicColor)
    member this.jctor1(mainDemoStatePaintable: Paintable, ownershipPaintable: Paintable, helpPaintableInterface: Paintable, basicColor: BasicColor) : unit =
        ()
        this.setColor(basicColor)
        ColorChangeEventHandler.getInstance().addListenerInterface(this)
        ()
    
    override this.setState(state: int) : unit =
        this.setCurrentStatePaintable(this.getMainDemoStatePaintable())
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ()
    
    abstract setColor : basicColor: BasicColor -> unit
    default this.setColor(basicColor: BasicColor) : unit =
        let mutable mainGameDemoStatePaintable : MainGameDemoStatePaintable = (box (this.getMainDemoStatePaintable()) :?> MainGameDemoStatePaintable)
        let mutable formPaintable : FormPaintable = (box (mainGameDemoStatePaintable.getMenuPaintableInterface()) :?> FormPaintable)
        let mutable scrollSelectionForm : ScrollSelectionForm = (box (formPaintable.getForm()) :?> ScrollSelectionForm)
        mainGameDemoStatePaintable.getOwnershipPaintableInterface().setBasicColorP(basicColor)
        scrollSelectionForm.setButtonBasicColor(basicColor)
        let mutable item : ABTextItem = null
        let mutable stringComponent : ABStringComponent = null
        let mutable index : int = scrollSelectionForm.size() - 1
        while index >= 0 do
            item <- (box (scrollSelectionForm.get(index)) :?> ABTextItem)
            stringComponent <- item.getLabelStringComponent()
            if not (JR.same(stringComponent, null)) then
                stringComponent.setForegroundBasicColor(basicColor)
            index <- index - 1
    interface ColorChangeListener
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


