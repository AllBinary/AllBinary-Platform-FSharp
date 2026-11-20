namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABCustomGaugeItem =
    inherit ABCustomItem
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GAUGE_ITEM : ABCustomGaugeItem
    static member NULL_GAUGE_ITEM with get() : ABCustomGaugeItem = (ABCustomGaugeItem.jclinit(); ABCustomGaugeItem.jcell_NULL_GAUGE_ITEM) and set (jvalue: ABCustomGaugeItem) = (ABCustomGaugeItem.jclinit(); ABCustomGaugeItem.jcell_NULL_GAUGE_ITEM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABCustomGaugeItem.jclinitDone then
            ABCustomGaugeItem.jclinitDone <- true
            ABCustomGaugeItem.jclinitBody()
    static member private jclinitBody() : unit =
        ABCustomGaugeItem.jcell_NULL_GAUGE_ITEM <- (new ABCustomGaugeItem(StringUtil.getInstance().EMPTY_STRING, 1, 0, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        ()
    
    new (label: string, maxValue: int, initialValue: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) =
        { inherit ABCustomItem(label, backgroundBasicColor, foregroundBasicColor) }


