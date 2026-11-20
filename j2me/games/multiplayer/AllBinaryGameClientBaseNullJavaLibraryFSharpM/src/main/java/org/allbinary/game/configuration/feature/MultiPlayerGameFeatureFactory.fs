namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type MultiPlayerGameFeatureFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : MultiPlayerGameFeatureFactory
    static member instance with get() : MultiPlayerGameFeatureFactory = (MultiPlayerGameFeatureFactory.jclinit(); MultiPlayerGameFeatureFactory.jcell_instance) and set (jvalue: MultiPlayerGameFeatureFactory) = (MultiPlayerGameFeatureFactory.jclinit(); MultiPlayerGameFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultiPlayerGameFeatureFactory.jclinitDone then
            MultiPlayerGameFeatureFactory.jclinitDone <- true
            MultiPlayerGameFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MultiPlayerGameFeatureFactory.jcell_instance <- (new MultiPlayerGameFeatureFactory())
        ()
    
    static member getInstance() : MultiPlayerGameFeatureFactory =
        MultiPlayerGameFeatureFactory.instance
    
    new () =
        {  }
    
    abstract addCommands : anyType: obj -> unit
    default this.addCommands(anyType: obj) : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        let mutable canvas : Canvas = (box (anyType) :?> Canvas)
        canvas.addCommand(gameCommandsFactory.QUIT_COMMAND)


