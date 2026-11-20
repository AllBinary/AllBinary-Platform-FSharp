namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABCustomItemInterface =
    abstract getMinimumWidth : unit -> int
    abstract getMinimumHeight : unit -> int
    abstract getLabel : unit -> string
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    abstract paintUnselected : graphics: Graphics * x: int * y: int -> unit


