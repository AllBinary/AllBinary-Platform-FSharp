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
type ColorFillBasePaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable colorP : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorFillBasePaintable.jclinitDone then
            ColorFillBasePaintable.jclinitDone <- true
            ColorFillBasePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ColorFillBasePaintable() : unit =
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        ()
    
    new (basicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_ColorFillBasePaintable()
            this.jctor1(basicColor)
    member this.jctor1(basicColor: BasicColor) : unit =
        this.setBasicColorP(basicColor)
        ()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
        this.setColor(this.getBasicColorP().intValue())
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract getColor : unit -> int
    default this.getColor() : int =
        this.colorP
    
    abstract setColor : color: int -> unit
    default this.setColor(color: int) : unit =
        this.colorP <- color
    
    override this.paint(graphics: Graphics) : unit =
        ()
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)


