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
type TouchButtonsPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable foregroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable foregroundColor : int
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable touchButtonFactory : TouchButtonFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonsPaintable.jclinitDone then
            TouchButtonsPaintable.jclinitDone <- true
            TouchButtonsPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButtonsPaintable() : unit =
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.touchButtonFactory <- TouchButtonFactory.getInstance()
        ()
    
    new (basicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_TouchButtonsPaintable()
            this.jctor1(basicColor)
    member this.jctor1(basicColor: BasicColor) : unit =
        this.foregroundBasicColor <- basicColor
        this.foregroundColor <- basicColor.intValue()
        ()
    
    override this.paint(graphics: Graphics) : unit =
        let mutable list_ : BasicArrayList = this.touchButtonFactory.getList()
        this.basicSetColorUtil.setBasicColorP3(graphics, this.foregroundBasicColor, this.foregroundColor)
        let mutable touchButton : TouchButton = null
        let mutable index : int = list_.size()
        while ((index <- index - 1; index)) >= 0 do
            touchButton <- (box (list_.objectArray.[index]) :?> TouchButton)
            touchButton.paint(graphics)
        let mutable index : int = list_.size()
        while ((index <- index - 1; index)) >= 0 do
            touchButton <- (box (list_.objectArray.[index]) :?> TouchButton)
            touchButton.paintHint(graphics)


