namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABTextFieldItem =
    inherit ABTextItem
    [<DefaultValue(false)>] val mutable font : Font
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABTextFieldItem.jclinitDone then
            ABTextFieldItem.jclinitDone <- true
            ABTextFieldItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (canvas: Canvas, visitor: Visitor, label: string, value: string, maxSize: int, layout: int, altText: string, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ABTextItem(label, layout, altText, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jctor1(canvas, visitor, label, value, maxSize, layout, altText, font, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(canvas: Canvas, visitor: Visitor, label: string, value: string, maxSize: int, layout: int, altText: string, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.font <- font
        ()
    
    override this.getLabel() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    override this.setLabel(label: string) : unit =
        ()
    
    abstract getString : unit -> string
    default this.getString() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract setString : string_: string -> unit
    default this.setString(string_: string) : unit =
        ()
    
    abstract setFocus : state: bool -> unit
    default this.setFocus(state: bool) : unit =
        ()
    
    abstract getFontHeight : unit -> int
    default this.getFontHeight() : int =
        this.font.getHeight()
    
    abstract setBackgroundBasicColorP : basicColor: BasicColor -> unit
    default this.setBackgroundBasicColorP(basicColor: BasicColor) : unit =
        ()
    
    abstract setForegroundBasicColorP : basicColor: BasicColor -> unit
    default this.setForegroundBasicColorP(basicColor: BasicColor) : unit =
        ()


