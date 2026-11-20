namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRotationAnimation.jclinitDone then
            NullRotationAnimation.jclinitDone <- true
            NullRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createTotalAngle(angleInfo: AngleInfo, totalAngle: int16, animationBehavior: AnimationBehavior) : NullRotationAnimation =
        (new NullRotationAnimation(angleInfo, CircularIndexUtil.createInstance((int (totalAngle) / int (angleInfo.getAngleIncrementInfo().getAngleIncrement()))), animationBehavior))
    
    static member createQuarter(animationBehavior: AnimationBehavior) : NullRotationAnimation =
        (new NullRotationAnimation(AngleInfo.getInstance(AngleFactory.getInstance().QUARTER_TOTAL_ANGLE), CircularIndexUtil.createInstance(4), animationBehavior))
    
    new (angleInfo: AngleInfo, circularIndexUtil: CircularIndexUtil, animationBehavior: AnimationBehavior) =
        { inherit RotationAnimation(angleInfo, circularIndexUtil, animationBehavior) }
    
    override this.getAnimationSize() : int =
        0


