namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CollisionThreedProcessor =
    inherit CollisionProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollisionThreedProcessor.jclinitDone then
            CollisionThreedProcessor.jclinitDone <- true
            CollisionThreedProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit CollisionProcessor() }
    
    override this.isCollision(myLayer: AllBinaryLayer, myLayer2: AllBinaryLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((((myLayer2.getXP() >= myLayer.getX2()) || (myLayer2.getYP() >= myLayer.getY2())) || (myLayer2.getX2() <= myLayer.getXP())) || (myLayer2.getY2() <= myLayer.getYP())) || (myLayer2.getZP() < myLayer.getZ2())) || (myLayer2.getZ2() > myLayer.getZP()) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret


