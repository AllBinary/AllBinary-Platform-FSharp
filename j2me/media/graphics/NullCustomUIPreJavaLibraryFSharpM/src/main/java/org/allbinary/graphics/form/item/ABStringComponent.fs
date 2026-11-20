namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABStringComponent =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_STRING_COMPONENT : ABStringComponent
    static member NULL_STRING_COMPONENT with get() : ABStringComponent = (ABStringComponent.jclinit(); ABStringComponent.jcell_NULL_STRING_COMPONENT) and set (jvalue: ABStringComponent) = (ABStringComponent.jclinit(); ABStringComponent.jcell_NULL_STRING_COMPONENT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABStringComponent.jclinitDone then
            ABStringComponent.jclinitDone <- true
            ABStringComponent.jclinitBody()
    static member private jclinitBody() : unit =
        ABStringComponent.jcell_NULL_STRING_COMPONENT <- (new ABStringComponent(BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        ()
    
    abstract getBackgroundBasicColor : unit -> BasicColor
    default this.getBackgroundBasicColor() : BasicColor =
        BasicColorFactory.getInstance().WHITE
    
    new (backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) =
        {  }
    
    abstract getForegroundBasicColor : unit -> BasicColor
    default this.getForegroundBasicColor() : BasicColor =
        BasicColorFactory.getInstance().WHITE
    
    abstract setForegroundBasicColor : foregroundBasicColor: BasicColor -> unit
    default this.setForegroundBasicColor(foregroundBasicColor: BasicColor) : unit =
        ()


