namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type AnalogLocationInputFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnalogLocationInputFactory
    static member instance with get() : AnalogLocationInputFactory = (AnalogLocationInputFactory.jclinit(); AnalogLocationInputFactory.jcell_instance) and set (jvalue: AnalogLocationInputFactory) = (AnalogLocationInputFactory.jclinit(); AnalogLocationInputFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogLocationInputFactory.jclinitDone then
            AnalogLocationInputFactory.jclinitDone <- true
            AnalogLocationInputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AnalogLocationInputFactory.jcell_instance <- (new AnalogLocationInputFactory())
        ()
    member this.jfields_AnalogLocationInputFactory() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : AnalogLocationInputFactory =
        AnalogLocationInputFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AnalogLocationInputFactory()
    
    abstract addPlayer : playerInputId: int -> unit
    default this.addPlayer(playerInputId: int) : unit =
        let mutable analogLocationInput : AnalogLocationInput = AnalogLocationInput.NULL_ANALOG_LOCATION_INPUT
        if playerInputId < this.list.size() then
            analogLocationInput <- (box (this.list.get(playerInputId)) :?> AnalogLocationInput)
        if (JR.same(analogLocationInput, AnalogLocationInput.NULL_ANALOG_LOCATION_INPUT)) then
            analogLocationInput <- (new AnalogLocationInput(playerInputId))
            ignore (this.list.add(analogLocationInput))
    
    abstract getInstanceForPlayer : playerInputId: int -> AnalogLocationInput
    default this.getInstanceForPlayer(playerInputId: int) : AnalogLocationInput =
        (box (this.list.get(playerInputId)) :?> AnalogLocationInput)
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


