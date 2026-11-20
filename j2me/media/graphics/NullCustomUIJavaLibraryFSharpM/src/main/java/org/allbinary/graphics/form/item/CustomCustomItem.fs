namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CustomCustomItem =
    inherit ABCustomItem
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomCustomItem.jclinitDone then
            CustomCustomItem.jclinitDone <- true
            CustomCustomItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CustomCustomItem() : unit =
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        ()
    
    new (label: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ABCustomItem(label, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_CustomCustomItem()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        ()
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


