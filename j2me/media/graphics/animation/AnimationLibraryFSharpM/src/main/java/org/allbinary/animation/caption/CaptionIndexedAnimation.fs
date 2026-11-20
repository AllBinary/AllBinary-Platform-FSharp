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
type CaptionIndexedAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable movieIndexedAnimationInterface : IndexedAnimation
    [<DefaultValue(false)>] val mutable captionDx : int
    [<DefaultValue(false)>] val mutable captionDy : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable time : int
    [<DefaultValue(false)>] val mutable END_EVENT : AllBinaryEventObject
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable player : Player
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CaptionIndexedAnimation.jclinitDone then
            CaptionIndexedAnimation.jclinitDone <- true
            CaptionIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterface: Animation, movieIndexedAnimationInterface: IndexedAnimation, player: Player, captionDx: int, captionDy: int, dx: int, dy: int, time: int, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jctor1(animationInterface, movieIndexedAnimationInterface, player, captionDx, captionDy, dx, dy, time, animationBehavior)
    member this.jctor1(animationInterface: Animation, movieIndexedAnimationInterface: IndexedAnimation, player: Player, captionDx: int, captionDy: int, dx: int, dy: int, time: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.animationInterface <- animationInterface
        this.movieIndexedAnimationInterface <- movieIndexedAnimationInterface
        this.captionDx <- captionDx
        this.captionDy <- captionDy
        this.dx <- dx
        this.dy <- dy
        this.time <- time
        this.END_EVENT <- (new AllBinaryEventObject(this))
        let mutable timePerFrame : int = this.time / this.getSize()
        this.timeDelayHelper <- (new TimeDelayHelper(timePerFrame))
        this.player <- player
        this.player.start()
        ()
    
    override this.nextFrame() : unit =
        if this.timeDelayHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            this.movieIndexedAnimationInterface.nextFrame()
        if this.isLastFrame() then
            AnimationEventHandler.getInstance().fireEvent(this.END_EVENT)
    
    override this.isLastFrame() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.movieIndexedAnimationInterface.getFrame() = (this.getSize() - 1) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    override this.previousFrame() : unit =
        this.movieIndexedAnimationInterface.previousFrame()
    
    override this.setFrame(index: int) : unit =
        this.movieIndexedAnimationInterface.setFrame(index)
    
    override this.getFrame() : int =
        this.movieIndexedAnimationInterface.getFrame()
    
    override this.getSize() : int =
        this.movieIndexedAnimationInterface.getSize()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.animationInterface.paintXY(graphics, (x + this.captionDx), (y + this.captionDy))
        this.movieIndexedAnimationInterface.paintXY(graphics, ((x + this.captionDx) + this.dx), ((y + this.captionDy) + this.dy))
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        this.animationInterface.paintThreedXYZ(graphics, (x + this.captionDx), (y + this.captionDy), z)
        this.movieIndexedAnimationInterface.paintThreedXYZ(graphics, ((x + this.captionDx) + this.dx), ((y + this.captionDy) + this.dy), z)


