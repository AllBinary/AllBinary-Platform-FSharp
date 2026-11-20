namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABCustomImageItem =
    inherit ABCustomItem
    [<DefaultValue(false)>] val mutable yOffset : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABCustomImageItem.jclinitDone then
            ABCustomImageItem.jclinitDone <- true
            ABCustomImageItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ABCustomImageItem() : unit =
        this.yOffset <- 0
        ()
    
    new (label: string, image: Image, layout: int, altText: string, basicColor: BasicColor, yOffset: int) as this =
        { inherit ABCustomItem(label, basicColor, basicColor) }
        then
            this.jfields_ABCustomImageItem()
    
    abstract getImage : unit -> Image
    default this.getImage() : Image =
        NullImage.NULL_IMAGE


