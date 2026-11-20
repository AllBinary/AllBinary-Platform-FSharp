namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type AnalogLocationInput =
    [<DefaultValue(false)>] val mutable playerId : int
    [<DefaultValue(false)>] val mutable customGPoint : CustomGPoint
    [<DefaultValue(false)>] val mutable rz : int
    [<DefaultValue(false)>] val mutable rightTrigger : int
    [<DefaultValue(false)>] val mutable leftTrigger : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ANALOG_LOCATION_INPUT : AnalogLocationInput
    static member NULL_ANALOG_LOCATION_INPUT with get() : AnalogLocationInput = (AnalogLocationInput.jclinit(); AnalogLocationInput.jcell_NULL_ANALOG_LOCATION_INPUT) and set (jvalue: AnalogLocationInput) = (AnalogLocationInput.jclinit(); AnalogLocationInput.jcell_NULL_ANALOG_LOCATION_INPUT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogLocationInput.jclinitDone then
            AnalogLocationInput.jclinitDone <- true
            AnalogLocationInput.jclinitBody()
    static member private jclinitBody() : unit =
        AnalogLocationInput.jcell_NULL_ANALOG_LOCATION_INPUT <- (new AnalogLocationInput(-1))
        ()
    
    new (playerId: int) as this =
        {  }
        then
            this.jctor1(playerId)
    member this.jctor1(playerId: int) : unit =
        this.playerId <- playerId
        this.customGPoint <- (new CustomGPoint(0, 0, 0))
        ()
    
    abstract getPlayerId : unit -> int
    default this.getPlayerId() : int =
        this.playerId
    
    abstract getCustomGPoint : unit -> CustomGPoint
    default this.getCustomGPoint() : CustomGPoint =
        this.customGPoint
    
    abstract getRz : unit -> int
    default this.getRz() : int =
        this.rz
    
    abstract setRz : rz: int -> unit
    default this.setRz(rz: int) : unit =
        this.rz <- rz
    
    abstract getRightTrigger : unit -> int
    default this.getRightTrigger() : int =
        this.rightTrigger
    
    abstract setRightTrigger : rightTrigger: int -> unit
    default this.setRightTrigger(rightTrigger: int) : unit =
        this.rightTrigger <- rightTrigger
    
    abstract getLeftTrigger : unit -> int
    default this.getLeftTrigger() : int =
        this.leftTrigger
    
    abstract setLeftTrigger : leftTrigger: int -> unit
    default this.setLeftTrigger(leftTrigger: int) : unit =
        this.leftTrigger <- leftTrigger


