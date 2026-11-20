namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABCustomItem =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CUSTOM_ITEM : obj
    static member NULL_CUSTOM_ITEM with get() : obj = (ABCustomItem.jclinit(); ABCustomItem.jcell_NULL_CUSTOM_ITEM) and set (jvalue: obj) = (ABCustomItem.jclinit(); ABCustomItem.jcell_NULL_CUSTOM_ITEM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABCustomItem.jclinitDone then
            ABCustomItem.jclinitDone <- true
            ABCustomItem.jclinitBody()
    static member private jclinitBody() : unit =
        ABCustomItem.jcell_NULL_CUSTOM_ITEM <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getNullInstance() : ABCustomItem =
        if (JR.same(ABCustomItem.NULL_CUSTOM_ITEM, NullUtil.getInstance().NULL_OBJECT)) then
            ABCustomItem.NULL_CUSTOM_ITEM <- (new ABCustomItem(StringUtil.getInstance().EMPTY_STRING, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        (box (ABCustomItem.NULL_CUSTOM_ITEM) :?> ABCustomItem)
    
    new (label: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) =
        {  }
    
    abstract setOwner : owner: Screen -> unit
    default this.setOwner(owner: Screen) : unit =
        ()
    
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    default this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()
    
    abstract paintUnselected : graphics: Graphics * x: int * y: int -> unit
    default this.paintUnselected(graphics: Graphics, x: int, y: int) : unit =
        ()
    
    abstract isFocusable : unit -> bool
    default this.isFocusable() : bool =
        false
    
    abstract getLabel : unit -> string
    default this.getLabel() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract setLabel : label: string -> unit
    default this.setLabel(label: string) : unit =
        ()
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        0
    
    abstract setHeight : height: int -> unit
    default this.setHeight(height: int) : unit =
        ()
    
    abstract getValue : unit -> float32
    default this.getValue() : float32 =
        0.0f
    
    abstract setValue : value: float32 -> unit
    default this.setValue(value: float32) : unit =
        ()
    
    abstract getMinimumWidth : unit -> int
    default this.getMinimumWidth() : int =
        0
    
    abstract getMinimumHeight : unit -> int
    default this.getMinimumHeight() : int =
        0
    
    abstract preMeasurement : graphics: Graphics -> unit
    default this.preMeasurement(graphics: Graphics) : unit =
        ()


