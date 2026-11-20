namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type GameAdStateFactory =
    [<DefaultValue(false)>] val mutable gameAdStateArray : GameAdState[]
    [<DefaultValue(false)>] val mutable gameAdState : GameAdState
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameAdStateFactory
    static member instance with get() : GameAdStateFactory = (GameAdStateFactory.jclinit(); GameAdStateFactory.jcell_instance) and set (jvalue: GameAdStateFactory) = (GameAdStateFactory.jclinit(); GameAdStateFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameAdStateFactory.jclinitDone then
            GameAdStateFactory.jclinitDone <- true
            GameAdStateFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameAdStateFactory.jcell_instance <- (new GameAdStateFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameAdStateFactory()
    member this.jfields_GameAdStateFactory() : unit =
        this.gameAdStateArray <- ([| (new GameAdState((new AppNameLicensingAdConfiguration()))) |] : GameAdState[])
        this.gameAdState <- this.gameAdStateArray.[0]
        ()
    
    static member getInstance() : GameAdStateFactory =
        GameAdStateFactory.instance
    
    abstract getCurrentInstance : unit -> GameAdState
    default this.getCurrentInstance() : GameAdState =
        this.gameAdState
    
    abstract getInstanceForApp : softwareInformation: SoftwareInformation -> GameAdStateBase
    default this.getInstanceForApp(softwareInformation: SoftwareInformation) : GameAdStateBase =
        this.gameAdState <- this.gameAdStateArray.[0]
        this.gameAdStateArray.[0]
    
    abstract isEnabled : unit -> bool
    default this.isEnabled() : bool =
        false
    interface GameAdStateFactoryInterface with
        member this.getInstanceForApp(jp0: SoftwareInformation) : GameAdStateBase = this.getInstanceForApp(jp0)


