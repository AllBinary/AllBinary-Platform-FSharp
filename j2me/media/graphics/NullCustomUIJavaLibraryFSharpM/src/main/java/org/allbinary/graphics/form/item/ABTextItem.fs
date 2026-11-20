namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABTextItem =
    inherit CustomCustomItem
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABTextItem.jclinitDone then
            ABTextItem.jclinitDone <- true
            ABTextItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (label: string, layout: int, altText: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) =
        { inherit CustomCustomItem(label, backgroundBasicColor, foregroundBasicColor) }
    
    abstract keyPressed : keyCode: int -> unit
    default this.keyPressed(keyCode: int) : unit =
        ()
    
    override this.paintUnselected(graphics: Graphics, x: int, y: int) : unit =
        ()
    
    abstract getLabelStringComponent : unit -> ABStringComponent
    default this.getLabelStringComponent() : ABStringComponent =
        ABStringComponent.NULL_STRING_COMPONENT
    
    override this.getMinimumWidth() : int =
        base.getMinimumWidth()
    
    override this.getMinimumHeight() : int =
        base.getMinimumHeight()
    
    override this.getLabel() : string =
        base.getLabel()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        base.paintXY(graphics, x, y)
    interface ABCustomItemInterface with
        member this.getMinimumWidth() : int = this.getMinimumWidth()
        member this.getMinimumHeight() : int = this.getMinimumHeight()
        member this.getLabel() : string = this.getLabel()
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)
        member this.paintUnselected(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintUnselected(jp0, jp1, jp2)


