namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABCustomForm =
    inherit CustomScreen
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABCustomForm.jclinitDone then
            ABCustomForm.jclinitDone <- true
            ABCustomForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ABCustomForm() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (title: string, items: ABCustomItem[], backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CustomScreen() }
        then
            this.jfields_ABCustomForm()
    
    abstract getAllitems : unit -> ABCustomItem[]
    default this.getAllitems() : ABCustomItem[] =
        (Array.zeroCreate<ABCustomItem> (0))
    
    abstract size : unit -> int
    default this.size() : int =
        0
    
    abstract setSelectedIndex : index: int -> unit
    default this.setSelectedIndex(index: int) : unit =
        ()
    
    abstract getSelectedIndex : unit -> int
    default this.getSelectedIndex() : int =
        0
    
    abstract deleteAll : unit -> unit
    default this.deleteAll() : unit =
        ()
    
    abstract delete : itemNum: int -> unit
    default this.delete(itemNum: int) : unit =
        ()
    
    abstract append : item: ABCustomItem -> int
    default this.append(item: ABCustomItem) : int =
        -1
    
    abstract insert : itemNum: int * item: ABCustomItem -> unit
    default this.insert(itemNum: int, item: ABCustomItem) : unit =
        ()
    
    abstract set : itemNum: int * item: ABCustomItem -> unit
    default this.set(itemNum: int, item: ABCustomItem) : unit =
        ()
    
    abstract get : itemNum: int -> ABCustomItem
    default this.get(itemNum: int) : ABCustomItem =
        ABCustomItem.getNullInstance()
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        raise ((new JRuntimeException()))
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract getTitle : unit -> string
    default this.getTitle() : string =
        StringUtil.getInstance().EMPTY_STRING


