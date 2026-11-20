namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type TimedVectorAnimation =
    inherit VectorAnimation
    [<DefaultValue(false)>] val mutable timeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimedVectorAnimation.jclinitDone then
            TimedVectorAnimation.jclinitDone <- true
            TimedVectorAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TimedVectorAnimation() : unit =
        this.timeElapsedHelper <- (new TimeDelayHelper(200))
        ()
    
    new (currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) as this =
        { inherit VectorAnimation(currentPoints, basicColor, animationBehavior) }
        then
            this.jfields_TimedVectorAnimation()
    
    override this.nextFrame() : unit =
        if this.timeElapsedHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            base.nextFrame()


