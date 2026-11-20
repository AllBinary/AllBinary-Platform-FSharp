namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type BasicGameInfoFactory =
    [<DefaultValue(false)>] val mutable currentReleaseIndex : int
    [<DefaultValue(false)>] val mutable currentDestroyIndex : int
    [<DefaultValue(false)>] val mutable total : int
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : BasicGameInfoFactory
    static member SINGLETON with get() : BasicGameInfoFactory = (BasicGameInfoFactory.jclinit(); BasicGameInfoFactory.jcell_SINGLETON) and set (jvalue: BasicGameInfoFactory) = (BasicGameInfoFactory.jclinit(); BasicGameInfoFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicGameInfoFactory.jclinitDone then
            BasicGameInfoFactory.jclinitDone <- true
            BasicGameInfoFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicGameInfoFactory.jcell_SINGLETON <- (new BasicGameInfoFactory())
        ()
    
    static member getInstance() : BasicGameInfoFactory =
        BasicGameInfoFactory.SINGLETON
    
    new () =
        {  }
    
    abstract init : total: int -> unit
    default this.init(total: int) : unit =
        this.currentReleaseIndex <- 0
        this.currentDestroyIndex <- 0
        this.total <- total
    
    abstract isPeaked : unit -> bool
    default this.isPeaked() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.currentDestroyIndex >= this.total then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract howManyLeft : unit -> int
    default this.howManyLeft() : int =
        this.total - this.currentDestroyIndex


