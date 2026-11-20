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
type SimpleTextPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable text : string
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable topScoresWidth : int
    [<DefaultValue(false)>] val mutable fontHeight : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleTextPaintable.jclinitDone then
            SimpleTextPaintable.jclinitDone <- true
            SimpleTextPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_SimpleTextPaintable() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.topScoresWidth <- 0
        this.fontHeight <- 0
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (text: string, basicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_SimpleTextPaintable()
            this.jctor1(text, basicColor)
    member this.jctor1(text: string, basicColor: BasicColor) : unit =
        this.text <- text
        this.basicColor <- basicColor
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.topScoresWidth <- (font.stringWidth(this.text) >>> 1)
        this.fontHeight <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable width : int = this.displayInfoSingleton.getLast().[this.displayInfoSingleton.WIDTH]
        graphics.setColor(this.getBasicColorP().intValue())
        graphics.drawString(this.text, ((width >>> 1) - this.topScoresWidth), this.fontHeight, this.anchor)
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    member this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract setText : text: string -> unit
    default this.setText(text: string) : unit =
        this.text <- text
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract getText : unit -> string
    default this.getText() : string =
        this.text
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


