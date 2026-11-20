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
type ImageArraySpecialAnimation =
    inherit ImageArrayAnimation
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable loopCount : int
    [<DefaultValue(false)>] val mutable loopCountTotal : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArraySpecialAnimation.jclinitDone then
            ImageArraySpecialAnimation.jclinitDone <- true
            ImageArraySpecialAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageArraySpecialAnimation() : unit =
        this.timeDelayHelper <- (new TimeDelayHelper(270))
        this.loopCount <- 0
        this.loopCountTotal <- 1
        ()
    
    new (imageArray: Image[], animationBehavior: AnimationBehavior) as this =
        { inherit ImageArrayAnimation(imageArray, animationBehavior) }
        then
            this.jfields_ImageArraySpecialAnimation()
            this.jctor1(imageArray, animationBehavior)
    member this.jctor1(imageArray: Image[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.reset()
        ()
    
    abstract getLoopCount : unit -> int
    default this.getLoopCount() : int =
        this.loopCount
    
    abstract setLastFrame : unit -> unit
    default this.setLastFrame() : unit =
        this.circularIndexUtil.setIndex((this.circularIndexUtil.getSize() - 1))
    
    override this.reset() : unit =
        this.setFrame((this.getSize() - 1))
        this.loopCount <- 0
    
    override this.nextFrame() : unit =
        if this.getFrame() > 0 then
            if this.timeDelayHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
                this.previousFrame()
                if this.getFrame() = 0 then
                    this.loopCount <- this.loopCount + 1
    
    abstract isComplete : unit -> bool
    default this.isComplete() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (this.loopCount < this.loopCountTotal) || (this.getFrame() <> 0) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable x = x
        let mutable y = y
        x <- DisplayInfoSingleton.getInstance().getLastHalfWidth() - (this.getImage(this.circularIndexUtil.getIndex()).getWidth() >>> 1)
        y <- 5
        base.paintXY(graphics, x, y)
    interface SpecialAnimationInterface with
        member this.setLastFrame() : unit = this.setLastFrame()
        member this.isComplete() : bool = this.isComplete()
    interface IndexedAnimationInterface with
        member this.reset() : unit = this.reset()
        member this.setFrame(jp0: int) : unit = this.setFrame(jp0)
        member this.getFrame() : int = this.getFrame()
    interface SequentialAnimationInterface with
        member this.getSize() : int = this.getSize()
        member this.previousFrame() : unit = this.previousFrame()
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface SequenceInterface with
        member this.setSequence(jp0: int[]) : unit = this.setSequence(jp0)
        member this.getSequence() : int[] = this.getSequence()
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


