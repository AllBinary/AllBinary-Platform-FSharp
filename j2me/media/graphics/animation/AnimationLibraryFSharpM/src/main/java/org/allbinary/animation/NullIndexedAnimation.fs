namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullIndexedAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullIndexedAnimation.jclinitDone then
            NullIndexedAnimation.jclinitDone <- true
            NullIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationBehavior: AnimationBehavior) =
        { inherit IndexedAnimation(animationBehavior) }
    
    override this.getAnimationSize() : int =
        0


