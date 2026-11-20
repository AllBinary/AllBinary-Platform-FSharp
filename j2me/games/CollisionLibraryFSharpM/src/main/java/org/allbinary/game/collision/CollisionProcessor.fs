namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CollisionProcessor =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollisionProcessor.jclinitDone then
            CollisionProcessor.jclinitDone <- true
            CollisionProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract isCollision : myLayer: AllBinaryLayer * myLayer2: AllBinaryLayer -> bool
    default this.isCollision(myLayer: AllBinaryLayer, myLayer2: AllBinaryLayer) : bool =
        false


